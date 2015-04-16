using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelBindingExample
{
    public class CustomViewModel : ObservableObject
    {
        private MyModel _itemSelected;
        public MyModel ItemSelected { get { return _itemSelected; } set { SetProperty(ref _itemSelected, value); } }

        public CustomViewModel()
        {
            ItemSelected = new MyModel();
        }
    }
}
