using MVVMBase;

namespace WPFWindowFactory.ViewModels
{
    class Xmal1VM: NotificationObject
    {
        private string textContent="Some text content";

        public string TextContent
        {
            get { return textContent; }
            set
            {
                if(textContent != value)
                {
                    textContent = value;
                    RaiseProperityChanged(textContent);
                }
            }
        }

    }
}
