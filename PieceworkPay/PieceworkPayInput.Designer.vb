<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PieceWorkPayInput
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PieceWorkPayInput))
        Me.lblWorkerNameHeader = New System.Windows.Forms.Label()
        Me.lblNumberOfPiecesHeader = New System.Windows.Forms.Label()
        Me.txtWorkerName = New System.Windows.Forms.TextBox()
        Me.txtNumberOfPieces = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalPay = New System.Windows.Forms.Label()
        Me.ttpPieceworkTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblWorkerNameHeader
        '
        Me.lblWorkerNameHeader.AutoSize = True
        Me.lblWorkerNameHeader.Location = New System.Drawing.Point(34, 34)
        Me.lblWorkerNameHeader.Name = "lblWorkerNameHeader"
        Me.lblWorkerNameHeader.Size = New System.Drawing.Size(76, 13)
        Me.lblWorkerNameHeader.TabIndex = 0
        Me.lblWorkerNameHeader.Text = "&Worker Name:"
        '
        'lblNumberOfPiecesHeader
        '
        Me.lblNumberOfPiecesHeader.AutoSize = True
        Me.lblNumberOfPiecesHeader.Location = New System.Drawing.Point(34, 63)
        Me.lblNumberOfPiecesHeader.Name = "lblNumberOfPiecesHeader"
        Me.lblNumberOfPiecesHeader.Size = New System.Drawing.Size(94, 13)
        Me.lblNumberOfPiecesHeader.TabIndex = 2
        Me.lblNumberOfPiecesHeader.Text = "&Number of Pieces:"
        '
        'txtWorkerName
        '
        Me.txtWorkerName.Location = New System.Drawing.Point(134, 31)
        Me.txtWorkerName.Name = "txtWorkerName"
        Me.txtWorkerName.Size = New System.Drawing.Size(151, 20)
        Me.txtWorkerName.TabIndex = 1
        Me.ttpPieceworkTips.SetToolTip(Me.txtWorkerName, "Enter the worker's name here.")
        '
        'txtNumberOfPieces
        '
        Me.txtNumberOfPieces.Location = New System.Drawing.Point(134, 60)
        Me.txtNumberOfPieces.Name = "txtNumberOfPieces"
        Me.txtNumberOfPieces.Size = New System.Drawing.Size(151, 20)
        Me.txtNumberOfPieces.TabIndex = 3
        Me.ttpPieceworkTips.SetToolTip(Me.txtNumberOfPieces, "Enter the number of pieces the worker produced here.")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 139)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "&Calculate"
        Me.ttpPieceworkTips.SetToolTip(Me.btnCalculate, "Click to calculate the pay of the worker.")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(93, 139)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear"
        Me.ttpPieceworkTips.SetToolTip(Me.btnClear, "Click to clear data from this form.")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSummary
        '
        Me.btnSummary.Location = New System.Drawing.Point(174, 139)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(75, 23)
        Me.btnSummary.TabIndex = 8
        Me.btnSummary.Text = "&Summary"
        Me.ttpPieceworkTips.SetToolTip(Me.btnSummary, "Click to display the summary form.")
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(255, 139)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.ttpPieceworkTips.SetToolTip(Me.btnExit, "Click t close the program.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Pay:"
        '
        'lblTotalPay
        '
        Me.lblTotalPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPay.Location = New System.Drawing.Point(134, 90)
        Me.lblTotalPay.Name = "lblTotalPay"
        Me.lblTotalPay.Size = New System.Drawing.Size(151, 20)
        Me.lblTotalPay.TabIndex = 5
        Me.ttpPieceworkTips.SetToolTip(Me.lblTotalPay, "The calculated pay of the worker will be displayed here.")
        '
        'PieceWorkPayInput
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(338, 174)
        Me.Controls.Add(Me.lblTotalPay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSummary)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNumberOfPieces)
        Me.Controls.Add(Me.txtWorkerName)
        Me.Controls.Add(Me.lblNumberOfPiecesHeader)
        Me.Controls.Add(Me.lblWorkerNameHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PieceWorkPayInput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Piecework Pay Input"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWorkerNameHeader As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfPiecesHeader As System.Windows.Forms.Label
    Friend WithEvents txtWorkerName As System.Windows.Forms.TextBox
    Friend WithEvents txtNumberOfPieces As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSummary As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPay As System.Windows.Forms.Label
    Friend WithEvents ttpPieceworkTips As System.Windows.Forms.ToolTip

End Class
