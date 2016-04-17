using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Identity.Auth.Device.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MultiMap']"
	[global::Android.Runtime.Register ("com/amazon/identity/auth/device/utils/MultiMap", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
	public partial class MultiMap : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/identity/auth/device/utils/MultiMap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultiMap); }
		}

		protected MultiMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MultiMap']/constructor[@name='MultiMap' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MultiMap ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MultiMap)) {
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

		static Delegate cb_getKeys;
#pragma warning disable 0169
		static Delegate GetGetKeysHandler ()
		{
			if (cb_getKeys == null)
				cb_getKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKeys);
			return cb_getKeys;
		}

		static IntPtr n_GetKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Utils.MultiMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Utils.MultiMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet.ToLocalJniHandle (__this.Keys);
		}
#pragma warning restore 0169

		static IntPtr id_getKeys;
		public virtual unsafe global::System.Collections.ICollection Keys {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MultiMap']/method[@name='getKeys' and count(parameter)=0]"
			[Register ("getKeys", "()Ljava/util/Set;", "GetGetKeysHandler")]
			get {
				if (id_getKeys == IntPtr.Zero)
					id_getKeys = JNIEnv.GetMethodID (class_ref, "getKeys", "()Ljava/util/Set;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getKeys), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeys", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addAll_Ljava_lang_Object_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetAddAll_Ljava_lang_Object_Ljava_util_Set_Handler ()
		{
			if (cb_addAll_Ljava_lang_Object_Ljava_util_Set_ == null)
				cb_addAll_Ljava_lang_Object_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AddAll_Ljava_lang_Object_Ljava_util_Set_);
			return cb_addAll_Ljava_lang_Object_Ljava_util_Set_;
		}

		static bool n_AddAll_Ljava_lang_Object_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Utils.MultiMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Utils.MultiMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaSet.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAll (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addAll_Ljava_lang_Object_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MultiMap']/method[@name='addAll' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='java.util.Set&lt;V&gt;']]"
		[Register ("addAll", "(Ljava/lang/Object;Ljava/util/Set;)Z", "GetAddAll_Ljava_lang_Object_Ljava_util_Set_Handler")]
		public virtual unsafe bool AddAll (global::Java.Lang.Object p0, global::System.Collections.ICollection p1)
		{
			if (id_addAll_Ljava_lang_Object_Ljava_util_Set_ == IntPtr.Zero)
				id_addAll_Ljava_lang_Object_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "addAll", "(Ljava/lang/Object;Ljava/util/Set;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaSet.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_addAll_Ljava_lang_Object_Ljava_util_Set_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAll", "(Ljava/lang/Object;Ljava/util/Set;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Utils.MultiMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Utils.MultiMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MultiMap']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_getValues_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetValues_Ljava_lang_Object_Handler ()
		{
			if (cb_getValues_Ljava_lang_Object_ == null)
				cb_getValues_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetValues_Ljava_lang_Object_);
			return cb_getValues_Ljava_lang_Object_;
		}

		static IntPtr n_GetValues_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Identity.Auth.Device.Utils.MultiMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Utils.MultiMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaSet.ToLocalJniHandle (__this.GetValues (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getValues_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MultiMap']/method[@name='getValues' and count(parameter)=1 and parameter[1][@type='K']]"
		[Register ("getValues", "(Ljava/lang/Object;)Ljava/util/Set;", "GetGetValues_Ljava_lang_Object_Handler")]
		public virtual unsafe global::System.Collections.ICollection GetValues (global::Java.Lang.Object p0)
		{
			if (id_getValues_Ljava_lang_Object_ == IntPtr.Zero)
				id_getValues_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getValues", "(Ljava/lang/Object;)Ljava/util/Set;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.ICollection __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaSet.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getValues_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaSet.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValues", "(Ljava/lang/Object;)Ljava/util/Set;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_put_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_put_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Put_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_put_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static bool n_Put_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Identity.Auth.Device.Utils.MultiMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Utils.MultiMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Put (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MultiMap']/method[@name='put' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='V']]"
		[Register ("put", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe bool Put (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_put_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_put_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_put_Ljava_lang_Object_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Identity.Auth.Device.Utils.MultiMap __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Identity.Auth.Device.Utils.MultiMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.identity.auth.device.utils']/class[@name='MultiMap']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

	}
}
