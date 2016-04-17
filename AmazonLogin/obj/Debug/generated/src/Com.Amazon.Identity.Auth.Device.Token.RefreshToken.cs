using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Token {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='RefreshToken']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/token/RefreshToken", DoNotGenerateAcw=true)]
	public partial class RefreshToken : global::Com.Amazon.Identity.Auth.Device.Token.AbstractToken {


		static IntPtr DEFAULT_REGION_HINT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='RefreshToken']/field[@name='DEFAULT_REGION_HINT']"
		[Register ("DEFAULT_REGION_HINT")]
		public static global::Com.Amazon.Identity.Auth.Device.AccountManagerConstants.REGION_HINT DefaultRegionHint {
			get {
				if (DEFAULT_REGION_HINT_jfieldId == IntPtr.Zero)
					DEFAULT_REGION_HINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_REGION_HINT", "Lcom/amazon/identity/auth/device/AccountManagerConstants$REGION_HINT;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_REGION_HINT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AccountManagerConstants.REGION_HINT> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/token/RefreshToken", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RefreshToken); }
		}

		protected RefreshToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='RefreshToken']/constructor[@name='RefreshToken' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/util/Map;)V", "")]
		public unsafe RefreshToken (global::System.Collections.Generic.IDictionary<string, string> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (RefreshToken)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_amazon_identity_auth_device_AccountManagerConstants_REGION_HINT_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='RefreshToken']/constructor[@name='RefreshToken' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.identity.auth.device.AccountManagerConstants.REGION_HINT'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/amazon/identity/auth/device/AccountManagerConstants$REGION_HINT;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe RefreshToken (string p0, global::Com.Amazon.Identity.Auth.Device.AccountManagerConstants.REGION_HINT p1, string p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (RefreshToken)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/amazon/identity/auth/device/AccountManagerConstants$REGION_HINT;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/amazon/identity/auth/device/AccountManagerConstants$REGION_HINT;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_amazon_identity_auth_device_AccountManagerConstants_REGION_HINT_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_amazon_identity_auth_device_AccountManagerConstants_REGION_HINT_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/amazon/identity/auth/device/AccountManagerConstants$REGION_HINT;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_amazon_identity_auth_device_AccountManagerConstants_REGION_HINT_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_amazon_identity_auth_device_AccountManagerConstants_REGION_HINT_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_amazon_identity_auth_device_AccountManagerConstants_REGION_HINT_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='RefreshToken']/constructor[@name='RefreshToken' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.amazon.identity.auth.device.AccountManagerConstants.REGION_HINT'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/amazon/identity/auth/device/AccountManagerConstants$REGION_HINT;Ljava/lang/String;)V", "")]
		public unsafe RefreshToken (string p0, global::Com.Amazon.Identity.Auth.Device.AccountManagerConstants.REGION_HINT p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (RefreshToken)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/amazon/identity/auth/device/AccountManagerConstants$REGION_HINT;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/amazon/identity/auth/device/AccountManagerConstants$REGION_HINT;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_amazon_identity_auth_device_AccountManagerConstants_REGION_HINT_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_amazon_identity_auth_device_AccountManagerConstants_REGION_HINT_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/amazon/identity/auth/device/AccountManagerConstants$REGION_HINT;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_amazon_identity_auth_device_AccountManagerConstants_REGION_HINT_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_amazon_identity_auth_device_AccountManagerConstants_REGION_HINT_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='RefreshToken']/constructor[@name='RefreshToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe RefreshToken (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (RefreshToken)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='RefreshToken']/constructor[@name='RefreshToken' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe RefreshToken (string p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (RefreshToken)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getDMSDirectedId;
#pragma warning disable 0169
		static Delegate GetGetDMSDirectedIdHandler ()
		{
			if (cb_getDMSDirectedId == null)
				cb_getDMSDirectedId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDMSDirectedId);
			return cb_getDMSDirectedId;
		}

		static IntPtr n_GetDMSDirectedId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.RefreshToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.RefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DMSDirectedId);
		}
#pragma warning restore 0169

		static IntPtr id_getDMSDirectedId;
		public virtual unsafe string DMSDirectedId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='RefreshToken']/method[@name='getDMSDirectedId' and count(parameter)=0]"
			[Register ("getDMSDirectedId", "()Ljava/lang/String;", "GetGetDMSDirectedIdHandler")]
			get {
				if (id_getDMSDirectedId == IntPtr.Zero)
					id_getDMSDirectedId = JNIEnv.GetMethodID (class_ref, "getDMSDirectedId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDMSDirectedId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDMSDirectedId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRegionHint;
#pragma warning disable 0169
		static Delegate GetGetRegionHintHandler ()
		{
			if (cb_getRegionHint == null)
				cb_getRegionHint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRegionHint);
			return cb_getRegionHint;
		}

		static IntPtr n_GetRegionHint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.RefreshToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.RefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RegionHint);
		}
#pragma warning restore 0169

		static IntPtr id_getRegionHint;
		public virtual unsafe global::Com.Amazon.Identity.Auth.Device.AccountManagerConstants.REGION_HINT RegionHint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='RefreshToken']/method[@name='getRegionHint' and count(parameter)=0]"
			[Register ("getRegionHint", "()Lcom/amazon/identity/auth/device/AccountManagerConstants$REGION_HINT;", "GetGetRegionHintHandler")]
			get {
				if (id_getRegionHint == IntPtr.Zero)
					id_getRegionHint = JNIEnv.GetMethodID (class_ref, "getRegionHint", "()Lcom/amazon/identity/auth/device/AccountManagerConstants$REGION_HINT;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AccountManagerConstants.REGION_HINT> (JNIEnv.CallObjectMethod  (Handle, id_getRegionHint), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.AccountManagerConstants.REGION_HINT> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegionHint", "()Lcom/amazon/identity/auth/device/AccountManagerConstants$REGION_HINT;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.RefreshToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.RefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='RefreshToken']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUniqueId;
#pragma warning disable 0169
		static Delegate GetGetUniqueIdHandler ()
		{
			if (cb_getUniqueId == null)
				cb_getUniqueId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUniqueId);
			return cb_getUniqueId;
		}

		static IntPtr n_GetUniqueId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.RefreshToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.RefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UniqueId);
		}
#pragma warning restore 0169

		static IntPtr id_getUniqueId;
		public virtual unsafe string UniqueId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='RefreshToken']/method[@name='getUniqueId' and count(parameter)=0]"
			[Register ("getUniqueId", "()Ljava/lang/String;", "GetGetUniqueIdHandler")]
			get {
				if (id_getUniqueId == IntPtr.Zero)
					id_getUniqueId = JNIEnv.GetMethodID (class_ref, "getUniqueId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUniqueId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUniqueId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setDMSDirectedId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDMSDirectedId_Ljava_lang_String_Handler ()
		{
			if (cb_setDMSDirectedId_Ljava_lang_String_ == null)
				cb_setDMSDirectedId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDMSDirectedId_Ljava_lang_String_);
			return cb_setDMSDirectedId_Ljava_lang_String_;
		}

		static IntPtr n_SetDMSDirectedId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Token.RefreshToken __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Token.RefreshToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SetDMSDirectedId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDMSDirectedId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='RefreshToken']/method[@name='setDMSDirectedId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDMSDirectedId", "(Ljava/lang/String;)Ljava/lang/String;", "GetSetDMSDirectedId_Ljava_lang_String_Handler")]
		public virtual unsafe string SetDMSDirectedId (string p0)
		{
			if (id_setDMSDirectedId_Ljava_lang_String_ == IntPtr.Zero)
				id_setDMSDirectedId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDMSDirectedId", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_setDMSDirectedId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDMSDirectedId", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
