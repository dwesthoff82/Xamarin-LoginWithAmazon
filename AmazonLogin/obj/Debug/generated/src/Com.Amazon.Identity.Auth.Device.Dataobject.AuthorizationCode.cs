using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Dataobject {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/dataobject/AuthorizationCode", DoNotGenerateAcw=true)]
	public partial class AuthorizationCode : global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject, global::Android.OS.IParcelable {


		static IntPtr ALL_COLUMNS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode']/field[@name='ALL_COLUMNS']"
		[Register ("ALL_COLUMNS")]
		public static IList<string> AllColumns {
			get {
				if (ALL_COLUMNS_jfieldId == IntPtr.Zero)
					ALL_COLUMNS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL_COLUMNS", "[Ljava/lang/String;");
				return JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ALL_COLUMNS_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode.COL_INDEX']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/dataobject/AuthorizationCode$COL_INDEX", DoNotGenerateAcw=true)]
		public sealed partial class COL_INDEX : global::Java.Lang.Enum {


			static IntPtr APP_FAMILY_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode.COL_INDEX']/field[@name='APP_FAMILY_ID']"
			[Register ("APP_FAMILY_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode.COL_INDEX AppFamilyId {
				get {
					if (APP_FAMILY_ID_jfieldId == IntPtr.Zero)
						APP_FAMILY_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_FAMILY_ID", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationCode$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_FAMILY_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUTHORIZATION_TOKEN_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode.COL_INDEX']/field[@name='AUTHORIZATION_TOKEN_ID']"
			[Register ("AUTHORIZATION_TOKEN_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode.COL_INDEX AuthorizationTokenId {
				get {
					if (AUTHORIZATION_TOKEN_ID_jfieldId == IntPtr.Zero)
						AUTHORIZATION_TOKEN_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHORIZATION_TOKEN_ID", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationCode$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHORIZATION_TOKEN_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CODE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode.COL_INDEX']/field[@name='CODE']"
			[Register ("CODE")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode.COL_INDEX Code {
				get {
					if (CODE_jfieldId == IntPtr.Zero)
						CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CODE", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationCode$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CODE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ROW_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode.COL_INDEX']/field[@name='ROW_ID']"
			[Register ("ROW_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode.COL_INDEX RowId {
				get {
					if (ROW_ID_jfieldId == IntPtr.Zero)
						ROW_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ROW_ID", "Lcom/amazon/identity/auth/device/dataobject/AuthorizationCode$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ROW_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr colId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode.COL_INDEX']/field[@name='colId']"
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
					return JNIEnv.FindClass ("com/amazon/identity/auth/device/dataobject/AuthorizationCode$COL_INDEX", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode.COL_INDEX']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AuthorizationCode$COL_INDEX;", "")]
			public static unsafe global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode.COL_INDEX ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/AuthorizationCode$COL_INDEX;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode.COL_INDEX __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode.COL_INDEX> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode.COL_INDEX']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/identity/auth/device/dataobject/AuthorizationCode$COL_INDEX;", "")]
			public static unsafe global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode.COL_INDEX[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/identity/auth/device/dataobject/AuthorizationCode$COL_INDEX;");
				try {
					return (global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode.COL_INDEX[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode.COL_INDEX));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/dataobject/AuthorizationCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthorizationCode); }
		}

		protected AuthorizationCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode']/constructor[@name='AuthorizationCode' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;J)V", "")]
		public unsafe AuthorizationCode (string p0, string p1, long p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (AuthorizationCode)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;J)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode']/constructor[@name='AuthorizationCode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AuthorizationCode ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AuthorizationCode)) {
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
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppFamilyId);
		}
#pragma warning restore 0169

		static IntPtr id_getAppFamilyId;
		public virtual unsafe string AppFamilyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode']/method[@name='getAppFamilyId' and count(parameter)=0]"
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

		static Delegate cb_getAuthorizationTokenId;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationTokenIdHandler ()
		{
			if (cb_getAuthorizationTokenId == null)
				cb_getAuthorizationTokenId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAuthorizationTokenId);
			return cb_getAuthorizationTokenId;
		}

		static long n_GetAuthorizationTokenId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AuthorizationTokenId;
		}
#pragma warning restore 0169

		static Delegate cb_setAuthorizationTokenId_J;
#pragma warning disable 0169
		static Delegate GetSetAuthorizationTokenId_JHandler ()
		{
			if (cb_setAuthorizationTokenId_J == null)
				cb_setAuthorizationTokenId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetAuthorizationTokenId_J);
			return cb_setAuthorizationTokenId_J;
		}

		static void n_SetAuthorizationTokenId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AuthorizationTokenId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthorizationTokenId;
		static IntPtr id_setAuthorizationTokenId_J;
		public virtual unsafe long AuthorizationTokenId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode']/method[@name='getAuthorizationTokenId' and count(parameter)=0]"
			[Register ("getAuthorizationTokenId", "()J", "GetGetAuthorizationTokenIdHandler")]
			get {
				if (id_getAuthorizationTokenId == IntPtr.Zero)
					id_getAuthorizationTokenId = JNIEnv.GetMethodID (class_ref, "getAuthorizationTokenId", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getAuthorizationTokenId);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthorizationTokenId", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode']/method[@name='setAuthorizationTokenId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setAuthorizationTokenId", "(J)V", "GetSetAuthorizationTokenId_JHandler")]
			set {
				if (id_setAuthorizationTokenId_J == IntPtr.Zero)
					id_setAuthorizationTokenId_J = JNIEnv.GetMethodID (class_ref, "setAuthorizationTokenId", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAuthorizationTokenId_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuthorizationTokenId", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCode;
#pragma warning disable 0169
		static Delegate GetGetCodeHandler ()
		{
			if (cb_getCode == null)
				cb_getCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCode);
			return cb_getCode;
		}

		static IntPtr n_GetCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Code);
		}
#pragma warning restore 0169

		static Delegate cb_setCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCode_Ljava_lang_String_Handler ()
		{
			if (cb_setCode_Ljava_lang_String_ == null)
				cb_setCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCode_Ljava_lang_String_);
			return cb_setCode_Ljava_lang_String_;
		}

		static void n_SetCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Code = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCode;
		static IntPtr id_setCode_Ljava_lang_String_;
		public virtual unsafe string Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()Ljava/lang/String;", "GetGetCodeHandler")]
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCode", "(Ljava/lang/String;)V", "GetSetCode_Ljava_lang_String_Handler")]
			set {
				if (id_setCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValuesForInsert);
		}
#pragma warning restore 0169

		static IntPtr id_getValuesForInsert;
		public override unsafe global::Android.Content.ContentValues ValuesForInsert {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode']/method[@name='getValuesForInsert' and count(parameter)=0]"
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

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/amazon/identity/auth/device/dataobject/AuthorizationCode;", "GetCloneHandler")]
		public virtual unsafe global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/amazon/identity/auth/device/dataobject/AuthorizationCode;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lcom/amazon/identity/auth/device/dataobject/AuthorizationCode;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
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
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this._getDataSource (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDataSource_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode']/method[@name='getDataSource' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDataSource", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/AuthorizationCodeDataSource;", "Get_getDataSource_Landroid_content_Context_Handler")]
		public virtual unsafe global::Com.Amazon.Identity.Auth.Device.Datastore.AuthorizationCodeDataSource _getDataSource (global::Android.Content.Context p0)
		{
			if (id_getDataSource_Landroid_content_Context_ == IntPtr.Zero)
				id_getDataSource_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getDataSource", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/AuthorizationCodeDataSource;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Identity.Auth.Device.Datastore.AuthorizationCodeDataSource __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AuthorizationCodeDataSource> (JNIEnv.CallObjectMethod  (Handle, id_getDataSource_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.AuthorizationCodeDataSource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataSource", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/AuthorizationCodeDataSource;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAppId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAppId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode']/method[@name='setAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setId_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setId", "(J)V", "GetSetId_JHandler")]
		public virtual unsafe void SetId (long p0)
		{
			if (id_setId_J == IntPtr.Zero)
				id_setId_J = JNIEnv.GetMethodID (class_ref, "setId", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setId_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setId", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.AuthorizationCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='AuthorizationCode']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
