Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Module ModuloBD
#Region "Variables"
    Public x, y, n As Integer
    Public nom_servidor, nom_bd As String
    Public conexion As SqlConnection
    Public presupuesto, consulta As String
    Public reader As SqlDataReader
    Public dt As DataTable
    Public adaptador As New SqlDataAdapter
    Public comando As SqlCommand
    Public claveReporte, sentenciaHtml As String
    'Acccess
    Public str, Tipousuario, departamento, trimestre As String

    Public dset As New DataSet
    Public myarray As New ArrayList
    Dim provedor As String
    Dim adaptadorAcces As OleDbDataAdapter
    Public conexionAcces, conexionAcces2 As OleDbConnection
    Dim comandoacces As OleDbCommand
    Dim readerAcces As OleDbDataReader
    Public lector1, lector2 As OleDbDataReader
    Dim drow As DataRow
    Dim connectionString As String
    Public montofinal As Integer
#End Region

#Region "Metodos"
    Public Sub conectarAccess()
        Try
            provedor = Application.StartupPath & "\v.a.o.accdb"

            conexionAcces = New OleDbConnection()
            conexionAcces.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & provedor & "; Persist Security Info=False "

            conexionAcces.Open()
            'MsgBox("Conexion realizada con exito", MsgBoxStyle.Information Or MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub desconectar()
        conexionAcces.Close()
    End Sub
    Public Sub guardar(ByVal sentencia)
        Call conectarAccess()
        comandoacces = New OleDbCommand(sentencia, conexionAcces)


        With comandoacces
            .ExecuteNonQuery()
        End With


        conexionAcces.Close()
    End Sub

    Public Sub cargarCombo(ByVal combo As ComboBox, ByVal consulta As String)
        Call conectarAccess()

        adaptadorAcces = New OleDbDataAdapter(consulta, conexionAcces)
        dt = New DataTable()
        adaptadorAcces.Fill(dt)
        If dt.Rows.Count > 0 Then
            combo.DataSource = dt
            combo.ValueMember = dt.Columns(0).ToString()

        End If
        conexionAcces.Close()
    End Sub
    Public Function StrReader(ByVal sentencia As String) As String
        conectarAccess()
        str = ""
        consulta = sentencia
        comandoacces = New OleDbCommand(consulta, conexionAcces)
        readerAcces = comandoacces.ExecuteReader()
        Try

            While (readerAcces.Read())
                str = readerAcces(0).ToString()
            End While
            If str = "" Then
                str = "0"
            End If


            readerAcces.Close()
            conexionAcces.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return str.Trim
    End Function
    Public Sub cargarList(ByVal lista As ListBox, ByVal consulta As String)
        Call conectarAccess()
        adaptadorAcces = New OleDbDataAdapter(consulta, conexionAcces)
        dt = New DataTable()
        adaptadorAcces.Fill(dt)
        If dt.Rows.Count > 0 Then
            lista.DataSource = dt
            lista.ValueMember = dt.Columns(0).ToString()
        End If
    End Sub
    Public Sub cargarDataGrid(ByVal DataG As DataGridView, ByVal consulta As String)
        Call conectarAccess()
        Try
            Dim registros As New DataSet
            adaptadorAcces = New OleDbDataAdapter(consulta, conexionAcces)
            registros.Tables.Add("OFRENDAS")

            adaptadorAcces.Fill(registros.Tables("OFRENDAS"))
            DataG.DataSource = registros.Tables("OFRENDAS")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public Function ArrayAcces(ByVal sentencia As String) As OleDbDataReader
        consulta = sentencia
        conectarAccess()
        comandoacces = New OleDbCommand(consulta, conexionAcces)
        readerAcces = comandoacces.ExecuteReader()
        If readerAcces.HasRows Then
            readerAcces.Read()
        End If

        Return readerAcces
    End Function

    Public Function ArrayAcces2(ByVal sentencia As String) As OleDbDataReader
        consulta = sentencia
        conectarAccess()
        comandoacces = New OleDbCommand(consulta, conexionAcces)
        readerAcces = comandoacces.ExecuteReader()
        If readerAcces.HasRows Then
            readerAcces.Read()
        End If

        Return readerAcces
    End Function
#End Region

End Module
