using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ViewModelBindingExample
{
    public class CustomPage : ContentPage
    {
        private int _count;

        public CustomPage()
        {
            this.BindingContext = new CustomViewModel();

            var view = new CustomView();
            view.SetBinding(CustomView.ItemSelectedProperty, "ItemSelected");

            var button = new Button() {Text = "Click Me"};
            button.Clicked += (sender, args) =>
            {
                var viewModel = this.BindingContext as CustomViewModel;

                if (viewModel != null)
                {
                    _count++;
                    viewModel.ItemSelected = new MyModel(){Title = string.Format("Clicked {0} times", _count)};
                }
            };

            var stackLayout = new StackLayout();
            stackLayout.Children.Add(view);
            stackLayout.Children.Add(button);

            this.Content = stackLayout;
        }
    }
}
