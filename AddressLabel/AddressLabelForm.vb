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

    'When DisplayButton is clicked -> format output and set focus to first name
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click

        Dim textBoxesList As New List(Of TextBox) From {FirstNameTextBox, LastNameTextBox, StreetAddressTextBox, CityTextBox, StateTextBox, ZipTextBox}
        Dim errorMessage As String = ""
        Dim tempZip As Integer

        'check each textbox to see if they are empty
        For Each textbox In textBoxesList
            If textbox.Text = "" Then
                errorMessage &= ($"{textbox.Name} is empty. {vbNewLine}")
                textbox.Focus()
            End If
        Next

        'Check if zip only contains numbers
        Try
            tempZip = CInt(ZipTextBox.Text)
        Catch ex As Exception
            errorMessage &= "Zip Code must contain only numbers." & vbNewLine
            If errorMessage = ("Zip Code must contain only numbers." & vbNewLine) Then
                ZipTextBox.Focus()
            End If
        End Try

        'check if StateTextBox is more or less than 2 characters long
        Select Case StateTextBox.Text.Count
            Case 2
                'character count is valid

            Case Else
                errorMessage &= "State Must only be 2 characters" & vbNewLine

        End Select



        'handle errors if there are any in errorMessage
        If errorMessage = "" Then
            'display only when all are not invalid
            DisplayLabel.Text = ($"{FirstNameTextBox.Text} {LastNameTextBox.Text} {vbNewLine}" &
                $"{StreetAddressTextBox.Text} {vbNewLine}" &
                $"{CityTextBox.Text}, {StateTextBox.Text} {ZipTextBox.Text}")

        Else
            'message user of errors
            MsgBox(errorMessage)

            'set label to default
            DisplayLabel.Text = ($"(First Name) (LastName) {vbNewLine}" &
                $"(Street Address) {vbNewLine}" &
                $"(City), (State) (Zip)")

        End If


    End Sub

End Class
