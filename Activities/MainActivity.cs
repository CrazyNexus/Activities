using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Activities
{
	[Activity(Label = "Activities", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.myButton);

			button.Click += delegate
			{
				// code to open a new activity
				var intent = new Intent(this, typeof(ShareActivity));
				intent.PutExtra("myString", "passed message");

				// share objects between activities
				// http://hmkcode.com/android-passing-java-object-another-activity/

				StartActivity(intent);
			};
		}
	}
}

