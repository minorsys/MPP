Imports System.ComponentModel
Public Class frmProgressBar
    'Button1のClickイベントハンドラ
    Private Sub Button1_Click(ByVal sender As Object,
        ByVal e As System.EventArgs) Handles Button1.Click
        '処理が行われているときは、何もしない
        If BackgroundWorker1.IsBusy Then
            Return
        End If

        'Button1を無効にする
        Button1.Enabled = False

        'コントロールを初期化する
        progressbar1.Minimum = 0
        progressbar1.Maximum = 10
        progressbar1.Value = 0
        Label1.Text = "0"

        'BackgroundWorkerのProgressChangedイベントが発生するようにする
        BackgroundWorker1.WorkerReportsProgress = True
        'DoWorkで取得できるパラメータ(10)を指定して、処理を開始する
        'パラメータが必要なければ省略できる
        BackgroundWorker1.RunWorkerAsync(10)
    End Sub

    'BackgroundWorker1のDoWorkイベントハンドラ
    'ここで時間のかかる処理を行う
    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object,
        ByVal e As DoWorkEventArgs) _
        Handles BackgroundWorker1.DoWork
        Dim bgWorker As BackgroundWorker = DirectCast(sender, BackgroundWorker)

        'パラメータを取得する
        Dim maxLoops As Integer = CInt(e.Argument)

        '時間のかかる処理を開始する
        Dim i As Integer
        For i = 1 To maxLoops
            '1秒間待機する（時間のかかる処理があるものとする）
            System.Threading.Thread.Sleep(1000)

            'ProgressChangedイベントハンドラを呼び出し、
            'コントロールの表示を変更する
            bgWorker.ReportProgress(i)
        Next

        'ProgressChangedで取得できる結果を設定する
        '結果が必要なければ省略できる
        e.Result = maxLoops
    End Sub

    'BackgroundWorker1のProgressChangedイベントハンドラ
    'コントロールの操作は必ずここで行い、DoWorkでは絶対にしない
    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object,
        ByVal e As ProgressChangedEventArgs) _
        Handles BackgroundWorker1.ProgressChanged
        'ProgressBar1の値を変更する
        progressbar1.Value = e.ProgressPercentage
        'Label1のテキストを変更する
        Label1.Text = e.ProgressPercentage.ToString()
    End Sub

    'BackgroundWorker1のRunWorkerCompletedイベントハンドラ
    '処理が終わったときに呼び出される
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object,
        ByVal e As RunWorkerCompletedEventArgs) _
        Handles BackgroundWorker1.RunWorkerCompleted
        If Not e.Error Is Nothing Then
            'エラーが発生したとき
            Label1.Text = "エラー:" & e.Error.Message
        Else
            '正常に終了したとき
            '結果を取得する
            Dim result As Integer = CInt(e.Result)
            Label1.Text = result.ToString() & "回で完了しました。"
        End If

        'Button1を有効に戻す
        Button1.Enabled = True
    End Sub
End Class