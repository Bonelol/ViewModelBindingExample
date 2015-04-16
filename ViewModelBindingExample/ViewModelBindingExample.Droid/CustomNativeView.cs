using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace ViewModelBindingExample.Droid
{
    public class CustomNativeView : LinearLayout
    {
        public TextView TitleTextView { get; set; }

        protected CustomNativeView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public CustomNativeView(Context context) : base(context)
        {
            LayoutInflater inflater = LayoutInflater.From(context);
            inflater.Inflate(Resource.Layout.custom_native_view, this);
            TitleTextView = FindViewById<TextView>(Resource.Id.title_textView);
        }

        public CustomNativeView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public CustomNativeView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public CustomNativeView(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
        }
    }
}