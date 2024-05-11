Sub Function (FileName as string)
'
' Macro4 Macro
'

'
    On Error GoTo Handle
    Windows("Historical Metrics Report.csv").Activate
    Range("A2:V" & Cells(Rows.Count, "V").End(xlUp).Row).Select
    Selection.Copy
    Dim currentMonth As String
    currentMonth = Format(Now, "mmmm")
    Dim f As String
    
    'f = "C:\Users\eid.50\Documents\UiPath\Ring Bot\Data\RAW DATA\Offered Voice\" & currentMonth & ".csv"

    ' Get the full name of the current month
    Workbooks.Open Filename:=FileName
    Range("A2" & Cells(Rows.Count, "A").End(xlUp).Row).Select
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
Handle:
    errorhandle = Err.Description & "  And error Number Is " & Err.Number
End Function 