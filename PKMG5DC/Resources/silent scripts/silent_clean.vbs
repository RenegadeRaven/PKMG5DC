Set oShell = CreateObject ("Wscript.Shell") 
if FileExists("clean.bat") then
oShell.Run "cmd /c clean.bat", 0, true
end if

Function FileExists(FilePath)
  Set fso = CreateObject("Scripting.FileSystemObject")
  If fso.FileExists(FilePath) Then
    FileExists=CBool(1)
  Else
    FileExists=CBool(0)
  End If
End Function