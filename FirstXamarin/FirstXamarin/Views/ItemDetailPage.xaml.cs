using FirstXamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FirstXamarin.Views
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