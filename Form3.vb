Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DeliveryServiceDataSet.Clients". При необходимости она может быть перемещена или удалена.
        Me.ClientsTableAdapter.Fill(Me.DeliveryServiceDataSet.Clients)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button5.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim c As DataGridViewTextBoxColumn
        Select Case ListBox1.SelectedIndex
            Case 0
                c = ClientIDDataGridViewTextBoxColumn
            Case 1
                c = ClientFIODataGridViewTextBoxColumn
            Case 2
                c = ClientGenderDataGridViewTextBoxColumn
            Case 3
                c = ClientPhoneDataGridViewTextBoxColumn
            Case 4
                c = ClientPassportDataGridViewTextBoxColumn
            Case 5
                c = ClientAddressDataGridViewTextBoxColumn
        End Select
        If RadioButton2.Checked Then
            DataGridView1.Sort(c, System.ComponentModel.ListSortDirection.Descending)
        Else
            DataGridView1.Sort(c, System.ComponentModel.ListSortDirection.Ascending)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i, j As Integer
        Dim f As Boolean
        f = False
        For i = 0 To DataGridView1.ColumnCount - 1
            For j = 0 To DataGridView1.RowCount - 1
                DataGridView1.Item(i, j).Style.BackColor = Color.White
            Next j
        Next i
        For i = 0 To DataGridView1.ColumnCount - 1
            For j = 0 To DataGridView1.RowCount - 1
                If InStr(DataGridView1.Item(i, j).Value, TextBox1.Text) Then
                    DataGridView1.Item(i, j).Style.BackColor = Color.BlueViolet
                    f = True
                End If
            Next j
        Next i
        If Not f Then
            MessageBox.Show("Not found")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClientsBindingSource.Filter = "ClientFIO ='" & ClientFIOComboBox.Text & "'"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClientsBindingSource.Filter = ""
    End Sub
End Class