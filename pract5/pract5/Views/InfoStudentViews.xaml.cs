using pract5.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pract5.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InfoStudentViews : ContentPage
	{
		public InfoStudentViews ()
		{
			InitializeComponent ();
            BindingContext = new InfoStudentViewModel();
        }
	}
}