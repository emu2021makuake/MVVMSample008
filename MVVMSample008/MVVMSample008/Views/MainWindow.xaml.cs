using MVVMSample008.ViewModels;
using System.Windows;

namespace MVVMSample008.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
