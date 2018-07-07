namespace TreeView001
{
    using System.Windows;

    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //// ViewModelの作成
            MainWindowViewModel vm = new MainWindowViewModel();
            //// TreeViewの項目を作成
            vm.MakeTree();
            //// MainWindowの作成
            MainWindow window = new MainWindow
            {
                //// ViewModelの割り当て
                DataContext = vm
            };

            //// MainWindowの表示
            window.Show();
        }
    }
}
