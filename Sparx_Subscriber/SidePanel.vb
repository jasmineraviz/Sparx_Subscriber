Public Class SidePanel

    Sub childControl(ByVal panelControl As UserControl)
        MainPanel.Controls.Clear()
        panelControl.Dock = DockStyle.Fill
        MainPanel.Controls.Add(panelControl)
        panelControl.BringToFront()
    End Sub

    Private Sub SetHeader(title As String)
        HeaderLbl.Text = title
    End Sub

    Private Sub SidePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Username.Text = "Jasmine Raviz"
        Email.Text = "jasss@gmail.com"

        HeaderPanel.Visible = True
        SetHeader("Welcome")
    End Sub

    ' default color of button kapag di pa naki-click
    Private defaultBackColor As Color = Color.FromArgb(29, 41, 61)
    Private activeButton As Button = Nothing


    'kapag na-click na ang button, machange na ang color
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles ProfileButton.Click, HistoryButton.Click
        If activeButton IsNot Nothing Then
            activeButton.BackColor = defaultBackColor
        End If

        Dim clickedButton = TryCast(sender, Button)
        If clickedButton IsNot Nothing Then
            clickedButton.BackColor = Color.FromArgb(24, 93, 252)
            activeButton = clickedButton
        End If
    End Sub

    Private Sub ProfileButton_Click(sender As Object, e As EventArgs) Handles ProfileButton.Click
        Dim profile As New Profile()
        childControl(profile)
        HeaderPanel.Visible = True
        SetHeader("My Profile")
    End Sub

    Private Sub HistoryButton_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click
        Dim history As New History()
        childControl(history)
        HeaderPanel.Visible = True
        SetHeader("History")
    End Sub

End Class
