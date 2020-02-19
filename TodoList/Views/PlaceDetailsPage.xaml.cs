using Storm.Mvvm.Forms;
using TodoList.ViewModels;
using Xamarin.Forms.Xaml;

namespace TodoList.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaceDetailsPage : BaseContentPage
    {
        public PlaceDetailsPage()
        {
            BindingContext = new PlaceDetailsPageViewModel();
            InitializeComponent();
        }
    }
}