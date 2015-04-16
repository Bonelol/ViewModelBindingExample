using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ViewModelBindingExample;
using ViewModelBindingExample.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(CustomView), typeof(CustomViewRenderer))]
namespace ViewModelBindingExample.Droid
{
    public class CustomViewRenderer : ViewRenderer<CustomView, CustomNativeView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomView> e)
        {
            base.OnElementChanged(e);

            var nativeView = new CustomNativeView(this.Context);

            if (e.OldElement != null) { }

            if (e.NewElement != null)
            {
                if (e.NewElement.ItemSelected != null)
                    nativeView.TitleTextView.Text = e.NewElement.ItemSelected.Title;
            }

            SetNativeControl(nativeView);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == CustomView.ItemSelectedProperty.PropertyName)
            {
                this.Control.TitleTextView.Text = this.Element.ItemSelected.Title;
            }
        }
    }
}