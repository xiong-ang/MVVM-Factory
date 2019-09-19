using System.ComponentModel;

namespace MVVMBase
{
    public class NotificationObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaiseProperityChanged(string properityName)
        {
            if (!string.IsNullOrWhiteSpace(properityName))
                this.PropertyChanged(this, new PropertyChangedEventArgs(properityName));
        }
    }
}
