﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnMasterStaff = New System.Windows.Forms.Button()
        Me.btnMasterPhone = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSyakenUpload = New System.Windows.Forms.Button()
        Me.btnMenkyoUpload = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMasterCar
        '
        Me.btnMasterCar.BackColor = System.Drawing.Color.LightBlue
        Me.btnMasterCar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMasterCar.Location = New System.Drawing.Point(13, 13)
        Me.btnMasterCar.Name = "btnMasterCar"
        Me.btnMasterCar.Size = New System.Drawing.Size(92, 23)
        Me.btnMasterCar.TabIndex = 0
        Me.btnMasterCar.Text = "車両マスタ"
        Me.btnMasterCar.UseVisualStyleBackColor = False
        '
        'btnMasterStaff
        '
        Me.btnMasterStaff.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnMasterStaff.Location = New System.Drawing.Point(13, 43)
        Me.btnMasterStaff.Name = "btnMasterStaff"
        Me.btnMasterStaff.Size = New System.Drawing.Size(92, 23)
        Me.btnMasterStaff.TabIndex = 1
        Me.btnMasterStaff.Text = "社員マスタ"
        Me.btnMasterStaff.UseVisualStyleBackColor = False
        '
        'btnMasterPhone
        '
        Me.btnMasterPhone.BackColor = System.Drawing.Color.LightSalmon
        Me.btnMasterPhone.Location = New System.Drawing.Point(13, 73)
        Me.btnMasterPhone.Name = "btnMasterPhone"
        Me.btnMasterPhone.Size = New System.Drawing.Size(92, 23)
        Me.btnMasterPhone.TabIndex = 2
        Me.btnMasterPhone.Text = "電話マスタ"
        Me.btnMasterPhone.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(144, 122)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSyakenUpload
        '
        Me.btnSyakenUpload.BackColor = System.Drawing.Color.LightBlue
        Me.btnSyakenUpload.Location = New System.Drawing.Point(111, 13)
        Me.btnSyakenUpload.Name = "btnSyakenUpload"
        Me.btnSyakenUpload.Size = New System.Drawing.Size(92, 23)
        Me.btnSyakenUpload.TabIndex = 4
        Me.btnSyakenUpload.Text = "車検証pdf更新"
        Me.btnSyakenUpload.UseVisualStyleBackColor = False
        '
        'btnMenkyoUpload
        '
        Me.btnMenkyoUpload.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnMenkyoUpload.Location = New System.Drawing.Point(110, 43)
        Me.btnMenkyoUpload.Name = "btnMenkyoUpload"
        Me.btnMenkyoUpload.Size = New System.Drawing.Size(93, 23)
        Me.btnMenkyoUpload.TabIndex = 5
        Me.btnMenkyoUpload.Text = "免許証pdf更新"
        Me.btnMenkyoUpload.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(231, 157)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnMenkyoUpload)
        Me.Controls.Add(Me.btnSyakenUpload)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMasterPhone)
        Me.Controls.Add(Me.btnMasterStaff)
        Me.Controls.Add(Me.btnMasterCar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAdmin"
        Me.Text = "管理メニュー"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMasterCar As Button
    Friend WithEvents btnMasterStaff As Button
    Friend WithEvents btnMasterPhone As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSyakenUpload As Button
    Friend WithEvents btnMenkyoUpload As Button
    Friend WithEvents Button1 As Button
End Class
