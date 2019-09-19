using System.Windows;
using ViewModels;
using Views;

namespace Caculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Create Control
            CaculatorControl caculatorControl = new CaculatorControl();
            //Bind View and ViewModel
            caculatorControl.DataContext = new CaculatorViewModel();

            this.Content = caculatorControl;
        }
    }
}
