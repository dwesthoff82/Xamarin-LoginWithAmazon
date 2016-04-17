using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Dataobject {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/dataobject/RequestedScope", DoNotGenerateAcw=true)]
	public partial class RequestedScope : global::Com.Amazon.Identity.Auth.Device.Dataobject.AbstractDataObject, global::Android.OS.IParcelable {


		static IntPtr ALL_COLUMNS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/field[@name='ALL_COLUMNS']"
		[Register ("ALL_COLUMNS")]
		public static IList<string> AllColumns {
			get {
				if (ALL_COLUMNS_jfieldId == IntPtr.Zero)
					ALL_COLUMNS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL_COLUMNS", "[Ljava/lang/String;");
				return JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ALL_COLUMNS_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope.COL_INDEX']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/dataobject/RequestedScope$COL_INDEX", DoNotGenerateAcw=true)]
		public sealed partial class COL_INDEX : global::Java.Lang.Enum {


			static IntPtr APP_FAMILY_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope.COL_INDEX']/field[@name='APP_FAMILY_ID']"
			[Register ("APP_FAMILY_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.COL_INDEX AppFamilyId {
				get {
					if (APP_FAMILY_ID_jfieldId == IntPtr.Zero)
						APP_FAMILY_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_FAMILY_ID", "Lcom/amazon/identity/auth/device/dataobject/RequestedScope$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_FAMILY_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUTHORIZATION_ACCESS_TOKEN_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope.COL_INDEX']/field[@name='AUTHORIZATION_ACCESS_TOKEN_ID']"
			[Register ("AUTHORIZATION_ACCESS_TOKEN_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.COL_INDEX AuthorizationAccessTokenId {
				get {
					if (AUTHORIZATION_ACCESS_TOKEN_ID_jfieldId == IntPtr.Zero)
						AUTHORIZATION_ACCESS_TOKEN_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHORIZATION_ACCESS_TOKEN_ID", "Lcom/amazon/identity/auth/device/dataobject/RequestedScope$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHORIZATION_ACCESS_TOKEN_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUTHORIZATION_REFRESH_TOKEN_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope.COL_INDEX']/field[@name='AUTHORIZATION_REFRESH_TOKEN_ID']"
			[Register ("AUTHORIZATION_REFRESH_TOKEN_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.COL_INDEX AuthorizationRefreshTokenId {
				get {
					if (AUTHORIZATION_REFRESH_TOKEN_ID_jfieldId == IntPtr.Zero)
						AUTHORIZATION_REFRESH_TOKEN_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHORIZATION_REFRESH_TOKEN_ID", "Lcom/amazon/identity/auth/device/dataobject/RequestedScope$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHORIZATION_REFRESH_TOKEN_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DIRECTED_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope.COL_INDEX']/field[@name='DIRECTED_ID']"
			[Register ("DIRECTED_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.COL_INDEX DirectedId {
				get {
					if (DIRECTED_ID_jfieldId == IntPtr.Zero)
						DIRECTED_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIRECTED_ID", "Lcom/amazon/identity/auth/device/dataobject/RequestedScope$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DIRECTED_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ROW_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope.COL_INDEX']/field[@name='ROW_ID']"
			[Register ("ROW_ID")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.COL_INDEX RowId {
				get {
					if (ROW_ID_jfieldId == IntPtr.Zero)
						ROW_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ROW_ID", "Lcom/amazon/identity/auth/device/dataobject/RequestedScope$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ROW_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SCOPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope.COL_INDEX']/field[@name='SCOPE']"
			[Register ("SCOPE")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.COL_INDEX Scope {
				get {
					if (SCOPE_jfieldId == IntPtr.Zero)
						SCOPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SCOPE", "Lcom/amazon/identity/auth/device/dataobject/RequestedScope$COL_INDEX;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SCOPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.COL_INDEX> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr colId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope.COL_INDEX']/field[@name='colId']"
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
					return JNIEnv.FindClass ("com/amazon/identity/auth/device/dataobject/RequestedScope$COL_INDEX", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope.COL_INDEX']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/RequestedScope$COL_INDEX;", "")]
			public static unsafe global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.COL_INDEX ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/RequestedScope$COL_INDEX;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.COL_INDEX __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.COL_INDEX> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope.COL_INDEX']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/identity/auth/device/dataobject/RequestedScope$COL_INDEX;", "")]
			public static unsafe global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.COL_INDEX[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/identity/auth/device/dataobject/RequestedScope$COL_INDEX;");
				try {
					return (global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.COL_INDEX[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.COL_INDEX));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope.OUTCOME']"
		[global::Android.Runtime.Register ("com/amazon/identity/auth/device/dataobject/RequestedScope$OUTCOME", DoNotGenerateAcw=true)]
		public sealed partial class OUTCOME : global::Java.Lang.Enum {


			static IntPtr GRANTED_LOCALLY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope.OUTCOME']/field[@name='GRANTED_LOCALLY']"
			[Register ("GRANTED_LOCALLY")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.OUTCOME GrantedLocally {
				get {
					if (GRANTED_LOCALLY_jfieldId == IntPtr.Zero)
						GRANTED_LOCALLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GRANTED_LOCALLY", "Lcom/amazon/identity/auth/device/dataobject/RequestedScope$OUTCOME;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GRANTED_LOCALLY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.OUTCOME> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REJECTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope.OUTCOME']/field[@name='REJECTED']"
			[Register ("REJECTED")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.OUTCOME Rejected {
				get {
					if (REJECTED_jfieldId == IntPtr.Zero)
						REJECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REJECTED", "Lcom/amazon/identity/auth/device/dataobject/RequestedScope$OUTCOME;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REJECTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.OUTCOME> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope.OUTCOME']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.OUTCOME Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/amazon/identity/auth/device/dataobject/RequestedScope$OUTCOME;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.OUTCOME> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr longVal_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope.OUTCOME']/field[@name='longVal']"
			[Register ("longVal")]
			public long LongVal {
				get {
					if (longVal_jfieldId == IntPtr.Zero)
						longVal_jfieldId = JNIEnv.GetFieldID (class_ref, "longVal", "J");
					return JNIEnv.GetLongField (Handle, longVal_jfieldId);
				}
				set {
					if (longVal_jfieldId == IntPtr.Zero)
						longVal_jfieldId = JNIEnv.GetFieldID (class_ref, "longVal", "J");
					try {
						JNIEnv.SetField (Handle, longVal_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/identity/auth/device/dataobject/RequestedScope$OUTCOME", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OUTCOME); }
			}

			internal OUTCOME (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope.OUTCOME']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/RequestedScope$OUTCOME;", "")]
			public static unsafe global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.OUTCOME ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/identity/auth/device/dataobject/RequestedScope$OUTCOME;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.OUTCOME __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.OUTCOME> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope.OUTCOME']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/identity/auth/device/dataobject/RequestedScope$OUTCOME;", "")]
			public static unsafe global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.OUTCOME[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/identity/auth/device/dataobject/RequestedScope$OUTCOME;");
				try {
					return (global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.OUTCOME[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope.OUTCOME));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/dataobject/RequestedScope", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestedScope); }
		}

		protected RequestedScope (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/constructor[@name='RequestedScope' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe RequestedScope (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (RequestedScope)) {
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

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/constructor[@name='RequestedScope' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RequestedScope ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RequestedScope)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/constructor[@name='RequestedScope' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long'] and parameter[5][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJ)V", "")]
		public unsafe RequestedScope (string p0, string p1, string p2, long p3, long p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (RequestedScope)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJ)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/constructor[@name='RequestedScope' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe RequestedScope (string p0, string p1, string p2)
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
				if (GetType () != typeof (RequestedScope)) {
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
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppFamilyId);
		}
#pragma warning restore 0169

		static Delegate cb_setAppFamilyId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppFamilyId_Ljava_lang_String_Handler ()
		{
			if (cb_setAppFamilyId_Ljava_lang_String_ == null)
				cb_setAppFamilyId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppFamilyId_Ljava_lang_String_);
			return cb_setAppFamilyId_Ljava_lang_String_;
		}

		static void n_SetAppFamilyId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppFamilyId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAppFamilyId;
		static IntPtr id_setAppFamilyId_Ljava_lang_String_;
		public virtual unsafe string AppFamilyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='getAppFamilyId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='setAppFamilyId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppFamilyId", "(Ljava/lang/String;)V", "GetSetAppFamilyId_Ljava_lang_String_Handler")]
			set {
				if (id_setAppFamilyId_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppFamilyId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppFamilyId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAppFamilyId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppFamilyId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAuthorizationAccessTokenId;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationAccessTokenIdHandler ()
		{
			if (cb_getAuthorizationAccessTokenId == null)
				cb_getAuthorizationAccessTokenId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAuthorizationAccessTokenId);
			return cb_getAuthorizationAccessTokenId;
		}

		static long n_GetAuthorizationAccessTokenId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AuthorizationAccessTokenId;
		}
#pragma warning restore 0169

		static Delegate cb_setAuthorizationAccessTokenId_J;
#pragma warning disable 0169
		static Delegate GetSetAuthorizationAccessTokenId_JHandler ()
		{
			if (cb_setAuthorizationAccessTokenId_J == null)
				cb_setAuthorizationAccessTokenId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetAuthorizationAccessTokenId_J);
			return cb_setAuthorizationAccessTokenId_J;
		}

		static void n_SetAuthorizationAccessTokenId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AuthorizationAccessTokenId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthorizationAccessTokenId;
		static IntPtr id_setAuthorizationAccessTokenId_J;
		public virtual unsafe long AuthorizationAccessTokenId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='getAuthorizationAccessTokenId' and count(parameter)=0]"
			[Register ("getAuthorizationAccessTokenId", "()J", "GetGetAuthorizationAccessTokenIdHandler")]
			get {
				if (id_getAuthorizationAccessTokenId == IntPtr.Zero)
					id_getAuthorizationAccessTokenId = JNIEnv.GetMethodID (class_ref, "getAuthorizationAccessTokenId", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getAuthorizationAccessTokenId);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthorizationAccessTokenId", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='setAuthorizationAccessTokenId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setAuthorizationAccessTokenId", "(J)V", "GetSetAuthorizationAccessTokenId_JHandler")]
			set {
				if (id_setAuthorizationAccessTokenId_J == IntPtr.Zero)
					id_setAuthorizationAccessTokenId_J = JNIEnv.GetMethodID (class_ref, "setAuthorizationAccessTokenId", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAuthorizationAccessTokenId_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuthorizationAccessTokenId", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthorizationRefreshTokenId;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationRefreshTokenIdHandler ()
		{
			if (cb_getAuthorizationRefreshTokenId == null)
				cb_getAuthorizationRefreshTokenId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAuthorizationRefreshTokenId);
			return cb_getAuthorizationRefreshTokenId;
		}

		static long n_GetAuthorizationRefreshTokenId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AuthorizationRefreshTokenId;
		}
#pragma warning restore 0169

		static Delegate cb_setAuthorizationRefreshTokenId_J;
#pragma warning disable 0169
		static Delegate GetSetAuthorizationRefreshTokenId_JHandler ()
		{
			if (cb_setAuthorizationRefreshTokenId_J == null)
				cb_setAuthorizationRefreshTokenId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetAuthorizationRefreshTokenId_J);
			return cb_setAuthorizationRefreshTokenId_J;
		}

		static void n_SetAuthorizationRefreshTokenId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AuthorizationRefreshTokenId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthorizationRefreshTokenId;
		static IntPtr id_setAuthorizationRefreshTokenId_J;
		public virtual unsafe long AuthorizationRefreshTokenId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='getAuthorizationRefreshTokenId' and count(parameter)=0]"
			[Register ("getAuthorizationRefreshTokenId", "()J", "GetGetAuthorizationRefreshTokenIdHandler")]
			get {
				if (id_getAuthorizationRefreshTokenId == IntPtr.Zero)
					id_getAuthorizationRefreshTokenId = JNIEnv.GetMethodID (class_ref, "getAuthorizationRefreshTokenId", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getAuthorizationRefreshTokenId);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthorizationRefreshTokenId", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='setAuthorizationRefreshTokenId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setAuthorizationRefreshTokenId", "(J)V", "GetSetAuthorizationRefreshTokenId_JHandler")]
			set {
				if (id_setAuthorizationRefreshTokenId_J == IntPtr.Zero)
					id_setAuthorizationRefreshTokenId_J = JNIEnv.GetMethodID (class_ref, "setAuthorizationRefreshTokenId", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAuthorizationRefreshTokenId_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuthorizationRefreshTokenId", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDirectedId;
#pragma warning disable 0169
		static Delegate GetGetDirectedIdHandler ()
		{
			if (cb_getDirectedId == null)
				cb_getDirectedId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDirectedId);
			return cb_getDirectedId;
		}

		static IntPtr n_GetDirectedId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DirectedId);
		}
#pragma warning restore 0169

		static Delegate cb_setDirectedId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDirectedId_Ljava_lang_String_Handler ()
		{
			if (cb_setDirectedId_Ljava_lang_String_ == null)
				cb_setDirectedId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDirectedId_Ljava_lang_String_);
			return cb_setDirectedId_Ljava_lang_String_;
		}

		static void n_SetDirectedId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DirectedId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDirectedId;
		static IntPtr id_setDirectedId_Ljava_lang_String_;
		public virtual unsafe string DirectedId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='getDirectedId' and count(parameter)=0]"
			[Register ("getDirectedId", "()Ljava/lang/String;", "GetGetDirectedIdHandler")]
			get {
				if (id_getDirectedId == IntPtr.Zero)
					id_getDirectedId = JNIEnv.GetMethodID (class_ref, "getDirectedId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDirectedId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDirectedId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='setDirectedId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDirectedId", "(Ljava/lang/String;)V", "GetSetDirectedId_Ljava_lang_String_Handler")]
			set {
				if (id_setDirectedId_Ljava_lang_String_ == IntPtr.Zero)
					id_setDirectedId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDirectedId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDirectedId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDirectedId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getScope;
#pragma warning disable 0169
		static Delegate GetGetScopeHandler ()
		{
			if (cb_getScope == null)
				cb_getScope = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScope);
			return cb_getScope;
		}

		static IntPtr n_GetScope (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Scope);
		}
#pragma warning restore 0169

		static IntPtr id_getScope;
		public virtual unsafe global::Com.Amazon.Identity.Auth.Device.Dataobject.Scope Scope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='getScope' and count(parameter)=0]"
			[Register ("getScope", "()Lcom/amazon/identity/auth/device/dataobject/Scope;", "GetGetScopeHandler")]
			get {
				if (id_getScope == IntPtr.Zero)
					id_getScope = JNIEnv.GetMethodID (class_ref, "getScope", "()Lcom/amazon/identity/auth/device/dataobject/Scope;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Scope> (JNIEnv.CallObjectMethod  (Handle, id_getScope), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.Scope> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScope", "()Lcom/amazon/identity/auth/device/dataobject/Scope;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScopeValue;
#pragma warning disable 0169
		static Delegate GetGetScopeValueHandler ()
		{
			if (cb_getScopeValue == null)
				cb_getScopeValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScopeValue);
			return cb_getScopeValue;
		}

		static IntPtr n_GetScopeValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ScopeValue);
		}
#pragma warning restore 0169

		static Delegate cb_setScopeValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetScopeValue_Ljava_lang_String_Handler ()
		{
			if (cb_setScopeValue_Ljava_lang_String_ == null)
				cb_setScopeValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScopeValue_Ljava_lang_String_);
			return cb_setScopeValue_Ljava_lang_String_;
		}

		static void n_SetScopeValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ScopeValue = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getScopeValue;
		static IntPtr id_setScopeValue_Ljava_lang_String_;
		public virtual unsafe string ScopeValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='getScopeValue' and count(parameter)=0]"
			[Register ("getScopeValue", "()Ljava/lang/String;", "GetGetScopeValueHandler")]
			get {
				if (id_getScopeValue == IntPtr.Zero)
					id_getScopeValue = JNIEnv.GetMethodID (class_ref, "getScopeValue", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getScopeValue), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScopeValue", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='setScopeValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setScopeValue", "(Ljava/lang/String;)V", "GetSetScopeValue_Ljava_lang_String_Handler")]
			set {
				if (id_setScopeValue_Ljava_lang_String_ == IntPtr.Zero)
					id_setScopeValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setScopeValue", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setScopeValue_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScopeValue", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValuesForInsert);
		}
#pragma warning restore 0169

		static IntPtr id_getValuesForInsert;
		public override unsafe global::Android.Content.ContentValues ValuesForInsert {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='getValuesForInsert' and count(parameter)=0]"
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
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/amazon/identity/auth/device/dataobject/RequestedScope;", "GetCloneHandler")]
		public virtual unsafe global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/amazon/identity/auth/device/dataobject/RequestedScope;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lcom/amazon/identity/auth/device/dataobject/RequestedScope;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this._getDataSource (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDataSource_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='getDataSource' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDataSource", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/RequestedScopeDataSource;", "Get_getDataSource_Landroid_content_Context_Handler")]
		public virtual unsafe global::Com.Amazon.Identity.Auth.Device.Datastore.RequestedScopeDataSource _getDataSource (global::Android.Content.Context p0)
		{
			if (id_getDataSource_Landroid_content_Context_ == IntPtr.Zero)
				id_getDataSource_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getDataSource", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/RequestedScopeDataSource;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Identity.Auth.Device.Datastore.RequestedScopeDataSource __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.RequestedScopeDataSource> (JNIEnv.CallObjectMethod  (Handle, id_getDataSource_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Datastore.RequestedScopeDataSource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataSource", "(Landroid/content/Context;)Lcom/amazon/identity/auth/device/datastore/RequestedScopeDataSource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isGranted;
#pragma warning disable 0169
		static Delegate GetIsGrantedHandler ()
		{
			if (cb_isGranted == null)
				cb_isGranted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsGranted);
			return cb_isGranted;
		}

		static IntPtr n_IsGranted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsGranted ());
		}
#pragma warning restore 0169

		static IntPtr id_isGranted;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='isGranted' and count(parameter)=0]"
		[Register ("isGranted", "()Ljava/lang/Boolean;", "GetIsGrantedHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsGranted ()
		{
			if (id_isGranted == IntPtr.Zero)
				id_isGranted = JNIEnv.GetMethodID (class_ref, "isGranted", "()Ljava/lang/Boolean;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_isGranted), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isGranted", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setIsGranted_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetIsGranted_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setIsGranted_Ljava_lang_Boolean_ == null)
				cb_setIsGranted_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIsGranted_Ljava_lang_Boolean_);
			return cb_setIsGranted_Ljava_lang_Boolean_;
		}

		static void n_SetIsGranted_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIsGranted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIsGranted_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='setIsGranted' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setIsGranted", "(Ljava/lang/Boolean;)V", "GetSetIsGranted_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetIsGranted (global::Java.Lang.Boolean p0)
		{
			if (id_setIsGranted_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setIsGranted_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setIsGranted", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIsGranted_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsGranted", "(Ljava/lang/Boolean;)V"), __args);
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
			global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Dataobject.RequestedScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.dataobject']/class[@name='RequestedScope']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
