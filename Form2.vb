Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DeliveryServiceDataSet.Clients". При необходимости она может быть перемещена или удалена.
        Me.ClientsTableAdapter.Fill(Me.DeliveryServiceDataSet.Clients)

    End Sub

    Private Sub ClientIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles ClientIDTextBox.TextChanged

    End Sub
    Private Sub ClientFIOTextBox_TextChanged(sender As Object, e As EventArgs) Handles ClientFIOTextBox.TextChanged

    End Sub

    Private Sub ClientGenderTextBox_TextChanged(sender As Object, e As EventArgs) Handles ClientGenderTextBox.TextChanged

    End Sub

    Private Sub ClientPhoneTextBox_TextChanged(sender As Object, e As EventArgs) Handles ClientPhoneTextBox.TextChanged

    End Sub

    Private Sub ClientPassportTextBox_TextChanged(sender As Object, e As EventArgs) Handles ClientPassportTextBox.TextChanged

    End Sub

    Private Sub ClientAddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles ClientAddressTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClientsBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClientsBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClientsBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClientsBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ClientsBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ClientsBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
