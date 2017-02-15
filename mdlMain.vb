
Imports System
Imports System.Globalization




Module mdlMain
    '管理者ログインフラグ
    'f=一般ユーザ　t=管理者
    Public UserIsAdmin As Boolean = False


    Function AD_to_Wareki(ByVal impoDate As Date) As String
        Dim culture As CultureInfo = New CultureInfo("ja-JP", True)
        culture.DateTimeFormat.Calendar = New JapaneseCalendar()

        Dim target As DateTime = impoDate
        Dim result As String = target.ToString("ggyy年M月d日", culture)
        'Console.WriteLine(result)
        ' 出力：平成15年7月1日
        Return result
    End Function


    Function Wareki_to_AD(ByVal impoDate As String) As DateTime
        Dim culture As CultureInfo = New CultureInfo("ja-JP", True)
        culture.DateTimeFormat.Calendar = New JapaneseCalendar()

        Dim target As String = impoDate
        Dim result As DateTime = DateTime.ParseExact(target, "ggyy年M月d日", culture)
        'Console.WriteLine(result.ToLongDateString())
        ' 出力：2003年7月1日

        Return result
    End Function

End Module

