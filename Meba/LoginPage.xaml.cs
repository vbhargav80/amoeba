using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Meba
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();
		}

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        Navigation.PushModalAsync(new EnterPhone());
	    }
	}
}
