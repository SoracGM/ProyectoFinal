Imports System.Data.OleDb
Imports ProyectoFinal.Conexionmodul
Public Class RegistroProductos
    Private Sub RegistroProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProjectoFinalDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ProjectoFinalDataSet.Productos)

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            If Val(txtcantidad.Text) < 0 Or Val(txtprecio.Text) = 0 Then
                MessageBox.Show("No se perminten valores negativos.")
                Exit Sub

            End If
            abrirconexion()
            Dim cmd As New OleDbCommand("Insert into Productos(Nombre, Cantidad, Precio) Values(?, ?, ?)", conexion)
            cmd.Parameters.AddWithValue("?", txtnombre.Text)
            cmd.Parameters.AddWithValue("?", txtcantidad.Text)
            cmd.Parameters.AddWithValue("?", txtprecio.Text)
            cmd.ExecuteNonQuery()
            cerrarconexion()
            MsgBox("Producto fue guardado correctamente")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

End Class