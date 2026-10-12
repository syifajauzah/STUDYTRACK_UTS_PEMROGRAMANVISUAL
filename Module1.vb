Imports System.Data

Module Module1

    Public TabelTugas As New DataTable()

    Public Sub SiapkanData()
        If TabelTugas.Columns.Count = 0 Then
            TabelTugas.Columns.Add("ID", GetType(Integer))
            TabelTugas.Columns.Add("Nama Tugas")
            TabelTugas.Columns.Add("Mata Kuliah")
            TabelTugas.Columns.Add("Deadline", GetType(Date))
            TabelTugas.Columns.Add("Prioritas")
            TabelTugas.Columns.Add("Catatan")
            TabelTugas.Columns.Add("Status")
        End If
    End Sub

End Module
