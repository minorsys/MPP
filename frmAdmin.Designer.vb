<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnMasterCar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMasterCar
        '
        Me.btnMasterCar.Location = New System.Drawing.Point(13, 13)
        Me.btnMasterCar.Name = "btnMasterCar"
        Me.btnMasterCar.Size = New System.Drawing.Size(75, 23)
        Me.btnMasterCar.TabIndex = 0
        Me.btnMasterCar.Text = "車両マスタ"
        Me.btnMasterCar.UseVisualStyleBackColor = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(229, 261)
        Me.Controls.Add(Me.btnMasterCar)
        Me.Name = "frmAdmin"
        Me.Text = "frmAdmin"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMasterCar As Button
End Class
