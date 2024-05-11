Sub RefreshAllDataAndWait()
    Dim qt As QueryTable
    Dim refreshComplete As Boolean
    
    ' Refresh all data connections
    ThisWorkbook.RefreshAll
    
    ' Wait until the data connections finish refreshing
    Application.ScreenUpdating = False
    refreshComplete = False
    
    Do Until refreshComplete
        refreshComplete = True ' Assume refresh is complete
        
        ' Check the status of each QueryTable object
        For Each qt In ThisWorkbook.Sheets(1).QueryTables ' Change the sheet index as needed
            If qt.Refreshing Then
                refreshComplete = False ' Refresh is still ongoing
                Exit For
            End If
        Next qt
        
        If Not refreshComplete Then
            DoEvents ' Allow Excel to process other events during the loop
        End If
    Loop
    
    Application.ScreenUpdating = True
    
  
    ' Display a message when the refresh is complete
    MsgBox "Data refresh is complete."
End Sub