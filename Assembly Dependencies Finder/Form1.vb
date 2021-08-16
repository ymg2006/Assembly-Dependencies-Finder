Imports System.IO
Imports System.Reflection
Imports Telerik.WinControls

Public Class Form1
#Region "fafa"
    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click
        If (Me.OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            If IsAssembly(Me.OpenFileDialog1.FileName) Then
                txtAssemAddress.Text = OpenFileDialog1.FileName
            Else
                RadMessageBox.Show("Please Select An .Net Assembly", String.Empty, MessageBoxButtons.OK, RadMessageIcon.Error)
            End If
        End If
    End Sub

    Private Sub GetDepenBtn_Click(sender As Object, e As EventArgs) Handles GetDepenBtn.Click
        lblAssemList.Items.Clear()
        Dim strs As List(Of String) = GetReferencedAssemblies(txtAssemAddress.Text, cbExcludeDotNetAssemblies.Checked, cbIgnoreNotFound.Checked, New List(Of String))
        If strs IsNot Nothing Then
            For Each Str As String In strs
                lblAssemList.Items.Add(Str)
            Next
            RadMessageBox.Show("Found " & Me.lblAssemList.Items.Count & " Assemblies !", String.Empty, MessageBoxButtons.OK, RadMessageIcon.Info)
            CopyBtn.Enabled = True
        Else
            CopyBtn.Enabled = False
        End If
    End Sub

            ''' <summary>
        ''' Finds Referenced Assemblies Of File
        ''' </summary>
        ''' <param name="asmFile"><c><seealso cref="String">Must define File Location of Assemblies
        ''' </seealso></c></param>
        ''' <param name="excludeDotNetAssemblies"><c><seealso cref="Boolean">Exclude Microsoft .Net Framework Assemblies
        ''' </seealso></c></param>
        ''' <remarks></remarks>
        Public Shared Function GetReferencedAssemblies(ByVal asmFile As String, ByVal excludeDotNetAssemblies As Boolean, ByVal cbIgnoreNotFound As Boolean, ByVal alreadyAnalyzed As List(Of String)) As List(Of String)
            Dim source As New List(Of String)
            Try
                Dim referencedAssemblies As AssemblyName() = Assembly.LoadFile(asmFile).GetReferencedAssemblies
                Dim name As AssemblyName
                Dim flag As Boolean = cbIgnoreNotFound
                For Each name In referencedAssemblies
                    Try
                        Dim assembly2 As Assembly = Assembly.Load(name)
                        Dim versionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(assembly2.Location)
                        If excludeDotNetAssemblies Then
                            If Not versionInfo.ProductName.ToLower.Contains("Microsoft® .NET Framework".ToLower) Then
                                source.Add(assembly2.Location)
                            End If
                        Else
                            source.Add(assembly2.Location)
                        End If
                    Catch exception1 As Exception

                        Dim str As String
                        For Each str In Directory.GetFiles(Path.GetDirectoryName(asmFile))
                            Try
                                If (Assembly.LoadFile(str).FullName = name.FullName) Then
                                    source.Add(str)
                                    flag = True
                                    Exit For
                                End If
                            Catch exception2 As Exception
                            End Try
                        Next
                        If Not flag Then
                            Dim openFileDlg As OpenFileDialog = New OpenFileDialog With {
                                .Filter = ".Net Assembly File (.exe,.dll)|*.exe;*.dll",
                                .Title = "Can not find """ & name.Name & """ Assembly, please give src manually !"
                            }
                            If (openFileDlg.ShowDialog = DialogResult.OK) Then
                                source.Add(openFileDlg.FileName)
                            Else
                                source.Add(name.FullName)
                            End If
                        Else
                            source.Add(name.FullName)
                        End If
                    End Try
                Next
                alreadyAnalyzed.Add(asmFile)
                Dim collection As New List(Of String)
                Dim str2 As String
                For Each str2 In (From p In source
                                  Where (alreadyAnalyzed.IndexOf(p) < 0)
                                  Select p)
                    If File.Exists(str2) Then
                        collection.AddRange(GetReferencedAssemblies(str2, excludeDotNetAssemblies, flag, alreadyAnalyzed))
                    End If
                Next
                source.AddRange(collection)
                Return Enumerable.ToList(Of String)((From p In Enumerable.Distinct(Of String)(source) Order By p
                                                     Select p))
            Catch ex As Exception
                Return Nothing
            End Try
        End Function


    Private Sub CopyBtn_Click(sender As Object, e As EventArgs) Handles CopyBtn.Click
        If (FolderBrowserDialog1.ShowDialog = DialogResult.OK) Then
            For Each Item In Me.lblAssemList.Items
                If File.Exists(Item.Value.ToString) Then
                    File.Copy(Item.Value.ToString, (FolderBrowserDialog1.SelectedPath.TrimEnd(New Char() {"\"c}) & "\" & Path.GetFileName(Item.Value.ToString)))
                End If
            Next
            RadMessageBox.Show("All file(s) has been copied !", String.Empty, MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub
    Private Function IsAssembly(Src As String) As Boolean
        Try
            Dim testAssembly As AssemblyName = AssemblyName.GetAssemblyName(Src)
            Return True
        Catch ex As FileNotFoundException
            Return False
        Catch ex As BadImageFormatException
            Return False
        End Try
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CopyBtn.Enabled = False
    End Sub
#End Region

End Class
