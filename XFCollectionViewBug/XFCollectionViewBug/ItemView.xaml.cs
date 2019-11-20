using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFCollectionViewBug
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemView
    {
            public string PageIdStr { get => (string)BindingContext; }
            public int PageId { get => Int32.Parse(PageIdStr, CultureInfo.InvariantCulture); }

            public ItemView()
            {
                InitializeComponent();
                WidthRequest = App.ScreenWidth * 0.95;
                BindingContextChanged += Init;
            }

            private void Init(object sender, EventArgs args)
            {
                if (BindingContext == null)
                    return;

                if (PageId % 2 == 0)
                {
                    BackgroundColor = Color.Red;
                }
                else
                {
                    BackgroundColor = Color.Blue;
                }
            }
    }
}