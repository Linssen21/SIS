
Module ModConnection


    Public conStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.Environment.CurrentDirectory + "\StudentInfoDB1.accdb"
    '  Public con As New OleDb.OleDbConnection(conStr)
    Public Sub RecordRow(ByVal sql As String)
        Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection(conStr)
        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        cmd.Connection = con
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Sub RecordRow1(ByVal sql As String)
        Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection(conStr)
        Dim cmd As New OleDb.OleDbCommand

        Dim queryResult As Integer

        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        cmd.Connection = con
        con.Open()
        queryResult = cmd.ExecuteNonQuery()
        con.Close()
    End Sub



    Public Function DTTable(ByVal sql As String, ByVal tName As String, ByVal filter As String) As DataTable
        Dim connection As New OleDb.OleDbConnection(conStr)
        Dim dataAdapter As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        dataAdapter = New OleDb.OleDbDataAdapter(sql + " FROM " + tName & "" + filter, connection)
        dataAdapter.Fill(ds, tName)
        Return ds.Tables(tName)
    End Function

End Module
