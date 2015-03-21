Public Class Form1

    Dim feeling As Integer = 5

    Private Sub initiation() Handles Me.Load



    End Sub

    Public Sub start()

        Button_editValues.Enabled = False
        CheckBox_state.CheckState = CheckState.Indeterminate
        Timer1.Start()
        CheckBox_state.CheckState = CheckState.Checked

    End Sub

    Public Sub stopp()

        CheckBox_state.CheckState = CheckState.Indeterminate
        Timer1.Stop()
        CheckBox_state.CheckState = CheckState.Unchecked
        Button_editValues.Enabled = True

    End Sub

    Private Sub Button_start_Click(sender As Object, e As EventArgs) Handles Button_start.Click
        start()
    End Sub

    Private Sub Button_stop_Click(sender As Object, e As EventArgs) Handles Button_stop.Click
        stopp()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        TrackBar_Feeling.Value = feeling
    End Sub

    Private Sub Button_editValues_Click(sender As Object, e As EventArgs) Handles Button_editValues.Click

        If Button_editValues.Text = "Done" Then
            Button_editValues.Text = "Please Wait..."
            Button_editValues.Enabled = False
            TrackBar_Feeling.Enabled = False
            feeling = TrackBar_Feeling.Value
            ' set other values
            Button_editValues.Text = "Edit Values"
            Button_editValues.Enabled = True
            Button_start.Enabled = True
            Button_stop.Enabled = True
        Else
            If MsgBox("!!! Warning !!!" & vbCrLf & "Bla Bla Bla" & vbCrLf & "Comming Soon...", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Button_start.Enabled = False
                Button_stop.Enabled = False
                Button_editValues.Text = "Done"
                TrackBar_Feeling.Enabled = True
            End If
        End If

    End Sub
End Class
