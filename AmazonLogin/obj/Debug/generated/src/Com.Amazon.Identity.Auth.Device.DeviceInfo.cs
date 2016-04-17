using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='DeviceInfo']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/DeviceInfo", DoNotGenerateAcw=true)]
	public partial class DeviceInfo : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='DeviceInfo']/field[@name='EMPTY_FIELD']"
		[Register ("EMPTY_FIELD")]
		public const string EmptyField = (string) "unknown";

		static IntPtr manufacturer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='DeviceInfo']/field[@name='manufacturer']"
		[Register ("manufacturer")]
		public static string Manufacturer {
			get {
				if (manufacturer_jfieldId == IntPtr.Zero)
					manufacturer_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "manufacturer", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, manufacturer_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr model_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='DeviceInfo']/field[@name='model']"
		[Register ("model")]
		public static string Model {
			get {
				if (model_jfieldId == IntPtr.Zero)
					model_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "model", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, model_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr release_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='DeviceInfo']/field[@name='release']"
		[Register ("release")]
		public static string Release {
			get {
				if (release_jfieldId == IntPtr.Zero)
					release_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "release", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, release_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr sdk_version_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='DeviceInfo']/field[@name='sdk_version']"
		[Register ("sdk_version")]
		public static int SdkVersion {
			get {
				if (sdk_version_jfieldId == IntPtr.Zero)
					sdk_version_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sdk_version", "I");
				return JNIEnv.GetStaticIntField (class_ref, sdk_version_jfieldId);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/DeviceInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceInfo); }
		}

		protected DeviceInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device']/class[@name='DeviceInfo']/constructor[@name='DeviceInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DeviceInfo (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DeviceInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}
