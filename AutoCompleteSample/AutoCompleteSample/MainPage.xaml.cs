using Syncfusion.SfAutoComplete.XForms;
using Syncfusion.XForms.ComboBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AutoCompleteSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            comboBox.Filter = ContainingSpaceFilter;
        }

        public bool ContainingSpaceFilter(string search, object item)
        {
            return true;
        }
    }
}