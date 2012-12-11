Imports xButton.Shape

Public Class Main
    Dim blnIsPinned As Boolean = False
    Dim blnMD As Boolean = False 'MD=MouseDown...Checks if the mouse is pressed in btnMove
    Dim sinX As Single 'Stores e.X in btnMove_mouseDown event
    Dim sinY As Single 'Stores e.Y in btnMove_mouseDown event

    Private Sub btnMore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMore.Click
        If Not btnMore.nTransparency = 255 Then
            btnMore.nTransparency = 255
            btnMore.Image = My.Resources.menuSpeech
            btnMore.ImageAlign = ContentAlignment.MiddleLeft
            tmrMouseCheck.Enabled = False
            If wmp.Width >= Me.ClientRectangle.Width - sidebar.Width Then
                Dim i As Integer
                For i = 0 To sidebar.Width Step 3
                    wmp.Width = wmp.Width - 3
                    btnMore.Left = wmp.Left - 11
                Next
                wmp.Width = Me.ClientRectangle.Width - sidebar.Width
                btnMore.Left = wmp.Left - 2
            End If
        Else
            tmrMouseCheck.Enabled = True
            wmp.Width = wmp.Width + 3
            btnMore.Left = wmp.Left - 1
            wmp.Refresh()
            wmp.Width = Me.ClientRectangle.Width
            sidebar.Left = -sidebar.Width
            btnMore.Left = -1
            btnMore.Image = Global.Moviewer.My.Resources.Resources.menu
            btnMore.ImageAlign = ContentAlignment.MiddleCenter
            cont_main.Refresh()
            btnMore.nTransparency = 0
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox(My.Settings.Main_Size.Height.ToString + " | " + My.Settings.Main_Size.Width.ToString)
        End
    End Sub

    Private Sub Main_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If btnMore.Left = -1 Then
            wmp.Size = Me.ClientRectangle.Size
            btnMore.Top = (Me.ClientRectangle.Height / 2) - btnMore.Height
            btnMove.Top = btnMore.Top
            btnMove.Left = Me.ClientRectangle.Width - btnMove.Width
            btnExit.Top = Me.ClientRectangle.Height - btnIkonize.Height
            btnPin.Top = btnExit.Top
            Me.Refresh()
        Else
            Call btnMore_Click(Me, New System.EventArgs)
        End If
    End Sub

    Private Sub Main_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        My.Settings.Main_Size = Me.Size
        My.Settings.Save()
    End Sub

    Private Sub tbOpacity_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbOpacity.Scroll
        Me.Opacity = tbOpacity.Value / 100
        My.Settings.Main_Opacity = tbOpacity.Value
        My.Settings.Save()
    End Sub

    Private Sub tmrMouseCheck_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMouseCheck.Tick
        Dim pos As System.Drawing.Point = MousePosition
        If pos.X >= Me.Left And pos.Y >= Me.Top And pos.X < Right And pos.Y < Me.Bottom Then
            Dim i As Integer
            If Not btnMore.Width >= 50 Then
                i = i + 5
                btnMore.Width = btnMore.Width + i
                btnMove.Left = (btnMove.Left - 10)

            Else
                btnMore.Width = 50
                btnMove.Left = Me.ClientRectangle.Width - btnMove.Width
            End If
        Else
            Dim i As Integer
            If Not btnMore.Width = 0 Then
                i = i + 5
                btnMore.Width = btnMore.Width - i
                btnMove.Left = btnMove.Left + 10
            Else
                btnMore.Width = 0
                btnMove.Left = Me.ClientRectangle.Width + btnMove.Width
            End If
        End If
    End Sub

    Private Sub btnMove_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMove.MouseDown
        blnMD = True
        sinX = e.X
        sinY = e.X
    End Sub

    Private Sub btnMove_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMove.MouseMove
        If blnMD = True Then
            Dim iTop, iLeft
            iLeft = Me.Left - (sinX - e.X)
            iTop = Me.Top - (sinY - e.Y)
            Me.Left = iLeft
            Me.Top = iTop
            Me.Cursor = Cursors.SizeAll
        End If
    End Sub

    Private Sub btnMove_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMove.MouseUp
        blnMD = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnIkonize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIkonize.Click
        'Ikonizer is a DLL module that sends the object to the desktop
        '(that's just a general description!). Based on APIs. Coded by me in VB6 
        Dim Ikonizer As IkonizerModule.Ikonizer = New IkonizerModule.Ikonizer()
        Dim Handle As Integer = cont_main.Handle.ToInt32()
        Ikonizer.SetTranslucent(Handle, 255, 200, 3)
        Ikonizer.Ikonize(Handle)
        'cont_main.Location = Me.Location
        Me.Location = cont_main.Location
        Me.Refresh()
        cont_main.Refresh()
        'blnIsIkonized = True

        Dim szF As System.Drawing.SizeF = New System.Drawing.SizeF(cont_main.Width, cont_main.Height)
        cont_main.Region = RoundedRegion(szF, 5, Corner.None) 'Rounds the panel
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        My.Settings.Save()
        End
    End Sub

    Private Sub btnPin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPin.Click
        If blnIsPinned = False Then
            btnPin.Image = My.Resources.pinSel
            Me.TopMost = True
            blnIsPinned = True
        Else
            btnPin.Image = My.Resources.pinN
            Me.TopMost = False
            blnIsPinned = False
        End If
        Me.Refresh()
    End Sub
End Class
