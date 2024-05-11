Function CopyAgent()
'
' CopyAgent Macro
'

'
    On Error GoTo Handle

    Dim currentMonth As String

    currentMonth = Format(Now, "yyyymm")
    Windows("On time Outbound Freedom.xlsx").Activate
    Sheets("Agent").Select
    Range("A2:I367").Select
    Range("A3").Activate
    Application.CutCopyMode = False
    Selection.Copy
    Windows("Master Freedom DPR.xlsx").Activate
    Sheets("On Time Outbound").Select
    Range("A4").Select
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
    Range("J10").Select
    ActiveWorkbook.Save
Handle:
    errorhandle = Err.Description & "  And error Number Is " & Err.Number
End Function 