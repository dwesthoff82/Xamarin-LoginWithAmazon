using System;

namespace Com.Amazon.Identity.Auth.Device.Datastore
{
	public sealed partial class AppInfoDataSource{

		public override Java.Lang.Object CursorToObject(Android.Database.ICursor ic){
		
		
			return this._cursorToObject (ic);
		}



	}

	public sealed partial class AuthorizationCodeDataSource{

		public override Java.Lang.Object CursorToObject(Android.Database.ICursor ic){


			return this._cursorToObject (ic);
		}



	}

	public sealed partial class AuthorizationTokenDataSource{



			public override Java.Lang.Object CursorToObject(Android.Database.ICursor ic){


				return this._cursorToObject (ic);
			}
			
	}

	public sealed partial class ProfileDataSource{

		public override Java.Lang.Object CursorToObject(Android.Database.ICursor ic){


			return this._cursorToObject (ic);
		}



	}
	public sealed partial class RequestedScopeDataSource{

		public override Java.Lang.Object CursorToObject(Android.Database.ICursor ic){


			return this._cursorToObject (ic);
		}



	}
}

