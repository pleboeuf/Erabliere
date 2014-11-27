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
    Public WithEvents Txt_ecrit_reg As System.Windows.Forms.TextBox
    Public WithEvents Mbaxp1 As AxMBAXPLib.AxMbaxp
    Public WithEvents Cmd_connect_shefford As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Lbl_rev_VB As System.Windows.Forms.Label
    Public WithEvents Cmd_disconnect_Shefford As System.Windows.Forms.Button
    Public WithEvents Cmd_rearm_alm As System.Windows.Forms.Button
    Friend WithEvents Std_ctrl_lamp_alm As SymbolFactoryDotNet.StandardControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_arr_vacc2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_mar_vacc1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_arr_vacc1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_ok_vacc1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_titre As System.Windows.Forms.Label
    Public WithEvents Lbl_deb_pump1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_ok_vacc2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_perte_vacc2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_faute_pump1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_perte_vacc1 As System.Windows.Forms.Label
    Public WithEvents Lbl_deb_pump2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_txt_deb_pump2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_faute_pump2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_mar_vacc2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents PLC_Shefford As AxMBAXPLib.AxMbaxp
    Friend WithEvents PLC_Laporte As AxMBAXPLib.AxMbaxp
    Friend WithEvents GrpBox_Pump1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Txt_deb_pump1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Text_Inst1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_text_inst2 As System.Windows.Forms.Label
    Friend WithEvents LblDureMarchePompeAmeneP1 As System.Windows.Forms.Label
    Friend WithEvents GrpBox_Pump2 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_txt_sec1 As System.Windows.Forms.Label
    Friend WithEvents LblDureMarchePompeAmeneP2 As System.Windows.Forms.Label
    Friend WithEvents GrpBox_Vacc2 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_txt_temps_mar_v2 As System.Windows.Forms.Label
    Friend WithEvents GrpBox_Vacc1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_txt_temps_mar_v1 As System.Windows.Forms.Label
    Friend WithEvents GrpBox_Osm1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_txt_temps_mar_o1 As System.Windows.Forms.Label
    Friend WithEvents Std_Ctrl_pump2 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents Std_Ctrl_pump1 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents TxtCheminDuFichier As System.Windows.Forms.TextBox
    Friend WithEvents TxtMessages As System.Windows.Forms.TextBox
    Friend WithEvents LbLNomduFichier As System.Windows.Forms.Label
    Public WithEvents LblHeureMarcheOsm1 As System.Windows.Forms.Label
    Public WithEvents LblHeureMarcheVac2 As System.Windows.Forms.Label
    Public WithEvents LblHeureMarcheVac1 As System.Windows.Forms.Label
    Friend WithEvents StandardControlVac2 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents StandardControlVac1 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents PanelPump1 As System.Windows.Forms.Panel
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents PanelPump2 As System.Windows.Forms.Panel
    Friend WithEvents PanelVacc2 As System.Windows.Forms.Panel
    Friend WithEvents PanelVacc1 As System.Windows.Forms.Panel
    Friend WithEvents TimeoutCoule As System.Windows.Forms.Timer
    Friend WithEvents GrpBox_Pump3 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_faute_pump3 As System.Windows.Forms.Label
    Friend WithEvents PanelPump3 As System.Windows.Forms.Panel
    Friend WithEvents LblDureMarchePompeAmeneP3 As System.Windows.Forms.Label
    Friend WithEvents Std_Ctrl_pump3 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Lbl_deb_pump3 As System.Windows.Forms.Label
    Friend WithEvents GrpBox_Vacc3 As System.Windows.Forms.GroupBox
    Public WithEvents LblHeureMarcheVac3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_arr_vacc3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_mar_vacc3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_txt_temps_mar_v3 As System.Windows.Forms.Label
    Friend WithEvents StandardControlVac3 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents PanelVacc3 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_perte_vacc3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_ok_vacc3 As System.Windows.Forms.Label
    Public WithEvents Lbl_deb_total As System.Windows.Forms.Label
    Friend WithEvents PanelOSM As System.Windows.Forms.Panel
    Friend WithEvents Lbl_Osm1_On_Off As System.Windows.Forms.Label
    Friend WithEvents Pict_Osmose1 As System.Windows.Forms.PictureBox
    Friend WithEvents Std_ctrl_osm1 As SymbolFactoryDotNet.StandardControl
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents LblTemperature As System.Windows.Forms.Label
    Friend WithEvents PLC_Laporte2 As AxMBAXPLib.AxMbaxp
    Friend WithEvents GrpConnectShefford As System.Windows.Forms.GroupBox
    Friend WithEvents GrpConnectLaporte As System.Windows.Forms.GroupBox
    Public WithEvents Cmd_disconnect_Laporte As System.Windows.Forms.Button
    Public WithEvents Cmd_connect_Laporte As System.Windows.Forms.Button
    Friend WithEvents LaporteTimerWatchDog As System.Windows.Forms.Timer
    Friend WithEvents Panel_Osm1_On_Off As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents WebBrowserCamRelacheur As System.Windows.Forms.WebBrowser
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents WebBrowserCamReservoir As System.Windows.Forms.WebBrowser
    Friend WithEvents Lbl_Coulee_en_cour As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Temperature As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBox_mess_alm As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PropertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents SheffordTimerWatchDog As System.Windows.Forms.Timer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GrpBox_Osm1 = New System.Windows.Forms.GroupBox()
        Me.LblHeureMarcheOsm1 = New System.Windows.Forms.Label()
        Me.Lbl_txt_temps_mar_o1 = New System.Windows.Forms.Label()
        Me.PanelOSM = New System.Windows.Forms.Panel()
        Me.Panel_Osm1_On_Off = New System.Windows.Forms.Panel()
        Me.Lbl_Osm1_On_Off = New System.Windows.Forms.Label()
        Me.Pict_Osmose1 = New System.Windows.Forms.PictureBox()
        Me.Std_ctrl_osm1 = New SymbolFactoryDotNet.StandardControl()
        Me.GrpBox_Pump2 = New System.Windows.Forms.GroupBox()
        Me.Lbl_faute_pump2 = New System.Windows.Forms.Label()
        Me.PanelPump2 = New System.Windows.Forms.Panel()
        Me.LblDureMarchePompeAmeneP2 = New System.Windows.Forms.Label()
        Me.Std_Ctrl_pump2 = New SymbolFactoryDotNet.StandardControl()
        Me.Lbl_txt_deb_pump2 = New System.Windows.Forms.Label()
        Me.Lbl_text_inst2 = New System.Windows.Forms.Label()
        Me.Lbl_deb_pump2 = New System.Windows.Forms.Label()
        Me.GrpBox_Pump1 = New System.Windows.Forms.GroupBox()
        Me.PanelPump1 = New System.Windows.Forms.Panel()
        Me.Std_Ctrl_pump1 = New SymbolFactoryDotNet.StandardControl()
        Me.Lbl_faute_pump1 = New System.Windows.Forms.Label()
        Me.Lbl_txt_sec1 = New System.Windows.Forms.Label()
        Me.LblDureMarchePompeAmeneP1 = New System.Windows.Forms.Label()
        Me.Lbl_Txt_deb_pump1 = New System.Windows.Forms.Label()
        Me.Lbl_deb_pump1 = New System.Windows.Forms.Label()
        Me.Lbl_Text_Inst1 = New System.Windows.Forms.Label()
        Me.StandardControlVac1 = New SymbolFactoryDotNet.StandardControl()
        Me.StandardControlVac2 = New SymbolFactoryDotNet.StandardControl()
        Me.GrpBox_Pump3 = New System.Windows.Forms.GroupBox()
        Me.Lbl_faute_pump3 = New System.Windows.Forms.Label()
        Me.PanelPump3 = New System.Windows.Forms.Panel()
        Me.LblDureMarchePompeAmeneP3 = New System.Windows.Forms.Label()
        Me.Std_Ctrl_pump3 = New SymbolFactoryDotNet.StandardControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_deb_pump3 = New System.Windows.Forms.Label()
        Me.StandardControlVac3 = New SymbolFactoryDotNet.StandardControl()
        Me.Txt_ecrit_reg = New System.Windows.Forms.TextBox()
        Me.Cmd_connect_shefford = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Lbl_rev_VB = New System.Windows.Forms.Label()
        Me.Cmd_disconnect_Shefford = New System.Windows.Forms.Button()
        Me.Cmd_rearm_alm = New System.Windows.Forms.Button()
        Me.Std_ctrl_lamp_alm = New SymbolFactoryDotNet.StandardControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GrpConnectShefford = New System.Windows.Forms.GroupBox()
        Me.GrpConnectLaporte = New System.Windows.Forms.GroupBox()
        Me.Cmd_disconnect_Laporte = New System.Windows.Forms.Button()
        Me.Cmd_connect_Laporte = New System.Windows.Forms.Button()
        Me.PLC_Laporte2 = New AxMBAXPLib.AxMbaxp()
        Me.PLC_Shefford = New AxMBAXPLib.AxMbaxp()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.WebBrowserCamReservoir = New System.Windows.Forms.WebBrowser()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxtBox_mess_alm = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WebBrowserCamRelacheur = New System.Windows.Forms.WebBrowser()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lbl_deb_total = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_Coulee_en_cour = New System.Windows.Forms.Label()
        Me.GrpBox_Vacc3 = New System.Windows.Forms.GroupBox()
        Me.Lbl_arr_vacc3 = New System.Windows.Forms.Label()
        Me.Lbl_mar_vacc3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PanelVacc3 = New System.Windows.Forms.Panel()
        Me.LblHeureMarcheVac3 = New System.Windows.Forms.Label()
        Me.Lbl_perte_vacc3 = New System.Windows.Forms.Label()
        Me.Lbl_ok_vacc3 = New System.Windows.Forms.Label()
        Me.Lbl_txt_temps_mar_v3 = New System.Windows.Forms.Label()
        Me.GrpBox_Vacc2 = New System.Windows.Forms.GroupBox()
        Me.Lbl_arr_vacc2 = New System.Windows.Forms.Label()
        Me.Lbl_mar_vacc2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Lbl_txt_temps_mar_v2 = New System.Windows.Forms.Label()
        Me.PanelVacc2 = New System.Windows.Forms.Panel()
        Me.LblHeureMarcheVac2 = New System.Windows.Forms.Label()
        Me.Lbl_perte_vacc2 = New System.Windows.Forms.Label()
        Me.Lbl_ok_vacc2 = New System.Windows.Forms.Label()
        Me.GrpBox_Vacc1 = New System.Windows.Forms.GroupBox()
        Me.Lbl_mar_vacc1 = New System.Windows.Forms.Label()
        Me.Lbl_arr_vacc1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelVacc1 = New System.Windows.Forms.Panel()
        Me.Lbl_perte_vacc1 = New System.Windows.Forms.Label()
        Me.LblHeureMarcheVac1 = New System.Windows.Forms.Label()
        Me.Lbl_ok_vacc1 = New System.Windows.Forms.Label()
        Me.Lbl_txt_temps_mar_v1 = New System.Windows.Forms.Label()
        Me.Lbl_titre = New System.Windows.Forms.Label()
        Me.Temperature = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.LblTemperature = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtCheminDuFichier = New System.Windows.Forms.TextBox()
        Me.TxtMessages = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbLNomduFichier = New System.Windows.Forms.Label()
        Me.PLC_Laporte = New AxMBAXPLib.AxMbaxp()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.SheffordTimerWatchDog = New System.Windows.Forms.Timer(Me.components)
        Me.TimeoutCoule = New System.Windows.Forms.Timer(Me.components)
        Me.LaporteTimerWatchDog = New System.Windows.Forms.Timer(Me.components)
        Me.GrpBox_Osm1.SuspendLayout()
        Me.PanelOSM.SuspendLayout()
        Me.Panel_Osm1_On_Off.SuspendLayout()
        CType(Me.Pict_Osmose1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Std_ctrl_osm1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBox_Pump2.SuspendLayout()
        Me.PanelPump2.SuspendLayout()
        CType(Me.Std_Ctrl_pump2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBox_Pump1.SuspendLayout()
        Me.PanelPump1.SuspendLayout()
        CType(Me.Std_Ctrl_pump1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControlVac1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControlVac2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBox_Pump3.SuspendLayout()
        Me.PanelPump3.SuspendLayout()
        CType(Me.Std_Ctrl_pump3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardControlVac3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Std_ctrl_lamp_alm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GrpConnectShefford.SuspendLayout()
        Me.GrpConnectLaporte.SuspendLayout()
        CType(Me.PLC_Laporte2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLC_Shefford, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GrpBox_Vacc3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelVacc3.SuspendLayout()
        Me.GrpBox_Vacc2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelVacc2.SuspendLayout()
        Me.GrpBox_Vacc1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelVacc1.SuspendLayout()
        Me.Temperature.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PLC_Laporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpBox_Osm1
        '
        Me.GrpBox_Osm1.Controls.Add(Me.LblHeureMarcheOsm1)
        Me.GrpBox_Osm1.Controls.Add(Me.Lbl_txt_temps_mar_o1)
        Me.GrpBox_Osm1.Controls.Add(Me.PanelOSM)
        Me.GrpBox_Osm1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBox_Osm1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GrpBox_Osm1.Location = New System.Drawing.Point(790, 587)
        Me.GrpBox_Osm1.Name = "GrpBox_Osm1"
        Me.GrpBox_Osm1.Size = New System.Drawing.Size(449, 247)
        Me.GrpBox_Osm1.TabIndex = 155
        Me.GrpBox_Osm1.TabStop = False
        Me.GrpBox_Osm1.Text = "Osmose #1"
        Me.ToolTip1.SetToolTip(Me.GrpBox_Osm1, resources.GetString("GrpBox_Osm1.ToolTip"))
        '
        'LblHeureMarcheOsm1
        '
        Me.LblHeureMarcheOsm1.BackColor = System.Drawing.Color.LightGreen
        Me.LblHeureMarcheOsm1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblHeureMarcheOsm1.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblHeureMarcheOsm1.Font = New System.Drawing.Font("Arial", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeureMarcheOsm1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblHeureMarcheOsm1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblHeureMarcheOsm1.Location = New System.Drawing.Point(73, 173)
        Me.LblHeureMarcheOsm1.Name = "LblHeureMarcheOsm1"
        Me.LblHeureMarcheOsm1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblHeureMarcheOsm1.Size = New System.Drawing.Size(361, 54)
        Me.LblHeureMarcheOsm1.TabIndex = 182
        Me.LblHeureMarcheOsm1.Text = "00 : 00 : 00"
        Me.LblHeureMarcheOsm1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_txt_temps_mar_o1
        '
        Me.Lbl_txt_temps_mar_o1.AutoSize = True
        Me.Lbl_txt_temps_mar_o1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_txt_temps_mar_o1.ForeColor = System.Drawing.Color.Black
        Me.Lbl_txt_temps_mar_o1.Location = New System.Drawing.Point(206, 150)
        Me.Lbl_txt_temps_mar_o1.Name = "Lbl_txt_temps_mar_o1"
        Me.Lbl_txt_temps_mar_o1.Size = New System.Drawing.Size(177, 22)
        Me.Lbl_txt_temps_mar_o1.TabIndex = 170
        Me.Lbl_txt_temps_mar_o1.Text = "Temps de marche"
        '
        'PanelOSM
        '
        Me.PanelOSM.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelOSM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelOSM.Controls.Add(Me.Panel_Osm1_On_Off)
        Me.PanelOSM.Controls.Add(Me.Pict_Osmose1)
        Me.PanelOSM.Controls.Add(Me.Std_ctrl_osm1)
        Me.PanelOSM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelOSM.Location = New System.Drawing.Point(3, 28)
        Me.PanelOSM.Name = "PanelOSM"
        Me.PanelOSM.Size = New System.Drawing.Size(443, 216)
        Me.PanelOSM.TabIndex = 183
        '
        'Panel_Osm1_On_Off
        '
        Me.Panel_Osm1_On_Off.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Osm1_On_Off.Controls.Add(Me.Lbl_Osm1_On_Off)
        Me.Panel_Osm1_On_Off.Location = New System.Drawing.Point(273, 33)
        Me.Panel_Osm1_On_Off.Name = "Panel_Osm1_On_Off"
        Me.Panel_Osm1_On_Off.Size = New System.Drawing.Size(93, 52)
        Me.Panel_Osm1_On_Off.TabIndex = 166
        '
        'Lbl_Osm1_On_Off
        '
        Me.Lbl_Osm1_On_Off.AutoSize = True
        Me.Lbl_Osm1_On_Off.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Osm1_On_Off.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_Osm1_On_Off.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Osm1_On_Off.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Osm1_On_Off.Location = New System.Drawing.Point(3, 7)
        Me.Lbl_Osm1_On_Off.Name = "Lbl_Osm1_On_Off"
        Me.Lbl_Osm1_On_Off.Size = New System.Drawing.Size(81, 37)
        Me.Lbl_Osm1_On_Off.TabIndex = 164
        Me.Lbl_Osm1_On_Off.Text = "OFF"
        Me.Lbl_Osm1_On_Off.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pict_Osmose1
        '
        Me.Pict_Osmose1.Image = Global.ErabliereBrunelle.My.Resources.Resources.osmose30004000
        Me.Pict_Osmose1.Location = New System.Drawing.Point(21, 7)
        Me.Pict_Osmose1.Name = "Pict_Osmose1"
        Me.Pict_Osmose1.Size = New System.Drawing.Size(172, 124)
        Me.Pict_Osmose1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pict_Osmose1.TabIndex = 130
        Me.Pict_Osmose1.TabStop = False
        '
        'Std_ctrl_osm1
        '
        Me.Std_ctrl_osm1.AnalogIntValue1 = CType(0, Short)
        Me.Std_ctrl_osm1.AnalogValue1 = 0.0R
        Me.Std_ctrl_osm1.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill
        Me.Std_ctrl_osm1.BackColor = System.Drawing.Color.Transparent
        Me.Std_ctrl_osm1.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.Std_ctrl_osm1.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer)), "Band1"))
        Me.Std_ctrl_osm1.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Yellow, "Band2"))
        Me.Std_ctrl_osm1.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkInvisible, System.Drawing.Color.Red, "Band3"))
        Me.Std_ctrl_osm1.BlinkColor = System.Drawing.Color.Red
        Me.Std_ctrl_osm1.Category = "1Btn.cat2"
        Me.Std_ctrl_osm1.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("Std_ctrl_osm1.DebugData"))
        Me.Std_ctrl_osm1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Std_ctrl_osm1.Location = New System.Drawing.Point(21, 148)
        Me.Std_ctrl_osm1.Name = "Std_ctrl_osm1"
        Me.Std_ctrl_osm1.Size = New System.Drawing.Size(42, 39)
        Me.Std_ctrl_osm1.SymbolHandle = CType(1392289550, Long)
        Me.Std_ctrl_osm1.TabIndex = 110
        Me.ToolTip1.SetToolTip(Me.Std_ctrl_osm1, "Témoin indicateur pour indiquer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "combien il reste de temps pour" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "une inversion de" & _
                " cartouches.")
        '
        'GrpBox_Pump2
        '
        Me.GrpBox_Pump2.Controls.Add(Me.Lbl_faute_pump2)
        Me.GrpBox_Pump2.Controls.Add(Me.PanelPump2)
        Me.GrpBox_Pump2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.GrpBox_Pump2.Location = New System.Drawing.Point(8, 320)
        Me.GrpBox_Pump2.Name = "GrpBox_Pump2"
        Me.GrpBox_Pump2.Size = New System.Drawing.Size(425, 247)
        Me.GrpBox_Pump2.TabIndex = 154
        Me.GrpBox_Pump2.TabStop = False
        Me.GrpBox_Pump2.Text = "Pompe #2 - Shefford"
        Me.ToolTip1.SetToolTip(Me.GrpBox_Pump2, "Le calcule est fait sur une base de 30 minutes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Le temps de marche (en seconde) " & _
                "est " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "accumulé durant 30 minutes et converti" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en gallons.")
        '
        'Lbl_faute_pump2
        '
        Me.Lbl_faute_pump2.AutoSize = True
        Me.Lbl_faute_pump2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_faute_pump2.ForeColor = System.Drawing.Color.Red
        Me.Lbl_faute_pump2.Location = New System.Drawing.Point(271, 186)
        Me.Lbl_faute_pump2.Name = "Lbl_faute_pump2"
        Me.Lbl_faute_pump2.Size = New System.Drawing.Size(93, 29)
        Me.Lbl_faute_pump2.TabIndex = 24
        Me.Lbl_faute_pump2.Text = "FAUTE"
        '
        'PanelPump2
        '
        Me.PanelPump2.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelPump2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPump2.Controls.Add(Me.LblDureMarchePompeAmeneP2)
        Me.PanelPump2.Controls.Add(Me.Std_Ctrl_pump2)
        Me.PanelPump2.Controls.Add(Me.Lbl_txt_deb_pump2)
        Me.PanelPump2.Controls.Add(Me.Lbl_text_inst2)
        Me.PanelPump2.Controls.Add(Me.Lbl_deb_pump2)
        Me.PanelPump2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPump2.Location = New System.Drawing.Point(3, 31)
        Me.PanelPump2.Name = "PanelPump2"
        Me.PanelPump2.Size = New System.Drawing.Size(419, 213)
        Me.PanelPump2.TabIndex = 175
        '
        'LblDureMarchePompeAmeneP2
        '
        Me.LblDureMarchePompeAmeneP2.BackColor = System.Drawing.Color.LightGreen
        Me.LblDureMarchePompeAmeneP2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDureMarchePompeAmeneP2.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDureMarchePompeAmeneP2.Location = New System.Drawing.Point(48, 147)
        Me.LblDureMarchePompeAmeneP2.Name = "LblDureMarchePompeAmeneP2"
        Me.LblDureMarchePompeAmeneP2.Size = New System.Drawing.Size(110, 54)
        Me.LblDureMarchePompeAmeneP2.TabIndex = 154
        Me.LblDureMarchePompeAmeneP2.Text = "0"
        Me.LblDureMarchePompeAmeneP2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Std_Ctrl_pump2
        '
        Me.Std_Ctrl_pump2.AnalogIntValue1 = CType(0, Short)
        Me.Std_Ctrl_pump2.AnalogValue1 = 0.0R
        Me.Std_Ctrl_pump2.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill
        Me.Std_Ctrl_pump2.BackColor = System.Drawing.Color.Transparent
        Me.Std_Ctrl_pump2.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.Std_Ctrl_pump2.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band1"))
        Me.Std_Ctrl_pump2.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer)), "Band2"))
        Me.Std_Ctrl_pump2.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkInvisible, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), "Band3"))
        Me.Std_Ctrl_pump2.BlinkColor = System.Drawing.Color.Red
        Me.Std_Ctrl_pump2.Category = "1PMP.cat2"
        Me.Std_Ctrl_pump2.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("Std_Ctrl_pump2.DebugData"))
        Me.Std_Ctrl_pump2.FillColor = System.Drawing.Color.Red
        Me.Std_Ctrl_pump2.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded
        Me.Std_Ctrl_pump2.Location = New System.Drawing.Point(221, 2)
        Me.Std_Ctrl_pump2.Name = "Std_Ctrl_pump2"
        Me.Std_Ctrl_pump2.Size = New System.Drawing.Size(190, 153)
        Me.Std_Ctrl_pump2.SymbolHandle = CType(54563567, Long)
        Me.Std_Ctrl_pump2.TabIndex = 174
        Me.ToolTip1.SetToolTip(Me.Std_Ctrl_pump2, "Témoin indicateur pour indiquer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "combien il reste de temps pour" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "une inversion de" & _
                " cartouches.")
        '
        'Lbl_txt_deb_pump2
        '
        Me.Lbl_txt_deb_pump2.AutoSize = True
        Me.Lbl_txt_deb_pump2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_txt_deb_pump2.Location = New System.Drawing.Point(47, 4)
        Me.Lbl_txt_deb_pump2.Name = "Lbl_txt_deb_pump2"
        Me.Lbl_txt_deb_pump2.Size = New System.Drawing.Size(128, 22)
        Me.Lbl_txt_deb_pump2.TabIndex = 16
        Me.Lbl_txt_deb_pump2.Text = "Débit (gal/hr)"
        '
        'Lbl_text_inst2
        '
        Me.Lbl_text_inst2.AutoSize = True
        Me.Lbl_text_inst2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_text_inst2.Location = New System.Drawing.Point(11, 123)
        Me.Lbl_text_inst2.Name = "Lbl_text_inst2"
        Me.Lbl_text_inst2.Size = New System.Drawing.Size(204, 22)
        Me.Lbl_text_inst2.TabIndex = 151
        Me.Lbl_text_inst2.Text = "Temps marche (sec.)"
        '
        'Lbl_deb_pump2
        '
        Me.Lbl_deb_pump2.BackColor = System.Drawing.Color.LightGreen
        Me.Lbl_deb_pump2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_deb_pump2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lbl_deb_pump2.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_deb_pump2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lbl_deb_pump2.Location = New System.Drawing.Point(15, 29)
        Me.Lbl_deb_pump2.Name = "Lbl_deb_pump2"
        Me.Lbl_deb_pump2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl_deb_pump2.Size = New System.Drawing.Size(194, 78)
        Me.Lbl_deb_pump2.TabIndex = 5
        Me.Lbl_deb_pump2.Text = "0"
        Me.Lbl_deb_pump2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrpBox_Pump1
        '
        Me.GrpBox_Pump1.Controls.Add(Me.PanelPump1)
        Me.GrpBox_Pump1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBox_Pump1.Location = New System.Drawing.Point(8, 53)
        Me.GrpBox_Pump1.Name = "GrpBox_Pump1"
        Me.GrpBox_Pump1.Size = New System.Drawing.Size(425, 247)
        Me.GrpBox_Pump1.TabIndex = 152
        Me.GrpBox_Pump1.TabStop = False
        Me.GrpBox_Pump1.Text = "Pompe #1 - Shefford"
        Me.ToolTip1.SetToolTip(Me.GrpBox_Pump1, "Le calcule est fait sur une base de 30 minutes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Le temps de marche (en seconde) " & _
                "est " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "accumulé durant 30 minutes et converti" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en gallons.")
        '
        'PanelPump1
        '
        Me.PanelPump1.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelPump1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPump1.Controls.Add(Me.Std_Ctrl_pump1)
        Me.PanelPump1.Controls.Add(Me.Lbl_faute_pump1)
        Me.PanelPump1.Controls.Add(Me.Lbl_txt_sec1)
        Me.PanelPump1.Controls.Add(Me.LblDureMarchePompeAmeneP1)
        Me.PanelPump1.Controls.Add(Me.Lbl_Txt_deb_pump1)
        Me.PanelPump1.Controls.Add(Me.Lbl_deb_pump1)
        Me.PanelPump1.Controls.Add(Me.Lbl_Text_Inst1)
        Me.PanelPump1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPump1.Location = New System.Drawing.Point(3, 31)
        Me.PanelPump1.Name = "PanelPump1"
        Me.PanelPump1.Size = New System.Drawing.Size(419, 213)
        Me.PanelPump1.TabIndex = 174
        '
        'Std_Ctrl_pump1
        '
        Me.Std_Ctrl_pump1.AnalogIntValue1 = CType(0, Short)
        Me.Std_Ctrl_pump1.AnalogValue1 = 0.0R
        Me.Std_Ctrl_pump1.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill
        Me.Std_Ctrl_pump1.BackColor = System.Drawing.Color.Transparent
        Me.Std_Ctrl_pump1.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.Std_Ctrl_pump1.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band1"))
        Me.Std_Ctrl_pump1.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer)), "Band2"))
        Me.Std_Ctrl_pump1.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkInvisible, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), "Band3"))
        Me.Std_Ctrl_pump1.BlinkColor = System.Drawing.Color.Red
        Me.Std_Ctrl_pump1.Category = "1PMP.cat2"
        Me.Std_Ctrl_pump1.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("Std_Ctrl_pump1.DebugData"))
        Me.Std_Ctrl_pump1.FillColor = System.Drawing.Color.Red
        Me.Std_Ctrl_pump1.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded
        Me.Std_Ctrl_pump1.Location = New System.Drawing.Point(221, 2)
        Me.Std_Ctrl_pump1.Name = "Std_Ctrl_pump1"
        Me.Std_Ctrl_pump1.Size = New System.Drawing.Size(190, 153)
        Me.Std_Ctrl_pump1.SymbolHandle = CType(54563567, Long)
        Me.Std_Ctrl_pump1.TabIndex = 173
        Me.ToolTip1.SetToolTip(Me.Std_Ctrl_pump1, "Témoin indicateur pour indiquer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "combien il reste de temps pour" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "une inversion de" & _
                " cartouches.")
        '
        'Lbl_faute_pump1
        '
        Me.Lbl_faute_pump1.AutoSize = True
        Me.Lbl_faute_pump1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_faute_pump1.ForeColor = System.Drawing.Color.Red
        Me.Lbl_faute_pump1.Location = New System.Drawing.Point(267, 155)
        Me.Lbl_faute_pump1.Name = "Lbl_faute_pump1"
        Me.Lbl_faute_pump1.Size = New System.Drawing.Size(93, 29)
        Me.Lbl_faute_pump1.TabIndex = 23
        Me.Lbl_faute_pump1.Text = "FAUTE"
        '
        'Lbl_txt_sec1
        '
        Me.Lbl_txt_sec1.AutoSize = True
        Me.Lbl_txt_sec1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_txt_sec1.Location = New System.Drawing.Point(98, 180)
        Me.Lbl_txt_sec1.Name = "Lbl_txt_sec1"
        Me.Lbl_txt_sec1.Size = New System.Drawing.Size(0, 19)
        Me.Lbl_txt_sec1.TabIndex = 153
        '
        'LblDureMarchePompeAmeneP1
        '
        Me.LblDureMarchePompeAmeneP1.BackColor = System.Drawing.Color.LightGreen
        Me.LblDureMarchePompeAmeneP1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDureMarchePompeAmeneP1.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDureMarchePompeAmeneP1.Location = New System.Drawing.Point(51, 144)
        Me.LblDureMarchePompeAmeneP1.Name = "LblDureMarchePompeAmeneP1"
        Me.LblDureMarchePompeAmeneP1.Size = New System.Drawing.Size(110, 54)
        Me.LblDureMarchePompeAmeneP1.TabIndex = 152
        Me.LblDureMarchePompeAmeneP1.Text = "0"
        Me.LblDureMarchePompeAmeneP1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Txt_deb_pump1
        '
        Me.Lbl_Txt_deb_pump1.AutoSize = True
        Me.Lbl_Txt_deb_pump1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Txt_deb_pump1.Location = New System.Drawing.Point(47, 4)
        Me.Lbl_Txt_deb_pump1.Name = "Lbl_Txt_deb_pump1"
        Me.Lbl_Txt_deb_pump1.Size = New System.Drawing.Size(128, 22)
        Me.Lbl_Txt_deb_pump1.TabIndex = 151
        Me.Lbl_Txt_deb_pump1.Text = "Débit (gal/hr)"
        '
        'Lbl_deb_pump1
        '
        Me.Lbl_deb_pump1.BackColor = System.Drawing.Color.LightGreen
        Me.Lbl_deb_pump1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_deb_pump1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lbl_deb_pump1.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_deb_pump1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lbl_deb_pump1.Location = New System.Drawing.Point(15, 29)
        Me.Lbl_deb_pump1.Name = "Lbl_deb_pump1"
        Me.Lbl_deb_pump1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl_deb_pump1.Size = New System.Drawing.Size(194, 78)
        Me.Lbl_deb_pump1.TabIndex = 2
        Me.Lbl_deb_pump1.Text = "0"
        Me.Lbl_deb_pump1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Text_Inst1
        '
        Me.Lbl_Text_Inst1.AutoSize = True
        Me.Lbl_Text_Inst1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Text_Inst1.Location = New System.Drawing.Point(11, 120)
        Me.Lbl_Text_Inst1.Name = "Lbl_Text_Inst1"
        Me.Lbl_Text_Inst1.Size = New System.Drawing.Size(204, 22)
        Me.Lbl_Text_Inst1.TabIndex = 150
        Me.Lbl_Text_Inst1.Text = "Temps marche (sec.)"
        '
        'StandardControlVac1
        '
        Me.StandardControlVac1.AnalogIntValue1 = CType(0, Short)
        Me.StandardControlVac1.AnalogValue1 = 0.0R
        Me.StandardControlVac1.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill
        Me.StandardControlVac1.BackColor = System.Drawing.Color.Transparent
        Me.StandardControlVac1.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Opaque
        Me.StandardControlVac1.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"))
        Me.StandardControlVac1.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Green, "Band2"))
        Me.StandardControlVac1.BlinkColor = System.Drawing.Color.Red
        Me.StandardControlVac1.Category = "1PMP.cat2"
        Me.StandardControlVac1.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControlVac1.DebugData"))
        Me.StandardControlVac1.FillColor = System.Drawing.Color.Red
        Me.StandardControlVac1.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded
        Me.StandardControlVac1.Location = New System.Drawing.Point(202, 39)
        Me.StandardControlVac1.Name = "StandardControlVac1"
        Me.StandardControlVac1.Size = New System.Drawing.Size(116, 132)
        Me.StandardControlVac1.SymbolHandle = CType(1067057500, Long)
        Me.StandardControlVac1.TabIndex = 181
        Me.ToolTip1.SetToolTip(Me.StandardControlVac1, "Témoin indicateur pour indiquer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "combien il reste de temps pour" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "une inversion de" & _
                " cartouches.")
        '
        'StandardControlVac2
        '
        Me.StandardControlVac2.AnalogIntValue1 = CType(0, Short)
        Me.StandardControlVac2.AnalogValue1 = 0.0R
        Me.StandardControlVac2.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill
        Me.StandardControlVac2.BackColor = System.Drawing.Color.Transparent
        Me.StandardControlVac2.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Opaque
        Me.StandardControlVac2.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"))
        Me.StandardControlVac2.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Green, "Band2"))
        Me.StandardControlVac2.BlinkColor = System.Drawing.Color.Red
        Me.StandardControlVac2.Category = "1PMP.cat2"
        Me.StandardControlVac2.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControlVac2.DebugData"))
        Me.StandardControlVac2.FillColor = System.Drawing.Color.Red
        Me.StandardControlVac2.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded
        Me.StandardControlVac2.Location = New System.Drawing.Point(202, 39)
        Me.StandardControlVac2.Name = "StandardControlVac2"
        Me.StandardControlVac2.Size = New System.Drawing.Size(116, 132)
        Me.StandardControlVac2.SymbolHandle = CType(1067057500, Long)
        Me.StandardControlVac2.TabIndex = 182
        Me.ToolTip1.SetToolTip(Me.StandardControlVac2, "Témoin indicateur pour indiquer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "combien il reste de temps pour" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "une inversion de" & _
                " cartouches.")
        '
        'GrpBox_Pump3
        '
        Me.GrpBox_Pump3.Controls.Add(Me.Lbl_faute_pump3)
        Me.GrpBox_Pump3.Controls.Add(Me.PanelPump3)
        Me.GrpBox_Pump3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.GrpBox_Pump3.Location = New System.Drawing.Point(8, 587)
        Me.GrpBox_Pump3.Name = "GrpBox_Pump3"
        Me.GrpBox_Pump3.Size = New System.Drawing.Size(425, 247)
        Me.GrpBox_Pump3.TabIndex = 180
        Me.GrpBox_Pump3.TabStop = False
        Me.GrpBox_Pump3.Text = "Pompe #3 - P. Laporte"
        Me.ToolTip1.SetToolTip(Me.GrpBox_Pump3, "Le calcule est fait sur une base de 30 minutes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Le temps de marche (en seconde) " & _
                "est " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "accumulé durant 30 minutes et converti" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en gallons.")
        '
        'Lbl_faute_pump3
        '
        Me.Lbl_faute_pump3.AutoSize = True
        Me.Lbl_faute_pump3.BackColor = System.Drawing.Color.Silver
        Me.Lbl_faute_pump3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_faute_pump3.ForeColor = System.Drawing.Color.Red
        Me.Lbl_faute_pump3.Location = New System.Drawing.Point(271, 186)
        Me.Lbl_faute_pump3.Name = "Lbl_faute_pump3"
        Me.Lbl_faute_pump3.Size = New System.Drawing.Size(93, 29)
        Me.Lbl_faute_pump3.TabIndex = 24
        Me.Lbl_faute_pump3.Text = "FAUTE"
        '
        'PanelPump3
        '
        Me.PanelPump3.BackColor = System.Drawing.Color.Silver
        Me.PanelPump3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPump3.Controls.Add(Me.LblDureMarchePompeAmeneP3)
        Me.PanelPump3.Controls.Add(Me.Std_Ctrl_pump3)
        Me.PanelPump3.Controls.Add(Me.Label3)
        Me.PanelPump3.Controls.Add(Me.Label4)
        Me.PanelPump3.Controls.Add(Me.Lbl_deb_pump3)
        Me.PanelPump3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPump3.Location = New System.Drawing.Point(3, 31)
        Me.PanelPump3.Name = "PanelPump3"
        Me.PanelPump3.Size = New System.Drawing.Size(419, 213)
        Me.PanelPump3.TabIndex = 175
        '
        'LblDureMarchePompeAmeneP3
        '
        Me.LblDureMarchePompeAmeneP3.BackColor = System.Drawing.Color.LightGreen
        Me.LblDureMarchePompeAmeneP3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDureMarchePompeAmeneP3.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDureMarchePompeAmeneP3.Location = New System.Drawing.Point(48, 147)
        Me.LblDureMarchePompeAmeneP3.Name = "LblDureMarchePompeAmeneP3"
        Me.LblDureMarchePompeAmeneP3.Size = New System.Drawing.Size(110, 54)
        Me.LblDureMarchePompeAmeneP3.TabIndex = 154
        Me.LblDureMarchePompeAmeneP3.Text = "0"
        Me.LblDureMarchePompeAmeneP3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Std_Ctrl_pump3
        '
        Me.Std_Ctrl_pump3.AnalogIntValue1 = CType(0, Short)
        Me.Std_Ctrl_pump3.AnalogValue1 = 0.0R
        Me.Std_Ctrl_pump3.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill
        Me.Std_Ctrl_pump3.BackColor = System.Drawing.Color.Transparent
        Me.Std_Ctrl_pump3.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.Std_Ctrl_pump3.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band1"))
        Me.Std_Ctrl_pump3.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer)), "Band2"))
        Me.Std_Ctrl_pump3.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkInvisible, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), "Band3"))
        Me.Std_Ctrl_pump3.BlinkColor = System.Drawing.Color.Red
        Me.Std_Ctrl_pump3.Category = "1PMP.cat2"
        Me.Std_Ctrl_pump3.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("Std_Ctrl_pump3.DebugData"))
        Me.Std_Ctrl_pump3.FillColor = System.Drawing.Color.Red
        Me.Std_Ctrl_pump3.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded
        Me.Std_Ctrl_pump3.Location = New System.Drawing.Point(221, 2)
        Me.Std_Ctrl_pump3.Name = "Std_Ctrl_pump3"
        Me.Std_Ctrl_pump3.Size = New System.Drawing.Size(190, 153)
        Me.Std_Ctrl_pump3.SymbolHandle = CType(54563567, Long)
        Me.Std_Ctrl_pump3.TabIndex = 174
        Me.ToolTip1.SetToolTip(Me.Std_Ctrl_pump3, "Témoin indicateur pour indiquer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "combien il reste de temps pour" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "une inversion de" & _
                " cartouches.")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 22)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Débit (gal/hr)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 22)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "Temps marche (sec.)"
        '
        'Lbl_deb_pump3
        '
        Me.Lbl_deb_pump3.BackColor = System.Drawing.Color.LightGreen
        Me.Lbl_deb_pump3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_deb_pump3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lbl_deb_pump3.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_deb_pump3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lbl_deb_pump3.Location = New System.Drawing.Point(15, 29)
        Me.Lbl_deb_pump3.Name = "Lbl_deb_pump3"
        Me.Lbl_deb_pump3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl_deb_pump3.Size = New System.Drawing.Size(194, 78)
        Me.Lbl_deb_pump3.TabIndex = 5
        Me.Lbl_deb_pump3.Text = "0"
        Me.Lbl_deb_pump3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StandardControlVac3
        '
        Me.StandardControlVac3.AnalogIntValue1 = CType(0, Short)
        Me.StandardControlVac3.AnalogValue1 = 0.0R
        Me.StandardControlVac3.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill
        Me.StandardControlVac3.BackColor = System.Drawing.Color.Silver
        Me.StandardControlVac3.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Opaque
        Me.StandardControlVac3.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"))
        Me.StandardControlVac3.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Green, "Band2"))
        Me.StandardControlVac3.BlinkColor = System.Drawing.Color.Red
        Me.StandardControlVac3.Category = "1PMP.cat2"
        Me.StandardControlVac3.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("StandardControlVac3.DebugData"))
        Me.StandardControlVac3.FillColor = System.Drawing.Color.Red
        Me.StandardControlVac3.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded
        Me.StandardControlVac3.Location = New System.Drawing.Point(202, 39)
        Me.StandardControlVac3.Name = "StandardControlVac3"
        Me.StandardControlVac3.Size = New System.Drawing.Size(116, 132)
        Me.StandardControlVac3.SymbolHandle = CType(1067057500, Long)
        Me.StandardControlVac3.TabIndex = 182
        Me.ToolTip1.SetToolTip(Me.StandardControlVac3, "Témoin indicateur pour indiquer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "combien il reste de temps pour" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "une inversion de" & _
                " cartouches.")
        '
        'Txt_ecrit_reg
        '
        Me.Txt_ecrit_reg.AcceptsReturn = True
        Me.Txt_ecrit_reg.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_ecrit_reg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ecrit_reg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ecrit_reg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_ecrit_reg.Location = New System.Drawing.Point(1502, 955)
        Me.Txt_ecrit_reg.MaxLength = 0
        Me.Txt_ecrit_reg.Name = "Txt_ecrit_reg"
        Me.Txt_ecrit_reg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_ecrit_reg.Size = New System.Drawing.Size(113, 20)
        Me.Txt_ecrit_reg.TabIndex = 4
        Me.Txt_ecrit_reg.Text = "199"
        Me.Txt_ecrit_reg.Visible = False
        '
        'Cmd_connect_shefford
        '
        Me.Cmd_connect_shefford.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd_connect_shefford.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_connect_shefford.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_connect_shefford.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_connect_shefford.Location = New System.Drawing.Point(7, 31)
        Me.Cmd_connect_shefford.Name = "Cmd_connect_shefford"
        Me.Cmd_connect_shefford.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_connect_shefford.Size = New System.Drawing.Size(96, 33)
        Me.Cmd_connect_shefford.TabIndex = 1
        Me.Cmd_connect_shefford.Text = "Connection"
        Me.Cmd_connect_shefford.UseVisualStyleBackColor = False
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
        'Lbl_rev_VB
        '
        Me.Lbl_rev_VB.AutoSize = True
        Me.Lbl_rev_VB.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_rev_VB.Location = New System.Drawing.Point(1502, 921)
        Me.Lbl_rev_VB.Name = "Lbl_rev_VB"
        Me.Lbl_rev_VB.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl_rev_VB.Size = New System.Drawing.Size(109, 26)
        Me.Lbl_rev_VB.TabIndex = 76
        Me.Lbl_rev_VB.Text = "Visual Basic.net 2010" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "fev. 2012"
        '
        'Cmd_disconnect_Shefford
        '
        Me.Cmd_disconnect_Shefford.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd_disconnect_Shefford.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_disconnect_Shefford.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_disconnect_Shefford.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_disconnect_Shefford.Location = New System.Drawing.Point(126, 31)
        Me.Cmd_disconnect_Shefford.Name = "Cmd_disconnect_Shefford"
        Me.Cmd_disconnect_Shefford.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_disconnect_Shefford.Size = New System.Drawing.Size(96, 33)
        Me.Cmd_disconnect_Shefford.TabIndex = 77
        Me.Cmd_disconnect_Shefford.Text = "Déconnection"
        Me.Cmd_disconnect_Shefford.UseVisualStyleBackColor = False
        '
        'Cmd_rearm_alm
        '
        Me.Cmd_rearm_alm.BackColor = System.Drawing.Color.Blue
        Me.Cmd_rearm_alm.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_rearm_alm.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_rearm_alm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cmd_rearm_alm.Location = New System.Drawing.Point(384, 67)
        Me.Cmd_rearm_alm.Name = "Cmd_rearm_alm"
        Me.Cmd_rearm_alm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_rearm_alm.Size = New System.Drawing.Size(119, 59)
        Me.Cmd_rearm_alm.TabIndex = 109
        Me.Cmd_rearm_alm.Text = "REARMEMENT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ALARME"
        Me.Cmd_rearm_alm.UseVisualStyleBackColor = False
        '
        'Std_ctrl_lamp_alm
        '
        Me.Std_ctrl_lamp_alm.AnalogIntValue1 = CType(0, Short)
        Me.Std_ctrl_lamp_alm.AnalogValue1 = 0.0R
        Me.Std_ctrl_lamp_alm.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill
        Me.Std_ctrl_lamp_alm.BackColor = System.Drawing.Color.Transparent
        Me.Std_ctrl_lamp_alm.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent
        Me.Std_ctrl_lamp_alm.BandsCollection.Add(New SymbolFactoryNetEngine.Band(0.0R, 0, False, SymbolFactoryNetEngine.BandStyleOptions.BlinkInvisible, System.Drawing.Color.Red, "Band1"))
        Me.Std_ctrl_lamp_alm.BlinkColor = System.Drawing.Color.Red
        Me.Std_ctrl_lamp_alm.Category = "1Btn.cat2"
        Me.Std_ctrl_lamp_alm.DebugData = New SymbolFactoryDotNet.DebugClass(resources.GetString("Std_ctrl_lamp_alm.DebugData"))
        Me.Std_ctrl_lamp_alm.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Std_ctrl_lamp_alm.Location = New System.Drawing.Point(422, 22)
        Me.Std_ctrl_lamp_alm.Name = "Std_ctrl_lamp_alm"
        Me.Std_ctrl_lamp_alm.Size = New System.Drawing.Size(42, 39)
        Me.Std_ctrl_lamp_alm.SymbolHandle = CType(1257874638, Long)
        Me.Std_ctrl_lamp_alm.TabIndex = 111
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.Controls.Add(Me.Lbl_rev_VB)
        Me.TabPage1.Controls.Add(Me.Txt_ecrit_reg)
        Me.TabPage1.Controls.Add(Me.GrpConnectShefford)
        Me.TabPage1.Controls.Add(Me.GrpConnectLaporte)
        Me.TabPage1.Controls.Add(Me.PLC_Laporte2)
        Me.TabPage1.Controls.Add(Me.PLC_Shefford)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.Lbl_Coulee_en_cour)
        Me.TabPage1.Controls.Add(Me.GrpBox_Vacc3)
        Me.TabPage1.Controls.Add(Me.GrpBox_Pump3)
        Me.TabPage1.Controls.Add(Me.GrpBox_Osm1)
        Me.TabPage1.Controls.Add(Me.GrpBox_Vacc2)
        Me.TabPage1.Controls.Add(Me.GrpBox_Vacc1)
        Me.TabPage1.Controls.Add(Me.GrpBox_Pump2)
        Me.TabPage1.Controls.Add(Me.GrpBox_Pump1)
        Me.TabPage1.Controls.Add(Me.Lbl_titre)
        Me.TabPage1.Controls.Add(Me.Temperature)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1899, 982)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Rue Shefford"
        '
        'GrpConnectShefford
        '
        Me.GrpConnectShefford.Controls.Add(Me.Cmd_connect_shefford)
        Me.GrpConnectShefford.Controls.Add(Me.Cmd_disconnect_Shefford)
        Me.GrpConnectShefford.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpConnectShefford.Location = New System.Drawing.Point(1254, 905)
        Me.GrpConnectShefford.Name = "GrpConnectShefford"
        Me.GrpConnectShefford.Size = New System.Drawing.Size(230, 70)
        Me.GrpConnectShefford.TabIndex = 176
        Me.GrpConnectShefford.TabStop = False
        Me.GrpConnectShefford.Text = "PLC Shefford"
        '
        'GrpConnectLaporte
        '
        Me.GrpConnectLaporte.Controls.Add(Me.Cmd_disconnect_Laporte)
        Me.GrpConnectLaporte.Controls.Add(Me.Cmd_connect_Laporte)
        Me.GrpConnectLaporte.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpConnectLaporte.Location = New System.Drawing.Point(1630, 908)
        Me.GrpConnectLaporte.Name = "GrpConnectLaporte"
        Me.GrpConnectLaporte.Size = New System.Drawing.Size(230, 70)
        Me.GrpConnectLaporte.TabIndex = 177
        Me.GrpConnectLaporte.TabStop = False
        Me.GrpConnectLaporte.Text = "PLC Laporte"
        '
        'Cmd_disconnect_Laporte
        '
        Me.Cmd_disconnect_Laporte.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd_disconnect_Laporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_disconnect_Laporte.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_disconnect_Laporte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_disconnect_Laporte.Location = New System.Drawing.Point(128, 31)
        Me.Cmd_disconnect_Laporte.Name = "Cmd_disconnect_Laporte"
        Me.Cmd_disconnect_Laporte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_disconnect_Laporte.Size = New System.Drawing.Size(96, 33)
        Me.Cmd_disconnect_Laporte.TabIndex = 78
        Me.Cmd_disconnect_Laporte.Text = "Déconnection"
        Me.Cmd_disconnect_Laporte.UseVisualStyleBackColor = False
        '
        'Cmd_connect_Laporte
        '
        Me.Cmd_connect_Laporte.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd_connect_Laporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_connect_Laporte.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_connect_Laporte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_connect_Laporte.Location = New System.Drawing.Point(6, 31)
        Me.Cmd_connect_Laporte.Name = "Cmd_connect_Laporte"
        Me.Cmd_connect_Laporte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_connect_Laporte.Size = New System.Drawing.Size(96, 33)
        Me.Cmd_connect_Laporte.TabIndex = 2
        Me.Cmd_connect_Laporte.Text = "Connection"
        Me.Cmd_connect_Laporte.UseVisualStyleBackColor = False
        '
        'PLC_Laporte2
        '
        Me.PLC_Laporte2.Enabled = True
        Me.PLC_Laporte2.Location = New System.Drawing.Point(1108, 6)
        Me.PLC_Laporte2.Name = "PLC_Laporte2"
        Me.PLC_Laporte2.OcxState = CType(resources.GetObject("PLC_Laporte2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PLC_Laporte2.Size = New System.Drawing.Size(125, 35)
        Me.PLC_Laporte2.TabIndex = 175
        Me.PLC_Laporte2.Visible = False
        '
        'PLC_Shefford
        '
        Me.PLC_Shefford.Enabled = True
        Me.PLC_Shefford.Location = New System.Drawing.Point(976, 7)
        Me.PLC_Shefford.Name = "PLC_Shefford"
        Me.PLC_Shefford.OcxState = CType(resources.GetObject("PLC_Shefford.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PLC_Shefford.Size = New System.Drawing.Size(126, 35)
        Me.PLC_Shefford.TabIndex = 135
        Me.PLC_Shefford.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.WebBrowserCamReservoir)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1254, 463)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(606, 431)
        Me.GroupBox2.TabIndex = 180
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Caméra Réservoir Laporte"
        '
        'WebBrowserCamReservoir
        '
        Me.WebBrowserCamReservoir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowserCamReservoir.Location = New System.Drawing.Point(3, 28)
        Me.WebBrowserCamReservoir.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserCamReservoir.Name = "WebBrowserCamReservoir"
        Me.WebBrowserCamReservoir.Size = New System.Drawing.Size(600, 400)
        Me.WebBrowserCamReservoir.TabIndex = 178
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtBox_mess_alm)
        Me.GroupBox5.Controls.Add(Me.Cmd_rearm_alm)
        Me.GroupBox5.Controls.Add(Me.Std_ctrl_lamp_alm)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(8, 844)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(508, 132)
        Me.GroupBox5.TabIndex = 190
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Alarmes"
        '
        'TxtBox_mess_alm
        '
        Me.TxtBox_mess_alm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBox_mess_alm.Location = New System.Drawing.Point(12, 43)
        Me.TxtBox_mess_alm.Multiline = True
        Me.TxtBox_mess_alm.Name = "TxtBox_mess_alm"
        Me.TxtBox_mess_alm.Size = New System.Drawing.Size(366, 82)
        Me.TxtBox_mess_alm.TabIndex = 112
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.WebBrowserCamRelacheur)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1254, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(606, 431)
        Me.GroupBox1.TabIndex = 179
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Caméra Relacheur Laporte"
        '
        'WebBrowserCamRelacheur
        '
        Me.WebBrowserCamRelacheur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowserCamRelacheur.Location = New System.Drawing.Point(3, 28)
        Me.WebBrowserCamRelacheur.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserCamRelacheur.Name = "WebBrowserCamRelacheur"
        Me.WebBrowserCamRelacheur.Size = New System.Drawing.Size(600, 400)
        Me.WebBrowserCamRelacheur.TabIndex = 178
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Lbl_deb_total)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(790, 320)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(449, 247)
        Me.GroupBox3.TabIndex = 188
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Débit Total (gal/hr)"
        '
        'Lbl_deb_total
        '
        Me.Lbl_deb_total.BackColor = System.Drawing.Color.Gold
        Me.Lbl_deb_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_deb_total.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lbl_deb_total.Font = New System.Drawing.Font("Arial", 96.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_deb_total.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lbl_deb_total.Location = New System.Drawing.Point(15, 50)
        Me.Lbl_deb_total.Name = "Lbl_deb_total"
        Me.Lbl_deb_total.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl_deb_total.Size = New System.Drawing.Size(419, 173)
        Me.Lbl_deb_total.TabIndex = 182
        Me.Lbl_deb_total.Text = "00000"
        Me.Lbl_deb_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 213)
        Me.Panel1.TabIndex = 183
        '
        'Lbl_Coulee_en_cour
        '
        Me.Lbl_Coulee_en_cour.AutoSize = True
        Me.Lbl_Coulee_en_cour.BackColor = System.Drawing.Color.SandyBrown
        Me.Lbl_Coulee_en_cour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Coulee_en_cour.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Coulee_en_cour.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Coulee_en_cour.Location = New System.Drawing.Point(392, 10)
        Me.Lbl_Coulee_en_cour.Name = "Lbl_Coulee_en_cour"
        Me.Lbl_Coulee_en_cour.Size = New System.Drawing.Size(446, 39)
        Me.Lbl_Coulee_en_cour.TabIndex = 186
        Me.Lbl_Coulee_en_cour.Text = "Coulée #100 - 0 j 00 : 00 : 00"
        Me.Lbl_Coulee_en_cour.Visible = False
        '
        'GrpBox_Vacc3
        '
        Me.GrpBox_Vacc3.Controls.Add(Me.Lbl_arr_vacc3)
        Me.GrpBox_Vacc3.Controls.Add(Me.Lbl_mar_vacc3)
        Me.GrpBox_Vacc3.Controls.Add(Me.PictureBox3)
        Me.GrpBox_Vacc3.Controls.Add(Me.StandardControlVac3)
        Me.GrpBox_Vacc3.Controls.Add(Me.PanelVacc3)
        Me.GrpBox_Vacc3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.GrpBox_Vacc3.ForeColor = System.Drawing.Color.Firebrick
        Me.GrpBox_Vacc3.Location = New System.Drawing.Point(443, 587)
        Me.GrpBox_Vacc3.Name = "GrpBox_Vacc3"
        Me.GrpBox_Vacc3.Size = New System.Drawing.Size(334, 247)
        Me.GrpBox_Vacc3.TabIndex = 181
        Me.GrpBox_Vacc3.TabStop = False
        Me.GrpBox_Vacc3.Text = "Vaccum #3"
        '
        'Lbl_arr_vacc3
        '
        Me.Lbl_arr_vacc3.AutoSize = True
        Me.Lbl_arr_vacc3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_arr_vacc3.ForeColor = System.Drawing.Color.Red
        Me.Lbl_arr_vacc3.Location = New System.Drawing.Point(14, 52)
        Me.Lbl_arr_vacc3.Name = "Lbl_arr_vacc3"
        Me.Lbl_arr_vacc3.Size = New System.Drawing.Size(69, 19)
        Me.Lbl_arr_vacc3.TabIndex = 27
        Me.Lbl_arr_vacc3.Text = "En arret"
        '
        'Lbl_mar_vacc3
        '
        Me.Lbl_mar_vacc3.AutoSize = True
        Me.Lbl_mar_vacc3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_mar_vacc3.ForeColor = System.Drawing.Color.Green
        Me.Lbl_mar_vacc3.Location = New System.Drawing.Point(102, 52)
        Me.Lbl_mar_vacc3.Name = "Lbl_mar_vacc3"
        Me.Lbl_mar_vacc3.Size = New System.Drawing.Size(91, 19)
        Me.Lbl_mar_vacc3.TabIndex = 26
        Me.Lbl_mar_vacc3.Text = "En marche"
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(9, 47)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(189, 28)
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'PanelVacc3
        '
        Me.PanelVacc3.BackColor = System.Drawing.Color.Silver
        Me.PanelVacc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelVacc3.Controls.Add(Me.LblHeureMarcheVac3)
        Me.PanelVacc3.Controls.Add(Me.Lbl_perte_vacc3)
        Me.PanelVacc3.Controls.Add(Me.Lbl_ok_vacc3)
        Me.PanelVacc3.Controls.Add(Me.Lbl_txt_temps_mar_v3)
        Me.PanelVacc3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelVacc3.Location = New System.Drawing.Point(3, 31)
        Me.PanelVacc3.Name = "PanelVacc3"
        Me.PanelVacc3.Size = New System.Drawing.Size(328, 213)
        Me.PanelVacc3.TabIndex = 183
        '
        'LblHeureMarcheVac3
        '
        Me.LblHeureMarcheVac3.BackColor = System.Drawing.Color.LightGreen
        Me.LblHeureMarcheVac3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblHeureMarcheVac3.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblHeureMarcheVac3.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeureMarcheVac3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblHeureMarcheVac3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblHeureMarcheVac3.Location = New System.Drawing.Point(24, 157)
        Me.LblHeureMarcheVac3.Name = "LblHeureMarcheVac3"
        Me.LblHeureMarcheVac3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblHeureMarcheVac3.Size = New System.Drawing.Size(280, 44)
        Me.LblHeureMarcheVac3.TabIndex = 181
        Me.LblHeureMarcheVac3.Text = "0 j 00 : 00 : 00"
        Me.LblHeureMarcheVac3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_perte_vacc3
        '
        Me.Lbl_perte_vacc3.AutoSize = True
        Me.Lbl_perte_vacc3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_perte_vacc3.ForeColor = System.Drawing.Color.Red
        Me.Lbl_perte_vacc3.Location = New System.Drawing.Point(15, 72)
        Me.Lbl_perte_vacc3.Name = "Lbl_perte_vacc3"
        Me.Lbl_perte_vacc3.Size = New System.Drawing.Size(166, 19)
        Me.Lbl_perte_vacc3.TabIndex = 106
        Me.Lbl_perte_vacc3.Text = "PERTE DE VACCUM"
        Me.Lbl_perte_vacc3.Visible = False
        '
        'Lbl_ok_vacc3
        '
        Me.Lbl_ok_vacc3.AutoSize = True
        Me.Lbl_ok_vacc3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ok_vacc3.ForeColor = System.Drawing.Color.LimeGreen
        Me.Lbl_ok_vacc3.Location = New System.Drawing.Point(20, 72)
        Me.Lbl_ok_vacc3.Name = "Lbl_ok_vacc3"
        Me.Lbl_ok_vacc3.Size = New System.Drawing.Size(108, 19)
        Me.Lbl_ok_vacc3.TabIndex = 105
        Me.Lbl_ok_vacc3.Text = "VACCUM OK"
        Me.Lbl_ok_vacc3.Visible = False
        '
        'Lbl_txt_temps_mar_v3
        '
        Me.Lbl_txt_temps_mar_v3.AutoSize = True
        Me.Lbl_txt_temps_mar_v3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_txt_temps_mar_v3.ForeColor = System.Drawing.Color.Black
        Me.Lbl_txt_temps_mar_v3.Location = New System.Drawing.Point(22, 133)
        Me.Lbl_txt_temps_mar_v3.Name = "Lbl_txt_temps_mar_v3"
        Me.Lbl_txt_temps_mar_v3.Size = New System.Drawing.Size(177, 22)
        Me.Lbl_txt_temps_mar_v3.TabIndex = 157
        Me.Lbl_txt_temps_mar_v3.Text = "Temps de marche"
        '
        'GrpBox_Vacc2
        '
        Me.GrpBox_Vacc2.Controls.Add(Me.Lbl_arr_vacc2)
        Me.GrpBox_Vacc2.Controls.Add(Me.Lbl_mar_vacc2)
        Me.GrpBox_Vacc2.Controls.Add(Me.PictureBox2)
        Me.GrpBox_Vacc2.Controls.Add(Me.Lbl_txt_temps_mar_v2)
        Me.GrpBox_Vacc2.Controls.Add(Me.StandardControlVac2)
        Me.GrpBox_Vacc2.Controls.Add(Me.PanelVacc2)
        Me.GrpBox_Vacc2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.GrpBox_Vacc2.ForeColor = System.Drawing.Color.Firebrick
        Me.GrpBox_Vacc2.Location = New System.Drawing.Point(443, 320)
        Me.GrpBox_Vacc2.Name = "GrpBox_Vacc2"
        Me.GrpBox_Vacc2.Size = New System.Drawing.Size(334, 247)
        Me.GrpBox_Vacc2.TabIndex = 165
        Me.GrpBox_Vacc2.TabStop = False
        Me.GrpBox_Vacc2.Text = "Vaccum #2"
        '
        'Lbl_arr_vacc2
        '
        Me.Lbl_arr_vacc2.AutoSize = True
        Me.Lbl_arr_vacc2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_arr_vacc2.ForeColor = System.Drawing.Color.Red
        Me.Lbl_arr_vacc2.Location = New System.Drawing.Point(14, 52)
        Me.Lbl_arr_vacc2.Name = "Lbl_arr_vacc2"
        Me.Lbl_arr_vacc2.Size = New System.Drawing.Size(69, 19)
        Me.Lbl_arr_vacc2.TabIndex = 27
        Me.Lbl_arr_vacc2.Text = "En arret"
        '
        'Lbl_mar_vacc2
        '
        Me.Lbl_mar_vacc2.AutoSize = True
        Me.Lbl_mar_vacc2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_mar_vacc2.ForeColor = System.Drawing.Color.Green
        Me.Lbl_mar_vacc2.Location = New System.Drawing.Point(102, 52)
        Me.Lbl_mar_vacc2.Name = "Lbl_mar_vacc2"
        Me.Lbl_mar_vacc2.Size = New System.Drawing.Size(91, 19)
        Me.Lbl_mar_vacc2.TabIndex = 26
        Me.Lbl_mar_vacc2.Text = "En marche"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(9, 47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(189, 28)
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'Lbl_txt_temps_mar_v2
        '
        Me.Lbl_txt_temps_mar_v2.AutoSize = True
        Me.Lbl_txt_temps_mar_v2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_txt_temps_mar_v2.ForeColor = System.Drawing.Color.Black
        Me.Lbl_txt_temps_mar_v2.Location = New System.Drawing.Point(22, 165)
        Me.Lbl_txt_temps_mar_v2.Name = "Lbl_txt_temps_mar_v2"
        Me.Lbl_txt_temps_mar_v2.Size = New System.Drawing.Size(177, 22)
        Me.Lbl_txt_temps_mar_v2.TabIndex = 157
        Me.Lbl_txt_temps_mar_v2.Text = "Temps de marche"
        '
        'PanelVacc2
        '
        Me.PanelVacc2.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelVacc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelVacc2.Controls.Add(Me.LblHeureMarcheVac2)
        Me.PanelVacc2.Controls.Add(Me.Lbl_perte_vacc2)
        Me.PanelVacc2.Controls.Add(Me.Lbl_ok_vacc2)
        Me.PanelVacc2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelVacc2.Location = New System.Drawing.Point(3, 31)
        Me.PanelVacc2.Name = "PanelVacc2"
        Me.PanelVacc2.Size = New System.Drawing.Size(328, 213)
        Me.PanelVacc2.TabIndex = 183
        '
        'LblHeureMarcheVac2
        '
        Me.LblHeureMarcheVac2.BackColor = System.Drawing.Color.LightGreen
        Me.LblHeureMarcheVac2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblHeureMarcheVac2.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblHeureMarcheVac2.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeureMarcheVac2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblHeureMarcheVac2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblHeureMarcheVac2.Location = New System.Drawing.Point(24, 157)
        Me.LblHeureMarcheVac2.Name = "LblHeureMarcheVac2"
        Me.LblHeureMarcheVac2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblHeureMarcheVac2.Size = New System.Drawing.Size(280, 44)
        Me.LblHeureMarcheVac2.TabIndex = 181
        Me.LblHeureMarcheVac2.Text = "0 j 00 : 00 : 00"
        Me.LblHeureMarcheVac2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_perte_vacc2
        '
        Me.Lbl_perte_vacc2.AutoSize = True
        Me.Lbl_perte_vacc2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_perte_vacc2.ForeColor = System.Drawing.Color.Red
        Me.Lbl_perte_vacc2.Location = New System.Drawing.Point(15, 72)
        Me.Lbl_perte_vacc2.Name = "Lbl_perte_vacc2"
        Me.Lbl_perte_vacc2.Size = New System.Drawing.Size(166, 19)
        Me.Lbl_perte_vacc2.TabIndex = 106
        Me.Lbl_perte_vacc2.Text = "PERTE DE VACCUM"
        Me.Lbl_perte_vacc2.Visible = False
        '
        'Lbl_ok_vacc2
        '
        Me.Lbl_ok_vacc2.AutoSize = True
        Me.Lbl_ok_vacc2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ok_vacc2.ForeColor = System.Drawing.Color.LimeGreen
        Me.Lbl_ok_vacc2.Location = New System.Drawing.Point(20, 72)
        Me.Lbl_ok_vacc2.Name = "Lbl_ok_vacc2"
        Me.Lbl_ok_vacc2.Size = New System.Drawing.Size(108, 19)
        Me.Lbl_ok_vacc2.TabIndex = 105
        Me.Lbl_ok_vacc2.Text = "VACCUM OK"
        Me.Lbl_ok_vacc2.Visible = False
        '
        'GrpBox_Vacc1
        '
        Me.GrpBox_Vacc1.Controls.Add(Me.Lbl_mar_vacc1)
        Me.GrpBox_Vacc1.Controls.Add(Me.Lbl_arr_vacc1)
        Me.GrpBox_Vacc1.Controls.Add(Me.PictureBox1)
        Me.GrpBox_Vacc1.Controls.Add(Me.StandardControlVac1)
        Me.GrpBox_Vacc1.Controls.Add(Me.PanelVacc1)
        Me.GrpBox_Vacc1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.GrpBox_Vacc1.ForeColor = System.Drawing.Color.Firebrick
        Me.GrpBox_Vacc1.Location = New System.Drawing.Point(443, 53)
        Me.GrpBox_Vacc1.Name = "GrpBox_Vacc1"
        Me.GrpBox_Vacc1.Size = New System.Drawing.Size(334, 247)
        Me.GrpBox_Vacc1.TabIndex = 164
        Me.GrpBox_Vacc1.TabStop = False
        Me.GrpBox_Vacc1.Text = "Vaccum #1"
        '
        'Lbl_mar_vacc1
        '
        Me.Lbl_mar_vacc1.AutoSize = True
        Me.Lbl_mar_vacc1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_mar_vacc1.ForeColor = System.Drawing.Color.Green
        Me.Lbl_mar_vacc1.Location = New System.Drawing.Point(110, 50)
        Me.Lbl_mar_vacc1.Name = "Lbl_mar_vacc1"
        Me.Lbl_mar_vacc1.Size = New System.Drawing.Size(91, 19)
        Me.Lbl_mar_vacc1.TabIndex = 19
        Me.Lbl_mar_vacc1.Text = "En marche"
        '
        'Lbl_arr_vacc1
        '
        Me.Lbl_arr_vacc1.AutoSize = True
        Me.Lbl_arr_vacc1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_arr_vacc1.ForeColor = System.Drawing.Color.Red
        Me.Lbl_arr_vacc1.Location = New System.Drawing.Point(19, 50)
        Me.Lbl_arr_vacc1.Name = "Lbl_arr_vacc1"
        Me.Lbl_arr_vacc1.Size = New System.Drawing.Size(69, 19)
        Me.Lbl_arr_vacc1.TabIndex = 20
        Me.Lbl_arr_vacc1.Text = "En arret"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(16, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 28)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'PanelVacc1
        '
        Me.PanelVacc1.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelVacc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelVacc1.Controls.Add(Me.Lbl_perte_vacc1)
        Me.PanelVacc1.Controls.Add(Me.LblHeureMarcheVac1)
        Me.PanelVacc1.Controls.Add(Me.Lbl_ok_vacc1)
        Me.PanelVacc1.Controls.Add(Me.Lbl_txt_temps_mar_v1)
        Me.PanelVacc1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelVacc1.Location = New System.Drawing.Point(3, 31)
        Me.PanelVacc1.Name = "PanelVacc1"
        Me.PanelVacc1.Size = New System.Drawing.Size(328, 213)
        Me.PanelVacc1.TabIndex = 182
        '
        'Lbl_perte_vacc1
        '
        Me.Lbl_perte_vacc1.AutoSize = True
        Me.Lbl_perte_vacc1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_perte_vacc1.ForeColor = System.Drawing.Color.Red
        Me.Lbl_perte_vacc1.Location = New System.Drawing.Point(15, 72)
        Me.Lbl_perte_vacc1.Name = "Lbl_perte_vacc1"
        Me.Lbl_perte_vacc1.Size = New System.Drawing.Size(166, 19)
        Me.Lbl_perte_vacc1.TabIndex = 104
        Me.Lbl_perte_vacc1.Text = "PERTE DE VACCUM"
        Me.Lbl_perte_vacc1.Visible = False
        '
        'LblHeureMarcheVac1
        '
        Me.LblHeureMarcheVac1.BackColor = System.Drawing.Color.LightGreen
        Me.LblHeureMarcheVac1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblHeureMarcheVac1.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblHeureMarcheVac1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LblHeureMarcheVac1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblHeureMarcheVac1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblHeureMarcheVac1.Location = New System.Drawing.Point(24, 157)
        Me.LblHeureMarcheVac1.Name = "LblHeureMarcheVac1"
        Me.LblHeureMarcheVac1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblHeureMarcheVac1.Size = New System.Drawing.Size(280, 44)
        Me.LblHeureMarcheVac1.TabIndex = 180
        Me.LblHeureMarcheVac1.Text = "0 j 00 : 00 : 00"
        Me.LblHeureMarcheVac1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_ok_vacc1
        '
        Me.Lbl_ok_vacc1.AutoSize = True
        Me.Lbl_ok_vacc1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ok_vacc1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Lbl_ok_vacc1.Location = New System.Drawing.Point(15, 72)
        Me.Lbl_ok_vacc1.Name = "Lbl_ok_vacc1"
        Me.Lbl_ok_vacc1.Size = New System.Drawing.Size(108, 19)
        Me.Lbl_ok_vacc1.TabIndex = 103
        Me.Lbl_ok_vacc1.Text = "VACCUM OK"
        Me.Lbl_ok_vacc1.Visible = False
        '
        'Lbl_txt_temps_mar_v1
        '
        Me.Lbl_txt_temps_mar_v1.AutoSize = True
        Me.Lbl_txt_temps_mar_v1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_txt_temps_mar_v1.ForeColor = System.Drawing.Color.Black
        Me.Lbl_txt_temps_mar_v1.Location = New System.Drawing.Point(22, 133)
        Me.Lbl_txt_temps_mar_v1.Name = "Lbl_txt_temps_mar_v1"
        Me.Lbl_txt_temps_mar_v1.Size = New System.Drawing.Size(177, 22)
        Me.Lbl_txt_temps_mar_v1.TabIndex = 156
        Me.Lbl_txt_temps_mar_v1.Text = "Temps de marche"
        '
        'Lbl_titre
        '
        Me.Lbl_titre.AutoSize = True
        Me.Lbl_titre.Font = New System.Drawing.Font("Arial", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_titre.ForeColor = System.Drawing.Color.Navy
        Me.Lbl_titre.Location = New System.Drawing.Point(3, 3)
        Me.Lbl_titre.Name = "Lbl_titre"
        Me.Lbl_titre.Size = New System.Drawing.Size(218, 29)
        Me.Lbl_titre.TabIndex = 18
        Me.Lbl_titre.Text = "Erablière Brunelle"
        '
        'Temperature
        '
        Me.Temperature.Controls.Add(Me.Panel3)
        Me.Temperature.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Temperature.Location = New System.Drawing.Point(790, 53)
        Me.Temperature.Name = "Temperature"
        Me.Temperature.Size = New System.Drawing.Size(449, 247)
        Me.Temperature.TabIndex = 187
        Me.Temperature.TabStop = False
        Me.Temperature.Text = "Température"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 31)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(443, 213)
        Me.Panel3.TabIndex = 186
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Location = New System.Drawing.Point(11, 33)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(420, 131)
        Me.Panel9.TabIndex = 185
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel10.Controls.Add(Me.LblTemperature)
        Me.Panel10.Location = New System.Drawing.Point(19, 18)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(377, 93)
        Me.Panel10.TabIndex = 156
        '
        'LblTemperature
        '
        Me.LblTemperature.AutoSize = True
        Me.LblTemperature.BackColor = System.Drawing.SystemColors.ControlText
        Me.LblTemperature.Font = New System.Drawing.Font("Arial", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTemperature.ForeColor = System.Drawing.Color.Red
        Me.LblTemperature.Location = New System.Drawing.Point(49, 14)
        Me.LblTemperature.Name = "LblTemperature"
        Me.LblTemperature.Size = New System.Drawing.Size(279, 65)
        Me.LblTemperature.TabIndex = 185
        Me.LblTemperature.Text = "> 0 deg C"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtCheminDuFichier)
        Me.GroupBox4.Controls.Add(Me.TxtMessages)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.LbLNomduFichier)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(522, 844)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(717, 131)
        Me.GroupBox4.TabIndex = 189
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Messages"
        '
        'TxtCheminDuFichier
        '
        Me.TxtCheminDuFichier.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCheminDuFichier.Location = New System.Drawing.Point(12, 48)
        Me.TxtCheminDuFichier.Multiline = True
        Me.TxtCheminDuFichier.Name = "TxtCheminDuFichier"
        Me.TxtCheminDuFichier.Size = New System.Drawing.Size(691, 27)
        Me.TxtCheminDuFichier.TabIndex = 115
        Me.TxtCheminDuFichier.Text = "C:\Documents and Settings\Pierre\My Documents\Test Log\ Pompe 3-13 février 2014.x" & _
            "lsx" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtMessages
        '
        Me.TxtMessages.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtMessages.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMessages.Location = New System.Drawing.Point(12, 96)
        Me.TxtMessages.Multiline = True
        Me.TxtMessages.Name = "TxtMessages"
        Me.TxtMessages.ReadOnly = True
        Me.TxtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtMessages.Size = New System.Drawing.Size(690, 30)
        Me.TxtMessages.TabIndex = 178
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 20)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "Message d'erreur"
        '
        'LbLNomduFichier
        '
        Me.LbLNomduFichier.BackColor = System.Drawing.Color.Gainsboro
        Me.LbLNomduFichier.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLNomduFichier.Location = New System.Drawing.Point(11, 31)
        Me.LbLNomduFichier.Name = "LbLNomduFichier"
        Me.LbLNomduFichier.Size = New System.Drawing.Size(153, 20)
        Me.LbLNomduFichier.TabIndex = 174
        Me.LbLNomduFichier.Text = "Nom du fichier Excel"
        '
        'PLC_Laporte
        '
        Me.PLC_Laporte.Enabled = True
        Me.PLC_Laporte.Location = New System.Drawing.Point(844, 810)
        Me.PLC_Laporte.Name = "PLC_Laporte"
        Me.PLC_Laporte.OcxState = CType(resources.GetObject("PLC_Laporte.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PLC_Laporte.Size = New System.Drawing.Size(100, 50)
        Me.PLC_Laporte.TabIndex = 136
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1907, 1009)
        Me.TabControl1.TabIndex = 114
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightGray
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1899, 983)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Utilitaire"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.WebBrowser1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.PropertyGrid1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1262, 977)
        Me.Panel2.TabIndex = 176
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 57)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1262, 920)
        Me.WebBrowser1.TabIndex = 175
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(491, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(279, 39)
        Me.Button1.TabIndex = 180
        Me.Button1.Text = "Connection LogMeIN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Location = New System.Drawing.Point(3, 56)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(1259, 920)
        Me.PropertyGrid1.TabIndex = 176
        '
        'SheffordTimerWatchDog
        '
        '
        'LaporteTimerWatchDog
        '
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1912, 1014)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label26)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Erabliere Brunelle"
        Me.GrpBox_Osm1.ResumeLayout(False)
        Me.GrpBox_Osm1.PerformLayout()
        Me.PanelOSM.ResumeLayout(False)
        Me.Panel_Osm1_On_Off.ResumeLayout(False)
        Me.Panel_Osm1_On_Off.PerformLayout()
        CType(Me.Pict_Osmose1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Std_ctrl_osm1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBox_Pump2.ResumeLayout(False)
        Me.GrpBox_Pump2.PerformLayout()
        Me.PanelPump2.ResumeLayout(False)
        Me.PanelPump2.PerformLayout()
        CType(Me.Std_Ctrl_pump2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBox_Pump1.ResumeLayout(False)
        Me.PanelPump1.ResumeLayout(False)
        Me.PanelPump1.PerformLayout()
        CType(Me.Std_Ctrl_pump1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControlVac1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControlVac2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBox_Pump3.ResumeLayout(False)
        Me.GrpBox_Pump3.PerformLayout()
        Me.PanelPump3.ResumeLayout(False)
        Me.PanelPump3.PerformLayout()
        CType(Me.Std_Ctrl_pump3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardControlVac3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Std_ctrl_lamp_alm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GrpConnectShefford.ResumeLayout(False)
        Me.GrpConnectLaporte.ResumeLayout(False)
        CType(Me.PLC_Laporte2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLC_Shefford, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GrpBox_Vacc3.ResumeLayout(False)
        Me.GrpBox_Vacc3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelVacc3.ResumeLayout(False)
        Me.PanelVacc3.PerformLayout()
        Me.GrpBox_Vacc2.ResumeLayout(False)
        Me.GrpBox_Vacc2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelVacc2.ResumeLayout(False)
        Me.PanelVacc2.PerformLayout()
        Me.GrpBox_Vacc1.ResumeLayout(False)
        Me.GrpBox_Vacc1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelVacc1.ResumeLayout(False)
        Me.PanelVacc1.PerformLayout()
        Me.Temperature.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PLC_Laporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
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

    'Déclaration de constante pour clarifier le code
    Const NombreItemALogger As Integer = 7
    Const PompeP1 As Integer = 0
    Const PompeP2 As Integer = 1
    Const PompeP3 As Integer = 2
    Const NombreDePompe As Integer = 2 'Il y a 3 pompes mais les array commencent a 0
    Const OneMinute As Integer = 60000 '60000 millisecondes = une minute
    Const OneSecond As Integer = 1000 '1000 milliosecond = 1 seconde

    'Déclare un object ExcelLogging et un array de données pour chaque pompe
    Dim ExcelLogging As New LogginFunctions 'Chaque pompe utilise sa propre instance des fonction d'écriture Excel
    Dim LogData(NombreDePompe, NombreItemALogger - 1) As Struc_LogData

    'Déclaration des variables sous forme d'array pour l'acquisition de données
    Dim T0_DebutDeCycle(NombreDePompe) As Date
    Dim T1_Demarrage(NombreDePompe) As Date
    Dim T2_Arret(NombreDePompe) As Date
    Dim Duree(NombreDePompe) As TimeSpan
    Dim Cycle(NombreDePompe) As TimeSpan
    Dim EtatActuelDeLaPompe(NombreDePompe) As Boolean
    Dim CouleurFondOriginaleShefford As Color
    Dim CouleurFondOriginaleLaporte As Color

    Dim CouleEnCour As Boolean = False
    Dim DureeActuelDeCoule As TimeSpan
    Dim DateDebutDeCoulee As Date = DateAndTime.Now
    Dim NouvelleDateRequise As Boolean = True
    Dim e As Boolean

    Dim BitDeRearmement As Short = 0
    '
    Dim TestMode As Boolean = False

    Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'Au moment de quitter l'appication, quitter Excel et detruire les objets
        ExcelLogging.StopExcel()
        ExcelLogging = Nothing 'Detruit l'objet ExcelLogging avant de quitter
    End Sub

    Public Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Property grid settings
        PropertyGrid1.SelectedObject = My.Settings
        ' Attribute for the user-scope settings. 
        Dim userAttr As New System.Configuration.UserScopedSettingAttribute
        Dim attrs As New System.ComponentModel.AttributeCollection(userAttr)
        PropertyGrid1.BrowsableAttributes = attrs

        'Initialisation des propriétés de ExcelLogging
        TxtCheminDuFichier.Text = My.Settings.CheminFichierLog
        ExcelLogging.NoColonnePourEnregistrerLeNumeroDeLigneCourant = My.Settings.NoColOuSauverLeNoLigneCourrant
        ExcelLogging.CheminWindow = My.Settings.CheminFichierLog
        ExcelLogging.NomRapportVide = My.Settings.NomDuRaportVide
        If Control.ModifierKeys = Keys.Shift Then
            TestMode = True
            Me.BackColor = Color.Yellow
            Lbl_titre.Text = Lbl_titre.Text + " **** Mode de Test ****"
            TxtCheminDuFichier.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Test Log\"
            ExcelLogging.CheminWindow = TxtCheminDuFichier.Text
            WebBrowser1.Visible = False
        End If

        ExcelLogging.StartExcel()
        CouleurFondOriginaleShefford = GrpBox_Pump1.BackColor
        CouleurFondOriginaleLaporte = GrpBox_Pump3.BackColor

        'Activer la communication au depart
        Connect_PLC_Shefford()
        Connect_PLC_Laporte2()
        'Initialiser Les cycles des deux pompes 
        EtatActuelDeLaPompe(PompeP1) = False
        EtatActuelDeLaPompe(PompeP2) = False
        EtatActuelDeLaPompe(PompeP3) = False
        'Initialisation de T0_DebutDeCycle pour la premiere ligne du rapport
        T0_DebutDeCycle(PompeP1) = DateTime.Now
        T0_DebutDeCycle(PompeP2) = T0_DebutDeCycle(PompeP1)
        T0_DebutDeCycle(PompeP3) = T0_DebutDeCycle(PompeP1)
        T2_Arret(PompeP1) = DateTime.Now
        T2_Arret(PompeP2) = T2_Arret(PompeP1)
        T2_Arret(PompeP3) = T2_Arret(PompeP1)
        'Demarre les camera su site Laporte
        Try
            WebBrowserCamRelacheur.Navigate("http://" & My.Settings.Camera_IP_Laporte & ":" & My.Settings.PortCamera1130)
        Catch
        End Try
        Try
            WebBrowserCamReservoir.Navigate("http://" & My.Settings.Camera_IP_Laporte & ":" & My.Settings.PortCamera930)
        Catch
        End Try
        DureeActuelDeCoule = DateAndTime.Now.Subtract(DateAndTime.Now)
        'Demarre le timer de fin de coulee
        'TimeoutCoule.Enabled = True
        'ResetTimeoutCoule()
    End Sub

    Private Sub Connect_PLC_Shefford()
        Dim IPAddrPart() As String

        'Paramètre Connection TCP/IP
        If Not (TestMode) Then
            IPAddrPart = My.Settings.PLC_IP_Shefford.Split(".")
        Else
            IPAddrPart = "127.0.0.1".Split(".")
        End If
        PLC_Shefford.Connection() = MBAXPLib.enumConnection.TCP_IP
        PLC_Shefford.IPAddr1() = IPAddrPart(0)
        PLC_Shefford.IPAddr2() = IPAddrPart(1)
        PLC_Shefford.IPAddr3() = IPAddrPart(2)
        PLC_Shefford.IPAddr4() = IPAddrPart(3)
        PLC_Shefford.ConnectTimeout() = My.Settings.DelaisMaxConnection  'ms

        'Établissement de la communication TCP/IP
        e = PLC_Shefford.OpenConnection()

        'Commande de lecture MODBUS
        e = PLC_Shefford.ReadHoldingRegisters(1, 1, 3000, 20, 700) ' handle 1, slave 1, adresse 43001, quantite 20, rafraichissement 700mS
        e = PLC_Shefford.ReadHoldingRegisters(2, 1, 999, 1, 1000) ' handle 2, slave 1, adresse 41000, quantite 1, rafr. 1000mS
        e = PLC_Shefford.ReadCoilStatus(5, 1, 992, 30, 200) ' handle 5, slave 1, adresse 00993, quantite 30, rafraichissement 700mS
        e = PLC_Shefford.ForceMultipleCoils(6, 1, 34, 4, 700) ' D-OUT handle 6, slave 1, adresse 00035, quantite 4, rafr. 700mS
        e = PLC_Shefford.ReadCoilStatus(7, 1, 499, 2, 700) ' D-IN SONNORE handle 7, slave 1, adresse 00500, quantite 2, rafr. 700mS

        'Debute les taches
        PLC_Shefford.UpdateEnable(1)
        PLC_Shefford.UpdateEnable(2)
        PLC_Shefford.UpdateEnable(5)
        PLC_Shefford.UpdateEnable(6)
        PLC_Shefford.UpdateEnable(7)
        'Démarre le watchDog
        SheffordTimerWatchDog.Interval = My.Settings.DelaisWatchDog
        SheffordTimerWatchDog.Enabled = True
        '
        SetBackgroundColor_Shefford(CouleurFondOriginaleShefford)
    End Sub

    Private Sub Connect_PLC_Laporte2()
        Dim IPAddrPart() As String

        'Paramètre Connection TCP/IP
        If Not (TestMode) Then
            IPAddrPart = My.Settings.PLC_IP_Laporte.Split(".")
        Else
            IPAddrPart = "127.0.0.1".Split(".")
        End If
        PLC_Laporte2.Connection() = MBAXPLib.enumConnection.TCP_IP
        PLC_Laporte2.IPAddr1() = IPAddrPart(0)
        PLC_Laporte2.IPAddr2() = IPAddrPart(1)
        PLC_Laporte2.IPAddr3() = IPAddrPart(2)
        PLC_Laporte2.IPAddr4() = IPAddrPart(3)
        PLC_Laporte2.ConnectTimeout() = My.Settings.DelaisMaxConnection  'ms

        'Établissement de la communication TCP/IP
        e = PLC_Laporte2.OpenConnection()

        'Commande de lecture MODBUS
        e = PLC_Laporte2.ReadHoldingRegisters(1, 1, 1000, 20, 700) ' handle 1, slave 1, adresse 43001, quantite 20, rafraichissement 700mS
        e = PLC_Laporte2.ReadHoldingRegisters(2, 1, 999, 1, 1000) ' handle 2, slave 1, adresse 41000, quantite 1, rafr. 1000mS
        e = PLC_Laporte2.ReadCoilStatus(5, 1, 0, 49, 200) ' handle 5, slave 1, adresse 00993, quantite 30, rafraichissement 700mS
        e = PLC_Laporte2.ForceMultipleCoils(6, 1, 34, 4, 700) ' D-OUT handle 6, slave 1, adresse 00035, quantite 4, rafr. 700mS
        e = PLC_Laporte2.ReadCoilStatus(7, 1, 499, 2, 700) ' D-IN SONNORE handle 7, slave 1, adresse 00500, quantite 2, rafr. 700mS

        'Debute les taches
        PLC_Laporte2.UpdateEnable(1)
        PLC_Laporte2.UpdateEnable(2)
        PLC_Laporte2.UpdateEnable(5)
        PLC_Laporte2.UpdateEnable(6)
        PLC_Laporte2.UpdateEnable(7)
        'Démarre le watchDog
        LaporteTimerWatchDog.Interval = My.Settings.DelaisWatchDog
        LaporteTimerWatchDog.Enabled = True
        '
        SetBackgroundColor_Laporte(CouleurFondOriginaleLaporte)
    End Sub

    'Bouton de rearmement des alarmes
    Private Sub Cmd_rearm_alm_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_rearm_alm.Click
        PLC_Shefford.UpdateOnce(0) 'Bouton de rearmement des alarmes
        BitDeRearmement = 1
        PLC_Shefford.set_Coil(6, 0, BitDeRearmement)
        PLC_Shefford.UpdateOnce(0)

        PLC_Laporte2.UpdateOnce(0) 'Bouton de rearmement des alarmes
        PLC_Laporte2.set_Coil(6, 0, BitDeRearmement)
        PLC_Laporte2.UpdateOnce(0)
        Cmd_rearm_alm.BackColor = Color.DarkOrange
    End Sub

    'Vérification de la connection ethernet
    Private Sub PLC_Shefford_ResultError(ByVal sender As System.Object, ByVal e As AxMBAXPLib._DMbaxpEvents_ResultErrorEvent) Handles PLC_Shefford.ResultError
        'TACHE DE LA RECEPTION DES VALEURS DIGITALES DES ETATS
        If e.handle = 5 Then
            If e.error = 10 Then
                TxtBox_mess_alm.Text = "Timeout PLC Shefford - Vérifier le câble réseau." 'Voir dans la liste de code d erreur 10=Timeout
                TxtBox_mess_alm.BackColor = Color.Red
            Else
                TxtBox_mess_alm.Text = "" 'Efface le message
                TxtBox_mess_alm.BackColor = Color.LightGreen
            End If
            If e.error <> 0 Then
                TxtMessages.Text = e.error.ToString
            End If
        End If
    End Sub 'Cependant la tâche est terminé, l'évenement ResultOK est renvoyé

    'Vérification de la connection ethernet
    Private Sub PLC_Laporte2_ResultError(ByVal sender As System.Object, ByVal e As AxMBAXPLib._DMbaxpEvents_ResultErrorEvent) Handles PLC_Laporte2.ResultError
        'TACHE DE LA RECEPTION DES VALEURS DIGITALES DES ETATS
        If e.handle = 5 Then
            If e.error = 10 Then
                TxtBox_mess_alm.Text = "Timeout PLC Laporte - Vérifier le réseau." 'Voir dans la liste de code d erreur 10=Timeout
                TxtBox_mess_alm.BackColor = Color.Red
            Else
                TxtBox_mess_alm.Text = "" 'Efface le message
                TxtBox_mess_alm.BackColor = Color.LightGreen
            End If
            If e.error <> 0 Then
                TxtMessages.Text = e.error.ToString
            End If
        End If
    End Sub 'Cependant la tâche est terminé, l'évenement ResultOK est renvoyé

    Private Sub PLC_Shefford_ResultOk(ByVal sender As System.Object, ByVal e As AxMBAXPLib._DMbaxpEvents_ResultOkEvent) Handles PLC_Shefford.ResultOk
        Dim JrVac1 As Short, JrVac2 As Short
        Dim HrVac1 As Short, HrVac2 As Short, HrOsm1 As Short
        Dim MinVac1 As Short, MinVac2 As Short, MinOsm1 As Short
        Dim SecVac1 As Short, SecVac2 As Short, SecOsm1 As Short

        'Réinitialiser le watchDog Timer
        SetBackgroundColor_Shefford(CouleurFondOriginaleShefford)
        SheffordTimerWatchDog.Enabled = False
        SheffordTimerWatchDog.Interval = My.Settings.DelaisWatchDog
        SheffordTimerWatchDog.Enabled = True

        'TACHE DE LA RECEPTION DES VALEURS ANALOGUES
        If e.handle = 1 Then
            Lbl_deb_pump1.Text = CStr(2.0 * PLC_Shefford.get_Register(1, 0)) 'Affiche la valeur Pompe d'amenee#1 C'est l'eau aspiree de la cabane #1 (principale)rue Shefford - 43001
            Lbl_deb_pump2.Text = CStr(2.0 * PLC_Shefford.get_Register(1, 1)) 'Affiche la valeur Pompe d'amenee#2 C'est l'eau aspiree de la cabane #2 (petite) rue Shefford - 43002
            LblDureMarchePompeAmeneP1.Text = CStr(PLC_Shefford.get_Register(1, 2)) 'Affiche la durée de marche (sec) Pompe d'amenee#1 - 43003
            LblDureMarchePompeAmeneP2.Text = CStr(PLC_Shefford.get_Register(1, 3)) 'Affiche la durée de marche (sec) Pompe d'amenee#2 - 43004

            'Affichage Temps total d'opération du vacuum #1
            JrVac1 = PLC_Shefford.get_Register(1, 10) 'jour de marche vacuum 1
            HrVac1 = PLC_Shefford.get_Register(1, 9) 'heure de marche vacuum 1
            MinVac1 = PLC_Shefford.get_Register(1, 8) 'minutes de marche vacuum 1
            SecVac1 = PLC_Shefford.get_Register(1, 7) 'secondes de marche vacuum 1
            LblHeureMarcheVac1.Text = String.Format("{0:D} j {1:D2} : {2:D2} : {3:D2}", JrVac1, HrVac1, MinVac1, SecVac1)

            'Affichage Temps total d'opération du vacuum #2
            JrVac2 = PLC_Shefford.get_Register(1, 14) 'jour de marche vacuum 2
            HrVac2 = PLC_Shefford.get_Register(1, 13) 'heure de marche vacuum 2
            MinVac2 = PLC_Shefford.get_Register(1, 12) 'minutes de marche vacuum 2
            SecVac2 = PLC_Shefford.get_Register(1, 11) 'secondes de marche vacuum 2
            LblHeureMarcheVac2.Text = String.Format("{0:D} j {1:D2} : {2:D2} : {3:D2}", JrVac2, HrVac2, MinVac2, SecVac2)

            'Affichage Temps total d'opération du système Osmose#1
            HrOsm1 = PLC_Shefford.get_Register(1, 6) 'heure de marche vacuum
            MinOsm1 = PLC_Shefford.get_Register(1, 5) 'minutes de marche vacuum
            SecOsm1 = PLC_Shefford.get_Register(1, 4) 'secondes de marche vacuum
            LblHeureMarcheOsm1.Text = String.Format("{0:D2} : {1:D2} : {2:D2}", HrOsm1, MinOsm1, SecOsm1)
        End If

        'TACHE DE LA RECEPTION DES VALEURS DIGITALES DES ETATS
        If e.handle = 5 Then
            'Lecture de l'etat des systemes
            Dim Pompe1_ON_OFF_State As Boolean = PLC_Shefford.get_Coil(5, 1)    'Etat ON/OFF     Pompe#1-00994  Coil 993 + 1
            Dim Pompe1_Fault_State As Boolean = PLC_Shefford.get_Coil(5, 2)     'Etat Faute      Pompe#1-00995  Coil 993 + 2
            Dim Pompe2_ON_OFF_State As Boolean = PLC_Shefford.get_Coil(5, 4)    'Etat ON/OFF     Pompe#2-00997  Coil 993 + 4
            Dim Pompe2_Fault_State As Boolean = PLC_Shefford.get_Coil(5, 5)     'Etat Faute      Pompe#2-00998  Coil 993 + 5
            Dim Vacc1_ON_OFF_State As Boolean = PLC_Shefford.get_Coil(5, 7)     'Etat ON/OFF     Vacuum#1-01000 Coil 993 + 7
            Dim Vacc2_ON_OFF_State As Boolean = PLC_Shefford.get_Coil(5, 9)     'Etat ON/OFF     Vacuum#2-01002 Coil 993 + 9
            Dim Osm_green = PLC_Shefford.get_Coil(5, 10) 'Affiche l'etat VERT temps de marche    Osmose#1-01003 Coil 993 + 10
            Dim Osm_yellow = PLC_Shefford.get_Coil(5, 11) 'Affiche l'etat JAUNE temps de marche  Osmose#1-01004 Coil 993 + 11
            Dim Osm_red = PLC_Shefford.get_Coil(5, 12) 'Affiche l'etat ROUGE temps de marche     Osmose#1-01005 Coil 993 + 12
            Dim Osm1_On_OFF_State As Boolean = PLC_Shefford.get_Coil(5, 13)      'Etat ON/OFF     Osmose#1-01006 Coil 993 + 13

            'Affichage de l'état des pompes
            Std_Ctrl_pump1.DiscreteValue1 = Not (Pompe1_ON_OFF_State)
            Std_Ctrl_pump1.DiscreteValue2 = Pompe1_ON_OFF_State
            Std_Ctrl_pump1.DiscreteValue3 = Pompe1_Fault_State
            Lbl_faute_pump1.Visible = Pompe1_Fault_State

            Std_Ctrl_pump2.DiscreteValue1 = Not (Pompe2_ON_OFF_State)
            Std_Ctrl_pump2.DiscreteValue2 = Pompe2_ON_OFF_State
            Std_Ctrl_pump2.DiscreteValue3 = Pompe2_Fault_State
            Lbl_faute_pump2.Visible = Pompe2_Fault_State

            'Affichage de l'état des pompes
            Lbl_arr_vacc1.Visible = Not (Vacc1_ON_OFF_State)
            Lbl_mar_vacc1.Visible = Vacc1_ON_OFF_State
            StandardControlVac1.DiscreteValue1 = Not (Vacc1_ON_OFF_State)
            StandardControlVac1.DiscreteValue2 = Vacc1_ON_OFF_State

            Lbl_arr_vacc2.Visible = Not (Vacc2_ON_OFF_State)
            Lbl_mar_vacc2.Visible = Vacc2_ON_OFF_State
            StandardControlVac2.DiscreteValue1 = Not (Vacc2_ON_OFF_State)
            StandardControlVac2.DiscreteValue2 = Vacc2_ON_OFF_State

            'Affichage de l'état de l'Osmose
            Std_ctrl_osm1.DiscreteValue1 = Osm_green
            Std_ctrl_osm1.DiscreteValue2 = Osm_yellow
            Std_ctrl_osm1.DiscreteValue3 = Osm_red
            If Osm_green Then
                LblHeureMarcheOsm1.BackColor = Color.LightGreen
            ElseIf Osm_yellow Then
                LblHeureMarcheOsm1.BackColor = Color.Yellow
            ElseIf Osm_red Then
                LblHeureMarcheOsm1.BackColor = Color.Red
            End If

            If Osm1_On_OFF_State Then
                Lbl_Osm1_On_Off.Text = "ON"
                Panel_Osm1_On_Off.BackColor = Color.Green
            Else
                Lbl_Osm1_On_Off.Text = "OFF"
                Panel_Osm1_On_Off.BackColor = CouleurFondOriginaleShefford
            End If

            ' Change la couleur du champ de message en cas d'alarme
            If PLC_Shefford.get_Coil(7, 1) = 1 Then
                TxtBox_mess_alm.BackColor() = Color.OrangeRed
            Else
                TxtBox_mess_alm.BackColor() = Color.WhiteSmoke
            End If

            'Gestion de l'état des pompes et acquisition de données
            AcquisitionEtatDePompe(PompeP1, Pompe1_ON_OFF_State)
            AcquisitionEtatDePompe(PompeP2, Pompe2_ON_OFF_State)

        End If

        If e.handle = 6 Then 'RAZ le bouton de rearmement
            BitDeRearmement = 0 ' Met OFF le bit de rearmement
            PLC_Shefford.set_Coil(6, 0, BitDeRearmement)
            PLC_Shefford.UpdateOnce(0)
            Cmd_rearm_alm.BackColor = Color.Blue
        End If

        'TACHE DE LA RECEPTION DES VALEURS DIGITALES DES ALARMES
        If e.handle = 2 Then ' Gestion des messages d alarme
            If CStr(PLC_Shefford.get_Register(2, 0)) = 0 Then TxtBox_mess_alm.Text = "Operation normale"
            If CStr(PLC_Shefford.get_Register(2, 0)) = -32768 Then TxtBox_mess_alm.Text = "Osmose en marche au-delà de 4 heures" ' Bit 1-41000
            If CStr(PLC_Shefford.get_Register(2, 0)) = 16384 Then TxtBox_mess_alm.Text = "Pompe #1 fonctionne depuis 5 min. à vérifier" ' Bit 2-41000
            If CStr(PLC_Shefford.get_Register(2, 0)) = 8192 Then TxtBox_mess_alm.Text = "Pompe #2 fonctionne depuis 5 min. à vérifier" ' Bit 3-41000
            If CStr(PLC_Shefford.get_Register(2, 0)) = 4096 Then TxtBox_mess_alm.Text = "Bit de test 4" ' Bit 4-41000
            If CStr(PLC_Shefford.get_Register(2, 0)) = 2048 Then TxtBox_mess_alm.Text = "Bit de test 5" ' Bit 5-41000
            If CStr(PLC_Shefford.get_Register(2, 0)) = 1024 Then TxtBox_mess_alm.Text = "Bit de test 6" ' Bit 6-41000
            If CStr(PLC_Shefford.get_Register(2, 0)) = 512 Then TxtBox_mess_alm.Text = "Bit de test 7" ' Bit 7-41000
            If CStr(PLC_Shefford.get_Register(2, 0)) = 256 Then TxtBox_mess_alm.Text = "Bit de test 8" ' Bit 8-41000
            If CStr(PLC_Shefford.get_Register(2, 0)) = 128 Then TxtBox_mess_alm.Text = "Bit de test 9" ' Bit 9-41000
            If CStr(PLC_Shefford.get_Register(2, 0)) = 64 Then TxtBox_mess_alm.Text = "Bit de test 10" ' Bit 10-41000
            If CStr(PLC_Shefford.get_Register(2, 0)) = 32 Then TxtBox_mess_alm.Text = "Bit de test 11" ' Bit 11-41000
            If CStr(PLC_Shefford.get_Register(2, 0)) = 16 Then TxtBox_mess_alm.Text = "Bit de test 12" ' Bit 12-41000
            If CStr(PLC_Shefford.get_Register(2, 0)) = 8 Then TxtBox_mess_alm.Text = "Bit de test 13" ' Bit 13-41000
            If CStr(PLC_Shefford.get_Register(2, 0)) = 4 Then TxtBox_mess_alm.Text = "Bit de test 14" ' Bit 14-41000
            If CStr(PLC_Shefford.get_Register(2, 0)) = 2 Then TxtBox_mess_alm.Text = "Bit de test 15" ' Bit 15-41000
            If CStr(PLC_Shefford.get_Register(2, 0)) = 1 Then TxtBox_mess_alm.Text = "Bit de test 16" ' Bit 16-41000
        End If
    End Sub

    Private Sub PLC_Laporte2_ResultOk(ByVal sender As System.Object, ByVal e As AxMBAXPLib._DMbaxpEvents_ResultOkEvent) Handles PLC_Laporte2.ResultOk
        Dim JrVac3 As Short
        Dim HrVac3 As Short
        Dim MinVac3 As Short
        Dim SecVac3 As Short

        'Réinitialiser le watchDog Timer
        SetBackgroundColor_Laporte(CouleurFondOriginaleShefford)
        LaporteTimerWatchDog.Enabled = False
        LaporteTimerWatchDog.Interval = My.Settings.DelaisWatchDog
        LaporteTimerWatchDog.Enabled = True

        If e.handle = 1 Then
            Lbl_deb_pump3.Text = CStr(PLC_Laporte2.get_Register(1, 2)) '(41003)Affiche le DEBIT Pompe d'amenee#3 C'est l'eau aspiree de la cabane #3 boul. Pierre-Laporte
            LblDureMarchePompeAmeneP3.Text = CStr(PLC_Laporte2.get_Register(1, 4)) '(41005)Affiche la DUREE marche Pompe d'amenee#3  C'est l'eau aspiree de la cabane #3 boul. Pierre-Laporte
        End If

        If e.handle = 5 Then
            'Lecture de l'etat des systemes
            Dim Pompe3_ON_OFF_State As Boolean = PLC_Laporte2.get_Coil(5, 20)   'Etat ON/OFF     Pompe#3-00020   Coil 16 + 4
            Dim Pompe3_Fault_State As Boolean = PLC_Laporte2.get_Coil(5, 21)    'Etat Faute      Pompe#3-00021   Coil 16 + 5
            Dim Vacc3_ON_OFF_State As Boolean = PLC_Laporte2.get_Coil(5, 28)    'Etat ON/OFF     Vacuum#3-00028  Coil 16 + 12

            'Affichage de l'état de la pompe
            Std_Ctrl_pump3.DiscreteValue1 = Not (Pompe3_ON_OFF_State)
            Std_Ctrl_pump3.DiscreteValue2 = Pompe3_ON_OFF_State
            Std_Ctrl_pump3.DiscreteValue3 = Pompe3_Fault_State
            Lbl_faute_pump3.Visible = Pompe3_Fault_State

            'Affichage Temps total d'opération du vacuum #3
            JrVac3 = PLC_Laporte2.get_Register(1, 8) 'jour de marche vacuum 1
            HrVac3 = PLC_Laporte2.get_Register(1, 7) 'heure de marche vacuum 1
            MinVac3 = PLC_Laporte2.get_Register(1, 6) 'minutes de marche vacuum 1
            SecVac3 = PLC_Laporte2.get_Register(1, 5) 'secondes de marche vacuum 1
            LblHeureMarcheVac3.Text = String.Format("{0:D} j {1:D2} : {2:D2} : {3:D2}", JrVac3, HrVac3, MinVac3, SecVac3)

            'Affichage de l'état du vacuum
            Lbl_arr_vacc3.Visible = Not (Vacc3_ON_OFF_State) 'Affiche l'etat Arret       Vacuum#1-00999
            Lbl_mar_vacc3.Visible = Vacc3_ON_OFF_State 'Affiche l'etat Marche      Vacuum#1-01000
            StandardControlVac3.DiscreteValue1 = Not (Vacc3_ON_OFF_State)
            StandardControlVac3.DiscreteValue2 = Vacc3_ON_OFF_State

            'Affichage de la temperature
            Dim TempBit1 As Boolean = PLC_Laporte2.get_Coil(5, 22) 'Temerature bit 1 - 00022   Coil 16 + 6
            Dim TempBit2 As Boolean = PLC_Laporte2.get_Coil(5, 23) 'Temerature bit 1 - 00023   Coil 16 + 7
            Dim TempBit3 As Boolean = PLC_Laporte2.get_Coil(5, 24) 'Temerature bit 1 - 00024   Coil 16 + 8
            Dim TempBit4 As Boolean = PLC_Laporte2.get_Coil(5, 25) 'Temerature bit 1 - 00025   Coil 16 + 9
            Dim TempBit5 As Boolean = PLC_Laporte2.get_Coil(5, 26) 'Temerature bit 1 - 00026   Coil 16 + 10

            If TempBit5 Then
                LblTemperature.Text = "> 4 deg C"
                LblTemperature.BackColor = Color.Gold
            ElseIf TempBit4 Then
                LblTemperature.Text = "> 2 deg C"
                LblTemperature.BackColor = Color.Yellow
            ElseIf TempBit3 Then
                LblTemperature.Text = "> 0 deg C"
                LblTemperature.BackColor = Color.Lime
            ElseIf TempBit2 Then
                LblTemperature.Text = "> -2 deg C"
                LblTemperature.BackColor = Color.Aquamarine
            ElseIf TempBit1 Then
                LblTemperature.Text = "< -2 deg C"
                LblTemperature.BackColor = Color.LightSkyBlue
            End If

            'Gestion de l'état des pompes et acquisition de données
            AcquisitionEtatDePompe(PompeP3, Pompe3_ON_OFF_State)

        End If

        If e.handle = 6 Then 'RAZ le bouton de rearmement
            BitDeRearmement = 0  'Met OFF le bit de rearmement
            PLC_Laporte2.set_Coil(6, 0, BitDeRearmement) '(00035)Bit de rearmement mis a 0
            PLC_Laporte2.UpdateOnce(0)
        End If
    End Sub

    Private Sub AcquisitionEtatDePompe(ByVal NoPompe As Short, ByVal BitEtatMarche As Boolean)
        '---- Verifie le changement d'etat de la pompe, enregistre les temps et log les donnees dans le fichier excel a l'arret de la pompe
        Dim BitLectureEtatDeLapompe(NombreDePompe) As Boolean
        Dim PompePrefix() As String = {" Pompe 1-", " Pompe 2-", " Pompe 3-"}

        'Déactive temporairement le timer de coulée pour éviter les changenents de CouleEnCour pendant les vérifications et l'écriture des résultats
        '       TimeoutCoule.Enabled = False
        BitLectureEtatDeLapompe(NoPompe) = BitEtatMarche

        CheckTimeoutCoulee(EtatActuelDeLaPompe(PompeP1) Or EtatActuelDeLaPompe(PompeP2) Or EtatActuelDeLaPompe(PompeP3))

        If EtatActuelDeLaPompe(NoPompe) <> BitLectureEtatDeLapompe(NoPompe) Then
            'Changement d'etat
            EtatActuelDeLaPompe(NoPompe) = BitLectureEtatDeLapompe(NoPompe)
            If EtatActuelDeLaPompe(NoPompe) = True Then
                'Demarrage de la pompe  
                T1_Demarrage(NoPompe) = DateAndTime.Now
                'Noter le temps de demarrage de la pompe
                With LogData(NoPompe, 0)
                    .Description = "T. Démarrage"
                    .Valeur = T1_Demarrage(NoPompe)
                    .LettreDeLaColonne = "K"
                    .Format = "[$-F400]h:mm:ss AM/PM"
                End With
            Else
                'Arret de la pompe 
                T2_Arret(NoPompe) = DateTime.Now
                'Noter le temps d'arret de la pompe
                With LogData(NoPompe, 1)
                    .Description = "T. Arrêt "
                    .Valeur = T2_Arret(NoPompe)
                    .LettreDeLaColonne = "L"
                    .Format = "[$-F400]h:mm:ss AM/PM"
                End With

                Duree(NoPompe) = T2_Arret(NoPompe).Subtract(T1_Demarrage(NoPompe))
                'Noter la duree d'operation de la pompe
                With LogData(NoPompe, 2)
                    .Description = "Durée (sec.)"
                    .Valeur = Duree(NoPompe).TotalSeconds
                    .LettreDeLaColonne = "C"
                    .Format = "0.00"
                End With

                Cycle(NoPompe) = T2_Arret(NoPompe).Subtract(T0_DebutDeCycle(NoPompe))
                'Noter le pourcentage d'utilisation de la pompe
                With LogData(NoPompe, 3)
                    .Description = "% Utilisation"
                    .Valeur = Duree(NoPompe).TotalSeconds / Cycle(NoPompe).TotalSeconds
                    .LettreDeLaColonne = "F"
                    .Format = "0.0%"
                End With
                'Noter la temperature
                With LogData(NoPompe, 4)
                    .Description = "Temperature"
                    .Valeur = LblTemperature.Text
                    .LettreDeLaColonne = "H"
                    .Format = ""
                End With
                'Noter la duree d<operation du vacuum
                With LogData(NoPompe, 5)
                    .Description = "Duree operation vacuum"
                    If NoPompe = PompeP1 Then
                        .Valeur = LblHeureMarcheVac1.Text
                    ElseIf NoPompe = PompeP2 Then
                        .Valeur = LblHeureMarcheVac2.Text
                    Else
                        .Valeur = LblHeureMarcheVac3.Text
                    End If
                    .LettreDeLaColonne = "I"
                    '.Format = ""
                End With
                'Noter la duree d'operation de l'osmose
                With LogData(NoPompe, 6)
                    .Description = "Duree operation osmose"
                    .Valeur = LblHeureMarcheOsm1.Text
                    .LettreDeLaColonne = "J"
                    .Format = "[$-F400]h:mm:ss AM/PM"
                End With

                'Selectionner les donnees du sub-array correspondant à la pompe
                Dim DonneeLog(NombreItemALogger - 1) As Struc_LogData
                For N As Integer = 0 To NombreItemALogger - 1
                    DonneeLog(N) = LogData(NoPompe, N)
                Next
                'Ecriture des donnees dans le ficheir Excel
                ExcelLogging.NumeroDePompe = NoPompe + 1 'NoPompe est un indice pour les arrays, i.e: PompeP1 = 0 et PompeP2 = 1
                ExcelLogging.PrefixNom = My.Settings.PrefixFichierLog & PompePrefix(NoPompe)
                ExcelLogging.EcritDonneeLog(NouvelleDateRequise, DonneeLog) 'Une nouvelle date est requise seleument au début d'une nouvelle coulée
                NouvelleDateRequise = False 'On garde la même date jusqu'a la prochaine coulée
                If Not (TestMode) Then
                    TxtCheminDuFichier.Text = My.Settings.CheminFichierLog & ExcelLogging.NomDuFichierLog
                Else
                    TxtCheminDuFichier.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Test Log\" & ExcelLogging.NomDuFichierLog
                End If

                TxtMessages.Text = ExcelLogging.Message

                'Le temps de debut de cycle correspond a l'arret de la pompe
                T0_DebutDeCycle(NoPompe) = T2_Arret(NoPompe)
            End If
        End If
        '---

    End Sub

    Private Sub Cmd_connect_shefford_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_connect_shefford.Click
        Connect_PLC_Shefford() 'Demande d'ouverture de la connection ethernet TCP/IP
    End Sub

    Private Sub Cmd_connect_Laporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_connect_Laporte.Click
        Connect_PLC_Laporte2()  'Demande d'ouverture de la connection ethernet TCP/IP
    End Sub

    Private Sub Cmd_disconnect_Shefford_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_disconnect_Shefford.Click
        PLC_Shefford.CloseConnection() 'Fermeture de la connection TCP/IP
        TxtBox_mess_alm.Text = "PLC Shefford déconnecté"
    End Sub

    Private Sub Cmd_disconnect_Laporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_disconnect_Laporte.Click
        PLC_Laporte2.CloseConnection() 'Fermeture de la connection TCP/IP
        TxtBox_mess_alm.Text = "PLC Laporte déconnecté"
    End Sub

    Private Sub SheffordTimerWatchDog_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles SheffordTimerWatchDog.Tick
        'Le PLC n'a pas répondu en dedans du délais prévu. Indiqué un problème de communication.
        Dim MBAXErrorCode As Integer
        Dim MBAXBusyStatus As Boolean
        MBAXBusyStatus = PLC_Shefford.IsBusy(5)
        MBAXErrorCode = PLC_Shefford.GetLastError()
        SetBackgroundColor_Shefford(Color.Red)
    End Sub

    Private Sub LaporteTimerWatchDog_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporteTimerWatchDog.Tick
        'Le PLC n'a pas répondu en dedans du délais prévu. Indiqué un problème de communication.
        Dim MBAXErrorCode As Integer
        Dim MBAXBusyStatus As Boolean
        MBAXBusyStatus = PLC_Laporte2.IsBusy(5)
        MBAXErrorCode = PLC_Laporte2.GetLastError()
        SetBackgroundColor_Laporte(Color.Red)
    End Sub

    Private Sub CheckTimeoutCoulee(ByVal EtatDesPompes As Boolean)
        Dim DureeArretPompe(NombreDePompe) As TimeSpan
        TimeoutCoule.Enabled = False 'Arret du timer
        DureeArretPompe(PompeP1) = DateAndTime.Now.Subtract(T2_Arret(PompeP1))
        DureeArretPompe(PompeP2) = DateAndTime.Now.Subtract(T2_Arret(PompeP2))
        DureeArretPompe(PompeP3) = DateAndTime.Now.Subtract(T2_Arret(PompeP3))
        If CouleEnCour = True Then
            Dim Cond1 As Boolean = DureeArretPompe(PompeP1) > My.Settings.DelaisCouleMax
            Dim Cond2 As Boolean = DureeArretPompe(PompeP2) > My.Settings.DelaisCouleMax
            Dim Cond3 As Boolean = DureeArretPompe(PompeP3) > My.Settings.DelaisCouleMax

            If Not (EtatDesPompes) And Cond1 And Cond2 And Cond3 Then
                'Fin de coulée
                CouleEnCour = False
                DureeActuelDeCoule = DateAndTime.Now.Subtract(DateDebutDeCoulee)
                Debug.Print("Fin de coulée, durée: " & DureeActuelDeCoule.ToString)
                ExcelLogging.EcritDonneesCSV(1, "Find de coulée ; Durée ;" & DureeActuelDeCoule.ToString & ";", "Tout") 'Il fait ajouter un dernier séparateur à la fin
            Else
                'La coulée continue, mettre à jour la durée
                DureeActuelDeCoule = DateAndTime.Now.Subtract(DateDebutDeCoulee)
            End If
        Else
            If EtatDesPompes = True Then 'Debut de coulee
                CouleEnCour = True
                DateDebutDeCoulee = DateAndTime.Now
                NouvelleDateRequise = True
                Debug.Print("Début de coulée: " & DureeActuelDeCoule.ToString)
                My.Settings.NoDeCoulee = My.Settings.NoDeCoulee + 1
                My.Settings.PrefixFichierLog = "Coulee " & My.Settings.NoDeCoulee.ToString & " -"
                My.Settings.Save()
            End If

        End If
        Lbl_Coulee_en_cour.Visible = CouleEnCour
        DisplayCouleDuration()
    End Sub

    Private Sub SetBackgroundColor_Shefford(ByVal Couleur As Color)
        GrpBox_Pump1.BackColor = Couleur
        GrpBox_Pump2.BackColor = Couleur
        GrpBox_Vacc1.BackColor = Couleur
        GrpBox_Vacc2.BackColor = Couleur
        GrpBox_Osm1.BackColor = Couleur
    End Sub

    Private Sub SetBackgroundColor_Laporte(ByRef Couleur As Color)
        GrpBox_Pump3.BackColor = Couleur
        GrpBox_Vacc3.BackColor = Couleur
    End Sub

    Private Sub UpdateDebitTotal()
        Dim Total As Integer = 0
        Try
            Total = CInt(Lbl_deb_pump1.Text) + CInt(Lbl_deb_pump2.Text) + CInt(Lbl_deb_pump3.Text)
            Lbl_deb_total.Text = Total
        Catch
        End Try
    End Sub

    Private Sub Lbl_deb_pump1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lbl_deb_pump1.TextChanged
        UpdateDebitTotal()
    End Sub

    Private Sub Lbl_deb_pump2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lbl_deb_pump2.TextChanged
        UpdateDebitTotal()
    End Sub

    Private Sub Lbl_deb_pump3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lbl_deb_pump3.TextChanged
        UpdateDebitTotal()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(My.Settings.AdresseLogMeIn)
    End Sub

    Private Sub DisplayCouleDuration()
        'Affichage Temps total de coulee
        Dim JrCoule As Short = DureeActuelDeCoule.Days 'durée jour de coulée
        Dim HrCoule As Short = DureeActuelDeCoule.Hours Mod 24 'durée heure de coulée
        Dim MinCoule As Short = DureeActuelDeCoule.Minutes Mod 60 'durée minutes de coulée
        Dim SecCoule As Short = DureeActuelDeCoule.Seconds Mod 60 'durée secondes de coulée
        Lbl_Coulee_en_cour.Text = String.Format("Coulée# " & My.Settings.NoDeCoulee & " - {0:D} j {1:D2} : {2:D2} : {3:D2}", JrCoule, HrCoule, MinCoule, SecCoule)
    End Sub

    Private Sub PropertyGrid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertyGrid1.Click

    End Sub
End Class
