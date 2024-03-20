Imports System.Runtime.InteropServices
Imports System.Threading

Public Class Worker

    Private Const GR_GDIOBJECTS As Integer = 0
    Private Const GR_USEROBJECTS As Integer = 1
    Private _thread As Thread
    Public canRun As Boolean = True

    Public Event RaisedRefresh(sender As Object, e As ThreadedRefreshEventArgs)

    Public Sub New()

    End Sub

    <DllImport("User32.dll")>
    Private Shared Function GetGuiResources(ByVal hProcess As IntPtr, ByVal uiFlags As Integer) As Integer

    End Function

    Public Sub StartRefreshingThread()
        _thread = New Thread(AddressOf ThreadedRefresh)
        _thread.Start()
    End Sub

    Public Sub StopRefreshingThread()
        _thread.Suspend()
    End Sub


    Private Sub ThreadedRefresh()
        Dim gdiObjects As Integer
        While canRun
            gdiObjects = GetGuiResources(Process.GetCurrentProcess().Handle, GR_GDIOBJECTS)
            RaiseEvent RaisedRefresh(Me, New ThreadedRefreshEventArgs(gdiObjects))
            Threading.Thread.Sleep(1000)
        End While
    End Sub

End Class
