Option Explicit On
Option Strict On
'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Address label program
'https://github.com/AftaAnfi/AddressLabel.git

Public Class AddressLabelForm

    'exit button event -> close program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'set all TextBoxes to empty
    Sub ClearAllTextBoxes()
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
    End Sub

    'When ClearButton is pressed -> clear all input boxes
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ClearAllTextBoxes()
    End Sub
End Class
