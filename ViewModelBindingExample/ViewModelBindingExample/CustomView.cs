using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ViewModelBindingExample
{
    public class CustomView : View
    {
        public static readonly BindableProperty ItemSelectedProperty =
            BindableProperty.Create<CustomView, MyModel>(p => p.ItemSelected, null);

        public MyModel ItemSelected
        {
            get { return (MyModel)GetValue(ItemSelectedProperty); }
            set { SetValue(ItemSelectedProperty, value); } // it would rise ElementPropertyChanged event
        }
    }
}
