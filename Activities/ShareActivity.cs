﻿//
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

			// wenn dieser Wert nicht übergeben wurde, kommt es zur Laufzeit zu einem Crash. Das kann mittels try catch abgefangen werden
			var myString = Intent.GetStringExtra("myString");
			Log.Debug("DEBUG message", myString);



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

		protected override void OnPause()
		{
			Log.Debug("DEBUG", "OnPaused");
			base.OnPause();
		}

		protected override void OnDestroy()
		{
			Log.Debug("DEBUG", "OnDestroy");
			base.OnDestroy();
		}

		protected override void OnResume()
		{
			Log.Debug("DEBUG", "OnResume");
			base.OnResume();
		}
	}
}
