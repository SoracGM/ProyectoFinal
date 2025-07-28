Imports System.Data.OleDb
Module Conexionmodul
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Source\Repos\ProyectoFinal\ProyectoFinal\ProjectoFinal.mdb")
    Public Sub abrirconexion()
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
    End Sub
    Public Sub cerrarconexion()
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub

End Module
