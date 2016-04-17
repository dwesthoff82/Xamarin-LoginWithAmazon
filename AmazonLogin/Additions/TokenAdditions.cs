using System;

namespace Com.Amazon.Identity.Auth.Device.Token {

	public partial class RefreshAtzToken
	{
	
			public override Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource GetDataSource(Android.Content.Context c){
				var x=this._getDataSource (c);

				return x;
			}


	}

	public partial class AccessAtzToken
	{

		public override Com.Amazon.Identity.Auth.Device.Datastore.AbstractDataSource GetDataSource(Android.Content.Context c){
			var x=this._getDataSource (c);

			return x;
		}


	}
}

