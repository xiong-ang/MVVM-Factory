using MVVMBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WPFWindowFactory.Utils;
using WPFWindowFactory.ViewModels;
using WPFWindowFactory.Views;

namespace WPFWindowFactory
{
    class MainWindowVM: NotificationObject
    {
        private Grid container;
        private bool switchFlag = true;

        public MainWindowVM(Grid container)
        {
            this.container = container;
            SwitchCmd = new DelegateCommand(Switch);
        }

        public ICommand SwitchCmd { get; set; }
        private void Switch(object args)
        {
            if (switchFlag)
            {
                this.container.Children.Add(WindowFactory.CreateElement(new View1(), new View1VM()));
            }
            else
            {
                this.container.Children.Add(WindowFactory.CreateElementFromXmal("Xmals/Xmal1.xaml", new Xmal1VM()));
            }
            
            switchFlag = !switchFlag;
        }
    }
}
