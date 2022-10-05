Imports System.Data.SqlClient
Imports System.Data

Public Class conexion
    Private cadena As String = ("Data Source=LAPTOP-N1H31PPE\RUTA66;Initial Catalog=taller_tiago;Integrated Security=false; user id=sa;password=2022")
    Public cn As SqlConnection
    Private cmb As SqlCommandBuilder

    Private Sub conectar()
        cn = New SqlConnection(cadena)
    End Sub
    Public Sub New()
        conectar()
    End Sub
    Private comando As SqlCommand
    'insertar
    Public Function insertar(sql As String) As Boolean
        cn.Open()
        comando = New SqlCommand(sql, cn)
        Dim i As Integer = comando.ExecuteNonQuery()
        cn.Close()
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    'eliminar
    Public Function eliminar(tabla As String, condicion As String) As Boolean
        cn.Open()
        Dim sql As String = "delete from " & tabla & "where " & condicion
        comando = New SqlCommand(sql, cn)
        Dim i As Integer = comando.ExecuteNonQuery()
        cn.Close()
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    'actualizar
    Public Function actualizar(tabla As String, campos As String, condicion As String) As Boolean
        cn.Open()
        Dim sql As String = "update " & tabla & "set " & campos & "where " & condicion
        comando = New SqlCommand(sql, cn)
        Dim i As Integer = comando.ExecuteNonQuery()
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    'consultar
    Public ds As New DataSet()
    Public da As New SqlDataAdapter
    Public Sub consultar(sql As String, tabla As String)
        ds.Clear()
        da = New SqlDataAdapter(sql, cn)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Public Function consultar2(tabla As String) As DataTable
        Dim sql As String = "select * from " & tabla
        da = New SqlDataAdapter(sql, cn)
        Dim dts As New DataSet()
        da.Fill(dts, tabla)
        Dim dt As New DataTable()
        dt = dts.Tables(tabla)
        Return dt
    End Function
End Class
