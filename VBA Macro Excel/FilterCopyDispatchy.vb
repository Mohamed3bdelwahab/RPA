Sub FilterCopyDispatchy()
'
' Macro1 Macro
'
    Windows("TELEPERFORMANCE.csv").Activate
    Dim currentMonth As String
    currentMonth = Format(Now, "yyyymm")
    Dim ws As Worksheet
    Set ws = ActiveSheet ' This sets the ws variable to the active sheet

    ' Now you can work with the 'ws' variable, which represents the active sheet
    ' For example:
    MsgBox "Active sheet name: " & ws.Name
    Dim headerRange As Range
    Set headerRange = ws.Range("A1") ' Replace "lob" with the actual header cell reference

    
    Dim lastRow As Long
    lastRow = headerRange.Parent.Cells(headerRange.Parent.Rows.Count, headerRange.Column).End(xlUp).Row
 
    Dim dataRange As Range
    Set dataRange = headerRange.Offset(1).Resize(lastRow - headerRange.Row)

    dataRange.AutoFilter Field:=headerRange.Column, Criteria1:=Array(currentMonth), Operator:=xlFilterValues
    
    Set headerRange = ws.Range("F1") ' Replace "lob" with the actual header cell reference
    dataRange.AutoFilter Field:=headerRange.Column, Criteria1:=Array("TELEPERFORMANCE-CAIRO-EG"), Operator:=xlFilterValues
    Range("A2:CE2").Select
    Range("CE2").Activate
    Range(Selection, Selection.End(xlDown)).Select
    Selection.Copy
    Windows("Dispatch Accuracy_.xlsm").Activate
    Range("A2").Select
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
    
    

End Sub
