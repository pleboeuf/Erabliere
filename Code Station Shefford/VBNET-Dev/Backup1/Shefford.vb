Option Strict Off
Option Explicit On
Friend Class Form1
    Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    'For the start-up form, the first instance created is the default instance.
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
                    End If
                Catch
                End Try
            End If
        End If
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Text1 As System.Windows.Forms.TextBox
    Public WithEvents Mbaxp1 As AxMBAXPLib.AxMbaxp
    Public WithEvents Command2 As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Public WithEvents Command3 As System.Windows.Forms.Button
    Friend WithEvents CutawayControl1 As SymbolFactoryDotNet.CutawayControl
    Friend WithEvents CutawayControl2 As SymbolFactoryDotNet.CutawayControl
    Friend WithEvents CutawayControl5 As SymbolFactoryDotNet.CutawayControl
    Public WithEvents Command4 As System.Windows.Forms.Button
    Public WithEvents Text2 As System.Windows.Forms.TextBox
    Friend WithEvents StandardControl12 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents StandardControl9 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents StandardControl10 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StandardControl11 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents StandardControl8 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents CutawayControl6 As SymbolFactoryDotNet.CutawayControl
    Friend WithEvents StandardControl13 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents StandardControl5 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents StandardControl14 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents StandardControl2 As SymbolFactoryDotNet.StandardControl
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents AxMbaxp1 As AxMBAXPLib.AxMbaxp
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.Command2 = New System.Windows.Forms.Button
        Me.Command1 = New System.Windows.Forms.Button
        Me.AxMbaxp1 = New AxMBAXPLib.AxMbaxp
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Command3 = New System.Windows.Forms.Button
        Me.CutawayControl1 = New SymbolFactoryDotNet.CutawayControl
        Me.CutawayControl2 = New SymbolFactoryDotNet.CutawayControl
        Me.CutawayControl5 = New SymbolFactoryDotNet.CutawayControl
        Me.Command4 = New System.Windows.Forms.Button
        Me.Text2 = New System.Windows.Forms.TextBox
        Me.StandardControl12 = New SymbolFactoryDotNet.StandardControl
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.StandardControl2 = New SymbolFactoryDotNet.StandardControl
        Me.StandardControl14 = New SymbolFactoryDotNet.StandardControl
        Me.CutawayControl6 = New SymbolFactoryDotNet.CutawayControl
        Me.StandardControl5 = New SymbolFactoryDotNet.StandardControl
        Me.PictureBox16 = New System.Windows.Forms.PictureBox
        Me.StandardControl13 = New SymbolFactoryDotNet.StandardControl
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.PictureBox15 = New System.Windows.Forms.PictureBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.StandardControl8 = New SymbolFactoryDotNet.StandardControl
        Me.StandardControl9 = New SymbolFactoryDotNet.StandardControl
        Me.StandardControl10 = New SymbolFactoryDotNet.StandardControl
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.StandardControl11 = New SymbolFactoryDotNet.StandardControl
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.PictureBox9 = New System.Windows.Forms.PictureBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        CType(Me.AxMbaxp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CutawayControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CutawayControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CutawayControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.StandardControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CutawayControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(1147, 843)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(113, 20)
        Me.Text1.TabIndex = 4
        Me.Text1.Text = "199"
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(1147, 788)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(113, 33)
        Me.Command2.TabIndex = 0
        Me.Command2.Text = "Ajustement"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(1019, 754)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(111, 33)
        Me.Command1.TabIndex = 1
        Me.Command1.Text = "Ouvrir Connection"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'AxMbaxp1
        '
        Me.AxMbaxp1.Enabled = True
        Me.AxMbaxp1.Location = New System.Drawing.Point(944, 846)
        Me.AxMbaxp1.Name = "AxMbaxp1"
        Me.AxMbaxp1.OcxState = CType(resources.GetObject("AxMbaxp1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMbaxp1.Size = New System.Drawing.Size(186, 17)
        Me.AxMbaxp1.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(941, 827)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 14)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Etat de la communication:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(21, 455)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(0, 29)
        Me.Label26.TabIndex = 38
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(30, 652)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(86, 19)
        Me.Label41.TabIndex = 68
        Me.Label41.Text = "Citerne #1"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(374, 652)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(86, 19)
        Me.Label42.TabIndex = 69
        Me.Label42.Text = "Citerne #2"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(676, 649)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(86, 19)
        Me.Label43.TabIndex = 70
        Me.Label43.Text = "Citerne #3"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(15, 523)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(281, 29)
        Me.Label46.TabIndex = 73
        Me.Label46.Text = "Citernes - Rue Shefford"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(1147, 754)
        Me.Label49.Name = "Label49"
        Me.Label49.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label49.Size = New System.Drawing.Size(109, 26)
        Me.Label49.TabIndex = 76
        Me.Label49.Text = "Visual Basic.net 2008" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nov. 2010"
        '
        'Command3
        '
        Me.Command3.BackColor = System.Drawing.SystemColors.Control
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command3.Location = New System.Drawing.Point(1019, 793)
        Me.Command3.Name = "Command3"
        Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command3.Size = New System.Drawing.Size(111, 33)
        Me.Command3.TabIndex = 77
        Me.Command3.Text = "Fermer Connection"
        Me.Command3.UseVisualStyleBackColor = False
        '
        'CutawayControl1
        '
        Me.CutawayControl1.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill
        Me.CutawayControl1.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(90, 90, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer)), "TRES HAUT"))
        Me.CutawayControl1.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(80, 80, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.Yellow, "HAUT"))
        Me.CutawayControl1.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(0, 0, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.Green, "NORMAL"))
        Me.CutawayControl1.BlinkColor = System.Drawing.Color.Red
        Me.CutawayControl1.EmptyColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CutawayControl1.FillColor = System.Drawing.Color.Lime
        Me.CutawayControl1.Location = New System.Drawing.Point(93, 579)
        Me.CutawayControl1.Name = "CutawayControl1"
        Me.CutawayControl1.Size = New System.Drawing.Size(54, 61)
        Me.CutawayControl1.TabIndex = 81
        '
        'CutawayControl2
        '
        Me.CutawayControl2.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill
        Me.CutawayControl2.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(90, 90, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer)), "Band1"))
        Me.CutawayControl2.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(80, 80, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.Yellow, "Band2"))
        Me.CutawayControl2.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(70, 70, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.Green, "Band3"))
        Me.CutawayControl2.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(50, 50, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandChangeColor, System.Drawing.Color.Yellow, "Band4"))
        Me.CutawayControl2.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(30, 30, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandBlink, System.Drawing.Color.Red, "Band5"))
        Me.CutawayControl2.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(20, 20, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandChangeColor, System.Drawing.Color.Yellow, "Band6"))
        Me.CutawayControl2.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(0, 0, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandBlink, System.Drawing.Color.Red, "Band7"))
        Me.CutawayControl2.BlinkColor = System.Drawing.Color.Red
        Me.CutawayControl2.EmptyColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CutawayControl2.FillColor = System.Drawing.Color.Lime
        Me.CutawayControl2.Location = New System.Drawing.Point(384, 578)
        Me.CutawayControl2.Name = "CutawayControl2"
        Me.CutawayControl2.Size = New System.Drawing.Size(55, 61)
        Me.CutawayControl2.TabIndex = 84
        '
        'CutawayControl5
        '
        Me.CutawayControl5.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.AnalogIntegerColorFill
        Me.CutawayControl5.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(90, 90, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer)), "Band1"))
        Me.CutawayControl5.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(80, 80, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.Yellow, "Band2"))
        Me.CutawayControl5.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(70, 70, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.Green, "Band3"))
        Me.CutawayControl5.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(50, 50, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandChangeColor, System.Drawing.Color.Yellow, "Band4"))
        Me.CutawayControl5.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(30, 30, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandBlink, System.Drawing.Color.Red, "Band5"))
        Me.CutawayControl5.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(20, 20, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandChangeColor, System.Drawing.Color.Yellow, "Band6"))
        Me.CutawayControl5.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(0, 0, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandBlink, System.Drawing.Color.Red, "Band7"))
        Me.CutawayControl5.BlinkColor = System.Drawing.Color.Red
        Me.CutawayControl5.EmptyColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CutawayControl5.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CutawayControl5.Location = New System.Drawing.Point(668, 587)
        Me.CutawayControl5.Name = "CutawayControl5"
        Me.CutawayControl5.Size = New System.Drawing.Size(68, 53)
        Me.CutawayControl5.TabIndex = 89
        '
        'Command4
        '
        Me.Command4.BackColor = System.Drawing.Color.Blue
        Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Command4.Location = New System.Drawing.Point(792, 769)
        Me.Command4.Name = "Command4"
        Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command4.Size = New System.Drawing.Size(119, 59)
        Me.Command4.TabIndex = 109
        Me.Command4.Text = "REARMEMENT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ALARME"
        Me.Command4.UseVisualStyleBackColor = False
        '
        'Text2
        '
        Me.Text2.AcceptsReturn = True
        Me.Text2.BackColor = System.Drawing.SystemColors.Window
        Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text2.Location = New System.Drawing.Point(792, 834)
        Me.Text2.MaxLength = 0
        Me.Text2.Name = "Text2"
        Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text2.Size = New System.Drawing.Size(113, 20)
        Me.Text2.TabIndex = 110
        Me.Text2.Text = "0"
        '
        'StandardControl12
        '
        Me.StandardControl12.AnalogIntValue1 = CType(0, Short)
        Me.StandardControl12.AnalogValue1 = 0
        Me.StandardControl12.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill
        Me.StandardControl12.BackColor = System.Drawing.Color.Transparent
        Me.StandardControl12.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.StandardControl12.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0, 0, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkInvisible, System.Drawing.Color.Red, "Band1"))
        Me.StandardControl12.BlinkColor = System.Drawing.Color.Red
        Me.StandardControl12.Category = "1Btn.cat2"
        Me.StandardControl12.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl12.DebugData"))
        Me.StandardControl12.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl12.Location = New System.Drawing.Point(917, 782)
        Me.StandardControl12.Name = "StandardControl12"
        Me.StandardControl12.Size = New System.Drawing.Size(42, 39)
        Me.StandardControl12.SymbolHandle = CType(1257874638, Long)
        Me.StandardControl12.TabIndex = 111
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(96, 834)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(665, 26)
        Me.TextBox1.TabIndex = 112
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(13, 823)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(77, 38)
        Me.Label54.TabIndex = 113
        Me.Label54.Text = "Message" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Alarme"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.Controls.Add(Me.CutawayControl5)
        Me.TabPage1.Controls.Add(Me.CutawayControl1)
        Me.TabPage1.Controls.Add(Me.StandardControl2)
        Me.TabPage1.Controls.Add(Me.StandardControl14)
        Me.TabPage1.Controls.Add(Me.CutawayControl6)
        Me.TabPage1.Controls.Add(Me.StandardControl5)
        Me.TabPage1.Controls.Add(Me.CutawayControl2)
        Me.TabPage1.Controls.Add(Me.PictureBox16)
        Me.TabPage1.Controls.Add(Me.StandardControl13)
        Me.TabPage1.Controls.Add(Me.Label59)
        Me.TabPage1.Controls.Add(Me.Label60)
        Me.TabPage1.Controls.Add(Me.PictureBox15)
        Me.TabPage1.Controls.Add(Me.Label61)
        Me.TabPage1.Controls.Add(Me.Label58)
        Me.TabPage1.Controls.Add(Me.Label56)
        Me.TabPage1.Controls.Add(Me.Label57)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.PictureBox4)
        Me.TabPage1.Controls.Add(Me.PictureBox5)
        Me.TabPage1.Controls.Add(Me.StandardControl8)
        Me.TabPage1.Controls.Add(Me.StandardControl9)
        Me.TabPage1.Controls.Add(Me.StandardControl10)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.StandardControl11)
        Me.TabPage1.Controls.Add(Me.PictureBox8)
        Me.TabPage1.Controls.Add(Me.PictureBox9)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label41)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.Label46)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label43)
        Me.TabPage1.Controls.Add(Me.Label42)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label50)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label51)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1262, 718)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Rue Shefford"
        '
        'StandardControl2
        '
        Me.StandardControl2.AnalogIntValue1 = CType(0, Short)
        Me.StandardControl2.AnalogValue1 = 0
        Me.StandardControl2.BackColor = System.Drawing.Color.Transparent
        Me.StandardControl2.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.StandardControl2.BandsCollection.Add(New SymbolFactoryNetEngine.Band(90, 90, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"))
        Me.StandardControl2.BandsCollection.Add(New SymbolFactoryNetEngine.Band(80, 80, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"))
        Me.StandardControl2.BandsCollection.Add(New SymbolFactoryNetEngine.Band(70, 70, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"))
        Me.StandardControl2.BandsCollection.Add(New SymbolFactoryNetEngine.Band(50, 50, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"))
        Me.StandardControl2.BandsCollection.Add(New SymbolFactoryNetEngine.Band(30, 30, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"))
        Me.StandardControl2.BandsCollection.Add(New SymbolFactoryNetEngine.Band(20, 20, False, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"))
        Me.StandardControl2.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"))
        Me.StandardControl2.BlinkColor = System.Drawing.Color.Red
        Me.StandardControl2.Category = "1TANK.cat2"
        Me.StandardControl2.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl2.DebugData"))
        Me.StandardControl2.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl2.Location = New System.Drawing.Point(26, 567)
        Me.StandardControl2.Name = "StandardControl2"
        Me.StandardControl2.Size = New System.Drawing.Size(186, 82)
        Me.StandardControl2.SymbolHandle = CType(1613306155, Long)
        Me.StandardControl2.TabIndex = 134
        '
        'StandardControl14
        '
        Me.StandardControl14.AnalogIntValue1 = CType(0, Short)
        Me.StandardControl14.AnalogValue1 = 0
        Me.StandardControl14.BackColor = System.Drawing.Color.Transparent
        Me.StandardControl14.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.StandardControl14.BandsCollection.Add(New SymbolFactoryNetEngine.Band(90, 90, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"))
        Me.StandardControl14.BandsCollection.Add(New SymbolFactoryNetEngine.Band(80, 80, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"))
        Me.StandardControl14.BandsCollection.Add(New SymbolFactoryNetEngine.Band(70, 70, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"))
        Me.StandardControl14.BandsCollection.Add(New SymbolFactoryNetEngine.Band(50, 50, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"))
        Me.StandardControl14.BandsCollection.Add(New SymbolFactoryNetEngine.Band(30, 30, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"))
        Me.StandardControl14.BandsCollection.Add(New SymbolFactoryNetEngine.Band(20, 20, False, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"))
        Me.StandardControl14.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"))
        Me.StandardControl14.BlinkColor = System.Drawing.Color.Red
        Me.StandardControl14.Category = "1WW.cat2"
        Me.StandardControl14.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl14.DebugData"))
        Me.StandardControl14.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl14.Location = New System.Drawing.Point(602, 514)
        Me.StandardControl14.Name = "StandardControl14"
        Me.StandardControl14.Size = New System.Drawing.Size(211, 185)
        Me.StandardControl14.SymbolHandle = CType(621850601, Long)
        Me.StandardControl14.TabIndex = 133
        '
        'CutawayControl6
        '
        Me.CutawayControl6.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill
        Me.CutawayControl6.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(90, 90, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer)), "TRES HAUT"))
        Me.CutawayControl6.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(80, 80, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.Yellow, "HAUT"))
        Me.CutawayControl6.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(0, 0, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.Green, "NORMAL"))
        Me.CutawayControl6.BlinkColor = System.Drawing.Color.Red
        Me.CutawayControl6.EmptyColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CutawayControl6.FillColor = System.Drawing.Color.Yellow
        Me.CutawayControl6.Location = New System.Drawing.Point(200, 579)
        Me.CutawayControl6.Name = "CutawayControl6"
        Me.CutawayControl6.Size = New System.Drawing.Size(55, 61)
        Me.CutawayControl6.TabIndex = 128
        '
        'StandardControl5
        '
        Me.StandardControl5.AnalogIntValue1 = CType(0, Short)
        Me.StandardControl5.AnalogValue1 = 0
        Me.StandardControl5.BackColor = System.Drawing.Color.Transparent
        Me.StandardControl5.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.StandardControl5.BandsCollection.Add(New SymbolFactoryNetEngine.Band(90, 90, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"))
        Me.StandardControl5.BandsCollection.Add(New SymbolFactoryNetEngine.Band(80, 80, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"))
        Me.StandardControl5.BandsCollection.Add(New SymbolFactoryNetEngine.Band(70, 70, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"))
        Me.StandardControl5.BandsCollection.Add(New SymbolFactoryNetEngine.Band(50, 50, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"))
        Me.StandardControl5.BandsCollection.Add(New SymbolFactoryNetEngine.Band(30, 30, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"))
        Me.StandardControl5.BandsCollection.Add(New SymbolFactoryNetEngine.Band(20, 20, False, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"))
        Me.StandardControl5.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"))
        Me.StandardControl5.BlinkColor = System.Drawing.Color.Red
        Me.StandardControl5.Category = "1TANK.cat2"
        Me.StandardControl5.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl5.DebugData"))
        Me.StandardControl5.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl5.Location = New System.Drawing.Point(134, 567)
        Me.StandardControl5.Name = "StandardControl5"
        Me.StandardControl5.Size = New System.Drawing.Size(186, 82)
        Me.StandardControl5.SymbolHandle = CType(1613306155, Long)
        Me.StandardControl5.TabIndex = 132
        '
        'PictureBox16
        '
        Me.PictureBox16.Image = Global.Erable1.My.Resources.Resources.osmose30004000
        Me.PictureBox16.Location = New System.Drawing.Point(781, 6)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(473, 380)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox16.TabIndex = 130
        Me.PictureBox16.TabStop = False
        '
        'StandardControl13
        '
        Me.StandardControl13.AnalogIntValue1 = CType(0, Short)
        Me.StandardControl13.AnalogValue1 = 0
        Me.StandardControl13.BackColor = System.Drawing.Color.Transparent
        Me.StandardControl13.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.StandardControl13.BandsCollection.Add(New SymbolFactoryNetEngine.Band(90, 90, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"))
        Me.StandardControl13.BandsCollection.Add(New SymbolFactoryNetEngine.Band(80, 80, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"))
        Me.StandardControl13.BandsCollection.Add(New SymbolFactoryNetEngine.Band(70, 70, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"))
        Me.StandardControl13.BandsCollection.Add(New SymbolFactoryNetEngine.Band(50, 50, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"))
        Me.StandardControl13.BandsCollection.Add(New SymbolFactoryNetEngine.Band(30, 30, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"))
        Me.StandardControl13.BandsCollection.Add(New SymbolFactoryNetEngine.Band(20, 20, False, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"))
        Me.StandardControl13.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"))
        Me.StandardControl13.BlinkColor = System.Drawing.Color.Red
        Me.StandardControl13.Category = "1TANK.cat2"
        Me.StandardControl13.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl13.DebugData"))
        Me.StandardControl13.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl13.Location = New System.Drawing.Point(318, 567)
        Me.StandardControl13.Name = "StandardControl13"
        Me.StandardControl13.Size = New System.Drawing.Size(186, 82)
        Me.StandardControl13.SymbolHandle = CType(1613306155, Long)
        Me.StandardControl13.TabIndex = 129
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.Green
        Me.Label59.Location = New System.Drawing.Point(523, 252)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(91, 19)
        Me.Label59.TabIndex = 124
        Me.Label59.Text = "En marche"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Red
        Me.Label60.Location = New System.Drawing.Point(435, 252)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(69, 19)
        Me.Label60.TabIndex = 125
        Me.Label60.Text = "En arret"
        '
        'PictureBox15
        '
        Me.PictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox15.Location = New System.Drawing.Point(430, 247)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(189, 28)
        Me.PictureBox15.TabIndex = 127
        Me.PictureBox15.TabStop = False
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(453, 212)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(160, 29)
        Me.Label61.TabIndex = 123
        Me.Label61.Text = "Pompe filtrat"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(663, 523)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(106, 29)
        Me.Label58.TabIndex = 120
        Me.Label58.Text = "filtrat #1"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(362, 524)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(200, 29)
        Me.Label57.TabIndex = 119
        Me.Label57.Text = "Juste eau erable"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(21, 443)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(210, 66)
        Me.Label56.TabIndex = 118
        Me.Label56.Text = "2 cloisons au citerne #1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1ere eau d'erable" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2ieme filtrat #2 osmose"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 29)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Pompe #1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(100, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Gallons/heure"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(13, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(206, 97)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 19)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "FAUTE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(100, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Gallons/heure"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(13, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(81, 38)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 29)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Pompe #2"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(206, 168)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 19)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "FAUTE"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(8, 52)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(386, 147)
        Me.PictureBox4.TabIndex = 116
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Location = New System.Drawing.Point(6, 49)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(391, 153)
        Me.PictureBox5.TabIndex = 117
        Me.PictureBox5.TabStop = False
        '
        'StandardControl8
        '
        Me.StandardControl8.AnalogIntValue1 = CType(0, Short)
        Me.StandardControl8.AnalogValue1 = 0
        Me.StandardControl8.BackColor = System.Drawing.Color.Transparent
        Me.StandardControl8.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.StandardControl8.BlinkColor = System.Drawing.Color.Red
        Me.StandardControl8.BlinkMode = SymbolFactoryNetEngine.BlinkModeOptions.Invisible
        Me.StandardControl8.Category = "1Btn.cat2"
        Me.StandardControl8.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl8.DebugData"))
        Me.StandardControl8.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl8.Location = New System.Drawing.Point(335, 232)
        Me.StandardControl8.Name = "StandardControl8"
        Me.StandardControl8.Size = New System.Drawing.Size(42, 39)
        Me.StandardControl8.SymbolHandle = CType(1392289550, Long)
        Me.StandardControl8.TabIndex = 110
        '
        'StandardControl9
        '
        Me.StandardControl9.AnalogIntValue1 = CType(0, Short)
        Me.StandardControl9.AnalogValue1 = 0
        Me.StandardControl9.BackColor = System.Drawing.Color.Transparent
        Me.StandardControl9.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.StandardControl9.BlinkColor = System.Drawing.Color.Red
        Me.StandardControl9.Category = "1Btn.cat2"
        Me.StandardControl9.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl9.DebugData"))
        Me.StandardControl9.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl9.Location = New System.Drawing.Point(335, 232)
        Me.StandardControl9.Name = "StandardControl9"
        Me.StandardControl9.Size = New System.Drawing.Size(42, 39)
        Me.StandardControl9.SymbolHandle = CType(1367219686, Long)
        Me.StandardControl9.TabIndex = 111
        '
        'StandardControl10
        '
        Me.StandardControl10.AnalogIntValue1 = CType(0, Short)
        Me.StandardControl10.AnalogValue1 = 0
        Me.StandardControl10.BackColor = System.Drawing.Color.Transparent
        Me.StandardControl10.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.StandardControl10.BlinkColor = System.Drawing.Color.Red
        Me.StandardControl10.Category = "1Btn.cat2"
        Me.StandardControl10.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl10.DebugData"))
        Me.StandardControl10.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl10.Location = New System.Drawing.Point(335, 232)
        Me.StandardControl10.Name = "StandardControl10"
        Me.StandardControl10.Size = New System.Drawing.Size(42, 39)
        Me.StandardControl10.SymbolHandle = CType(1233294345, Long)
        Me.StandardControl10.TabIndex = 112
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(196, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 16)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "heures de marche"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label27.Location = New System.Drawing.Point(15, 235)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(146, 29)
        Me.Label27.TabIndex = 109
        Me.Label27.Text = "Osmose #1:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(161, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(38, 32)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "0"
        '
        'StandardControl11
        '
        Me.StandardControl11.AnalogIntValue1 = CType(0, Short)
        Me.StandardControl11.AnalogValue1 = 0
        Me.StandardControl11.BackColor = System.Drawing.Color.Transparent
        Me.StandardControl11.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.StandardControl11.BlinkColor = System.Drawing.Color.Red
        Me.StandardControl11.Category = "1Btn.cat2"
        Me.StandardControl11.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl11.DebugData"))
        Me.StandardControl11.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl11.Location = New System.Drawing.Point(335, 232)
        Me.StandardControl11.Name = "StandardControl11"
        Me.StandardControl11.Size = New System.Drawing.Size(42, 39)
        Me.StandardControl11.SymbolHandle = CType(703557272, Long)
        Me.StandardControl11.TabIndex = 113
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox8.Location = New System.Drawing.Point(8, 214)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(386, 73)
        Me.PictureBox8.TabIndex = 114
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox9.Location = New System.Drawing.Point(6, 212)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(391, 78)
        Me.PictureBox9.TabIndex = 115
        Me.PictureBox9.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(414, 115)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(137, 29)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "Vaccum #2"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(424, 157)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 19)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "En arret"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Green
        Me.Label14.Location = New System.Drawing.Point(512, 81)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 19)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "En marche"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(424, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 19)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "En arret"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label28.Location = New System.Drawing.Point(614, 81)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(108, 19)
        Me.Label28.TabIndex = 103
        Me.Label28.Text = "VACCUM OK"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(3, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(383, 29)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Erablière Brunelle - rue Shefford"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(412, 41)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(137, 29)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Vaccum #1"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label50.Location = New System.Drawing.Point(614, 157)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(108, 19)
        Me.Label50.TabIndex = 105
        Me.Label50.Text = "VACCUM OK"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(419, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 28)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Red
        Me.Label51.Location = New System.Drawing.Point(614, 157)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(166, 19)
        Me.Label51.TabIndex = 106
        Me.Label51.Text = "PERTE DE VACCUM"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(614, 81)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(166, 19)
        Me.Label29.TabIndex = 104
        Me.Label29.Text = "PERTE DE VACCUM"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Green
        Me.Label21.Location = New System.Drawing.Point(512, 157)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 19)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "En marche"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(419, 152)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(189, 28)
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(2, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1270, 745)
        Me.TabControl1.TabIndex = 114
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1272, 878)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.StandardControl12)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Command4)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.AxMbaxp1)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Location = New System.Drawing.Point(4, 24)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Erabliere Brunelle"
        CType(Me.AxMbaxp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CutawayControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CutawayControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CutawayControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.StandardControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CutawayControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Form1
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Form1
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Form1()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As Form1)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region
    Dim Sound As New System.Media.SoundPlayer()
    Dim e As Integer


    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        'Connection Serie
        'AxMbaxp1.Connection() = MBAXPLib.enumConnection.Port3 'COM Port #3 - USB
        'AxMbaxp1.BaudRate() = MBAXPLib.enumBaud.B9600 '9600 Bauds
        'AxMbaxp1.DataBits = 1 '8 Data bits
        'AxMbaxp1.Parity = 2 'Even parity
        'AxMbaxp1.StopBits = 0 '1 Stop bits
        'AxMbaxp1.ProtocolMode = 0 'RTU Mode
        'AxMbaxp1.Timeout = 2000

        'Connection TCP/IP
        AxMbaxp1.Connection() = MBAXPLib.enumConnection.TCP_IP
        AxMbaxp1.IPAddr1() = 192
        AxMbaxp1.IPAddr2() = 168
        AxMbaxp1.IPAddr3() = 1
        AxMbaxp1.IPAddr4() = 99
        AxMbaxp1.ConnectTimeout() = 3000  'ms



        e = AxMbaxp1.OpenConnection()
        e = AxMbaxp1.ReadHoldingRegisters(1, 1, 3000, 20, 700) ' handle 1, slave 1, adresse 43001, quantite 20, rafraichissement 700mS
        e = AxMbaxp1.ReadHoldingRegisters(2, 1, 999, 1, 1000) ' handle 2, slave 1, adresse 41000, quantite 1, rafr. 1000mS
        'e = AxMbaxp1.ReadHoldingRegisters(3, 1, 1, 1, 1000) ' handle 3, slave 1, adresse 40002, quantite 1, rafraichissement 1000mS
        'e = AxMbaxp1.ReadHoldingRegisters(4, 1, 0, 1, 1000) ' handle 4, slave 1, adresse 40001, quantite 1, rafraichissement 1000mS
        e = AxMbaxp1.ReadCoilStatus(5, 1, 0, 49, 1000) ' handle 5, slave 1, adresse 00001, quantite 50, rafraichissement 700mS
        e = AxMbaxp1.ForceMultipleCoils(6, 1, 34, 4, 700) ' D-OUT handle 6, slave 1, adresse 00035, quantite 4, rafr. 700mS
        e = AxMbaxp1.ReadCoilStatus(7, 1, 499, 2, 700) ' D-IN SONNORE handle 7, slave 1, adresse 00500, quantite 2, rafr. 700mS

        AxMbaxp1.UpdateEnable(1)
        AxMbaxp1.UpdateEnable(2) 'Debute les taches
        'AxMbaxp1.UpdateEnable(3)
        'AxMbaxp1.UpdateEnable(4)
        AxMbaxp1.UpdateEnable(5)
        AxMbaxp1.UpdateEnable(6)
        AxMbaxp1.UpdateEnable(7)

    End Sub
    'Ecrire une valeur dans le registre 40001
    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click ' Handle 0, slave 1, addr 40001, 1000mS
        AxMbaxp1.UpdateOnce(0)

        'Execute la tache avec handle 0
        e = AxMbaxp1.PresetSingleRegister(0, 1, 2800, 1000) 'handle 0, slave 1, 42801, 1000mS
        'Utilise handle 0 pour la premiere priorite
        'Le taux de rafraichissement ne veut rien dire si on utilise handle 0

        AxMbaxp1.set_Register(0, 0, Text1.Text) 'Text1 = valeur entree dans la case
        'Ecrit la valeur 0 dans le tableau 0 index 0

        AxMbaxp1.UpdateOnce(0)
        'Execute la tache une fois
        'Ce n'est pas possible d utiliser UpdateEnable non-ou UpdateDisable quand handle 0 est utilise
    End Sub
    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        AxMbaxp1.CloseConnection() 'Fermeture de la connection TCPIP
    End Sub
    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
        AxMbaxp1.UpdateOnce(0) 'Bouton de rearmement des alarmes
        Text2.Text = 1
        AxMbaxp1.set_Coil(6, 0, Text2.Text)
        AxMbaxp1.UpdateOnce(0)

    End Sub


    Private Sub AxMbaxp1_ResultError(ByVal sender As System.Object, ByVal e As AxMBAXPLib._DMbaxpEvents_ResultErrorEvent) Handles AxMbaxp1.ResultError
        ' Dans l'exemple, handle 1 est verifie seulement
        If e.handle = 1 Then
            If e.error = 10 Then 'Voir dans la liste de code d erreur 10=Timeout
                Label1.Text = "Timeout"
            End If
        End If

    End Sub 'Cependant la tâche est terminé, l'évenement ResultOK est renvoyé

    'TACHE DE LA RECEPTION DES VALEURS ANALOGUES
    Private Sub AxMbaxp1_ResultOk(ByVal sender As System.Object, ByVal e As AxMBAXPLib._DMbaxpEvents_ResultOkEvent) Handles AxMbaxp1.ResultOk
        If e.handle = 1 Then
            Label1.Text = CStr(AxMbaxp1.get_Register(1, 0)) 'Affiche la valeur Pompe d'amenee#1 C'est l'eau aspiree de la cabane #1 (principale)rue Shefford
            Label2.Text = CStr(AxMbaxp1.get_Register(1, 1)) 'Affiche la valeur Pompe d'amenee#2 C'est l'eau aspiree de la cabane #2 (petite) rue Shefford
            'Label3.Text = CStr(AxMbaxp1.get_Register(1, 2)) 'Affiche la valeur Pompe d'amenee#3 C'est l'eau aspiree de la cabane #3 boul. Pierre-Laporte
            Label4.Text = CStr(AxMbaxp1.get_Register(1, 3)) 'Affiche la valeur Osmose#1 cabane #1 (principale)rue Shefford
        End If
        'Sound.Load()
        'Sound.Play()
        'If e.handle = 2 Then
        'Label2.Text = CStr(AxMbaxp1.get_Register(2, 0)) 'Affiche la valeur du label #2
        'End If
        'If e.handle = 3 Then
        'Label3.Text = CStr(AxMbaxp1.get_Register(3, 0)) 'Affiche la valeur du label #3
        'End If
        'If e.handle = 4 Then
        'Label4.Text = CStr(AxMbaxp1.get_Register(4, 0)) 'Affiche la valeur du label #4
        'End If

        'TACHE DE LA RECEPTION DES VALEURS DIGITALES DES ETATS
        If e.handle = 5 Then
            Label14.Visible = CStr(AxMbaxp1.get_Coil(5, 0)) 'Affiche l'etat Marche      Vaccum#1-00001
            Label15.Visible = CStr(AxMbaxp1.get_Coil(5, 1)) 'Affiche l'etat Arret       Vaccum#1-00002
            Label21.Visible = CStr(AxMbaxp1.get_Coil(5, 2)) 'Affiche la l'etat Marche   Vaccum#2-00003
            Label20.Visible = CStr(AxMbaxp1.get_Coil(5, 3)) 'Affiche la l'etat Arret    Vaccum#2-00004
            'Label24.Visible = CStr(AxMbaxp1.get_Coil(5, 4)) 'Affiche la l'etat Marche   Vaccum#3-00005
            'Label23.Visible = CStr(AxMbaxp1.get_Coil(5, 5)) 'Affiche la l'etat Arret    Vaccum#3-00006
            'Label31.Visible = CStr(AxMbaxp1.get_Coil(5, 6)) 'Affiche la l'etat Marche   Pompe Poussee#1-00007
            'Label30.Visible = CStr(AxMbaxp1.get_Coil(5, 7)) 'Affiche la l'etat Arret    Pompe Poussee#1-00008
            StandardControl10.Visible = CStr(AxMbaxp1.get_Coil(5, 8)) 'Affiche l'etat VERT  l'heure de marche   Osmose#1-00009
            StandardControl9.Visible = CStr(AxMbaxp1.get_Coil(5, 9))  'Affiche l'etat JAUNE l'heure de marche   Osmose#1-00010
            StandardControl8.Visible = CStr(AxMbaxp1.get_Coil(5, 10)) 'Affiche l'etat ROUGE l'heure de marche   Osmose#1-00011
            Label17.Visible = CStr(AxMbaxp1.get_Coil(5, 22)) 'Affiche l'etat FAUTE      Pompe Amenee#1-00023
            Label18.Visible = CStr(AxMbaxp1.get_Coil(5, 23)) 'Affiche l'etat FAUTE      Pompe Amenee#2-00024
            'Label19.Visible = CStr(AxMbaxp1.get_Coil(5, 24)) 'Affiche l'etat FAUTE      Pompe Amenee#3-00025

            'TACHE DE LA RECEPTION D'UN BIT POUR GENERER UN SON LORSQU'UNE ALARME EST SURVENUE
            If AxMbaxp1.get_Coil(7, 0) = 1 Then 'Genere un son de l'alarme generale-00050
                My.Computer.Audio.Play("C:\ProjVB_Erabliere\VBNET\sound3.wav", AudioPlayMode.WaitToComplete)
            End If
            If AxMbaxp1.get_Coil(7, 1) = 1 Then
                TextBox1.BackColor() = Color.OrangeRed
            Else : TextBox1.BackColor() = Color.WhiteSmoke
            End If
        End If
        If e.handle = 6 Then 'RAZ le bouton de rearmement
            Text2.Text = 0 ' Met OFF le bit de rearmement
            AxMbaxp1.set_Coil(6, 0, Text2.Text)
            AxMbaxp1.UpdateOnce(0)
        End If

        'TACHE DE LA RECEPTION DES VALEURS DIGITALES DES ALARMES
        If e.handle = 2 Then ' Gestion des messages d alarme
            If CStr(AxMbaxp1.get_Register(2, 0)) = 0 Then TextBox1.Text = "Operation normale"
            If CStr(AxMbaxp1.get_Register(2, 0)) = -32768 Then TextBox1.Text = "Osmose en marche pendant 4 heures" ' Bit 1-41000
            If CStr(AxMbaxp1.get_Register(2, 0)) = 16384 Then TextBox1.Text = "Bit de test 2" ' Bit 2-41000
            If CStr(AxMbaxp1.get_Register(2, 0)) = 8192 Then TextBox1.Text = "Bit de test 3" ' Bit 3-41000
            If CStr(AxMbaxp1.get_Register(2, 0)) = 4096 Then TextBox1.Text = "Bit de test 4" ' Bit 4-41000
            If CStr(AxMbaxp1.get_Register(2, 0)) = 2048 Then TextBox1.Text = "Bit de test 5" ' Bit 5-41000
            If CStr(AxMbaxp1.get_Register(2, 0)) = 1024 Then TextBox1.Text = "Bit de test 6" ' Bit 6-41000
            If CStr(AxMbaxp1.get_Register(2, 0)) = 512 Then TextBox1.Text = "Bit de test 7" ' Bit 7-41000
            If CStr(AxMbaxp1.get_Register(2, 0)) = 256 Then TextBox1.Text = "Bit de test 8" ' Bit 8-41000
            If CStr(AxMbaxp1.get_Register(2, 0)) = 128 Then TextBox1.Text = "Bit de test 9" ' Bit 9-41000
            If CStr(AxMbaxp1.get_Register(2, 0)) = 64 Then TextBox1.Text = "Bit de test 10" ' Bit 10-41000
            If CStr(AxMbaxp1.get_Register(2, 0)) = 32 Then TextBox1.Text = "Bit de test 11" ' Bit 11-41000
            If CStr(AxMbaxp1.get_Register(2, 0)) = 16 Then TextBox1.Text = "Bit de test 12" ' Bit 12-41000
            If CStr(AxMbaxp1.get_Register(2, 0)) = 8 Then TextBox1.Text = "Bit de test 13" ' Bit 13-41000
            If CStr(AxMbaxp1.get_Register(2, 0)) = 4 Then TextBox1.Text = "Bit de test 14" ' Bit 14-41000
            If CStr(AxMbaxp1.get_Register(2, 0)) = 2 Then TextBox1.Text = "Bit de test 15" ' Bit 15-41000
            If CStr(AxMbaxp1.get_Register(2, 0)) = 1 Then TextBox1.Text = "Bit de test 16" ' Bit 16-41000
        End If
    End Sub


End Class