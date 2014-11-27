Imports Microsoft.Office.Interop
Imports System
Imports System.IO

'Ajouter une reference au projet a: Microsoft Excel 12.0 Objject Library
'Ajouter Imports Microsoft.Office.Interop au d/but de la classe principale du projet

' Pour rendre la class plus generale, les donnees a ecrire sont stocke dans un array d'element
' de ce type. Chaque valeus a logguer doit etre defini de cette facon.

Public Structure Struc_LogData
    Public LettreDeLaColonne As String
    Public Valeur As Object
    Public Format As String
    Public Description As String
End Structure

Public Class LogginFunctions
    Dim oXL As Excel.Application
    Dim oWB As Excel.Workbook
    Dim oSheet As Excel.Worksheet
    Dim oRng As Excel.Range

    Dim MessageErreur As String
    Dim FileName As String
    Dim SaveLineNumberCol As Integer
    Dim NoDePompe As Integer
    Dim LogPath As String
    Dim Prefix As String
    Dim NomDuRaportVide As String
    Dim Jour As String
    Dim Mois As String
    Dim Annee As String

    'Le numero de la pompe
    WriteOnly Property NumeroDePompe As Integer
        Set(ByVal value As Integer)
            NoDePompe = value
        End Set
    End Property

    'Le numero de la colonne a utilise pour enregister le numero de ligne courrant dans le fichier de log
    WriteOnly Property NoColonnePourEnregistrerLeNumeroDeLigneCourant As Integer
        Set(ByVal value As Integer)
            SaveLineNumberCol = value
        End Set
    End Property

    'Le chemin ou sauver le fichier de log.
    WriteOnly Property CheminWindow As String
        Set(ByVal value As String)
            LogPath = value
        End Set
    End Property

    'Prefix du nom de fichier
    WriteOnly Property PrefixNom As String
        Set(ByVal value As String)
            Prefix = value
        End Set
    End Property

    'Nom du fichier vide (Template) a utiliser
    WriteOnly Property NomRapportVide As String
        Set(ByVal value As String)
            NomDuRaportVide = value
        End Set
    End Property

    'Retoure un message a afficher en cas d'erreur
    ReadOnly Property Message() As String
        Get
            Return MessageErreur
        End Get
    End Property

    'Retourne le nom du fichier du log. Il est constitue comme suit:
    'Prefix + jour + mois + annee
    ReadOnly Property NomDuFichierLog As String
        Get
            Return FileName
        End Get
    End Property

    Public Sub StartExcel()
        ' Demarre MS Excel
        oXL = CType(CreateObject("Excel.Application"), Excel.Application)
        oXL.Visible = False
    End Sub

    Public Sub StopExcel()
        ' Quitte MS Excel 
        oXL.Quit()
        oXL = Nothing
    End Sub

    Public Sub EcritDonneeLog(ByVal NewDateRequired As Boolean, ByVal ExcelData() As Struc_LogData)
        Dim Aujourdhui As Date
        Dim LogName As String
        Dim LineNumber As Int32

        If NewDateRequired = True Then
            Aujourdhui = DateAndTime.Now
            Annee = String.Format("{0:yyyy}", Aujourdhui)
            Mois = String.Format("{0:MMMM}", Aujourdhui)
            Jour = String.Format("{0:dd}", Aujourdhui)
        End If
        FileName = Prefix & Jour & " " & Mois & " " & Annee
        LogName = LogPath + FileName

        MessageErreur = ""
        Try
            'Ouvre le fichier du jour ou cree le s'il n'existe pas
            oWB = oXL.Workbooks.Open(Filename:=LogName)
            oSheet = CType(oWB.ActiveSheet, Excel.Worksheet)
            'Lit le numero de la ligne dans la cellule 1,SaveLineNumberCol
            LineNumber = CType(oSheet.Cells(1, SaveLineNumberCol).value, Long)
            Exit Try
        Catch ex As Exception
            'Le fichier du jour n'existe pas
            MessageErreur = "Creation d'un nouveau rapport" & vbCrLf & vbCrLf & ex.Message & vbCrLf & ex.Source
            Try
                'Ouvre un rapport vide pour cree un nouveau fichier du jour
                oWB = oXL.Workbooks.Open(Filename:=LogPath & NomDuRaportVide)
                oSheet = CType(oWB.ActiveSheet, Excel.Worksheet)
                LineNumber = CType(oSheet.Cells(1, SaveLineNumberCol).value, Long)
                oSheet.Range("A8").Value = Aujourdhui.Date
                oSheet.Range("B3").Value = NoDePompe
                oSheet.Range("C3").Value = "Coulée"
                oSheet.Range("D3").Value = My.Settings.NoDeCoulee
            Catch ex1 As Exception
                MessageErreur = "Aucun fichier de rapport vide n'est présent. Création d'un rapport de base." _
                    & vbCrLf & vbCrLf & ex1.Message & vbCrLf & ex1.Source
                'En cas d'erreur cree un fichier plus simple a partir d'un nouveau document
                oWB = oXL.Workbooks.Add
                oSheet = CType(oWB.ActiveSheet, Excel.Worksheet)
                oSheet.Range("A1").Value = ExcelData(0).Description
                oSheet.Range("B1").Value = ExcelData(1).Description
                oSheet.Range("C1").Value = ExcelData(2).Description
                oSheet.Range("E1").Value = ExcelData(3).Description
                LineNumber = 1
            End Try
            oSheet.Name = "Pompe# " & NoDePompe.ToString
            oWB.SaveAs(Filename:=LogName, AccessMode:=Excel.XlSaveAsAccessMode.xlExclusive)
        End Try

        LineNumber = LineNumber + 1
        Dim Lettre As String

        'Insere une nouvelle ligne avant decrire les donnees.
        oSheet.Range(CStr(LineNumber - 1) & ":" & CStr(LineNumber - 1)).Copy() 'Copie la ligne precedente pour conserve/ les formules et le format
        oSheet.Range(CStr(LineNumber) & ":" & CStr(LineNumber)).Insert() 'Insere les cellules copies sur une nouvelle ligne

        For Each cellule As Struc_LogData In ExcelData
            Lettre = cellule.LettreDeLaColonne
            If Lettre = Nothing Then Exit For ' au cas ou
            oSheet.Range(cellule.LettreDeLaColonne & CStr(LineNumber)).Value = cellule.Valeur
            oRng = oSheet.Range(cellule.LettreDeLaColonne + CStr(LineNumber))
            oRng.NumberFormat = cellule.Format
        Next
        ''Garder le num/ro de la ligne courante dans la cellule (1,10)
        oSheet.Cells(1, SaveLineNumberCol) = LineNumber

        'Sauve les donnees en csv pour exportation vers une base de données (future)
        Dim UneLigne As String = My.Settings.NoDeCoulee.ToString & ";" & NoDePompe.ToString & ";"
        For ColNumber As Integer = 1 To 13
            UneLigne = UneLigne & oSheet.Cells(LineNumber, ColNumber).value.ToString & ";"
        Next

        EcritDonneesCSV(NoDePompe, UneLigne, "Tout")
        'Detruit les objet et ferme le fichier
        oRng = Nothing
        oSheet = Nothing
        oWB.Save()
        oWB.Close()

    End Sub

    Public Sub EcritDonneesCSV(ByVal PompeNo As Integer, ByVal OneLine As String, ByVal Table As String)
        Dim Aujourdhui As Date
        Dim Annee As String
        Dim LogName As String
        Dim CSVName As String
 
        'Nom du fichier
        Aujourdhui = DateAndTime.Now
        Annee = String.Format("{0:yyyy}", Aujourdhui)
        CSVName = "Cumulatif saison_" & Annee & "_" & Table & ".csv"
        LogName = LogPath + CSVName

        Dim sw As StreamWriter

        If File.Exists(LogName) = False Then
            ' Create a file to write to.
            sw = File.CreateText(LogName)
        Else
            ' Append data
            sw = File.AppendText(LogName)
        End If

        sw.WriteLine(Left(OneLine, Len(OneLine) - 1)) 'Enleve le dernier separateur
        sw.Flush()
        sw.Close()

    End Sub

    Protected Overrides Sub Finalize()

    End Sub

    Sub EcritDonneeLog(ByVal DonneeLog As Struc_LogData())
        Throw New NotImplementedException
    End Sub

End Class
