namespace TreeView001
{
    using System.Collections.Generic;

    /// <summary>
    /// Treeノード
    /// </summary>
    public class MyTreeViewItem
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name"></param>
        public MyTreeViewItem(string name)
        {
            this.Name = name;
        }

        public string Name { get; } = string.Empty;

        public bool IsExpanded { get; set; } = true;

        public List<MyTreeViewItem> Children { get; } = new List<MyTreeViewItem>();

        /// <summary>
        /// 子ノードを追加。
        /// </summary>
        /// <param name="cildren">子ノード</param>
        public void AddChildren(MyTreeViewItem cildren)
        {
            this.Children.Add(cildren);
        }
    }
}
