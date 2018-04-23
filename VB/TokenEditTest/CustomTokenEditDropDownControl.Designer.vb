Namespace TokenEditTest
    Partial Public Class CustomTokenEditDropDownControl
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
                components = Nothing
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.treeList_Renamed = New TokenEditTest.CustomTreeList()
            Me.colData = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            DirectCast(Me.treeList_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' treeList
            ' 
            Me.treeList_Renamed.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.treeList_Renamed.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colData})
            Me.treeList_Renamed.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList_Renamed.Location = New System.Drawing.Point(0, 0)
            Me.treeList_Renamed.Name = "treeList"
            Me.treeList_Renamed.OptionsBehavior.Editable = False
            Me.treeList_Renamed.OptionsBehavior.EnableFiltering = True
            Me.treeList_Renamed.OptionsBehavior.ReadOnly = True
            Me.treeList_Renamed.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.treeList_Renamed.OptionsView.ShowIndentAsRowStyle = True
            Me.treeList_Renamed.Size = New System.Drawing.Size(331, 209)
            Me.treeList_Renamed.TabIndex = 0
            ' 
            ' colData
            ' 
            Me.colData.Caption = "Data"
            Me.colData.FieldName = "colData"
            Me.colData.Name = "colData"
            Me.colData.Visible = True
            Me.colData.VisibleIndex = 0
            ' 
            ' CustomTokenEditPopupControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList_Renamed)
            Me.Name = "CustomTokenEditPopupControl"
            Me.Size = New System.Drawing.Size(331, 209)
            DirectCast(Me.treeList_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region


        Private WithEvents treeList_Renamed As CustomTreeList
        Private WithEvents colData As DevExpress.XtraTreeList.Columns.TreeListColumn


    End Class
End Namespace
