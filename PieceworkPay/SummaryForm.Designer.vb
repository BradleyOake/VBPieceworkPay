<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SummaryForm))
        Me.lblTotalPiecesHeader = New System.Windows.Forms.Label()
        Me.lblTotalPayHeader = New System.Windows.Forms.Label()
        Me.lblTotalPieces = New System.Windows.Forms.Label()
        Me.lblTotalPay = New System.Windows.Forms.Label()
        Me.lblTotalPayPerWorkerHeader = New System.Windows.Forms.Label()
        Me.lblTotalPayPerWorker = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTotalPiecesHeader
        '
        Me.lblTotalPiecesHeader.AutoSize = True
        Me.lblTotalPiecesHeader.Location = New System.Drawing.Point(29, 30)
        Me.lblTotalPiecesHeader.Name = "lblTotalPiecesHeader"
        Me.lblTotalPiecesHeader.Size = New System.Drawing.Size(69, 13)
        Me.lblTotalPiecesHeader.TabIndex = 0
        Me.lblTotalPiecesHeader.Text = "Total Pieces:"
        '
        'lblTotalPayHeader
        '
        Me.lblTotalPayHeader.AutoSize = True
        Me.lblTotalPayHeader.Location = New System.Drawing.Point(29, 65)
        Me.lblTotalPayHeader.Name = "lblTotalPayHeader"
        Me.lblTotalPayHeader.Size = New System.Drawing.Size(55, 13)
        Me.lblTotalPayHeader.TabIndex = 2
        Me.lblTotalPayHeader.Text = "Total Pay:"
        '
        'lblTotalPieces
        '
        Me.lblTotalPieces.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPieces.Location = New System.Drawing.Point(169, 30)
        Me.lblTotalPieces.Name = "lblTotalPieces"
        Me.lblTotalPieces.Size = New System.Drawing.Size(120, 20)
        Me.lblTotalPieces.TabIndex = 1
        '
        'lblTotalPay
        '
        Me.lblTotalPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPay.Location = New System.Drawing.Point(169, 65)
        Me.lblTotalPay.Name = "lblTotalPay"
        Me.lblTotalPay.Size = New System.Drawing.Size(120, 20)
        Me.lblTotalPay.TabIndex = 3
        '
        'lblTotalPayPerWorkerHeader
        '
        Me.lblTotalPayPerWorkerHeader.AutoSize = True
        Me.lblTotalPayPerWorkerHeader.Location = New System.Drawing.Point(29, 101)
        Me.lblTotalPayPerWorkerHeader.Name = "lblTotalPayPerWorkerHeader"
        Me.lblTotalPayPerWorkerHeader.Size = New System.Drawing.Size(112, 13)
        Me.lblTotalPayPerWorkerHeader.TabIndex = 4
        Me.lblTotalPayPerWorkerHeader.Text = "Total Pay Per Worker:"
        '
        'lblTotalPayPerWorker
        '
        Me.lblTotalPayPerWorker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPayPerWorker.Location = New System.Drawing.Point(169, 100)
        Me.lblTotalPayPerWorker.Name = "lblTotalPayPerWorker"
        Me.lblTotalPayPerWorker.Size = New System.Drawing.Size(120, 20)
        Me.lblTotalPayPerWorker.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(120, 145)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'SummaryForm
        '
        Me.AcceptButton = Me.btnClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(313, 190)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblTotalPayPerWorker)
        Me.Controls.Add(Me.lblTotalPayPerWorkerHeader)
        Me.Controls.Add(Me.lblTotalPay)
        Me.Controls.Add(Me.lblTotalPieces)
        Me.Controls.Add(Me.lblTotalPayHeader)
        Me.Controls.Add(Me.lblTotalPiecesHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SummaryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotalPiecesHeader As System.Windows.Forms.Label
    Friend WithEvents lblTotalPayHeader As System.Windows.Forms.Label
    Friend WithEvents lblTotalPieces As System.Windows.Forms.Label
    Friend WithEvents lblTotalPay As System.Windows.Forms.Label
    Friend WithEvents lblTotalPayPerWorkerHeader As System.Windows.Forms.Label
    Friend WithEvents lblTotalPayPerWorker As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
