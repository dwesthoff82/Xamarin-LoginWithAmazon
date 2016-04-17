using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Token {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='RefreshAtzToken']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/token/RefreshAtzToken", DoNotGenerateAcw=true)]
	public partial class RefreshAtzToken : global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationToken {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/token/RefreshAtzToken", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RefreshAtzToken); }
		}

		protected RefreshAtzToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='RefreshAtzToken']/constructor[@name='RefreshAtzToken' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RefreshAtzToken ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RefreshAtzToken)) {
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

		static IntPtr id_ctor_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='RefreshAtzToken']/constructor[@name='RefreshAtzToken' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.token.RefreshAtzToken']]"
		[Register (".ctor", "(Lcom/amazon/identity/auth/device/token/RefreshAtzToken;)V", "")]
		public unsafe RefreshAtzToken (global::Com.Amazon.Identity.Auth.Device.Token.RefreshAtzToken p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (RefreshAtzToken)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/identity/auth/device/token/RefreshAtzToken;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/identity/auth/device/token/RefreshAtzToken;)V", __args);
					return;
				}

				if (id_ctor_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_ == IntPtr.Zero)
					id_ctor_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/identity/auth/device/token/RefreshAtzToken;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_identity_auth_device_token_RefreshAtzToken_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='RefreshAtzToken']/constructor[@name='RefreshAtzToken' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Date'] and parameter[5][@type='byte[]']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;[B)V", "")]
		public unsafe RefreshAtzToken (string p0, string p1, string p2, global::Java.Util.Date p3, byte[] p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				if (GetType () != typeof (RefreshAtzToken)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;[B)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_arrayB == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Date_arrayB, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.token']/class[@name='RefreshAtzToken']/constructor[@name='RefreshAtzToken' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[B)V", "")]
		public unsafe RefreshAtzToken (string p0, string p1, string p2, byte[] p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (RefreshAtzToken)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[B)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayB, __args);
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

	}
}
