using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using System.Reflection;
using Windows.UI.Xaml;

namespace DynamicResourceTest
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private IEnumerable<string> listColors;
        public IEnumerable<string> ListColors
        {
            get { return listColors; }
            set
            {
                if (listColors != value)
                {
                    listColors = value;
                    RaisePropertyChanged("ListColors");
                }
            }
        }

        private string color1;
        public string Color1
        {
            get { return color1; }
            set
            {
                if (color1 != value)
                {
                    color1 = value;
                    RaisePropertyChanged("Color1");
                }
            }
        }

        private string color2;
        public string Color2
        {
            get { return color2; }
            set
            {
                if (color2 != value)
                {
                    color2 = value;
                    RaisePropertyChanged("Color2");
                }
            }
        }

        private string color3;
        public string Color3
        {
            get { return color3; }
            set
            {
                if (color3 != value)
                {
                    color3 = value;
                    RaisePropertyChanged("Color3");
                }
            }
        }

        private string color4;
        public string Color4
        {
            get { return color4; }
            set
            {
                if (color4 != value)
                {
                    color4 = value;
                    RaisePropertyChanged("Color4");
                }
            }
        }

        public MainViewModel()
        {
            ListColors = typeof(Colors).GetRuntimeProperties().Select(t => t.Name);
            PropertyChanged += _PropertyChanged;
        }

        private void _PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName) {
                case "Color1":
                    Helper.SetResourceKey("Color1", Color1);
                    Helper.SetSettingKey("Color1", Color1);
                    break;
                case "Color2":
                    Helper.SetResourceKey("Color2", Color2);
                    Helper.SetSettingKey("Color2", Color2);
                    break;
                case "Color3":
                    Helper.SetResourceKey("Color3", Color3);
                    Helper.SetSettingKey("Color3", Color3);
                    break;
                case "Color4":
                    Helper.SetResourceKey("Color4", Color4);
                    Helper.SetSettingKey("Color4", Color4);
                    break;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}
