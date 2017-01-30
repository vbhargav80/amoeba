using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Meba
{
	public partial class EnterPhone : ContentPage
	{
		public EnterPhone ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();
            Back.GestureRecognizers.Add(new TapGestureRecognizer() {Command = new Command(NavigateBack)});
		}

	    private void NavigateBack()
	    {
	        Navigation?.PopModalAsync();
	    }
	}
}
