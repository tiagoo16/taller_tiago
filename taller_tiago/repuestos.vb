Imports System.Data.SqlClient

Public Class repuestos
    Dim conexion As New SqlConnection("Data Source=LAPTOP-N1H31PPE\RUTA66;Initial Catalog=taller_tiago;Integrated Security=false; user id=sa;password=2022")
    Dim sentencia, mensaje As String
    Private Sub propietarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub Mostrar()
        Dim da As New SqlDataAdapter("select * from repuestos", conexion)
        Dim ds As New DataSet

        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        conexion.Close()
    End Sub

    Sub EjecutarSql(sql As String, msg As String)
        Try
            Dim cmd As New SqlCommand(sql, conexion)
            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btninsertr_Click(sender As Object, e As EventArgs) Handles btninsertr.Click
        sentencia = "insert into repuestos values('" + txtid.Text + "','" + txtnombre.Text + "','" + txttelefono.Text + "')"
        mensaje = "Datos Insertados Correctamente"
        EjecutarSql(sentencia, mensaje)
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        sentencia = "update repuestos set descripcion_rep='" + txtnombre.Text + "',importe_rep='" + txttelefono.Text + "'where cod_repuesto='" + txtid.Text + "'"
        mensaje = "Datos Actualizados correctamente"
        EjecutarSql(sentencia, mensaje)
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        sentencia = "delete from repuestos where cod_repuesto='" + txtid.Text + "'"
        mensaje = "Datos eliminados correctamente"
        EjecutarSql(sentencia, mensaje)
    End Sub

    Private Sub BTNMOSTRAR_Click(sender As Object, e As EventArgs) Handles BTNMOSTRAR.Click
        Mostrar()
    End Sub
End Class