using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;
using System.ComponentModel;

namespace WpfApp1
{
    public class VM 
    {
        private Model text;
        public SimpleCommand Simple { get; set; }
        public VM()
        {
            Simple = new SimpleCommand(this);
            text = new Model() { Ten = "oppo" };
            ShowMessageBox=new Ralay<string>((p) => p != null, (p) =>
            {
                MessageBox.Show("Hello"+ p.ToString());
                
            });
            Click = new RalyWithoutPara(() => { Method1(); } );
            ClickCommand = new Ralay<UIElementCollection>((p) => p!=null, (p) =>
            {
                
               
                foreach (var item in p)
                {
                    TextBox a = item as TextBox;
                    if (a==null)
                    {
                        continue;
                    }
                    if (String.IsNullOrEmpty(a.Name))
                    {
                        continue;
                    }
                    if (a.Name.Equals("Txb_a"))
                    {
                        _Text.Ten = a.Text.ToString();
                    }
                }
            });
        }
        internal void Method1()
        {
            MessageBox.Show("Hello");
        }
        public ICommand Click { get; set; }
        public ICommand ClickCommand { get; set; }
        public ICommand ShowMessageBox { get; set; }
        public Model _Text { get => text; set => text = value; }
        
    }
}
