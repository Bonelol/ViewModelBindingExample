using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelBindingExample
{
    public class MyModel
    {
        public string Title { get; set; }

        public MyModel()
        {
            this.Title = "Clicked 0 time";
        }
    }
}
