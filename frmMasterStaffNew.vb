﻿Imports System.Text.RegularExpressions
Public Class frmMasterStaffNew

    Private Sub frmMasterStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_car' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.Tbl_carTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_car)
        ''TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_PhoneNum' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_staff' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_staffTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_staff)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_branch' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_branchTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_branch)


        ''### 新しい社員IDを生成する ###

        ''コネクションを指定する
        'Using connection As New SqlClient.SqlConnection(My.Settings.PhoneNumDBConnectionString)

        '    'コマンドをコネクションから作成する
        '    Dim command As SqlClient.SqlCommand = connection.CreateCommand

        '    'コネクションを開く
        '    connection.Open()

        '    'データリーダーの定義
        '    Dim dr As SqlClient.SqlDataReader

        '    'データコマンドの定義
        '    command.CommandText = "SELECT id_staff FROM tbl_staff ORDER BY id_staff"
        '    'データリーダーからのデータの読出し
        '    dr = command.ExecuteReader()


        '    Do While dr.Read
        '        lblStaffID.Text = dr("id_staff")
        '    Loop

        '    'データリーダーを閉じる
        '    dr.Close()

        '    '最大IDに1を足す
        '    lblStaffID.Text = (lblStaffID.Text) + 1

        '    'IDの文字数を取得し、6-(文字数)個の0を先頭に付加する
        '    Dim nZero As Integer
        '    nZero = (5 - Len(lblStaffID.Text))

        '    Dim i As Integer = 1
        '    Do While i <= nZero
        '        lblStaffID.Text = "0" & lblStaffID.Text
        '        i = i + 1
        '    Loop

        'End Using

        '### 所属コンボボックスの設定###
        cmbBranch.SelectedIndex = -1


        '免許証期限の初期値はオブジェクトのプロパティで設定した


    End Sub


    '[閉じる]ボタン
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    '[登録]ボタン
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click


        '登録するデータのチェック　不備があればキャンセルになる
        If Not CheckEditData() Then
            Return
        End If

        '保存確認と保存処理
        If MsgBox("この内容で新規登録してよろしいですか？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then


            '処理の成功をチェックするフラグ
            Dim bSuccess As Boolean = False

            '### 新しい社員IDを生成する ###

            'コネクションを指定する
            Using connection As New SqlClient.SqlConnection(My.Settings.PhoneNumDBConnectionString)

                'コマンドをコネクションから作成する
                Dim command As SqlClient.SqlCommand = connection.CreateCommand

                'コネクションを開く
                connection.Open()

                'トランザクションの開始
                command.Transaction = connection.BeginTransaction()

                Try


                    'データリーダーの定義
                    Dim dr As SqlClient.SqlDataReader

                    'データコマンドの定義
                    command.CommandText = "SELECT id_staff FROM tbl_staff ORDER BY id_staff"
                    'データリーダーからのデータの読出し
                    dr = command.ExecuteReader()


                    Do While dr.Read
                        lblStaffID.Text = dr("id_staff")
                    Loop

                    'データリーダーを閉じる
                    dr.Close()

                    '最大IDに1を足す
                    lblStaffID.Text = (lblStaffID.Text) + 1

                    'IDの文字数を取得し、6-(文字数)個の0を先頭に付加する
                    Dim nZero As Integer
                    nZero = (5 - Len(lblStaffID.Text))

                    Dim i As Integer = 1
                    Do While i <= nZero
                        lblStaffID.Text = "0" & lblStaffID.Text
                        i = i + 1
                    Loop

                    '行の定義
                    Dim newrecord As PhoneNumDBDataSet.tbl_staffRow = Me.PhoneNumDBDataSet.tbl_staff.Newtbl_staffRow

                    '行にデータをセットする
                    newrecord.id_staff = lblStaffID.Text
                    newrecord.staff_name = txtStaffName.Text
                    newrecord.staff_kana = txtStaffKana.Text
                    newrecord.branch_id = cmbBranch.SelectedValue
                    newrecord.biko = txtBiko.Text
                    newrecord.limit_menkyo = dtpMenkyoLimit.Value

                    '新規行をデータテーブルに追加する
                    Me.PhoneNumDBDataSet.tbl_staff.Addtbl_staffRow(newrecord)

                    'トランザクションのコミット
                    command.Transaction.Commit()

                    '処理が成功したため、フラグにセットする
                    bSuccess = True

                    '処理が失敗したとき
                Catch ex As Exception
                    'トランザクションのロールバック
                    command.Transaction.Rollback()

                    MsgBox("エラーが発生したため、処理を中止します。" & vbCrLf & ex.Message)

                End Try

            End Using

            'テーブルアダプタを介して、tbl_carテーブルを更新する
            Me.Tbl_staffTableAdapter.Update(Me.PhoneNumDBDataSet.tbl_staff)



            'フォームを閉じる
            Me.Close()
        End If
    End Sub

    Private Function CheckEditData() As Boolean

        'データの検査(氏名)
        With txtStaffName
            '空白でない
            If .Text = "" Then
                MsgBox("氏名は必ず入力してください")
                .Select()
                Return False
            End If

            '文字数チェック
            If Not CheckMaxLengthStaff("staff_name", .Text) Then
                MsgBox("氏名は全角10字以内で入力してください")
                .Select()
                Return False

            End If

            '氏名は、既存の登録と重複がないかチェックする。ただし、警告メッセージを表示するだけ
            If Not CheckNameOverlap(txtStaffName.Text) Then
                MsgBox("注意：既に同名の登録があります")

            End If
        End With

        'データの検査(氏名ｶﾅ)
        With txtStaffKana
            '空白でない
            If .Text = "" Then
                MsgBox("氏名ｶﾅは必ず入力してください")
                .Select()
                Return False
            End If
            '文字数チェック
            If Not CheckMaxLengthStaff("staff_kana", .Text) Then

                .Select()
                Return False
            End If
        End With


        'データの検査(免許証期限)

        'データの検査(備考)
        With txtBiko
            If Not CheckMaxLengthStaff("biko", .Text) Then
                MsgBox("備考は全角50字以内で入力してください")
                .Select()
                Return False

            End If
        End With



        '全ての検査を通過した
        Return True

    End Function

    '桁数チェック-車両番号(指定された列のサイズと文字列の比較) 
    Private Function CheckMaxLengthStaff(ByVal fieldname As String, ByVal value As String) As Boolean
        'データセットから列の情報を読み取る
        Dim column As DataColumn = PhoneNumDBDataSet.tbl_staff.Columns(fieldname)
        'シフトJISで文字列のバイト数を取得する
        Dim length As Integer = System.Text.Encoding.GetEncoding(932).GetByteCount(value)

        '指定されたサイズを超えたときはエラーになる
        If length > column.MaxLength Then
            Return False
        Else
            Return True
        End If

    End Function


    '重複チェック―氏名
    Private Function CheckNameOverlap(ByVal staffname As String) As Boolean
        Dim dbName As String
        Dim inputName As String

        For Each drw As DataRow In PhoneNumDBDataSet.tbl_staff.Rows()
            '行の状態が"削除"のデータを除外する
            If drw.RowState <> DataRowState.Deleted Then

                'この行の氏名と、入力された氏名を比較する
                '比較する文字列からスペースを抜く
                dbName = Replace(drw("staff_name"), "　", "")
                dbName = Replace(dbName, " ", "")
                inputName = Replace(staffname, "　", "")
                inputName = Replace(inputName, " ", "")
                If dbName = inputName Then
                    '重複の場合には終了する

                    Return False
                End If
            End If
        Next

        Return True
    End Function

    '氏名ｶﾅ用半角カタカナチェック
    Private Function CheckKana(ByVal value As String)


        If Not Regex.IsMatch(value, "^[0-9]{1,5}$") Then
            Return False

        Else
            Return True
        End If

    End Function

    'キーボードショートカット
    Private Sub frmMasterStaffNew_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub

    Private Sub dtpMenkyoLimit_ValueChanged(sender As Object, e As EventArgs) Handles dtpMenkyoLimit.ValueChanged
        dtpMenkyoLimit.Format = DateTimePickerFormat.Long

    End Sub
End Class