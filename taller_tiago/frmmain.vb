Public Class frmmain
    Private Sub PropietariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropietariosToolStripMenuItem.Click
        Dim frm As New propietarios
        propietarios.ShowDialog()
    End Sub

    Private Sub EspecialidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspecialidadesToolStripMenuItem.Click
        Dim frm As New especialidades
        especialidades.ShowDialog()
    End Sub

    Private Sub RepuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepuestosToolStripMenuItem.Click
        Dim frm As New repuestos
        repuestos.ShowDialog()
    End Sub
End Class