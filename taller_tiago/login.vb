Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        Me.txtusuario.Focus()
    End Sub
    Private Sub login_us()
        cmd.Connection = connection.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "select id_usuarios, usuario,psw from usuarios  
                             where usuario =  '" & Me.txtusuario.Text & "'"
        cmd.CommandText = sql
        dr = cmd.ExecuteReader()
        Try
            If dr.HasRows Then
                While dr.Read

                    Me.lblnombre.Text = dr(1).ToString
                    Me.lblcontraseña.Text = dr(2).ToString
                    Me.txtcontraseña.Focus()

                End While
            Else
                MsgBox("Usuario Inexistente", Title:="tiago")
                Me.txtusuario.Clear()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub login_psw()
        If (Me.txtcontraseña.Text = Me.lblcontraseña.Text) Then
            Me.btnaceptar.Visible = True
            frmmain.Show()
            Me.Close()
        Else
            MsgBox("Los datos ingresados no son correctos", MsgBoxStyle.Critical, "Error de acceso")
            Me.txtusuario.Clear()
            Me.txtusuario.Focus()
            Me.txtcontraseña.Clear()
            Me.btnaceptar.Visible = False
            Me.txtusuario.Focus()
        End If
    End Sub
    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusuario.KeyDown
        If e.KeyData = Keys.Enter Then
            login_us()
        End If

    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontraseña.KeyDown
        If e.KeyData = Keys.Enter Then
            login_psw()
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        Me.Close()
    End Sub
End Class