Option Explicit
Public Sub Delete_Emails()
    Dim olApp As Outlook.Application
    Dim olNs As Outlook.NameSpace
    Dim Inbox As Outlook.MAPIFolder
    Dim Items As Outlook.Items
    Dim Filter As String
    Dim Msg As String
    Dim i As Long
    Dim olSubfolder As Outlook.MAPIFolder
    
    Set olApp = CreateObject("Outlook.Application")
    Set olNs = olApp.GetNamespace("MAPI")
    Set Inbox = olNs.GetDefaultFolder(olFolderInbox)
    Set olSubfolder = Inbox.Folders("Abdelwahab")

    
    
    Filter = "[Subject] = 'Bot Status Email-Creation Bot success' "
    Set Items = olSubfolder.Items.Restrict(Filter)
    
    Msg = Items.Count & " items in " & olSubfolder.Name & ". Delete?"
    
    If MsgBox(Msg, vbYesNo) = vbYes Then
        For i = Items.Count To 1 Step -1

            Items.Remove i
        Next
    End If
End Sub
