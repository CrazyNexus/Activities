//
// ShareActivity.cs
//
// Created by Thomas Dubiel on 16.06.2017
// Copyright 2017 Thomas Dubiel. All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Activities
{
	[Activity(Label = "ShareActivity")]
	public class ShareActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.NewActivityLayout);

			Button shareButton = FindViewById<Button>(Resource.Id.shareButton);

			shareButton.Click += delegate
			{
				Log.Debug("DEBUG", "Share Button Pressed!");
				this.Finish();
			};
		}

		public override void OnBackPressed()
		{
			// disable the device Back button or do some extra stuff (save for example
			Log.Debug("DEBUG", "Back Button Pressed!");
			base.OnBackPressed();
		}
	}
}
