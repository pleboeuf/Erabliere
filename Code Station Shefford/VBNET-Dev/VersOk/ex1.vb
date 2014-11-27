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
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Public WithEvents Command3 As System.Windows.Forms.Button
    Friend WithEvents StandardControl1 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents StandardControl2 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents StandardControl3 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents CutawayControl1 As SymbolFactoryDotNet.CutawayControl
    Friend WithEvents StandardControl4 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents CutawayControl2 As SymbolFactoryDotNet.CutawayControl
    Friend WithEvents StandardControl5 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents CutawayControl3 As SymbolFactoryDotNet.CutawayControl
    Friend WithEvents CutawayControl4 As SymbolFactoryDotNet.CutawayControl
    Friend WithEvents CutawayControl5 As SymbolFactoryDotNet.CutawayControl
    Friend WithEvents StandardControl6 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents StandardControl7 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents StandardControl8 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents StandardControl9 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents StandardControl10 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents StandardControl11 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Public WithEvents Command4 As System.Windows.Forms.Button
    Public WithEvents Text2 As System.Windows.Forms.TextBox
    Friend WithEvents StandardControl12 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.AxMbaxp1 = New AxMBAXPLib.AxMbaxp
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.PictureBox11 = New System.Windows.Forms.PictureBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Command3 = New System.Windows.Forms.Button
        Me.StandardControl1 = New SymbolFactoryDotNet.StandardControl
        Me.StandardControl2 = New SymbolFactoryDotNet.StandardControl
        Me.StandardControl3 = New SymbolFactoryDotNet.StandardControl
        Me.CutawayControl1 = New SymbolFactoryDotNet.CutawayControl
        Me.StandardControl4 = New SymbolFactoryDotNet.StandardControl
        Me.CutawayControl2 = New SymbolFactoryDotNet.CutawayControl
        Me.StandardControl5 = New SymbolFactoryDotNet.StandardControl
        Me.CutawayControl3 = New SymbolFactoryDotNet.CutawayControl
        Me.CutawayControl4 = New SymbolFactoryDotNet.CutawayControl
        Me.CutawayControl5 = New SymbolFactoryDotNet.CutawayControl
        Me.StandardControl6 = New SymbolFactoryDotNet.StandardControl
        Me.StandardControl7 = New SymbolFactoryDotNet.StandardControl
        Me.StandardControl8 = New SymbolFactoryDotNet.StandardControl
        Me.StandardControl9 = New SymbolFactoryDotNet.StandardControl
        Me.StandardControl10 = New SymbolFactoryDotNet.StandardControl
        Me.StandardControl11 = New SymbolFactoryDotNet.StandardControl
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.PictureBox9 = New System.Windows.Forms.PictureBox
        Me.PictureBox10 = New System.Windows.Forms.PictureBox
        Me.PictureBox12 = New System.Windows.Forms.PictureBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Command4 = New System.Windows.Forms.Button
        Me.Text2 = New System.Windows.Forms.TextBox
        Me.StandardControl12 = New SymbolFactoryDotNet.StandardControl
        Me.TextBox1 = New System.Windows.Forms.TextBox
        CType(Me.AxMbaxp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CutawayControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CutawayControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CutawayControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CutawayControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CutawayControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControl12, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(167, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(38, 32)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "0"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(19, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(81, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "0"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(19, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(81, 38)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "0"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(19, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "0"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(106, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Gallons/heure"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(106, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Gallons/heure"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(106, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Gallons/heure"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(202, 375)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "heures de marche"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(299, 29)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Pompe #1 - Rue Shefford"
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(299, 29)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Pompe #2 - Rue Shefford"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 237)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(356, 29)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Pompe #3 - Rte Pierre-Laporte"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(21, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(218, 29)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Erablière Brunelle"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Green
        Me.Label14.Location = New System.Drawing.Point(518, 98)
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
        Me.Label15.Location = New System.Drawing.Point(430, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 19)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "En arret"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(420, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(310, 29)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Vaccum #1 - Rue Shefford"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(425, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 28)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(212, 102)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 19)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "FAUTE"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(212, 191)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 19)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "FAUTE"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(212, 284)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 19)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "FAUTE"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(430, 187)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 19)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "En arret"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Green
        Me.Label21.Location = New System.Drawing.Point(518, 187)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 19)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "En marche"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(425, 182)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(189, 28)
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(420, 145)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(310, 29)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "Vaccum #2 - Rue Shefford"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(430, 279)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(69, 19)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "En arret"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Green
        Me.Label24.Location = New System.Drawing.Point(518, 279)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(91, 19)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "En marche"
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(425, 274)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(189, 28)
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(420, 237)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(367, 29)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "Vaccum #3 - Rte Pierre-Laporte"
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(16, 50)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(386, 268)
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Location = New System.Drawing.Point(14, 48)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(391, 272)
        Me.PictureBox5.TabIndex = 35
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Location = New System.Drawing.Point(412, 48)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(395, 272)
        Me.PictureBox6.TabIndex = 36
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox7.Location = New System.Drawing.Point(414, 50)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(391, 268)
        Me.PictureBox7.TabIndex = 37
        Me.PictureBox7.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(21, 389)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(0, 29)
        Me.Label26.TabIndex = 38
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label27.Location = New System.Drawing.Point(21, 366)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(146, 29)
        Me.Label27.TabIndex = 39
        Me.Label27.Text = "Osmose #1:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Red
        Me.Label30.Location = New System.Drawing.Point(430, 376)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(69, 19)
        Me.Label30.TabIndex = 46
        Me.Label30.Text = "En arret"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Green
        Me.Label31.Location = New System.Drawing.Point(518, 376)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(91, 19)
        Me.Label31.TabIndex = 45
        Me.Label31.Text = "En marche"
        '
        'PictureBox11
        '
        Me.PictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox11.Location = New System.Drawing.Point(425, 372)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(189, 28)
        Me.PictureBox11.TabIndex = 48
        Me.PictureBox11.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(420, 335)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(383, 29)
        Me.Label32.TabIndex = 47
        Me.Label32.Text = "Pompe poussée - Rte P.-Laporte"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Red
        Me.Label33.Location = New System.Drawing.Point(893, 117)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(66, 19)
        Me.Label33.TabIndex = 50
        Me.Label33.Text = "Fermée"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Green
        Me.Label34.Location = New System.Drawing.Point(893, 102)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(60, 19)
        Me.Label34.TabIndex = 49
        Me.Label34.Text = "Ouvert"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Red
        Me.Label35.Location = New System.Drawing.Point(893, 162)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(66, 19)
        Me.Label35.TabIndex = 52
        Me.Label35.Text = "Fermée"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Green
        Me.Label36.Location = New System.Drawing.Point(893, 147)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(60, 19)
        Me.Label36.TabIndex = 51
        Me.Label36.Text = "Ouvert"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Red
        Me.Label37.Location = New System.Drawing.Point(982, 162)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(66, 19)
        Me.Label37.TabIndex = 56
        Me.Label37.Text = "Fermée"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Green
        Me.Label38.Location = New System.Drawing.Point(982, 147)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(60, 19)
        Me.Label38.TabIndex = 55
        Me.Label38.Text = "Ouvert"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Red
        Me.Label39.Location = New System.Drawing.Point(982, 117)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(66, 19)
        Me.Label39.TabIndex = 54
        Me.Label39.Text = "Fermée"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Green
        Me.Label40.Location = New System.Drawing.Point(982, 102)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(60, 19)
        Me.Label40.TabIndex = 53
        Me.Label40.Text = "Ouvert"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(30, 576)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(86, 19)
        Me.Label41.TabIndex = 68
        Me.Label41.Text = "Citerne #1"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(374, 576)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(86, 19)
        Me.Label42.TabIndex = 69
        Me.Label42.Text = "Citerne #2"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(676, 576)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(86, 19)
        Me.Label43.TabIndex = 70
        Me.Label43.Text = "Citerne #3"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(35, 759)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(105, 19)
        Me.Label44.TabIndex = 71
        Me.Label44.Text = "Réservoir #1"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(258, 759)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(105, 19)
        Me.Label45.TabIndex = 72
        Me.Label45.Text = "Réservoir #2"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(63, 458)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(281, 29)
        Me.Label46.TabIndex = 73
        Me.Label46.Text = "Citernes - Rue Shefford"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(63, 634)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(271, 29)
        Me.Label47.TabIndex = 74
        Me.Label47.Text = "Réser. - Rte P.-Laporte"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(906, 50)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(129, 38)
        Me.Label48.TabIndex = 75
        Me.Label48.Text = "Position valves " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rte P.-Laporte"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(870, 2)
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
        'StandardControl1
        '
        Me.StandardControl1.AnalogIntValue1 = CType(0, Short)
        Me.StandardControl1.AnalogValue1 = 0
        Me.StandardControl1.BackColor = System.Drawing.Color.Transparent
        Me.StandardControl1.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.StandardControl1.BandsCollection.Add(New SymbolFactoryNetEngine.Band(90, 90, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"))
        Me.StandardControl1.BandsCollection.Add(New SymbolFactoryNetEngine.Band(80, 80, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"))
        Me.StandardControl1.BandsCollection.Add(New SymbolFactoryNetEngine.Band(70, 70, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"))
        Me.StandardControl1.BandsCollection.Add(New SymbolFactoryNetEngine.Band(50, 50, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"))
        Me.StandardControl1.BandsCollection.Add(New SymbolFactoryNetEngine.Band(30, 30, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"))
        Me.StandardControl1.BandsCollection.Add(New SymbolFactoryNetEngine.Band(20, 20, False, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"))
        Me.StandardControl1.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"))
        Me.StandardControl1.BlinkColor = System.Drawing.Color.Red
        Me.StandardControl1.Category = "1TANK.cat2"
        Me.StandardControl1.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl1.DebugData"))
        Me.StandardControl1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl1.Location = New System.Drawing.Point(247, 657)
        Me.StandardControl1.Name = "StandardControl1"
        Me.StandardControl1.Size = New System.Drawing.Size(128, 121)
        Me.StandardControl1.SymbolHandle = CType(1015960268, Long)
        Me.StandardControl1.TabIndex = 78
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
        Me.StandardControl2.Category = "1veh.cat2"
        Me.StandardControl2.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl2.DebugData"))
        Me.StandardControl2.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl2.Location = New System.Drawing.Point(14, 502)
        Me.StandardControl2.Name = "StandardControl2"
        Me.StandardControl2.Size = New System.Drawing.Size(180, 77)
        Me.StandardControl2.SymbolHandle = CType(1039280940, Long)
        Me.StandardControl2.TabIndex = 79
        '
        'StandardControl3
        '
        Me.StandardControl3.AnalogIntValue1 = CType(0, Short)
        Me.StandardControl3.AnalogValue1 = 0
        Me.StandardControl3.BackColor = System.Drawing.Color.Transparent
        Me.StandardControl3.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.StandardControl3.BandsCollection.Add(New SymbolFactoryNetEngine.Band(90, 90, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"))
        Me.StandardControl3.BandsCollection.Add(New SymbolFactoryNetEngine.Band(80, 80, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"))
        Me.StandardControl3.BandsCollection.Add(New SymbolFactoryNetEngine.Band(70, 70, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"))
        Me.StandardControl3.BandsCollection.Add(New SymbolFactoryNetEngine.Band(50, 50, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"))
        Me.StandardControl3.BandsCollection.Add(New SymbolFactoryNetEngine.Band(30, 30, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"))
        Me.StandardControl3.BandsCollection.Add(New SymbolFactoryNetEngine.Band(20, 20, False, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"))
        Me.StandardControl3.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"))
        Me.StandardControl3.BlinkColor = System.Drawing.Color.Red
        Me.StandardControl3.Category = "1TANK.cat2"
        Me.StandardControl3.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl3.DebugData"))
        Me.StandardControl3.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl3.Location = New System.Drawing.Point(26, 657)
        Me.StandardControl3.Name = "StandardControl3"
        Me.StandardControl3.Size = New System.Drawing.Size(128, 121)
        Me.StandardControl3.SymbolHandle = CType(1015960268, Long)
        Me.StandardControl3.TabIndex = 80
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
        Me.CutawayControl1.Location = New System.Drawing.Point(74, 512)
        Me.CutawayControl1.Name = "CutawayControl1"
        Me.CutawayControl1.Size = New System.Drawing.Size(55, 51)
        Me.CutawayControl1.TabIndex = 81
        '
        'StandardControl4
        '
        Me.StandardControl4.AnalogIntValue1 = CType(0, Short)
        Me.StandardControl4.AnalogValue1 = 0
        Me.StandardControl4.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill
        Me.StandardControl4.BackColor = System.Drawing.Color.Transparent
        Me.StandardControl4.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.StandardControl4.BandsCollection.Add(New SymbolFactoryNetEngine.Band(90, 90, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band1"))
        Me.StandardControl4.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Lime, "Band2"))
        Me.StandardControl4.BlinkColor = System.Drawing.Color.Red
        Me.StandardControl4.Category = "1VLV.cat2"
        Me.StandardControl4.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl4.DebugData"))
        Me.StandardControl4.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl4.Location = New System.Drawing.Point(857, 274)
        Me.StandardControl4.Name = "StandardControl4"
        Me.StandardControl4.Rotation = SymbolFactoryNetEngine.RotationOptions.Rotate270
        Me.StandardControl4.Size = New System.Drawing.Size(54, 56)
        Me.StandardControl4.SymbolHandle = CType(1720777111, Long)
        Me.StandardControl4.TabIndex = 82
        '
        'CutawayControl2
        '
        Me.CutawayControl2.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.AnalogIntegerColorFill
        Me.CutawayControl2.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(90, 90, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer)), "Band1"))
        Me.CutawayControl2.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(80, 80, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.Yellow, "Band2"))
        Me.CutawayControl2.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(70, 70, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.Green, "Band3"))
        Me.CutawayControl2.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(50, 50, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandChangeColor, System.Drawing.Color.Yellow, "Band4"))
        Me.CutawayControl2.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(30, 30, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandBlink, System.Drawing.Color.Red, "Band5"))
        Me.CutawayControl2.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(20, 20, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandChangeColor, System.Drawing.Color.Yellow, "Band6"))
        Me.CutawayControl2.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(0, 0, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandBlink, System.Drawing.Color.Red, "Band7"))
        Me.CutawayControl2.BlinkColor = System.Drawing.Color.Red
        Me.CutawayControl2.EmptyColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CutawayControl2.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CutawayControl2.Location = New System.Drawing.Point(384, 512)
        Me.CutawayControl2.Name = "CutawayControl2"
        Me.CutawayControl2.Size = New System.Drawing.Size(55, 51)
        Me.CutawayControl2.TabIndex = 84
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
        Me.StandardControl5.Category = "1veh.cat2"
        Me.StandardControl5.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl5.DebugData"))
        Me.StandardControl5.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl5.Location = New System.Drawing.Point(324, 502)
        Me.StandardControl5.Name = "StandardControl5"
        Me.StandardControl5.Size = New System.Drawing.Size(180, 77)
        Me.StandardControl5.SymbolHandle = CType(1039280940, Long)
        Me.StandardControl5.TabIndex = 83
        '
        'CutawayControl3
        '
        Me.CutawayControl3.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.AnalogIntegerColorFill
        Me.CutawayControl3.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(90, 90, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer)), "Band1"))
        Me.CutawayControl3.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(80, 80, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.Yellow, "Band2"))
        Me.CutawayControl3.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(70, 70, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.Green, "Band3"))
        Me.CutawayControl3.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(50, 50, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandChangeColor, System.Drawing.Color.Yellow, "Band4"))
        Me.CutawayControl3.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(30, 30, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandBlink, System.Drawing.Color.Red, "Band5"))
        Me.CutawayControl3.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(20, 20, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandChangeColor, System.Drawing.Color.Yellow, "Band6"))
        Me.CutawayControl3.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(0, 0, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandBlink, System.Drawing.Color.Red, "Band7"))
        Me.CutawayControl3.BlinkColor = System.Drawing.Color.Red
        Me.CutawayControl3.EmptyColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CutawayControl3.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CutawayControl3.Location = New System.Drawing.Point(85, 687)
        Me.CutawayControl3.Name = "CutawayControl3"
        Me.CutawayControl3.Size = New System.Drawing.Size(55, 61)
        Me.CutawayControl3.TabIndex = 86
        '
        'CutawayControl4
        '
        Me.CutawayControl4.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.AnalogIntegerColorFill
        Me.CutawayControl4.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(90, 90, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer)), "Band1"))
        Me.CutawayControl4.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(80, 80, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.Yellow, "Band2"))
        Me.CutawayControl4.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(70, 70, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandOriginalColor, System.Drawing.Color.Green, "Band3"))
        Me.CutawayControl4.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(50, 50, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandChangeColor, System.Drawing.Color.Yellow, "Band4"))
        Me.CutawayControl4.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(30, 30, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandBlink, System.Drawing.Color.Red, "Band5"))
        Me.CutawayControl4.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(20, 20, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandChangeColor, System.Drawing.Color.Yellow, "Band6"))
        Me.CutawayControl4.BandsCollection.Add(New SymbolFactoryNetEngine.CutawayBands(0, 0, False, SymbolFactoryNetEngine.CutawayBandStyleOptions.BandBlink, System.Drawing.Color.Red, "Band7"))
        Me.CutawayControl4.BlinkColor = System.Drawing.Color.Red
        Me.CutawayControl4.EmptyColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CutawayControl4.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CutawayControl4.Location = New System.Drawing.Point(308, 687)
        Me.CutawayControl4.Name = "CutawayControl4"
        Me.CutawayControl4.Size = New System.Drawing.Size(55, 61)
        Me.CutawayControl4.TabIndex = 87
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
        Me.CutawayControl5.Location = New System.Drawing.Point(717, 502)
        Me.CutawayControl5.Name = "CutawayControl5"
        Me.CutawayControl5.Size = New System.Drawing.Size(55, 61)
        Me.CutawayControl5.TabIndex = 89
        '
        'StandardControl6
        '
        Me.StandardControl6.AnalogIntValue1 = CType(0, Short)
        Me.StandardControl6.AnalogValue1 = 0
        Me.StandardControl6.BackColor = System.Drawing.Color.Transparent
        Me.StandardControl6.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.StandardControl6.BandsCollection.Add(New SymbolFactoryNetEngine.Band(90, 90, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"))
        Me.StandardControl6.BandsCollection.Add(New SymbolFactoryNetEngine.Band(80, 80, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"))
        Me.StandardControl6.BandsCollection.Add(New SymbolFactoryNetEngine.Band(70, 70, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"))
        Me.StandardControl6.BandsCollection.Add(New SymbolFactoryNetEngine.Band(50, 50, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"))
        Me.StandardControl6.BandsCollection.Add(New SymbolFactoryNetEngine.Band(30, 30, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"))
        Me.StandardControl6.BandsCollection.Add(New SymbolFactoryNetEngine.Band(20, 20, False, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"))
        Me.StandardControl6.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"))
        Me.StandardControl6.BlinkColor = System.Drawing.Color.Red
        Me.StandardControl6.Category = "1TANK.cat2"
        Me.StandardControl6.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl6.DebugData"))
        Me.StandardControl6.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl6.Location = New System.Drawing.Point(656, 472)
        Me.StandardControl6.Name = "StandardControl6"
        Me.StandardControl6.Size = New System.Drawing.Size(128, 121)
        Me.StandardControl6.SymbolHandle = CType(1015960268, Long)
        Me.StandardControl6.TabIndex = 88
        '
        'StandardControl7
        '
        Me.StandardControl7.AnalogIntValue1 = CType(0, Short)
        Me.StandardControl7.AnalogValue1 = 0
        Me.StandardControl7.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill
        Me.StandardControl7.BackColor = System.Drawing.Color.Transparent
        Me.StandardControl7.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.StandardControl7.BandsCollection.Add(New SymbolFactoryNetEngine.Band(90, 90, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"))
        Me.StandardControl7.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Green, "Band2"))
        Me.StandardControl7.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0, 0, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Red, "Band3"))
        Me.StandardControl7.BlinkColor = System.Drawing.Color.Red
        Me.StandardControl7.Category = "1PMP.cat2"
        Me.StandardControl7.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl7.DebugData"))
        Me.StandardControl7.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl7.Location = New System.Drawing.Point(640, 356)
        Me.StandardControl7.Name = "StandardControl7"
        Me.StandardControl7.Size = New System.Drawing.Size(102, 74)
        Me.StandardControl7.SymbolHandle = CType(318240838, Long)
        Me.StandardControl7.TabIndex = 90
        Me.StandardControl7.UserNote1 = "Arret"
        Me.StandardControl7.UserNote2 = "Marche"
        Me.StandardControl7.UserNote3 = "Surchauffe"
        '
        'StandardControl8
        '
        Me.StandardControl8.AnalogIntValue1 = CType(0, Short)
        Me.StandardControl8.AnalogValue1 = 0
        Me.StandardControl8.BackColor = System.Drawing.Color.Transparent
        Me.StandardControl8.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.StandardControl8.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"))
        Me.StandardControl8.BlinkColor = System.Drawing.Color.Red
        Me.StandardControl8.BlinkMode = SymbolFactoryNetEngine.BlinkModeOptions.Invisible
        Me.StandardControl8.Category = "1Btn.cat2"
        Me.StandardControl8.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl8.DebugData"))
        Me.StandardControl8.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl8.Location = New System.Drawing.Point(331, 364)
        Me.StandardControl8.Name = "StandardControl8"
        Me.StandardControl8.Size = New System.Drawing.Size(42, 39)
        Me.StandardControl8.SymbolHandle = CType(1392289550, Long)
        Me.StandardControl8.TabIndex = 91
        '
        'StandardControl9
        '
        Me.StandardControl9.AnalogIntValue1 = CType(0, Short)
        Me.StandardControl9.AnalogValue1 = 0
        Me.StandardControl9.BackColor = System.Drawing.Color.Transparent
        Me.StandardControl9.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.StandardControl9.BandsCollection.Add(New SymbolFactoryNetEngine.Band(90, 90, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"))
        Me.StandardControl9.BandsCollection.Add(New SymbolFactoryNetEngine.Band(80, 80, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"))
        Me.StandardControl9.BandsCollection.Add(New SymbolFactoryNetEngine.Band(70, 70, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"))
        Me.StandardControl9.BandsCollection.Add(New SymbolFactoryNetEngine.Band(50, 50, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"))
        Me.StandardControl9.BandsCollection.Add(New SymbolFactoryNetEngine.Band(30, 30, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"))
        Me.StandardControl9.BandsCollection.Add(New SymbolFactoryNetEngine.Band(20, 20, False, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"))
        Me.StandardControl9.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"))
        Me.StandardControl9.BlinkColor = System.Drawing.Color.Red
        Me.StandardControl9.Category = "1Btn.cat2"
        Me.StandardControl9.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl9.DebugData"))
        Me.StandardControl9.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl9.Location = New System.Drawing.Point(331, 364)
        Me.StandardControl9.Name = "StandardControl9"
        Me.StandardControl9.Size = New System.Drawing.Size(42, 39)
        Me.StandardControl9.SymbolHandle = CType(1367219686, Long)
        Me.StandardControl9.TabIndex = 92
        '
        'StandardControl10
        '
        Me.StandardControl10.AnalogIntValue1 = CType(0, Short)
        Me.StandardControl10.AnalogValue1 = 0
        Me.StandardControl10.BackColor = System.Drawing.Color.Transparent
        Me.StandardControl10.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.StandardControl10.BandsCollection.Add(New SymbolFactoryNetEngine.Band(90, 90, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"))
        Me.StandardControl10.BandsCollection.Add(New SymbolFactoryNetEngine.Band(80, 80, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"))
        Me.StandardControl10.BandsCollection.Add(New SymbolFactoryNetEngine.Band(70, 70, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"))
        Me.StandardControl10.BandsCollection.Add(New SymbolFactoryNetEngine.Band(50, 50, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"))
        Me.StandardControl10.BandsCollection.Add(New SymbolFactoryNetEngine.Band(30, 30, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"))
        Me.StandardControl10.BandsCollection.Add(New SymbolFactoryNetEngine.Band(20, 20, False, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"))
        Me.StandardControl10.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"))
        Me.StandardControl10.BlinkColor = System.Drawing.Color.Red
        Me.StandardControl10.Category = "1Btn.cat2"
        Me.StandardControl10.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl10.DebugData"))
        Me.StandardControl10.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl10.Location = New System.Drawing.Point(331, 364)
        Me.StandardControl10.Name = "StandardControl10"
        Me.StandardControl10.Size = New System.Drawing.Size(42, 39)
        Me.StandardControl10.SymbolHandle = CType(1233294345, Long)
        Me.StandardControl10.TabIndex = 93
        '
        'StandardControl11
        '
        Me.StandardControl11.AnalogIntValue1 = CType(0, Short)
        Me.StandardControl11.AnalogValue1 = 0
        Me.StandardControl11.BackColor = System.Drawing.Color.Transparent
        Me.StandardControl11.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.StandardControl11.BandsCollection.Add(New SymbolFactoryNetEngine.Band(90, 90, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"))
        Me.StandardControl11.BandsCollection.Add(New SymbolFactoryNetEngine.Band(80, 80, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"))
        Me.StandardControl11.BandsCollection.Add(New SymbolFactoryNetEngine.Band(70, 70, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"))
        Me.StandardControl11.BandsCollection.Add(New SymbolFactoryNetEngine.Band(50, 50, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"))
        Me.StandardControl11.BandsCollection.Add(New SymbolFactoryNetEngine.Band(30, 30, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"))
        Me.StandardControl11.BandsCollection.Add(New SymbolFactoryNetEngine.Band(20, 20, False, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"))
        Me.StandardControl11.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"))
        Me.StandardControl11.BlinkColor = System.Drawing.Color.Red
        Me.StandardControl11.Category = "1Btn.cat2"
        Me.StandardControl11.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControl11.DebugData"))
        Me.StandardControl11.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StandardControl11.Location = New System.Drawing.Point(331, 364)
        Me.StandardControl11.Name = "StandardControl11"
        Me.StandardControl11.Size = New System.Drawing.Size(42, 39)
        Me.StandardControl11.SymbolHandle = CType(703557272, Long)
        Me.StandardControl11.TabIndex = 94
        '
        'PictureBox8
        '
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox8.Location = New System.Drawing.Point(16, 324)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(386, 115)
        Me.PictureBox8.TabIndex = 99
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox9.Location = New System.Drawing.Point(14, 322)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(391, 119)
        Me.PictureBox9.TabIndex = 100
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox10.Location = New System.Drawing.Point(414, 324)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(391, 117)
        Me.PictureBox10.TabIndex = 101
        Me.PictureBox10.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox12.Location = New System.Drawing.Point(412, 322)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(395, 121)
        Me.PictureBox12.TabIndex = 102
        Me.PictureBox12.TabStop = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label28.Location = New System.Drawing.Point(620, 98)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(108, 19)
        Me.Label28.TabIndex = 103
        Me.Label28.Text = "VACCUM OK"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(620, 98)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(166, 19)
        Me.Label29.TabIndex = 104
        Me.Label29.Text = "PERTE DE VACCUM"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label50.Location = New System.Drawing.Point(620, 187)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(108, 19)
        Me.Label50.TabIndex = 105
        Me.Label50.Text = "VACCUM OK"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Red
        Me.Label51.Location = New System.Drawing.Point(620, 187)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(166, 19)
        Me.Label51.TabIndex = 106
        Me.Label51.Text = "PERTE DE VACCUM"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label52.Location = New System.Drawing.Point(620, 279)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(108, 19)
        Me.Label52.TabIndex = 107
        Me.Label52.Text = "VACCUM OK"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Red
        Me.Label53.Location = New System.Drawing.Point(620, 279)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(166, 19)
        Me.Label53.TabIndex = 108
        Me.Label53.Text = "PERTE DE VACCUM"
        '
        'Command4
        '
        Me.Command4.BackColor = System.Drawing.Color.Blue
        Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Command4.Location = New System.Drawing.Point(792, 754)
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
        Me.StandardControl12.Location = New System.Drawing.Point(986, 400)
        Me.StandardControl12.Name = "StandardControl12"
        Me.StandardControl12.Size = New System.Drawing.Size(42, 39)
        Me.StandardControl12.SymbolHandle = CType(1257874638, Long)
        Me.StandardControl12.TabIndex = 111
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(96, 834)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(665, 20)
        Me.TextBox1.TabIndex = 112
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1272, 878)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.StandardControl12)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Command4)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.StandardControl10)
        Me.Controls.Add(Me.StandardControl9)
        Me.Controls.Add(Me.StandardControl8)
        Me.Controls.Add(Me.StandardControl7)
        Me.Controls.Add(Me.CutawayControl5)
        Me.Controls.Add(Me.StandardControl6)
        Me.Controls.Add(Me.CutawayControl4)
        Me.Controls.Add(Me.CutawayControl3)
        Me.Controls.Add(Me.CutawayControl2)
        Me.Controls.Add(Me.StandardControl5)
        Me.Controls.Add(Me.StandardControl4)
        Me.Controls.Add(Me.CutawayControl1)
        Me.Controls.Add(Me.StandardControl3)
        Me.Controls.Add(Me.StandardControl2)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.StandardControl1)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.AxMbaxp1)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.StandardControl11)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox12)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Location = New System.Drawing.Point(4, 24)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Form1"
        CType(Me.AxMbaxp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CutawayControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CutawayControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CutawayControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CutawayControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CutawayControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControl12, System.ComponentModel.ISupportInitialize).EndInit()
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
        'Serial connection
        'AxMbaxp1.Connection() = MBAXPLib.enumConnection.Port3 'COM Port #3 - USB
        'AxMbaxp1.BaudRate() = MBAXPLib.enumBaud.B9600 '9600 Bauds
        'AxMbaxp1.DataBits = 1 '8 Data bits
        'AxMbaxp1.Parity = 2 'Even parity
        'AxMbaxp1.StopBits = 0 '1 Stop bits
        'AxMbaxp1.ProtocolMode = 0 'RTU Mode
        'AxMbaxp1.Timeout = 2000

        'TCP/IP connection
        AxMbaxp1.Connection() = MBAXPLib.enumConnection.TCP_IP
        AxMbaxp1.IPAddr1() = 192
        AxMbaxp1.IPAddr2() = 168
        AxMbaxp1.IPAddr3() = 2
        AxMbaxp1.IPAddr4() = 18
        AxMbaxp1.ConnectTimeout() = 3000  'ms



        e = AxMbaxp1.OpenConnection()
        e = AxMbaxp1.ReadHoldingRegisters(1, 1, 0, 20, 700) ' handle 1, slave 1, adresse 40001, quantite 20, rafraichissement 700mS
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
        Sound.SoundLocation = "C:\Program Files\Modbus Tools\MBAXP\Examples\VBNET\sound3.wav"

    End Sub
    'Ecrire une valeur dans le registre 40001
    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click ' Handle 0, slave 1, addr 40001, 1000mS
        AxMbaxp1.UpdateOnce(0)

        'Execute la tache avec handle 0
        e = AxMbaxp1.PresetSingleRegister(0, 1, 1, 1000) 'handle 0, slave 1, 40001, 1000mS
        'Utilise handle 0 pour la premiere priorite
        'Le taux de rafraichissement ne veut rien dire si on utilise handle 0

        AxMbaxp1.set_Register(0, 0, Text1.Text) 'Text1 = valeur entree dans la case
        'Ecrit la valeur 0 dans le tableau 0 index 0

        AxMbaxp1.UpdateOnce(0)
        'Execute la tache une fois
        'Ce n'est pas possible d utiliser UpdateEnable non-ou UpdateDisable quand handle 0 est utilise
    End Sub
    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        AxMbaxp1.CloseConnection()
    End Sub
    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
        AxMbaxp1.UpdateOnce(0) 'Bouton de rearmement
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

    End Sub
    'Cependant la tâche est terminé, l'évenement ResultOK est renvoyé
    Private Sub AxMbaxp1_ResultOk(ByVal sender As System.Object, ByVal e As AxMBAXPLib._DMbaxpEvents_ResultOkEvent) Handles AxMbaxp1.ResultOk
        If e.handle = 1 Then
            Label1.Text = CStr(AxMbaxp1.get_Register(1, 0)) 'Affiche la valeur Pompe d'amenee#1
            Label2.Text = CStr(AxMbaxp1.get_Register(1, 1)) 'Affiche la valeur Pompe d'amenee#2
            Label3.Text = CStr(AxMbaxp1.get_Register(1, 2)) 'Affiche la valeur Pompe d'amenee#3
            Label4.Text = CStr(AxMbaxp1.get_Register(1, 3)) 'Affiche la valeur Osmose#1
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
        If e.handle = 5 Then
            Label14.Visible = CStr(AxMbaxp1.get_Coil(5, 0)) 'Affiche l'etat Marche Vaccum#1-00001
            Label15.Visible = CStr(AxMbaxp1.get_Coil(5, 1)) 'Affiche l'etat Arret Vaccum#1-00002
            Label21.Visible = CStr(AxMbaxp1.get_Coil(5, 2)) 'Affiche la l'etat Marche Vaccum#2-00003
            Label20.Visible = CStr(AxMbaxp1.get_Coil(5, 3)) 'Affiche la l'etat Arret Vaccum#2-00004
            Label24.Visible = CStr(AxMbaxp1.get_Coil(5, 4)) 'Affiche la l'etat Marche Vaccum#3-00005
            Label23.Visible = CStr(AxMbaxp1.get_Coil(5, 5)) 'Affiche la l'etat Arret Vaccum#3-00006
            Label31.Visible = CStr(AxMbaxp1.get_Coil(5, 6)) 'Affiche la l'etat Marche Pompe Poussee#1-00007
            Label30.Visible = CStr(AxMbaxp1.get_Coil(5, 7)) 'Affiche la l'etat Arret Pompe Poussee#1-00008
            StandardControl10.Visible = CStr(AxMbaxp1.get_Coil(5, 8)) 'Affiche l'etat VERT l'heure de marche Osmose#1-00009
            StandardControl9.Visible = CStr(AxMbaxp1.get_Coil(5, 9)) 'Affiche l'etat JAUNE l'heure de marche Osmose#1-00010
            StandardControl8.Visible = CStr(AxMbaxp1.get_Coil(5, 10)) 'Affiche l'etat ROUGE l'heure de marche Osmose#1-00011
            Label17.Visible = CStr(AxMbaxp1.get_Coil(5, 22)) 'Affiche l'etat FAUTE Pompe Amenee#1-00023
            Label18.Visible = CStr(AxMbaxp1.get_Coil(5, 23)) 'Affiche l'etat FAUTE Pompe Amenee#2-00024
            Label19.Visible = CStr(AxMbaxp1.get_Coil(5, 24)) 'Affiche l'etat FAUTE Pompe Amenee#3-00025
            If AxMbaxp1.get_Coil(7, 0) = 1 Then 'Genere un son de l'alarme generale-00050
                Sound.Play()
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
        If e.handle = 2 Then
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