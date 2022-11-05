Imports System.IO
Public Class Form1


    Sub install(sender As Button, FileName As String, argument As String)
        sender.Enabled = False
        Panel1.Enabled = False

        Dim installerFilePath As String = Application.StartupPath & "\Setup\" & FileName
        Dim p As New System.Diagnostics.ProcessStartInfo

        p.FileName = installerFilePath
        p.Arguments = argument
        'p.WindowStyle = ProcessWindowStyle.Maximized
        Dim processObj As Process = Process.Start(p)

        'Label1.ForeColor = Color.Black
        Label1.Text &= "Please wait while installing " & FileName & " ..." & vbCrLf
        Do While Not processObj.WaitForExit(1000)
            processObj.Refresh()
            Application.DoEvents()
            If ProgressBar1.Value = 100 Then
                ProgressBar1.Value = 0
            End If
            ProgressBar1.Value += 1
        Loop

        Me.Cursor = Cursors.Default
        If processObj.ExitCode = 0 Then
            'Label1.ForeColor = Color.Green
            Label1.Text &= FileName & " Successfully Installed!" & vbCrLf & vbCrLf
        Else
            sender.Enabled = True
            'Label1.ForeColor = Color.Red
            Label1.Text &= FileName & " Install Failed. . . Code: " & processObj.ExitCode.ToString & vbCrLf & vbCrLf
        End If

        For i As Integer = ProgressBar1.Value To 99
            Threading.Thread.Sleep(10)
            processObj.Refresh()
            Application.DoEvents()
            If ProgressBar1.Value < 100 Then ProgressBar1.Value += 1
        Next

        'MessageBox.Show(FileName & " done installing")

        Panel1.Enabled = True

    End Sub

    Private Sub btnFrameWork_Click(sender As Object, e As EventArgs) Handles btnFrameWork.Click
        install(sender, "dotNetFx40_Full_x86_x64.exe", "/q /norestart")
    End Sub

    Private Sub btnCrystalReport_Click(sender As Object, e As EventArgs) Handles btnCrystalReport.Click
        install(sender, "CRRuntime_32bit_13_0_10.msi", "")
    End Sub

    Private Sub btnSQL_Click(sender As Object, e As EventArgs) Handles btnSQL.Click
        'install("SQLEXPR_x86_ENU.exe", "ConfigurationFile=ConfigurationFile.INI /QS /QUIET=True /IAcceptSQLServerLicenseTerms /SAPWD=123")

        'install("SQLEXPR_x86_ENU.exe", "  /PCUSOURCE=""" & Application.StartupPath & "\Setup\Temp"" /ConfigurationFile=""" & Application.StartupPath & "\Setup\ConfigurationFile.INI""") '
        'install("SQLServer2008SP4-KB2979596-x86-ENU.exe", "  /PCUSOURCE=""" & tempFolder & """ /ConfigurationFile=""" & Application.StartupPath & "\Setup\ConfigurationFile.INI""") '

        'Dim tempFolder As String = Path.GetTempFileName().Split(".")(0)
        'If Directory.Exists(tempFolder) Then Directory.Delete(tempFolder)
        'Directory.CreateDirectory(tempFolder)
        install(sender, "SQLEXPR_x86_ENU.exe", " /ConfigurationFile=""" & Application.StartupPath & "\Setup\ConfigurationFile.INI""") '
        'Directory.Delete(tempFolder)
    End Sub

    Private Sub btnShortcut_Click(sender As Object, e As EventArgs) Handles btnShortcut.Click
        sender.Enabled = False
        Dim objShell, strDesktopPath, objLink
        objShell = CreateObject("WScript.Shell")
        strDesktopPath = objShell.SpecialFolders("Desktop")
        objLink = objShell.CreateShortcut(strDesktopPath & "\OMEGA.lnk")
        'objLink.Arguments = "c:\windows\tips.txt"
        'objLink.Description = "Shortcut to Notepad.exe"
        objLink.TargetPath = Application.StartupPath & "\OMEGA.exe"
        'objLink.WindowStyle = 1
        'objLink.WorkingDirectory = "c:\windows"
        objLink.Save()

        'Label1.ForeColor = Color.Green
        Label1.Text &= " Shortcut added :)" & vbCrLf & vbCrLf
        
        For i As Integer = ProgressBar1.Value To 99
            Threading.Thread.Sleep(10)
            Application.DoEvents()
            If ProgressBar1.Value < 100 Then ProgressBar1.Value += 1
        Next

    End Sub

    Private Sub btnSetupAll_Click(sender As Object, e As EventArgs) Handles btnSetupAll.Click
        btnSetupAll.Enabled = False

        btnFrameWork_Click(btnFrameWork, Nothing)
        btnCrystalReport_Click(btnCrystalReport, Nothing)
        btnSQL_Click(btnSQL, Nothing)
        btnShortcut_Click(btnShortcut, Nothing)
        Label1.Text &= " All setup Done :)" & vbCrLf & vbCrLf

        btnSetupAll.Enabled = True
    End Sub


End Class
