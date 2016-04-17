using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='DefaultLibraryInfo']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/utils/DefaultLibraryInfo", DoNotGenerateAcw=true)]
	public abstract partial class DefaultLibraryInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/utils/DefaultLibraryInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultLibraryInfo); }
		}

		protected DefaultLibraryInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='DefaultLibraryInfo']/constructor[@name='DefaultLibraryInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultLibraryInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DefaultLibraryInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_isProd;
		public static unsafe bool IsProd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='DefaultLibraryInfo']/method[@name='isProd' and count(parameter)=0]"
			[Register ("isProd", "()Z", "GetIsProdHandler")]
			get {
				if (id_isProd == IntPtr.Zero)
					id_isProd = JNIEnv.GetStaticMethodID (class_ref, "isProd", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isProd);
				} finally {
				}
			}
		}

		static IntPtr id_getOverrideLibraryState;
		public static unsafe global::Com.Amazon.Identity.Auth.Device.AccountManagerConstants.OVERIDE_APP_STATE OverrideLibraryState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='DefaultLibraryInfo']/method[@name='getOverrideLibraryState' and count(parameter)=0]"
			[Register ("getOverrideLibraryState", "()Lcom/amazon/identity/auth/device/AccountManagerConstants$OVERIDE_APP_STATE;", "GetGetOverrideLibraryStateHandler")]
			get {
				if (id_getOverrideLibraryState == IntPtr.Zero)
					id_getOverrideLibraryState = JNIEnv.GetStaticMethodID (class_ref, "getOverrideLibraryState", "()Lcom/amazon/identity/auth/device/AccountManagerConstants$OVERIDE_APP_STATE;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AccountManagerConstants.OVERIDE_APP_STATE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOverrideLibraryState), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_setOverrideAppState_Lcom_amazon_identity_auth_device_AccountManagerConstants_OVERIDE_APP_STATE_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='DefaultLibraryInfo']/method[@name='setOverrideAppState' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.AccountManagerConstants.OVERIDE_APP_STATE']]"
		[Register ("setOverrideAppState", "(Lcom/amazon/identity/auth/device/AccountManagerConstants$OVERIDE_APP_STATE;)V", "")]
		public static unsafe void SetOverrideAppState (global::Com.Amazon.Identity.Auth.Device.AccountManagerConstants.OVERIDE_APP_STATE p0)
		{
			if (id_setOverrideAppState_Lcom_amazon_identity_auth_device_AccountManagerConstants_OVERIDE_APP_STATE_ == IntPtr.Zero)
				id_setOverrideAppState_Lcom_amazon_identity_auth_device_AccountManagerConstants_OVERIDE_APP_STATE_ = JNIEnv.GetStaticMethodID (class_ref, "setOverrideAppState", "(Lcom/amazon/identity/auth/device/AccountManagerConstants$OVERIDE_APP_STATE;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setOverrideAppState_Lcom_amazon_identity_auth_device_AccountManagerConstants_OVERIDE_APP_STATE_, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/utils/DefaultLibraryInfo", DoNotGenerateAcw=true)]
	internal partial class DefaultLibraryInfoInvoker : DefaultLibraryInfo {

		public DefaultLibraryInfoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultLibraryInfoInvoker); }
		}

	}

}
