using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='TokenVendor']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/endpoint/TokenVendor", DoNotGenerateAcw=true)]
	public sealed partial class TokenVendor : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/endpoint/TokenVendor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TokenVendor); }
		}

		internal TokenVendor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='TokenVendor']/constructor[@name='TokenVendor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TokenVendor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TokenVendor)) {
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

		static IntPtr id_getCachedScopes_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='TokenVendor']/method[@name='getCachedScopes' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.Context']]"
		[Register ("getCachedScopes", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> GetCachedScopes (string p0, string p1, global::Android.Content.Context p2)
		{
			if (id_getCachedScopes_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getCachedScopes_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getCachedScopes", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::System.Collections.Generic.IList<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> __ret = global::Android.Runtime.JavaList<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getCachedScopes_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getRequestedScopes_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='TokenVendor']/method[@name='getRequestedScopes' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='android.content.Context']]"
		[Register ("getRequestedScopes", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/content/Context;)[Lcom/amazon/identity/auth/device/dataobject/RequestedScope;", "")]
		public unsafe global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope[] GetRequestedScopes (string p0, string p1, string[] p2, global::Android.Content.Context p3)
		{
			if (id_getRequestedScopes_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getRequestedScopes_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getRequestedScopes", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/content/Context;)[Lcom/amazon/identity/auth/device/dataobject/RequestedScope;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope[] __ret = (global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getRequestedScopes_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_insertTokens_Landroid_content_Context_Lcom_amazon_identity_auth_device_token_AccessAtzToken_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='TokenVendor']/method[@name='insertTokens' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.amazon.identity.auth.device.token.AccessAtzToken'] and parameter[3][@type='com.amazon.identity.auth.device.token.RefreshAtzToken'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String[]']]"
		[Register ("insertTokens", "(Landroid/content/Context;Lcom/amazon/identity/auth/device/token/AccessAtzToken;Lcom/amazon/identity/auth/device/token/RefreshAtzToken;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", "")]
		public unsafe void InsertTokens (global::Android.Content.Context p0, global::Com.Amazon.Identity.Auth.Device.Token.AccessAtzToken p1, global::Com.Amazon.Identity.Auth.Device.Token.RefreshAtzToken p2, string p3, string p4, string[] p5)
		{
			if (id_insertTokens_Landroid_content_Context_Lcom_amazon_identity_auth_device_token_AccessAtzToken_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_insertTokens_Landroid_content_Context_Lcom_amazon_identity_auth_device_token_AccessAtzToken_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "insertTokens", "(Landroid/content/Context;Lcom/amazon/identity/auth/device/token/AccessAtzToken;Lcom/amazon/identity/auth/device/token/RefreshAtzToken;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				JNIEnv.CallVoidMethod  (Handle, id_insertTokens_Landroid_content_Context_Lcom_amazon_identity_auth_device_token_AccessAtzToken_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
			}
		}

		static IntPtr id_setServerCommunication_Lcom_amazon_identity_auth_device_endpoint_ServerCommunication_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='TokenVendor']/method[@name='setServerCommunication' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.endpoint.ServerCommunication']]"
		[Register ("setServerCommunication", "(Lcom/amazon/identity/auth/device/endpoint/ServerCommunication;)V", "")]
		public unsafe void SetServerCommunication (global::Com.Amazon.Identity.Auth.Device.Endpoint.ServerCommunication p0)
		{
			if (id_setServerCommunication_Lcom_amazon_identity_auth_device_endpoint_ServerCommunication_ == IntPtr.Zero)
				id_setServerCommunication_Lcom_amazon_identity_auth_device_endpoint_ServerCommunication_ = JNIEnv.GetMethodID (class_ref, "setServerCommunication", "(Lcom/amazon/identity/auth/device/endpoint/ServerCommunication;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setServerCommunication_Lcom_amazon_identity_auth_device_endpoint_ServerCommunication_, __args);
			} finally {
			}
		}

		static IntPtr id_updateExistingRefreshToken_Lcom_amazon_identity_auth_device_dataobject_AuthorizationToken_Lcom_amazon_identity_auth_device_dataobject_AuthorizationToken_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='TokenVendor']/method[@name='updateExistingRefreshToken' and count(parameter)=3 and parameter[1][@type='com.amazon.identity.auth.device.dataobject.AuthorizationToken'] and parameter[2][@type='com.amazon.identity.auth.device.dataobject.AuthorizationToken'] and parameter[3][@type='android.content.Context']]"
		[Register ("updateExistingRefreshToken", "(Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken;Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken;Landroid/content/Context;)V", "")]
		public unsafe void UpdateExistingRefreshToken (global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken p0, global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken p1, global::Android.Content.Context p2)
		{
			if (id_updateExistingRefreshToken_Lcom_amazon_identity_auth_device_dataobject_AuthorizationToken_Lcom_amazon_identity_auth_device_dataobject_AuthorizationToken_Landroid_content_Context_ == IntPtr.Zero)
				id_updateExistingRefreshToken_Lcom_amazon_identity_auth_device_dataobject_AuthorizationToken_Lcom_amazon_identity_auth_device_dataobject_AuthorizationToken_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "updateExistingRefreshToken", "(Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken;Lcom/amazon/identity/auth/device/dataobject/AuthorizationToken;Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod  (Handle, id_updateExistingRefreshToken_Lcom_amazon_identity_auth_device_dataobject_AuthorizationToken_Lcom_amazon_identity_auth_device_dataobject_AuthorizationToken_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_vendNewToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='TokenVendor']/method[@name='vendNewToken' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='android.content.Context']]"
		[Register ("vendNewToken", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;", "")]
		public unsafe string VendNewToken (string p0, string p1, string p2, string[] p3, global::Android.Content.Context p4)
		{
			if (id_vendNewToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_vendNewToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "vendNewToken", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_vendNewToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_vendNewTokensFromCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='TokenVendor']/method[@name='vendNewTokensFromCode' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String[]'] and parameter[6][@type='android.content.Context']]"
		[Register ("vendNewTokensFromCode", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/content/Context;)Landroid/os/Bundle;", "")]
		public unsafe global::Android.OS.Bundle VendNewTokensFromCode (string p0, string p1, string p2, string p3, string[] p4, global::Android.Content.Context p5)
		{
			if (id_vendNewTokensFromCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_vendNewTokensFromCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "vendNewTokensFromCode", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/content/Context;)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_vendNewTokensFromCode_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		static IntPtr id_vendToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.endpoint']/class[@name='TokenVendor']/method[@name='vendToken' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='android.content.Context']]"
		[Register ("vendToken", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;", "")]
		public unsafe string VendToken (string p0, string p1, string p2, string[] p3, string p4, global::Android.Content.Context p5)
		{
			if (id_vendToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_vendToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "vendToken", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_vendToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

	}
}
