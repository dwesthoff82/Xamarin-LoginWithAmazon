using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Dataobject {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/dataobject/Profile", DoNotGenerateAcw=true)]
	public partial class Profile : global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject {


		static IntPtr ALL_COLUMNS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/field[@name='ALL_COLUMNS']"
		[Register ("ALL_COLUMNS")]
		public static IList<string> AllColumns {
			get {
				if (ALL_COLUMNS_jfieldId == IntPtr.Zero)
					ALL_COLUMNS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL_COLUMNS", "[Ljava/lang/String;");
				return JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ALL_COLUMNS_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr mAppFamilyId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/field[@name='mAppFamilyId']"
		[Register ("mAppFamilyId")]
		protected string MAppFamilyId {
			get {
				if (mAppFamilyId_jfieldId == IntPtr.Zero)
					mAppFamilyId_jfieldId = JNIEnv.GetFieldID (class_ref, "mAppFamilyId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mAppFamilyId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAppFamilyId_jfieldId == IntPtr.Zero)
					mAppFamilyId_jfieldId = JNIEnv.GetFieldID (class_ref, "mAppFamilyId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, mAppFamilyId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/field[@name='mData']"
		[Register ("mData")]
		protected string MData {
			get {
				if (mData_jfieldId == IntPtr.Zero)
					mData_jfieldId = JNIEnv.GetFieldID (class_ref, "mData", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mData_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mData_jfieldId == IntPtr.Zero)
					mData_jfieldId = JNIEnv.GetFieldID (class_ref, "mData", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, mData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mExpirationTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/field[@name='mExpirationTime']"
		[Register ("mExpirationTime")]
		protected global::Java.Util.Date MExpirationTime {
			get {
				if (mExpirationTime_jfieldId == IntPtr.Zero)
					mExpirationTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mExpirationTime", "Ljava/util/Date;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mExpirationTime_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mExpirationTime_jfieldId == IntPtr.Zero)
					mExpirationTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mExpirationTime", "Ljava/util/Date;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mExpirationTime_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile.COL_INDEX']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/dataobject/Profile$COL_INDEX", DoNotGenerateAcw=true)]
		public sealed partial class COL_INDEX : global::Java.Lang.Enum {


			static IntPtr APP_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile.COL_INDEX']/field[@name='APP_ID']"
			[Register ("APP_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile.COL_INDEX AppId {
				get {
					if (APP_ID_jfieldId == IntPtr.Zero)
						APP_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_ID", "Lcom/amazon/identity/auth/device/dataobject/Profile$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DATA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile.COL_INDEX']/field[@name='DATA']"
			[Register ("DATA")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile.COL_INDEX Data {
				get {
					if (DATA_jfieldId == IntPtr.Zero)
						DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA", "Lcom/amazon/identity/auth/device/dataobject/Profile$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EXPIRATION_TIME_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile.COL_INDEX']/field[@name='EXPIRATION_TIME']"
			[Register ("EXPIRATION_TIME")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile.COL_INDEX ExpirationTime {
				get {
					if (EXPIRATION_TIME_jfieldId == IntPtr.Zero)
						EXPIRATION_TIME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPIRATION_TIME", "Lcom/amazon/identity/auth/device/dataobject/Profile$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXPIRATION_TIME_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile.COL_INDEX']/field[@name='ID']"
			[Register ("ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile.COL_INDEX Id {
				get {
					if (ID_jfieldId == IntPtr.Zero)
						ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ID", "Lcom/amazon/identity/auth/device/dataobject/Profile$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr colId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile.COL_INDEX']/field[@name='colId']"
			[Register ("colId")]
			public int ColId {
				get {
					if (colId_jfieldId == IntPtr.Zero)
						colId_jfieldId = JNIEnv.GetFieldID (class_ref, "colId", "I");
					return JNIEnv.GetIntField (Handle, colId_jfieldId);
				}
				set {
					if (colId_jfieldId == IntPtr.Zero)
						colId_jfieldId = JNIEnv.GetFieldID (class_ref, "colId", "I");
					try {
						JNIEnv.SetField (Handle, colId_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/identity/auth/device/dataobject/Profile$COL_INDEX", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (COL_INDEX); }
			}

			internal COL_INDEX (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile.COL_INDEX']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/Profile$COL_INDEX;", "")]
			public static unsafe global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile.COL_INDEX ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/Profile$COL_INDEX;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile.COL_INDEX __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile.COL_INDEX> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile.COL_INDEX']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/identity/auth/device/dataobject/Profile$COL_INDEX;", "")]
			public static unsafe global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile.COL_INDEX[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/identity/auth/device/dataobject/Profile$COL_INDEX;");
				try {
					return (global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile.COL_INDEX[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile.COL_INDEX));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/dataobject/Profile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Profile); }
		}

		protected Profile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/constructor[@name='Profile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Profile (string p0, string p1)
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
				if (GetType () != typeof (Profile)) {
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

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/constructor[@name='Profile' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Profile ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Profile)) {
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

		static Delegate cb_getAppFamilyId;
#pragma warning disable 0169
		static Delegate GetGetAppFamilyIdHandler ()
		{
			if (cb_getAppFamilyId == null)
				cb_getAppFamilyId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppFamilyId);
			return cb_getAppFamilyId;
		}

		static IntPtr n_GetAppFamilyId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppFamilyId);
		}
#pragma warning restore 0169

		static IntPtr id_getAppFamilyId;
		public virtual unsafe string AppFamilyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/method[@name='getAppFamilyId' and count(parameter)=0]"
			[Register ("getAppFamilyId", "()Ljava/lang/String;", "GetGetAppFamilyIdHandler")]
			get {
				if (id_getAppFamilyId == IntPtr.Zero)
					id_getAppFamilyId = JNIEnv.GetMethodID (class_ref, "getAppFamilyId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppFamilyId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppFamilyId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Data);
		}
#pragma warning restore 0169

		static Delegate cb_setData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetData_Ljava_lang_String_Handler ()
		{
			if (cb_setData_Ljava_lang_String_ == null)
				cb_setData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Ljava_lang_String_);
			return cb_setData_Ljava_lang_String_;
		}

		static void n_SetData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Data = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		static IntPtr id_setData_Ljava_lang_String_;
		public virtual unsafe string Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/lang/String;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setData", "(Ljava/lang/String;)V", "GetSetData_Ljava_lang_String_Handler")]
			set {
				if (id_setData_Ljava_lang_String_ == IntPtr.Zero)
					id_setData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setData", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setData_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDataAsBundle;
#pragma warning disable 0169
		static Delegate GetGetDataAsBundleHandler ()
		{
			if (cb_getDataAsBundle == null)
				cb_getDataAsBundle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataAsBundle);
			return cb_getDataAsBundle;
		}

		static IntPtr n_GetDataAsBundle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataAsBundle);
		}
#pragma warning restore 0169

		static IntPtr id_getDataAsBundle;
		public virtual unsafe global::Android.OS.Bundle DataAsBundle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/method[@name='getDataAsBundle' and count(parameter)=0]"
			[Register ("getDataAsBundle", "()Landroid/os/Bundle;", "GetGetDataAsBundleHandler")]
			get {
				if (id_getDataAsBundle == IntPtr.Zero)
					id_getDataAsBundle = JNIEnv.GetMethodID (class_ref, "getDataAsBundle", "()Landroid/os/Bundle;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_getDataAsBundle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataAsBundle", "()Landroid/os/Bundle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExpirationTime;
#pragma warning disable 0169
		static Delegate GetGetExpirationTimeHandler ()
		{
			if (cb_getExpirationTime == null)
				cb_getExpirationTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpirationTime);
			return cb_getExpirationTime;
		}

		static IntPtr n_GetExpirationTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExpirationTime);
		}
#pragma warning restore 0169

		static Delegate cb_setExpirationTime_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetExpirationTime_Ljava_util_Date_Handler ()
		{
			if (cb_setExpirationTime_Ljava_util_Date_ == null)
				cb_setExpirationTime_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExpirationTime_Ljava_util_Date_);
			return cb_setExpirationTime_Ljava_util_Date_;
		}

		static void n_SetExpirationTime_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExpirationTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExpirationTime;
		static IntPtr id_setExpirationTime_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date ExpirationTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/method[@name='getExpirationTime' and count(parameter)=0]"
			[Register ("getExpirationTime", "()Ljava/util/Date;", "GetGetExpirationTimeHandler")]
			get {
				if (id_getExpirationTime == IntPtr.Zero)
					id_getExpirationTime = JNIEnv.GetMethodID (class_ref, "getExpirationTime", "()Ljava/util/Date;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getExpirationTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpirationTime", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/method[@name='setExpirationTime' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setExpirationTime", "(Ljava/util/Date;)V", "GetSetExpirationTime_Ljava_util_Date_Handler")]
			set {
				if (id_setExpirationTime_Ljava_util_Date_ == IntPtr.Zero)
					id_setExpirationTime_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setExpirationTime", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setExpirationTime_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExpirationTime", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_hasExpired;
#pragma warning disable 0169
		static Delegate GetHasExpiredHandler ()
		{
			if (cb_hasExpired == null)
				cb_hasExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasExpired);
			return cb_hasExpired;
		}

		static bool n_HasExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasExpired;
		}
#pragma warning restore 0169

		static IntPtr id_hasExpired;
		public virtual unsafe bool HasExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/method[@name='hasExpired' and count(parameter)=0]"
			[Register ("hasExpired", "()Z", "GetHasExpiredHandler")]
			get {
				if (id_hasExpired == IntPtr.Zero)
					id_hasExpired = JNIEnv.GetMethodID (class_ref, "hasExpired", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasExpired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasExpired", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetId);
			return cb_getId;
		}

		static long n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		static Delegate cb_setId_J;
#pragma warning disable 0169
		static Delegate GetSetId_JHandler ()
		{
			if (cb_setId_J == null)
				cb_setId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetId_J);
			return cb_setId_J;
		}

		static void n_SetId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_J;
		public virtual unsafe long Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()J", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getId);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setId", "(J)V", "GetSetId_JHandler")]
			set {
				if (id_setId_J == IntPtr.Zero)
					id_setId_J = JNIEnv.GetMethodID (class_ref, "setId", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setId_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setId", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getValuesForInsert;
#pragma warning disable 0169
		static Delegate GetGetValuesForInsertHandler ()
		{
			if (cb_getValuesForInsert == null)
				cb_getValuesForInsert = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValuesForInsert);
			return cb_getValuesForInsert;
		}

		static IntPtr n_GetValuesForInsert (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValuesForInsert);
		}
#pragma warning restore 0169

		static IntPtr id_getValuesForInsert;
		public override unsafe global::Android.Content.ContentValues ValuesForInsert {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/method[@name='getValuesForInsert' and count(parameter)=0]"
			[Register ("getValuesForInsert", "()Landroid/content/ContentValues;", "GetGetValuesForInsertHandler")]
			get {
				if (id_getValuesForInsert == IntPtr.Zero)
					id_getValuesForInsert = JNIEnv.GetMethodID (class_ref, "getValuesForInsert", "()Landroid/content/ContentValues;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallObjectMethod  (Handle, id_getValuesForInsert), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValuesForInsert", "()Landroid/content/ContentValues;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "GetEquals_Ljava_lang_Object_Handler")]
		public override unsafe bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_equals_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "equals", "(Ljava/lang/Object;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getDataSource_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate Get_getDataSource_Landroid_content_Context_Handler ()
		{
			if (cb_getDataSource_Landroid_content_Context_ == null)
				cb_getDataSource_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n__getDataSource_Landroid_content_Context_);
			return cb_getDataSource_Landroid_content_Context_;
		}

		static IntPtr n__getDataSource_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this._getDataSource (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDataSource_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/method[@name='getDataSource' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDataSource", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/ProfileDataSource;", "Get_getDataSource_Landroid_content_Context_Handler")]
		public virtual unsafe global::Com.Amazon.Identity.Auth.Device.Datastore.ProfileDataSource _getDataSource (global::Android.Content.Context p0)
		{
			if (id_getDataSource_Landroid_content_Context_ == IntPtr.Zero)
				id_getDataSource_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getDataSource", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/ProfileDataSource;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Identity.Auth.Device.Datastore.ProfileDataSource __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.ProfileDataSource> (JNIEnv.CallObjectMethod  (Handle, id_getDataSource_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.ProfileDataSource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataSource", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/ProfileDataSource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setAppId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppId_Ljava_lang_String_Handler ()
		{
			if (cb_setAppId_Ljava_lang_String_ == null)
				cb_setAppId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppId_Ljava_lang_String_);
			return cb_setAppId_Ljava_lang_String_;
		}

		static void n_SetAppId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAppId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAppId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/method[@name='setAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAppId", "(Ljava/lang/String;)V", "GetSetAppId_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAppId (string p0)
		{
			if (id_setAppId_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAppId_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppId", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_toLogString;
#pragma warning disable 0169
		static Delegate GetToLogStringHandler ()
		{
			if (cb_toLogString == null)
				cb_toLogString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToLogString);
			return cb_toLogString;
		}

		static IntPtr n_ToLogString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Profile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToLogString ());
		}
#pragma warning restore 0169

		static IntPtr id_toLogString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='Profile']/method[@name='toLogString' and count(parameter)=0]"
		[Register ("toLogString", "()Ljava/lang/String;", "GetToLogStringHandler")]
		public virtual unsafe string ToLogString ()
		{
			if (id_toLogString == IntPtr.Zero)
				id_toLogString = JNIEnv.GetMethodID (class_ref, "toLogString", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toLogString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toLogString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
