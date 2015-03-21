<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_Dashboard = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TrackBar_Feeling = New System.Windows.Forms.TrackBar()
        Me.Button_start = New System.Windows.Forms.Button()
        Me.Button_stop = New System.Windows.Forms.Button()
        Me.CheckBox_state = New System.Windows.Forms.CheckBox()
        Me.Button_editValues = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_Dashboard.SuspendLayout()
        CType(Me.TrackBar_Feeling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Dashboard)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(957, 578)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_Dashboard
        '
        Me.TabPage_Dashboard.Controls.Add(Me.Button_editValues)
        Me.TabPage_Dashboard.Controls.Add(Me.CheckBox_state)
        Me.TabPage_Dashboard.Controls.Add(Me.Button_stop)
        Me.TabPage_Dashboard.Controls.Add(Me.Button_start)
        Me.TabPage_Dashboard.Controls.Add(Me.TrackBar_Feeling)
        Me.TabPage_Dashboard.Controls.Add(Me.Label1)
        Me.TabPage_Dashboard.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Dashboard.Name = "TabPage_Dashboard"
        Me.TabPage_Dashboard.Size = New System.Drawing.Size(949, 552)
        Me.TabPage_Dashboard.TabIndex = 0
        Me.TabPage_Dashboard.Text = "Dashboard"
        Me.TabPage_Dashboard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(356, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Feeling"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TrackBar_Feeling
        '
        Me.TrackBar_Feeling.Enabled = False
        Me.TrackBar_Feeling.Location = New System.Drawing.Point(359, 111)
        Me.TrackBar_Feeling.Name = "TrackBar_Feeling"
        Me.TrackBar_Feeling.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar_Feeling.Size = New System.Drawing.Size(45, 237)
        Me.TrackBar_Feeling.TabIndex = 2
        '
        'Button_start
        '
        Me.Button_start.Location = New System.Drawing.Point(20, 14)
        Me.Button_start.Name = "Button_start"
        Me.Button_start.Size = New System.Drawing.Size(75, 23)
        Me.Button_start.TabIndex = 3
        Me.Button_start.Text = "Start"
        Me.Button_start.UseVisualStyleBackColor = True
        '
        'Button_stop
        '
        Me.Button_stop.Location = New System.Drawing.Point(20, 43)
        Me.Button_stop.Name = "Button_stop"
        Me.Button_stop.Size = New System.Drawing.Size(75, 23)
        Me.Button_stop.TabIndex = 4
        Me.Button_stop.Text = "Stop"
        Me.Button_stop.UseVisualStyleBackColor = True
        '
        'CheckBox_state
        '
        Me.CheckBox_state.AutoCheck = False
        Me.CheckBox_state.AutoSize = True
        Me.CheckBox_state.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox_state.Enabled = False
        Me.CheckBox_state.Location = New System.Drawing.Point(20, 72)
        Me.CheckBox_state.Name = "CheckBox_state"
        Me.CheckBox_state.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox_state.TabIndex = 5
        Me.CheckBox_state.TabStop = False
        Me.CheckBox_state.Text = "State: "
        Me.CheckBox_state.UseVisualStyleBackColor = True
        '
        'Button_editValues
        '
        Me.Button_editValues.Location = New System.Drawing.Point(134, 14)
        Me.Button_editValues.Name = "Button_editValues"
        Me.Button_editValues.Size = New System.Drawing.Size(75, 23)
        Me.Button_editValues.TabIndex = 6
        Me.Button_editValues.Text = "Edit Values"
        Me.Button_editValues.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 578)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_Dashboard.ResumeLayout(False)
        Me.TabPage_Dashboard.PerformLayout()
        CType(Me.TrackBar_Feeling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Dashboard As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TrackBar_Feeling As System.Windows.Forms.TrackBar
    Friend WithEvents CheckBox_state As System.Windows.Forms.CheckBox
    Friend WithEvents Button_stop As System.Windows.Forms.Button
    Friend WithEvents Button_start As System.Windows.Forms.Button
    Friend WithEvents Button_editValues As System.Windows.Forms.Button

End Class
