namespace TreeView001
{
    using System.Collections.Generic;

    /// <summary>
    /// MainWindowのViewModel
    /// </summary>
    public class MainWindowViewModel
    {
        /// <summary>
        /// Rootノード
        /// </summary>
        public List<MyTreeViewItem> RootNode { get; } = new List<MyTreeViewItem>();

        /// <summary>
        /// ツリーを作成
        /// </summary>
        public void MakeTree()
        {
            var root = new MyTreeViewItem("Root");
            for (int i = 0; i < 10; i++)
            {
                var treeX = new MyTreeViewItem($"Item-{i}");
                root.AddChildren(treeX);
                for (int j = 0; j < 50; j++)
                {
                    var treeY = new MyTreeViewItem($"SubItem-{i}:{j}");
                    treeX.AddChildren(treeY);
                }
            }

            this.RootNode.Add(root);
        }
    }
}
