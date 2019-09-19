using MVVMBase;
using System.IO;
using System.Windows;
using System.Windows.Markup;

namespace WPFWindowFactory.Utils
{
    class WindowFactory
    {
        /// <summary>
        /// Create element from existing element and view model
        /// </summary>
        /// <param name="element"></param>
        /// <param name="vm"></param>
        /// <returns></returns>
        public static FrameworkElement CreateElement(FrameworkElement element, NotificationObject vm)
        {
            if(null != element)
                element.DataContext = vm;

            return element;
        }

        /// <summary>
        /// Create element from resource xaml file and view model
        /// </summary>
        /// <param name="xamlFile"></param>
        /// <param name="vm"></param>
        /// <returns></returns>
        public static FrameworkElement CreateElementFromXmal(string xamlFile, NotificationObject vm)
        {
            FrameworkElement element;
            using (FileStream fs = new FileStream(xamlFile, FileMode.Open))
            {
                element = (FrameworkElement)XamlReader.Load(fs);
            }

            return CreateElement(element, vm);
        }
    }
}
