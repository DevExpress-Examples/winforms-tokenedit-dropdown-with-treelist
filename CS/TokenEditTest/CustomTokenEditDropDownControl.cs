using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace TokenEditTest {
    public partial class CustomTokenEditDropDownControl : CustomTokenEditDropDownControlBase {
        public CustomTokenEditDropDownControl() {
            InitializeComponent();
        }
        public override void Initialize(TokenEdit ownerEdit, TokenEditPopupForm ownerPopup) {
            base.Initialize(ownerEdit, ownerPopup);
        }
        public override void InitializeAppearances(AppearanceObject appearanceDropDown) {
            base.InitializeAppearances(appearanceDropDown);
        }
        public override void SetDataSource(object dataSource) {
            TreeList.DataSource = new TreeListDataSet((IEnumerable<TokenEditToken>)dataSource);
            TreeList.ExpandAll();
        }
        string currentFilter = string.Empty;
        public override void SetFilter(string filter, string columnName) {
            this.currentFilter = filter;
            TreeList.FilterNodes();
            if(TreeList.VisibleNodesCount == 0) OwnerEdit.ClosePopup(PopupCloseMode.Cancel);
        }
        public override void OnShowingPopupForm() {
            base.OnShowingPopupForm();
        }
        public override int GetItemCount() {
            return TreeList.VisibleNodesCount;
        }
        public override int CalcFormWidth() {
            return 500;
        }
        public override int CalcFormHeight(int itemCount) {
            return 200;
        }
        public override object GetResultValue() {
            TreeListLeaf leaf = GetSelectedDataItem() as TreeListLeaf;
            return leaf != null ? leaf.Token : null;
        }
        public override bool IsTokenSelected {
            get { return this.selNode != null; }
        }
        public override void ResetSelection() {
            this.selNode = null;
            TreeList.FocusedNode = null;
        }
        public override void ProcessKeyDown(KeyEventArgs e) {
            base.ProcessKeyDown(e);
            TreeList.DoKeyDown(e);
        }
        public override void OnEditorMouseWheel(MouseEventArgs e) {
            int step = SystemInformation.MouseWheelScrollLines > 0 ? SystemInformation.MouseWheelScrollLines : 1;
            if(e.Delta > 0) step *= -1;
            TreeList.TopVisibleNodeIndex += step;
        }
        public override void ResetResultValue() {
            this.selNode = null;
        }
        #region TreeList Handlers
        TreeListNode selNode = null;
        void OnTreeListFocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e) {
            this.selNode = e.Node;
        }
        void OnTreeListDoubleClick(object sender, EventArgs e) {
            TreeListHitInfo hi = TreeList.CalcHitInfo(TreeList.PointToClient(Control.MousePosition));
            if(hi.HitInfoType == HitInfoType.Cell && GetSelectedDataItem() is TreeListLeaf) {
                OwnerEdit.ClosePopup(PopupCloseMode.Normal);
            }
        }
        object GetSelectedDataItem() { return this.selNode != null ? TreeList.GetDataRecordByNode(this.selNode) : null; }
        void OnTreeListVirtualTreeGetChildNodes(object sender, VirtualTreeGetChildNodesInfo e) {
            if(e.Node is TreeListDataSet) {
                e.Children = ((TreeListDataSet)e.Node).GetChildren();
            }
            if(e.Node is TreeListRootObj) {
                e.Children = new object[] { ((TreeListRootObj)e.Node).Leaf };
            }
        }
        void OnTreeListVirtualTreeGetCellValue(object sender, VirtualTreeGetCellValueInfo e) {
            if(e.Node is TreeListRootObj || e.Node is TreeListLeaf) e.CellData = e.Node.ToString();
        }
        void OnTreeListFilterNode(object sender, FilterNodeEventArgs e) {
            TreeListRootObj obj = TreeList.GetDataRecordByNode(e.Node) as TreeListRootObj;
            if(obj != null && !obj.Leaf.IsMatch(currentFilter)) {
                e.Node.Visible = false;
                e.Handled = true;
            }
        }
        #endregion
        protected CustomTreeList TreeList { get { return treeList; } }
    }

    public class CustomTreeList : TreeList {
        public CustomTreeList() {
            BorderStyle = BorderStyles.NoBorder;
            SetStyle(ControlStyles.UserMouse, false);
        }
        public void DoKeyDown(KeyEventArgs e) { OnKeyDown(e); }
    }
}
