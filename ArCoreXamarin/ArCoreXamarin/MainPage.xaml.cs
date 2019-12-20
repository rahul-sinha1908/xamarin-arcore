using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ArCoreXamarin {
	public partial class MainPage : ContentPage {
		public MainPage() {
			InitializeComponent();
		}

		public static Action myAction;

		private void Button_Clicked(object sender, EventArgs e) {
			if (myAction != null)
				myAction();
		}
	}
}
