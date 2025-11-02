Public Class Profile
    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Header info
        Dim name As String = "Jasmine"
        HelloLbl.Text = "Hello, " & name & "!"
        UserFNLbl.Text = "Jasmine"
        UserLNLbl.Text = "Raviz"
        UserEmailLbl.Text = "jassraviz2gmail.com"
        UserPhoneLbl.Text = "09123456789"
        UserCountryLbl.Text = "Philippines"
        UserProvinceLbl.Text = "Camarines Norte"
        UserMunLbl.Text = "Vinzons"
        UserBrgyLbl.Text = "Napilihan"
        UserLandmarkLbl.Text = "Sa unahan ng Brgy. Hall"

    End Sub
    Private Sub PanelRound3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ContentPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub EditInfoBtn_Click(sender As Object, e As EventArgs) Handles EditInfoBtn.Click
        Dim editInfoForm As New EditInfo()
        Dim result As DialogResult = editInfoForm.ShowDialog()
        editInfoForm.Dispose()
    End Sub

    Private Sub EditAddressBtn_Click(sender As Object, e As EventArgs) Handles EditAddressBtn.Click
        Dim editAddressForm As New EditAddress()
        Dim result As DialogResult = editAddressForm.ShowDialog()
        editAddressForm.Dispose()
    End Sub
End Class
