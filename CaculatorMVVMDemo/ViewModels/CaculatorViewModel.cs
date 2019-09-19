using Models;
using MVVMBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class CaculatorViewModel: NotificationObject
    {
        private double input1;
        public double Input1
        {
            get { return input1; }
            set
            {
                if(input1 != value)
                {
                    input1 = value;
                    RaiseProperityChanged("Input1");
                }
            }
        }

        private double input2;
        public double Input2
        {
            get { return input2; }
            set
            {
                if(input2 != value)
                {
                    input2 = value;
                    RaiseProperityChanged("Input2");
                }
            }
        }

        private double result;
        public double Result
        {
            get { return result; }
            set
            {
                if(result != value)
                {
                    result = value;
                    RaiseProperityChanged("Result");
                }
            }
        }


        public DelegateCommand AddCommand { get; set; }
        private void Add(object obj)
        {
            CaculatorService caculatorService = new CaculatorService();
            this.Result = caculatorService.Add(input1, input2);
        }

        public CaculatorViewModel()
        {
            AddCommand = new DelegateCommand(Add);
        }
    }
}
