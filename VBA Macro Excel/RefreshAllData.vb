Sub RefreshAllData()

   ThisWorkbook.Queries.FastCombine = True


    Dim ws As Worksheet
    Dim tbl As ListObject
    
    On Error Resume Next
    
    For Each ws In ThisWorkbook.Worksheets
        ws.Unprotect
        
        For Each tbl In ws.ListObjects
            tbl.QueryTable.BackgroundQuery = False ' Disable background query for the specific query table
            tbl.QueryTable.Refresh ' Refresh the query table
        Next tbl

    Next ws
    
    On Error GoTo 0
    Range("A2").Select
    ActiveWorkbook.Save
End Sub
