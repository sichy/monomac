//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;

using System.Drawing;

using System.Runtime.InteropServices;

using MonoMac.CoreFoundation;

using MonoMac.Foundation;

using MonoMac.ObjCRuntime;

using MonoMac.CoreGraphics;

using MonoMac.CoreAnimation;

using MonoMac.CoreLocation;

using MonoMac.QTKit;

namespace MonoMac.CoreLocation {
	[Register("CLHeading")]
	public partial class CLHeading : NSObject {
		static IntPtr selMagneticHeading = Selector.GetHandle ("magneticHeading");
		static IntPtr selTrueHeading = Selector.GetHandle ("trueHeading");
		static IntPtr selHeadingAccuracy = Selector.GetHandle ("headingAccuracy");
		static IntPtr selX = Selector.GetHandle ("x");
		static IntPtr selY = Selector.GetHandle ("y");
		static IntPtr selZ = Selector.GetHandle ("z");
		static IntPtr selTimestamp = Selector.GetHandle ("timestamp");
		static IntPtr selDescription = Selector.GetHandle ("description");

		static IntPtr class_ptr = Class.GetHandle ("CLHeading");

		public override IntPtr ClassHandle { get { return class_ptr; } }

		[Export ("init")]
		public CLHeading () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[Export ("initWithCoder:")]
		public CLHeading (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public CLHeading (NSObjectFlag t) : base (t) {}

		public CLHeading (IntPtr handle) : base (handle) {}

		[Export ("description")]
		public virtual string Description ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDescription));
			} else {
				return NSString.FromHandle (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDescription));
			}
		}

		public virtual System.Double MagneticHeading {
			[Export ("magneticHeading")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selMagneticHeading);
				} else {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selMagneticHeading);
				}
			}

		}

		public virtual System.Double TrueHeading {
			[Export ("trueHeading")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selTrueHeading);
				} else {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selTrueHeading);
				}
			}

		}

		public virtual System.Double HeadingAccuracy {
			[Export ("headingAccuracy")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selHeadingAccuracy);
				} else {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selHeadingAccuracy);
				}
			}

		}

		public virtual System.Double X {
			[Export ("x")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selX);
				} else {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selX);
				}
			}

		}

		public virtual System.Double Y {
			[Export ("y")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selY);
				} else {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selY);
				}
			}

		}

		public virtual System.Double Z {
			[Export ("z")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selZ);
				} else {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selZ);
				}
			}

		}

		MonoMac.Foundation.NSDate __mt_Timestamp_var;
		public virtual NSDate Timestamp {
			[Export ("timestamp")]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret = (NSDate) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTimestamp));
				} else {
					ret = (NSDate) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTimestamp));
				}
				__mt_Timestamp_var = ret;
				return ret;
			}

		}

	
	} /* class CLHeading */
}
