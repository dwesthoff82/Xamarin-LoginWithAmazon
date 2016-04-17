using System;

namespace Com.Amazon.Identity.Auth.Device.Thread {

	public partial class MAPCallbackFuture {

		public Java.Lang.Object Get(){
		

		
			return this._get();
		}


		public Java.Lang.Object Get(long x,Java.Util.Concurrent.TimeUnit tu){

		
			var xx = this._get (x, tu);

			return xx;
		}



	}
}

