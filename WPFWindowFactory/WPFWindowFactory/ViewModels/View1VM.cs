using MVVMBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFWindowFactory.ViewModels
{
    class View1VM: NotificationObject
    {
        private string btnName = "Btn Value";

        public string BtnName
        {
            get { return btnName; }
            set
            {
                if(btnName != value)
                {
                    btnName = value;
                    RaiseProperityChanged(btnName);
                }
            }
        }

    }
}
