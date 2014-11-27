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
        CType(Me.AxMbaxp1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(168, 48)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(73, 20)
        Me.Text1.TabIndex = 4
        Me.Text1.Text = "100"
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(168, 80)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(113, 33)
        Me.Command2.TabIndex = 0
        Me.Command2.Text = "Write"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(8, 8)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(97, 33)
        Me.Command1.TabIndex = 1
        Me.Command1.Text = "Open Connection"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "0"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "0"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "0"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "0"
        '
        'AxMbaxp1
        '
        Me.AxMbaxp1.Enabled = True
        Me.AxMbaxp1.Location = New System.Drawing.Point(120, 128)
        Me.AxMbaxp1.Name = "AxMbaxp1"
        Me.AxMbaxp1.OcxState = CType(resources.GetObject("AxMbaxp1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMbaxp1.Size = New System.Drawing.Size(232, 40)
        Me.AxMbaxp1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(395, 207)
        Me.Controls.Add(Me.AxMbaxp1)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 24)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Form1"
        CType(Me.AxMbaxp1, System.ComponentModel.ISupportInitialize).EndInit()
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
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	Dim e As Boolean
	
	
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        'Serial connection
        AxMbaxp1.Connection() = MBAXPLib.enumConnection.Port1
        AxMbaxp1.BaudRate() = MBAXPLib.enumBaud.B9600
        AxMbaxp1.DataBits = 1 '8 Data bits
        AxMbaxp1.Parity = 0 'None parity
        AxMbaxp1.StopBits = 0 '1 Stop bits
        AxMbaxp1.ProtocolMode = 0 'RTU Mode
        AxMbaxp1.Timeout = 1000

        'TCP/IP connection
        'AxMbaxp1.Connection() = MBAXPLib.enumConnection.TCP_IP
        'AxMbaxp1.IPAddr1() = 10
        'AxMbaxp1.IPAddr2() = 5
        'AxMbaxp1.IPAddr3() = 76
        'AxMbaxp1.IPAddr4() = 3
        'AxMbaxp1.ConnectTimeout() = 3000  'ms



        e = AxMbaxp1.OpenConnection
        e = AxMbaxp1.ReadHoldingRegisters(1, 1, 0, 10, 1000) ' slave 1
        e = AxMbaxp1.ReadInputRegisters(2, 1, 0, 10, 1000) ' slave 1
        e = AxMbaxp1.ReadHoldingRegisters(3, 2, 0, 10, 1000) ' slave 2
        e = AxMbaxp1.ReadInputRegisters(4, 2, 0, 10, 1000) ' slave 2

        AxMbaxp1.UpdateEnable(1) 'start the tasks
        AxMbaxp1.UpdateEnable(2)
        AxMbaxp1.UpdateEnable(3)
        AxMbaxp1.UpdateEnable(4)

    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click ' Handle 0, slave 1, addr 0
        AxMbaxp1.UpdateOnce(0) 'Execute the task with handle 0
        e = AxMbaxp1.PresetSingleRegister(0, 1, 0, 1000) 'Use handle 0 for
        'first priority.
        'Update rate have no meaning
        'when using handle 0
        AxMbaxp1.set_Register(0, 0, Text1.Text) 'Write the value in array 0 index 0
        AxMbaxp1.UpdateOnce(0) 'Execute the task once
        'It's not possiple to use UpdateEnable nor UpdateDisable when handle 0 is used
    End Sub

    Private Sub AxMbaxp1_ResultError(ByVal sender As System.Object, ByVal e As AxMBAXPLib._DMbaxpEvents_ResultErrorEvent) Handles AxMbaxp1.ResultError
        ' In this example handle 1 is checked only
        If e.handle = 1 Then
            If e.error = 10 Then
                Label1.Text = "Timeout"
            End If
        End If

    End Sub
    'Whenever a task has finished, the ResultOk event is fired
    Private Sub AxMbaxp1_ResultOk(ByVal sender As System.Object, ByVal e As AxMBAXPLib._DMbaxpEvents_ResultOkEvent) Handles AxMbaxp1.ResultOk
        If e.handle = 1 Then
            Label1.Text = CStr(AxMbaxp1.get_Register(1, 0))
        End If
        If e.handle = 2 Then
            Label2.Text = CStr(AxMbaxp1.get_Register(2, 0))
        End If
        If e.handle = 3 Then
            Label3.Text = CStr(AxMbaxp1.get_Register(3, 0))
        End If
        If e.handle = 4 Then
            Label4.Text = CStr(AxMbaxp1.get_Register(4, 0))
        End If

    End Sub

End Class