using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPVersionHelper']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/utils/MAPVersionHelper", DoNotGenerateAcw=true)]
	public sealed partial class MAPVersionHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/utils/MAPVersionHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAPVersionHelper); }
		}

		internal MAPVersionHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getVersionAsString_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPVersionHelper']/method[@name='getVersionAsString' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("getVersionAsString", "([I)Ljava/lang/String;", "")]
		public static unsafe string GetVersionAsString (int[] p0)
		{
			if (id_getVersionAsString_arrayI == IntPtr.Zero)
				id_getVersionAsString_arrayI = JNIEnv.GetStaticMethodID (class_ref, "getVersionAsString", "([I)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVersionAsString_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getVersionInfo_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPVersionHelper']/method[@name='getVersionInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getVersionInfo", "(Ljava/lang/String;)[I", "")]
		public static unsafe int[] GetVersionInfo (string p0)
		{
			if (id_getVersionInfo_Ljava_lang_String_ == IntPtr.Zero)
				id_getVersionInfo_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getVersionInfo", "(Ljava/lang/String;)[I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVersionInfo_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
