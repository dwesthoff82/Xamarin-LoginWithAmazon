using System;

namespace Com.Amazon.Identity.Auth.Device.Dataobject {

	public partial class AuthorizationCode{


		public override Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource GetDataSource(Android.Content.Context c){
			var x=this._getDataSource (c);

			return x;
		}



	}

	public partial class AppInfo{


		public override Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource GetDataSource(Android.Content.Context c){
			var x=this._getDataSource (c);

			return x;
		}



	}

	public partial class Profile{


		public override Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource GetDataSource(Android.Content.Context c){
			var x=this._getDataSource (c);

			return x;
		}



	}

	public partial class RequestedScope{


		public override Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource GetDataSource(Android.Content.Context c){
			var x=this._getDataSource (c);

			return x;
		}



	}



}

