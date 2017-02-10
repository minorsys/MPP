Public Class frmProgressSyakenMenkyo



    '車検証のダウンロード　frmGrdから呼び出す
    Public Sub Syaken_DownLoad()
        Me.Show()

        lblMessage.Text = "ファイルをダウンロードしています"

        'ファイルを出力するためのフォルダを作成する
        Dim folderpath As String
        folderpath = DateTime.Now.ToString("yyyy-MM-dd HHmmss")
        System.IO.Directory.CreateDirectory("C:\MPP\Exports\" & folderpath & "\車検証")
        'System.IO.Directory.CreateDirectory("C:\MPP\Exports\" & folderpath & "\免許証")

        '見つからなかったファイル名をためる用
        Dim errmsg As String = ""

        'プログレスバーのプロパティ
        Dim pgbMax As Long = frmGrd.grdMain.GetCellCount(DataGridViewElementStates.Selected)

        pgbLoading.Maximum = pgbMax * 2
        pgbLoading.Minimum = 0
        pgbLoading.Step = 1


        '選択されている各行について、
        For Each c As DataGridViewCell In frmGrd.grdMain.SelectedCells


            '選択されている行の車番を取得する


            Dim selectedCarnum As String
            selectedCarnum = frmGrd.grdMain.Item(2, c.RowIndex).Value.ToString()

            '選択されている行の氏名を取得する
            'Dim selectedStaff As String
            'selectedStaff = frmGrd.grdMain.Item(4, c.RowIndex).Value.ToString

            If Not selectedCarnum = "" Then
                '取得した車番からはじまるファイル名をもつファイルを検索する
                Dim files As System.Collections.ObjectModel.ReadOnlyCollection(Of String) =
                 My.Computer.FileSystem.GetFiles(
                 "\\192.168.8.190\share\system\syaken",
                  FileIO.SearchOption.SearchTopLevelOnly,
                 "" & selectedCarnum & "*")

                '見つからなかったら、エラーメッセージに車番を追加する
                If files.Count = 0 Then
                    errmsg += vbCrLf & selectedCarnum
                Else


                    '該当ファイルをコピーする
                    For Each f As String In files

                        System.IO.File.Copy(f, "C:\MPP\Exports\" & folderpath & "\車検証\" & selectedCarnum & ".pdf")
                        pgbLoading.PerformStep()
                    Next

                End If

            End If

            'If Not selectedStaff = "" Then
            '    '取得した氏名からはじまるファイル名をもつファイルを検索する


            '    Dim files As System.Collections.ObjectModel.ReadOnlyCollection(Of String) =
            '     My.Computer.FileSystem.GetFiles(
            '     "\\192.168.8.190\share\system\menkyo",
            '      FileIO.SearchOption.SearchTopLevelOnly,
            '     "" & selectedStaff & "*")

            '    If files.Count = 0 Then
            '        errmsg += vbCrLf & selectedStaff
            '    Else
            '        '該当ファイルをコピーする
            '        For Each f As String In files
            '            System.IO.File.Copy(f, "C:\MPP\Exports\" & folderpath & "\免許証\" & selectedStaff & ".pdf")
            '            pgbLoading.PerformStep()
            '        Next

            '    End If

            'End If

        Next c

        '見つからなかった車検証があれば、エラーメッセージを表示
        If Not errmsg = "" Then
            errmsg = "以下のファイルは見つかりませんでした:" & errmsg
            MsgBox(errmsg)
        End If

        'エクスポートしたフォルダを表示する
        System.Diagnostics.Process.Start("C:\MPP\Exports\" & folderpath & "")

        Me.Close()
    End Sub

    '免許証のダウンロード　frmGrdから呼び出す
    Public Sub Menkyo_Download()
        Me.Show()

        lblMessage.Text = "ファイルをダウンロードしています"

        'ファイルを出力するためのフォルダを作成する
        Dim folderpath As String
        folderpath = DateTime.Now.ToString("yyyy-MM-dd HHmmss")
        System.IO.Directory.CreateDirectory("C:\MPP\Exports\" & folderpath & "\免許証")

        '見つからなかったファイル名をためる用
        Dim errmsg As String = ""

        'プログレスバーのプロパティ
        Dim pgbMax As Long = frmGrd.grdMain.GetCellCount(DataGridViewElementStates.Selected)

        pgbLoading.Maximum = pgbMax * 2
        pgbLoading.Minimum = 0
        pgbLoading.Step = 1


        '選択されている各行について、
        For Each c As DataGridViewCell In frmGrd.grdMain.SelectedCells



            '選択されている行の氏名を取得する
            Dim selectedStaff As String
            selectedStaff = frmGrd.grdMain.Item(4, c.RowIndex).Value.ToString


            If Not selectedStaff = "" Then
                '取得した氏名からはじまるファイル名をもつファイルを検索する


                Dim files As System.Collections.ObjectModel.ReadOnlyCollection(Of String) =
                 My.Computer.FileSystem.GetFiles(
                 "\\192.168.8.190\share\system\menkyo",
                  FileIO.SearchOption.SearchTopLevelOnly,
                 "" & selectedStaff & "*")

                If files.Count = 0 Then
                    errmsg += vbCrLf & selectedStaff
                Else
                    '該当ファイルをコピーする
                    For Each f As String In files
                        System.IO.File.Copy(f, "C:\MPP\Exports\" & folderpath & "\免許証\" & selectedStaff & ".pdf")
                        pgbLoading.PerformStep()
                    Next

                End If

            End If

        Next c

        '見つからなかった免許証があれば、エラーメッセージを表示
        If Not errmsg = "" Then
            errmsg = "以下のファイルは見つかりませんでした:" & errmsg
            MsgBox(errmsg)
        End If

        'エクスポートしたフォルダを表示する
        System.Diagnostics.Process.Start("C:\MPP\Exports\" & folderpath & "")

        Me.Close()
    End Sub
End Class