using System.ComponentModel;
using TioneV.MobileCompanion.ViewModels;
using Xamarin.Forms;

namespace TioneV.MobileCompanion.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}