using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Google.AR.Core;

namespace ArCoreXamarin.Droid.Activities {
	[Activity(Label = "ARSceneActivity", Theme = "@style/MainTheme.NoActionBar")]
	public class ARSceneActivity : Activity {
		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_ar_scene);

			//var sView = FindViewById<SurfaceView>(Resource.Id.surfaceView);
			// Create your application here
		}

		protected override void OnResume() {
			base.OnResume();

			//if (!CameraPermissionHelper.hasCameraPermission(this)) {
			//	CameraPermissionHelper.requestCameraPermission(this);
			//	return;
			//}
			var mSession = new Session(this);
		}
	}
	
}