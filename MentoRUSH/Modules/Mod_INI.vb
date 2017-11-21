Module Mod_INI

    'Get Settings from INI file.
    Public Function INIGet(ByVal Section As String, ByVal AppName As String, ByVal DefaultValue As String, ByVal FileName As String) As String
        Dim Str As String = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, DefaultValue, Str, Len(Str), FileName)
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function

    'Write Setings to INI file.
    Public Function INIWrite(ByVal Section As String, ByVal AppName As String, ByVal Value As String, ByVal FileName As String) As Long
        INIWrite = WritePrivateProfileString(Section, AppName, Value, FileName)
    End Function

    'READ INI API
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    'WRITE INI API
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32

End Module
