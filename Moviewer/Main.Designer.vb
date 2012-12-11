<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.cont_main = New System.Windows.Forms.Panel
        Me.btnMove = New xButton.xButton
        Me.Button2 = New System.Windows.Forms.Button
        Me.sidebar = New System.Windows.Forms.Panel
        Me.btnMovie2 = New xButton.xButton
        Me.btnMovie1 = New xButton.xButton
        Me.btnPin = New xButton.xButton
        Me.btnExit = New xButton.xButton
        Me.btnIkonize = New xButton.xButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbOpacity = New System.Windows.Forms.TrackBar
        Me.btnMore = New xButton.xButton
        Me.wmp = New AxWMPLib.AxWindowsMediaPlayer
        Me.tmrMouseCheck = New System.Windows.Forms.Timer(Me.components)
        Me.btnMovie3 = New xButton.xButton
        Me.btnBrowse = New xButton.xButton
        Me.cont_main.SuspendLayout()
        Me.sidebar.SuspendLayout()
        CType(Me.tbOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cont_main
        '
        Me.cont_main.Controls.Add(Me.btnMove)
        Me.cont_main.Controls.Add(Me.Button2)
        Me.cont_main.Controls.Add(Me.sidebar)
        Me.cont_main.Controls.Add(Me.btnMore)
        Me.cont_main.Controls.Add(Me.wmp)
        Me.cont_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cont_main.Location = New System.Drawing.Point(0, 0)
        Me.cont_main.Name = "cont_main"
        Me.cont_main.Size = New System.Drawing.Size(645, 330)
        Me.cont_main.TabIndex = 5
        '
        'btnMove
        '
        Me.btnMove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMove.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnMove.ExcludedCorners = 6
        Me.btnMove.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnMove.ForeColor = System.Drawing.Color.White
        Me.btnMove.Location = New System.Drawing.Point(595, 130)
        Me.btnMove.mmForeColor = System.Drawing.Color.White
        Me.btnMove.Name = "btnMove"
        Me.btnMove.nForeColor = System.Drawing.Color.White
        Me.btnMove.Radius = 1
        Me.btnMove.Size = New System.Drawing.Size(50, 50)
        Me.btnMove.TabIndex = 6
        Me.btnMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(338, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 53)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'sidebar
        '
        Me.sidebar.BackColor = System.Drawing.Color.White
        Me.sidebar.Controls.Add(Me.btnBrowse)
        Me.sidebar.Controls.Add(Me.btnMovie3)
        Me.sidebar.Controls.Add(Me.btnMovie2)
        Me.sidebar.Controls.Add(Me.btnMovie1)
        Me.sidebar.Controls.Add(Me.btnPin)
        Me.sidebar.Controls.Add(Me.btnExit)
        Me.sidebar.Controls.Add(Me.btnIkonize)
        Me.sidebar.Controls.Add(Me.Label1)
        Me.sidebar.Controls.Add(Me.tbOpacity)
        Me.sidebar.Dock = System.Windows.Forms.DockStyle.Right
        Me.sidebar.Location = New System.Drawing.Point(1, 0)
        Me.sidebar.Name = "sidebar"
        Me.sidebar.Size = New System.Drawing.Size(159, 330)
        Me.sidebar.TabIndex = 8
        '
        'btnMovie2
        '
        Me.btnMovie2.AutoEllipsis = True
        Me.btnMovie2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnMovie2.ExcludedCorners = 0
        Me.btnMovie2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnMovie2.ForeColor = System.Drawing.Color.Black
        Me.btnMovie2.Location = New System.Drawing.Point(3, 96)
        Me.btnMovie2.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.btnMovie2.mmForeColor = System.Drawing.Color.White
        Me.btnMovie2.Name = "btnMovie2"
        Me.btnMovie2.nForeColor = System.Drawing.Color.Black
        Me.btnMovie2.Radius = 0
        Me.btnMovie2.Size = New System.Drawing.Size(153, 26)
        Me.btnMovie2.TabIndex = 6
        Me.btnMovie2.Text = "Starred Movie 2"
        Me.btnMovie2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMovie1
        '
        Me.btnMovie1.AutoEllipsis = True
        Me.btnMovie1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnMovie1.ExcludedCorners = 12
        Me.btnMovie1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnMovie1.ForeColor = System.Drawing.Color.Black
        Me.btnMovie1.Location = New System.Drawing.Point(3, 67)
        Me.btnMovie1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.btnMovie1.mmForeColor = System.Drawing.Color.White
        Me.btnMovie1.Name = "btnMovie1"
        Me.btnMovie1.nForeColor = System.Drawing.Color.Black
        Me.btnMovie1.Radius = 1
        Me.btnMovie1.Size = New System.Drawing.Size(153, 26)
        Me.btnMovie1.TabIndex = 5
        Me.btnMovie1.Text = "Starred Movie 1"
        Me.btnMovie1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPin
        '
        Me.btnPin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnPin.ExcludedCorners = 12
        Me.btnPin.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnPin.ForeColor = System.Drawing.Color.White
        Me.btnPin.Image = Global.Moviewer.My.Resources.Resources.pinN
        Me.btnPin.Location = New System.Drawing.Point(3, 280)
        Me.btnPin.mmForeColor = System.Drawing.Color.White
        Me.btnPin.Name = "btnPin"
        Me.btnPin.nForeColor = System.Drawing.Color.White
        Me.btnPin.Radius = 1
        Me.btnPin.Size = New System.Drawing.Size(50, 50)
        Me.btnPin.TabIndex = 4
        Me.btnPin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnExit.ExcludedCorners = 12
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(109, 280)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.btnExit.mmForeColor = System.Drawing.Color.White
        Me.btnExit.Name = "btnExit"
        Me.btnExit.nForeColor = System.Drawing.Color.Black
        Me.btnExit.Radius = 1
        Me.btnExit.Size = New System.Drawing.Size(50, 50)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "..."
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnIkonize
        '
        Me.btnIkonize.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnIkonize.ExcludedCorners = 14
        Me.btnIkonize.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnIkonize.ForeColor = System.Drawing.Color.Black
        Me.btnIkonize.Location = New System.Drawing.Point(47, 209)
        Me.btnIkonize.Margin = New System.Windows.Forms.Padding(0)
        Me.btnIkonize.mmForeColor = System.Drawing.Color.White
        Me.btnIkonize.Name = "btnIkonize"
        Me.btnIkonize.nForeColor = System.Drawing.Color.White
        Me.btnIkonize.Radius = 1
        Me.btnIkonize.Size = New System.Drawing.Size(50, 50)
        Me.btnIkonize.TabIndex = 2
        Me.btnIkonize.Text = "Ikonize"
        Me.btnIkonize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnIkonize.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Opacity:"
        '
        'tbOpacity
        '
        Me.tbOpacity.BackColor = System.Drawing.Color.White
        Me.tbOpacity.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Moviewer.My.MySettings.Default, "Main_Opacity", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbOpacity.Location = New System.Drawing.Point(0, 20)
        Me.tbOpacity.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.tbOpacity.Maximum = 100
        Me.tbOpacity.Name = "tbOpacity"
        Me.tbOpacity.Size = New System.Drawing.Size(159, 45)
        Me.tbOpacity.TabIndex = 0
        Me.tbOpacity.TickFrequency = 10
        Me.tbOpacity.Value = Global.Moviewer.My.MySettings.Default.Main_Opacity
        '
        'btnMore
        '
        Me.btnMore.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnMore.ExcludedCorners = 9
        Me.btnMore.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnMore.ForeColor = System.Drawing.Color.White
        Me.btnMore.Image = Global.Moviewer.My.Resources.Resources.menu
        Me.btnMore.Location = New System.Drawing.Point(-1, 130)
        Me.btnMore.mmForeColor = System.Drawing.Color.White
        Me.btnMore.Name = "btnMore"
        Me.btnMore.nForeColor = System.Drawing.Color.White
        Me.btnMore.Radius = 1
        Me.btnMore.Size = New System.Drawing.Size(50, 50)
        Me.btnMore.TabIndex = 7
        Me.btnMore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'wmp
        '
        Me.wmp.Dock = System.Windows.Forms.DockStyle.Right
        Me.wmp.Enabled = True
        Me.wmp.Location = New System.Drawing.Point(160, 0)
        Me.wmp.Name = "wmp"
        Me.wmp.OcxState = CType(resources.GetObject("wmp.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmp.Size = New System.Drawing.Size(485, 330)
        Me.wmp.TabIndex = 6
        '
        'tmrMouseCheck
        '
        Me.tmrMouseCheck.Enabled = True
        Me.tmrMouseCheck.Interval = 10
        '
        'btnMovie3
        '
        Me.btnMovie3.AutoEllipsis = True
        Me.btnMovie3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnMovie3.ExcludedCorners = 0
        Me.btnMovie3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnMovie3.ForeColor = System.Drawing.Color.Black
        Me.btnMovie3.Location = New System.Drawing.Point(3, 125)
        Me.btnMovie3.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.btnMovie3.mmForeColor = System.Drawing.Color.White
        Me.btnMovie3.Name = "btnMovie3"
        Me.btnMovie3.nForeColor = System.Drawing.Color.Black
        Me.btnMovie3.Radius = 0
        Me.btnMovie3.Size = New System.Drawing.Size(153, 26)
        Me.btnMovie3.TabIndex = 7
        Me.btnMovie3.Text = "Starred Movie 3"
        Me.btnMovie3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnBrowse.ExcludedCorners = 12
        Me.btnBrowse.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnBrowse.Location = New System.Drawing.Point(56, 280)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.btnBrowse.mmForeColor = System.Drawing.Color.White
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.nForeColor = System.Drawing.Color.Black
        Me.btnBrowse.Radius = 1
        Me.btnBrowse.Size = New System.Drawing.Size(50, 50)
        Me.btnBrowse.TabIndex = 8
        Me.btnBrowse.Text = "×"
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(645, 330)
        Me.ControlBox = False
        Me.Controls.Add(Me.cont_main)
        Me.Name = "Main"
        Me.cont_main.ResumeLayout(False)
        Me.sidebar.ResumeLayout(False)
        Me.sidebar.PerformLayout()
        CType(Me.tbOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cont_main As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents sidebar As System.Windows.Forms.Panel
    Friend WithEvents btnMore As xButton.xButton
    Friend WithEvents wmp As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnMove As xButton.xButton
    Friend WithEvents tbOpacity As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tmrMouseCheck As System.Windows.Forms.Timer
    Friend WithEvents btnIkonize As xButton.xButton
    Friend WithEvents btnExit As xButton.xButton
    Friend WithEvents btnPin As xButton.xButton
    Friend WithEvents btnMovie1 As xButton.xButton
    Friend WithEvents btnMovie2 As xButton.xButton
    Friend WithEvents btnMovie3 As xButton.xButton
    Friend WithEvents btnBrowse As xButton.xButton

End Class
