namespace TokenEditTest {
    partial class CustomTokenEditDropDownControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
                components = null;
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.treeList = new TokenEditTest.CustomTreeList();
            this.colData = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList
            // 
            this.treeList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colData});
            this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList.Location = new System.Drawing.Point(0, 0);
            this.treeList.Name = "treeList";
            this.treeList.OptionsBehavior.Editable = false;
            this.treeList.OptionsBehavior.EnableFiltering = true;
            this.treeList.OptionsBehavior.ReadOnly = true;
            this.treeList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList.Size = new System.Drawing.Size(331, 209);
            this.treeList.TabIndex = 0;
            this.treeList.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.OnTreeListFocusedNodeChanged);
            this.treeList.VirtualTreeGetChildNodes += new DevExpress.XtraTreeList.VirtualTreeGetChildNodesEventHandler(this.OnTreeListVirtualTreeGetChildNodes);
            this.treeList.VirtualTreeGetCellValue += new DevExpress.XtraTreeList.VirtualTreeGetCellValueEventHandler(this.OnTreeListVirtualTreeGetCellValue);
            this.treeList.FilterNode += new DevExpress.XtraTreeList.FilterNodeEventHandler(this.OnTreeListFilterNode);
            this.treeList.DoubleClick += new System.EventHandler(this.OnTreeListDoubleClick);
            // 
            // colData
            // 
            this.colData.Caption = "Data";
            this.colData.FieldName = "colData";
            this.colData.Name = "colData";
            this.colData.Visible = true;
            this.colData.VisibleIndex = 0;
            // 
            // CustomTokenEditPopupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList);
            this.Name = "CustomTokenEditPopupControl";
            this.Size = new System.Drawing.Size(331, 209);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomTreeList treeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colData;


    }
}
