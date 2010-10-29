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
	[Register("CLRegion")]
	public partial class CLRegion : NSObject {
		static IntPtr selCenter = Selector.GetHandle ("center");
		static IntPtr selRadius = Selector.GetHandle ("radius");
		static IntPtr selIdentifier = Selector.GetHandle ("identifier");
		static IntPtr selInitCircularRegionWithCenterRadiusIdentifier = Selector.GetHandle ("initCircularRegionWithCenter:radius:identifier:");
		static IntPtr selContainsCoordinate = Selector.GetHandle ("containsCoordinate:");

		static IntPtr class_ptr = Class.GetHandle ("CLRegion");

		public override IntPtr ClassHandle { get { return class_ptr; } }

		[Export ("init")]
		public CLRegion () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[Export ("initWithCoder:")]
		public CLRegion (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public CLRegion (NSObjectFlag t) : base (t) {}

		public CLRegion (IntPtr handle) : base (handle) {}

		[Export ("initCircularRegionWithCenter:radius:identifier:")]
		public CLRegion (CLLocationCoordinate2D center, System.Double radius, string identifier) : base (NSObjectFlag.Empty)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			var nsidentifier = new NSString (identifier);

			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_IntPtr (this.Handle, selInitCircularRegionWithCenterRadiusIdentifier, center, radius, nsidentifier.Handle);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_IntPtr (this.SuperHandle, selInitCircularRegionWithCenterRadiusIdentifier, center, radius, nsidentifier.Handle);
			}
						nsidentifier.Dispose ();

		}

		[Export ("containsCoordinate:")]
		public virtual bool Contains (CLLocationCoordinate2D coordinate)
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.Boolean_objc_msgSend_CLLocationCoordinate2D (this.Handle, selContainsCoordinate, coordinate);
			} else {
				return MonoMac.ObjCRuntime.Messaging.Boolean_objc_msgSendSuper_CLLocationCoordinate2D (this.SuperHandle, selContainsCoordinate, coordinate);
			}
		}

		public virtual CLLocationCoordinate2D Center {
			[Export ("center")]
			get {
				CLLocationCoordinate2D ret;
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, this.Handle, selCenter);
				} else {
					MonoMac.ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret (out ret, this.SuperHandle, selCenter);
				}
				return ret;
			}

		}

		public virtual System.Double Radius {
			[Export ("radius")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selRadius);
				} else {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selRadius);
				}
			}

		}

		public virtual string Identifier {
			[Export ("identifier")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIdentifier));
				} else {
					return NSString.FromHandle (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selIdentifier));
				}
			}

		}

	
	} /* class CLRegion */
}
