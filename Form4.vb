Imports System.Data.SqlClient

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DeliveryServiceDataSet.Clients". При необходимости она может быть перемещена или удалена.
        Me.ClientsTableAdapter.Fill(Me.DeliveryServiceDataSet.Clients)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String
        connectionString = "Data Source=DESKTOP-TB6CE81\SQLEXPRESS;Initial Catalog=DeliveryService;Integrated Security=True"
        Dim selectCommand As String = (Me.TextBox1.Text)
        Dim conn As New SqlConnection(connectionString)
        conn.Open()
        Dim dataAdapter As New SqlDataAdapter(selectCommand, conn)
        Dim ds As New DeliveryServiceDataSet()
        dataAdapter.Fill(ds, "Clients")
        ClientsDataGridView.DataSource = ds.Tables(0)
        conn.Close()
    End Sub
End Class