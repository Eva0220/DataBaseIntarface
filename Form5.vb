Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Windows.Forms
Public Class Form5
    Public Sub INF()
        Dim strConn As String
        strConn = "Data Source=DESKTOP-TB6CE81\SQLEXPRESS;Initial Catalog=DeliveryService;Integrated Security=True"
        Dim cnSqlServer As New SqlClient.SqlConnection(strConn)
        Dim cmdSqlServer As New SqlClient.SqlCommand()
        Dim prmSQLParametr As SqlClient.SqlParameter
        With cmdSqlServer
            .Connection = cnSqlServer
            .CommandText = "Rezultat"
            .CommandType = CommandType.StoredProcedure
        End With
        Dim cost As Decimal
        cost = CDec(TextBox1.Text)
        prmSQLParametr = cmdSqlServer.Parameters.AddWithValue("@cost", CDec(TextBox1.Text))
        prmSQLParametr.Direction = ParameterDirection.Input
        prmSQLParametr.SqlDbType = SqlDbType.Money
        Dim paymentmark As String
        paymentmark = CStr(TextBox1.Text)
        prmSQLParametr = cmdSqlServer.Parameters.AddWithValue("@paymentmark", CStr(TextBox2.Text))
        prmSQLParametr.Direction = ParameterDirection.Input
        prmSQLParametr.SqlDbType = SqlDbType.VarChar
        prmSQLParametr = cmdSqlServer.Parameters.AddWithValue("@rez", Nothing)
        prmSQLParametr.Direction = ParameterDirection.Output
        prmSQLParametr.SqlDbType = SqlDbType.Int

        cnSqlServer.Open()
        Dim drSQLServer As SqlDataReader = cmdSqlServer.ExecuteReader
        TextBox3.Text = cmdSqlServer.Parameters("@rez").Value
        cnSqlServer.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call INF()
    End Sub
End Class