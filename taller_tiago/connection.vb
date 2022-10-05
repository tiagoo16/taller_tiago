Module connection
    Public conexion As New SqlClient.SqlConnection("Data Source=LAPTOP-N1H31PPE\RUTA66;Initial Catalog=taller_tiago;Integrated Security=false; user id=sa;password=2022")
    Public cmd As New SqlClient.SqlCommand
    Public dr As SqlClient.SqlDataReader
    Public Sub conectar()
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
