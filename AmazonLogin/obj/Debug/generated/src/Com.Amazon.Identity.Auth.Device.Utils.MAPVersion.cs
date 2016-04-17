using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPVersion']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/utils/MAPVersion", DoNotGenerateAcw=true)]
	public sealed partial class MAPVersion : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPVersion']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VERSION_ZERO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPVersion']/field[@name='VERSION_ZERO']"
		[Register ("VERSION_ZERO")]
		public static global::Com.Amazon.Identity.Auth.Device.Utils.MAPVersion VersionZero {
			get {
				if (VERSION_ZERO_jfieldId == IntPtr.Zero)
					VERSION_ZERO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION_ZERO", "Lcom/amazon/identity/auth/device/utils/MAPVersion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERSION_ZERO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Utils.MAPVersion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/utils/MAPVersion", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAPVersion); }
		}

		internal MAPVersion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPVersion']/constructor[@name='MAPVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MAPVersion (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (MAPVersion)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_arrayI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPVersion']/constructor[@name='MAPVersion' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register (".ctor", "([I)V", "")]
		public unsafe MAPVersion (int[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (MAPVersion)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([I)V", __args);
					return;
				}

				if (id_ctor_arrayI == IntPtr.Zero)
					id_ctor_arrayI = JNIEnv.GetMethodID (class_ref, "<init>", "([I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPVersion']/constructor[@name='MAPVersion' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe MAPVersion (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MAPVersion)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static IntPtr id_compare_Lcom_amazon_identity_auth_device_utils_MAPVersion_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPVersion']/method[@name='compare' and count(parameter)=1 and parameter[1][@type='com.amazon.identity.auth.device.utils.MAPVersion']]"
		[Register ("compare", "(Lcom/amazon/identity/auth/device/utils/MAPVersion;)I", "")]
		public unsafe int Compare (global::Com.Amazon.Identity.Auth.Device.Utils.MAPVersion p0)
		{
			if (id_compare_Lcom_amazon_identity_auth_device_utils_MAPVersion_ == IntPtr.Zero)
				id_compare_Lcom_amazon_identity_auth_device_utils_MAPVersion_ = JNIEnv.GetMethodID (class_ref, "compare", "(Lcom/amazon/identity/auth/device/utils/MAPVersion;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod  (Handle, id_compare_Lcom_amazon_identity_auth_device_utils_MAPVersion_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPVersion']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			} finally {
			}
		}

		static IntPtr id_getVersionInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPVersion']/method[@name='getVersionInfo' and count(parameter)=0]"
		[Register ("getVersionInfo", "()[I", "")]
		public unsafe int[] GetVersionInfo ()
		{
			if (id_getVersionInfo == IntPtr.Zero)
				id_getVersionInfo = JNIEnv.GetMethodID (class_ref, "getVersionInfo", "()[I");
			try {
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getVersionInfo), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MAPVersion']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}
}
