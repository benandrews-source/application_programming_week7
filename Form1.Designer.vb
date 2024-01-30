<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim lblTitle As System.Windows.Forms.Label
        Dim lblPlatform As System.Windows.Forms.Label
        Dim lblRating As System.Windows.Forms.Label
        Dim lblPrice As System.Windows.Forms.Label
        Dim lblNewused As System.Windows.Forms.Label
        Dim lblQuantity As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.GamesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GamesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtPlatform = New System.Windows.Forms.TextBox()
        Me.txtRating = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtNewused = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.FillByPsPlatformToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByPsPlatformToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByPriceToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByPriceToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByQuantityToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByQuantityToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByRatingToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByRatingToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByXbPlatformToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByXbPlatformToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GaloreDataSet = New ba_assignment7.GaloreDataSet()
        Me.GamesTableAdapter = New ba_assignment7.GaloreDataSetTableAdapters.GamesTableAdapter()
        Me.TableAdapterManager = New ba_assignment7.GaloreDataSetTableAdapters.TableAdapterManager()
        lblTitle = New System.Windows.Forms.Label()
        lblPlatform = New System.Windows.Forms.Label()
        lblRating = New System.Windows.Forms.Label()
        lblPrice = New System.Windows.Forms.Label()
        lblNewused = New System.Windows.Forms.Label()
        lblQuantity = New System.Windows.Forms.Label()
        CType(Me.GamesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GamesBindingNavigator.SuspendLayout()
        Me.FillByPsPlatformToolStrip.SuspendLayout()
        Me.FillByPriceToolStrip.SuspendLayout()
        Me.FillByQuantityToolStrip.SuspendLayout()
        Me.FillByRatingToolStrip.SuspendLayout()
        Me.FillByXbPlatformToolStrip.SuspendLayout()
        CType(Me.GamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GaloreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        lblTitle.AutoSize = True
        lblTitle.Location = New System.Drawing.Point(28, 215)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New System.Drawing.Size(33, 15)
        lblTitle.TabIndex = 3
        lblTitle.Text = "Title:"
        '
        'lblPlatform
        '
        lblPlatform.AutoSize = True
        lblPlatform.Location = New System.Drawing.Point(28, 264)
        lblPlatform.Name = "lblPlatform"
        lblPlatform.Size = New System.Drawing.Size(56, 15)
        lblPlatform.TabIndex = 5
        lblPlatform.Text = "Platform:"
        '
        'lblRating
        '
        lblRating.AutoSize = True
        lblRating.Location = New System.Drawing.Point(292, 216)
        lblRating.Name = "lblRating"
        lblRating.Size = New System.Drawing.Size(46, 15)
        lblRating.TabIndex = 7
        lblRating.Text = "Rating:"
        '
        'lblPrice
        '
        lblPrice.AutoSize = True
        lblPrice.Location = New System.Drawing.Point(300, 262)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New System.Drawing.Size(38, 15)
        lblPrice.TabIndex = 9
        lblPrice.Text = "Price:"
        '
        'lblNewused
        '
        lblNewused.AutoSize = True
        lblNewused.Location = New System.Drawing.Point(300, 305)
        lblNewused.Name = "lblNewused"
        lblNewused.Size = New System.Drawing.Size(67, 15)
        lblNewused.TabIndex = 11
        lblNewused.Text = "New Used:"
        '
        'lblQuantity
        '
        lblQuantity.AutoSize = True
        lblQuantity.Location = New System.Drawing.Point(300, 358)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New System.Drawing.Size(54, 15)
        lblQuantity.TabIndex = 13
        lblQuantity.Text = "Quantity:"
        '
        'GamesBindingNavigator
        '
        Me.GamesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GamesBindingNavigator.BindingSource = Me.GamesBindingSource
        Me.GamesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GamesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GamesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.GamesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GamesBindingNavigatorSaveItem})
        Me.GamesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GamesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GamesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GamesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GamesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GamesBindingNavigator.Name = "GamesBindingNavigator"
        Me.GamesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GamesBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.GamesBindingNavigator.TabIndex = 0
        Me.GamesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'GamesBindingNavigatorSaveItem
        '
        Me.GamesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GamesBindingNavigatorSaveItem.Image = CType(resources.GetObject("GamesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GamesBindingNavigatorSaveItem.Name = "GamesBindingNavigatorSaveItem"
        Me.GamesBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.GamesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtTitle
        '
        Me.txtTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GamesBindingSource, "Title", True))
        Me.txtTitle.Location = New System.Drawing.Point(129, 215)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtTitle.TabIndex = 4
        '
        'txtPlatform
        '
        Me.txtPlatform.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GamesBindingSource, "Platform", True))
        Me.txtPlatform.Location = New System.Drawing.Point(129, 259)
        Me.txtPlatform.Multiline = True
        Me.txtPlatform.Name = "txtPlatform"
        Me.txtPlatform.ReadOnly = True
        Me.txtPlatform.Size = New System.Drawing.Size(100, 20)
        Me.txtPlatform.TabIndex = 6
        '
        'txtRating
        '
        Me.txtRating.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GamesBindingSource, "Rating", True))
        Me.txtRating.Location = New System.Drawing.Point(373, 216)
        Me.txtRating.Multiline = True
        Me.txtRating.Name = "txtRating"
        Me.txtRating.ReadOnly = True
        Me.txtRating.Size = New System.Drawing.Size(100, 20)
        Me.txtRating.TabIndex = 8
        '
        'txtPrice
        '
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GamesBindingSource, "Price", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtPrice.Location = New System.Drawing.Point(373, 259)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 10
        '
        'txtNewused
        '
        Me.txtNewused.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GamesBindingSource, "NewUsed", True))
        Me.txtNewused.Location = New System.Drawing.Point(373, 302)
        Me.txtNewused.Multiline = True
        Me.txtNewused.Name = "txtNewused"
        Me.txtNewused.ReadOnly = True
        Me.txtNewused.Size = New System.Drawing.Size(100, 20)
        Me.txtNewused.TabIndex = 12
        '
        'txtQuantity
        '
        Me.txtQuantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GamesBindingSource, "Quantity", True))
        Me.txtQuantity.Location = New System.Drawing.Point(373, 355)
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ReadOnly = True
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 14
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnClose.ForeColor = System.Drawing.SystemColors.Control
        Me.btnClose.Location = New System.Drawing.Point(653, 350)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'FillByPsPlatformToolStrip
        '
        Me.FillByPsPlatformToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByPsPlatformToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByPsPlatformToolStripButton})
        Me.FillByPsPlatformToolStrip.Location = New System.Drawing.Point(0, 27)
        Me.FillByPsPlatformToolStrip.Name = "FillByPsPlatformToolStrip"
        Me.FillByPsPlatformToolStrip.Size = New System.Drawing.Size(800, 27)
        Me.FillByPsPlatformToolStrip.TabIndex = 21
        Me.FillByPsPlatformToolStrip.Text = "FillByPsPlatformToolStrip"
        '
        'FillByPsPlatformToolStripButton
        '
        Me.FillByPsPlatformToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByPsPlatformToolStripButton.Name = "FillByPsPlatformToolStripButton"
        Me.FillByPsPlatformToolStripButton.Size = New System.Drawing.Size(87, 24)
        Me.FillByPsPlatformToolStripButton.Text = "PlayStation"
        '
        'FillByPriceToolStrip
        '
        Me.FillByPriceToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByPriceToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByPriceToolStripButton})
        Me.FillByPriceToolStrip.Location = New System.Drawing.Point(0, 54)
        Me.FillByPriceToolStrip.Name = "FillByPriceToolStrip"
        Me.FillByPriceToolStrip.Size = New System.Drawing.Size(800, 27)
        Me.FillByPriceToolStrip.TabIndex = 22
        Me.FillByPriceToolStrip.Text = "FillByPriceToolStrip"
        '
        'FillByPriceToolStripButton
        '
        Me.FillByPriceToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByPriceToolStripButton.Name = "FillByPriceToolStripButton"
        Me.FillByPriceToolStripButton.Size = New System.Drawing.Size(45, 24)
        Me.FillByPriceToolStripButton.Text = "Price"
        '
        'FillByQuantityToolStrip
        '
        Me.FillByQuantityToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByQuantityToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByQuantityToolStripButton})
        Me.FillByQuantityToolStrip.Location = New System.Drawing.Point(0, 81)
        Me.FillByQuantityToolStrip.Name = "FillByQuantityToolStrip"
        Me.FillByQuantityToolStrip.Size = New System.Drawing.Size(800, 27)
        Me.FillByQuantityToolStrip.TabIndex = 23
        Me.FillByQuantityToolStrip.Text = "Quantity"
        '
        'FillByQuantityToolStripButton
        '
        Me.FillByQuantityToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByQuantityToolStripButton.Name = "FillByQuantityToolStripButton"
        Me.FillByQuantityToolStripButton.Size = New System.Drawing.Size(69, 24)
        Me.FillByQuantityToolStripButton.Text = "Quantity"
        '
        'FillByRatingToolStrip
        '
        Me.FillByRatingToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByRatingToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByRatingToolStripButton})
        Me.FillByRatingToolStrip.Location = New System.Drawing.Point(0, 108)
        Me.FillByRatingToolStrip.Name = "FillByRatingToolStrip"
        Me.FillByRatingToolStrip.Size = New System.Drawing.Size(800, 27)
        Me.FillByRatingToolStrip.TabIndex = 24
        Me.FillByRatingToolStrip.Text = "FillByRatingToolStrip"
        '
        'FillByRatingToolStripButton
        '
        Me.FillByRatingToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByRatingToolStripButton.Name = "FillByRatingToolStripButton"
        Me.FillByRatingToolStripButton.Size = New System.Drawing.Size(56, 24)
        Me.FillByRatingToolStripButton.Text = "Rating"
        '
        'FillByXbPlatformToolStrip
        '
        Me.FillByXbPlatformToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByXbPlatformToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByXbPlatformToolStripButton})
        Me.FillByXbPlatformToolStrip.Location = New System.Drawing.Point(0, 135)
        Me.FillByXbPlatformToolStrip.Name = "FillByXbPlatformToolStrip"
        Me.FillByXbPlatformToolStrip.Size = New System.Drawing.Size(800, 27)
        Me.FillByXbPlatformToolStrip.TabIndex = 25
        Me.FillByXbPlatformToolStrip.Text = "Xbox"
        '
        'FillByXbPlatformToolStripButton
        '
        Me.FillByXbPlatformToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByXbPlatformToolStripButton.Name = "FillByXbPlatformToolStripButton"
        Me.FillByXbPlatformToolStripButton.Size = New System.Drawing.Size(47, 24)
        Me.FillByXbPlatformToolStripButton.Text = "Xbox"
        '
        'GamesBindingSource
        '
        Me.GamesBindingSource.DataMember = "Games"
        Me.GamesBindingSource.DataSource = Me.GaloreDataSet
        '
        'GaloreDataSet
        '
        Me.GaloreDataSet.DataSetName = "GaloreDataSet"
        Me.GaloreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GamesTableAdapter
        '
        Me.GamesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GamesTableAdapter = Me.GamesTableAdapter
        Me.TableAdapterManager.UpdateOrder = ba_assignment7.GaloreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FillByXbPlatformToolStrip)
        Me.Controls.Add(Me.FillByRatingToolStrip)
        Me.Controls.Add(Me.FillByQuantityToolStrip)
        Me.Controls.Add(Me.FillByPriceToolStrip)
        Me.Controls.Add(Me.FillByPsPlatformToolStrip)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(lblTitle)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(lblPlatform)
        Me.Controls.Add(Me.txtPlatform)
        Me.Controls.Add(lblRating)
        Me.Controls.Add(Me.txtRating)
        Me.Controls.Add(lblPrice)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(lblNewused)
        Me.Controls.Add(Me.txtNewused)
        Me.Controls.Add(lblQuantity)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.GamesBindingNavigator)
        Me.Name = "frmMain"
        Me.Text = "Games"
        CType(Me.GamesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GamesBindingNavigator.ResumeLayout(False)
        Me.GamesBindingNavigator.PerformLayout()
        Me.FillByPsPlatformToolStrip.ResumeLayout(False)
        Me.FillByPsPlatformToolStrip.PerformLayout()
        Me.FillByPriceToolStrip.ResumeLayout(False)
        Me.FillByPriceToolStrip.PerformLayout()
        Me.FillByQuantityToolStrip.ResumeLayout(False)
        Me.FillByQuantityToolStrip.PerformLayout()
        Me.FillByRatingToolStrip.ResumeLayout(False)
        Me.FillByRatingToolStrip.PerformLayout()
        Me.FillByXbPlatformToolStrip.ResumeLayout(False)
        Me.FillByXbPlatformToolStrip.PerformLayout()
        CType(Me.GamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GaloreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GaloreDataSet As GaloreDataSet
    Friend WithEvents GamesBindingSource As BindingSource
    Friend WithEvents GamesTableAdapter As GaloreDataSetTableAdapters.GamesTableAdapter
    Friend WithEvents TableAdapterManager As GaloreDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GamesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents GamesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtPlatform As TextBox
    Friend WithEvents txtRating As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtNewused As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents FillByPsPlatformToolStrip As ToolStrip
    Friend WithEvents FillByPsPlatformToolStripButton As ToolStripButton
    Friend WithEvents FillByPriceToolStrip As ToolStrip
    Friend WithEvents FillByPriceToolStripButton As ToolStripButton
    Friend WithEvents FillByQuantityToolStrip As ToolStrip
    Friend WithEvents FillByQuantityToolStripButton As ToolStripButton
    Friend WithEvents FillByRatingToolStrip As ToolStrip
    Friend WithEvents FillByRatingToolStripButton As ToolStripButton
    Friend WithEvents FillByXbPlatformToolStrip As ToolStrip
    Friend WithEvents FillByXbPlatformToolStripButton As ToolStripButton
End Class
