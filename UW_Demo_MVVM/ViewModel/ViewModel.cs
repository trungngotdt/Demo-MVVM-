using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using System.Runtime.CompilerServices;

namespace UW_Demo_MVVM
{
    public class ViewModel
    {
        private Model txt;
      
        public DelegateCommand DeleClick { get; set; }
        public RalyWithoutPara ClickCommand { get; set; }
        public ICommand Click { get; set; }
        public Model Txt { get => txt; set => txt = value; }
        private void DeClick()
        {
            for (int i = 0; i < 3; i++)
            {

            }
        }
        public ViewModel()
        {
            DeleClick = new DelegateCommand(DeClick);
            txt = new Model() { Text = "Oppo" };
            Click = new RalayCommand<UIElementCollection>(p => 
            {
                foreach (var item in p)
                {
                    TextBox a = item as TextBox;
                    if (a == null)
                    {
                        continue;
                    }
                    if (String.IsNullOrEmpty(a.Name))
                    {
                        continue;
                    }
                    if (a.Name.Equals("Txb_a"))
                    {
                        txt.Text=a.Text.ToString();
                    }
                }
            });

            ClickCommand = new RalyWithoutPara(() => {
                txt.Text = "Hello";
            });
        }
    }
}
