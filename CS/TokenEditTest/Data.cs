using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;

namespace TokenEditTest {
    public class TreeListDataSet {
        IList<TreeListRootObj> rootNodes;
        public TreeListDataSet(IEnumerable<TokenEditToken> tokens) {
            this.rootNodes = CreateRootCol(tokens);
        }
        IList<TreeListRootObj> CreateRootCol(IEnumerable<TokenEditToken> tokens) {
            List<TreeListRootObj> res = new List<TreeListRootObj>();
            foreach(TokenEditToken token in tokens) {
                res.Add(new TreeListRootObj(token));
            }
            return res;
        }
        public int Count { get { return Children.Count; } }
        public TreeListRootObj[] GetChildren() {
            return this.rootNodes.ToArray();
        }
        public IList<TreeListRootObj> Children { get { return rootNodes; } }
    }

    public class TreeListRootObj {
        TreeListLeaf leaf;
        public TreeListRootObj(TokenEditToken token) {
            this.leaf = new TreeListLeaf(token);
        }
        public override string ToString() {
            return "Root Node";
        }
        public TreeListLeaf Leaf { get { return leaf; } }
    }

    public class TreeListLeaf {
        TokenEditToken token;
        public TreeListLeaf(TokenEditToken token) {
            this.token = token;
        }
        public bool IsMatch(string filter) {
            string filterCore = filter.Trim();
            if(string.IsNullOrEmpty(filterCore)) return true;
            return token.ToString().StartsWith(filterCore, StringComparison.OrdinalIgnoreCase);
        }
        public override string ToString() {
            return token.ToString();
        }
        public TokenEditToken Token { get { return token; } }
    }
}