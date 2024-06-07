Imports System.Runtime.InteropServices
Imports System.Threading

Public Class FrmMain

    Private worker As New Worker()
    Private _isCLosing As Boolean = False

    Private _forms As New List(Of Form)


    Private Sub mainForm_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _isCLosing = True
        worker.canRun = False
        Thread.Sleep(1000)
        RemoveHandler worker.RaisedRefresh, AddressOf OnRaisedRefresh
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler worker.RaisedRefresh, AddressOf OnRaisedRefresh
        worker.StartRefreshingThread()
    End Sub

    Private Sub OnRaisedRefresh(sender As Object, e As ThreadedRefreshEventArgs)
        RefreshInfo(e._value)
    End Sub

    Private Sub btnCloseForms_Click(sender As Object, e As EventArgs) Handles btnCloseForms.Click
        For Each currentForm As Form In _forms
            currentForm.Close()
        Next
    End Sub

    Private Sub btnForm_Click(sender As Object, e As EventArgs) Handles btnForm.Click
        Dim frmTest As New FrmTest
        frmTest.Show()
        _forms.Add(frmTest)
    End Sub

    Private Sub RefreshInfo(Optional count As Integer = 0)
        If Not _isCLosing Then
            lblInfo.Invoke(Sub() lblInfo.Text = String.Format("GDI OBJECTS: {0}", count))
        End If
    End Sub


End Class
