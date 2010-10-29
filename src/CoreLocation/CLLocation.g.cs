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
	[Register("CLLocation")]
	public partial class CLLocation : NSObject {
		static IntPtr selCoordinate = Selector.GetHandle ("coordinate");
		static IntPtr selAltitude = Selector.GetHandle ("altitude");
		static IntPtr selHorizontalAccuracy = Selector.GetHandle ("horizontalAccuracy");
		static IntPtr selVerticalAccuracy = Selector.GetHandle ("verticalAccuracy");
		static IntPtr selCourse = Selector.GetHandle ("course");
		static IntPtr selSpeed = Selector.GetHandle ("speed");
		static IntPtr selTimestamp = Selector.GetHandle ("timestamp");
		static IntPtr selInitWithLatitudeLongitude = Selector.GetHandle ("initWithLatitude:longitude:");
		static IntPtr selInitWithCoordinateAltitudeHorizontalAccuracyVerticalAccuracyTimestamp = Selector.GetHandle ("initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:timestamp:");
		static IntPtr selDescription = Selector.GetHandle ("description");
		static IntPtr selGetDistanceFrom = Selector.GetHandle ("getDistanceFrom:");
		static IntPtr selDistanceFromLocation = Selector.GetHandle ("distanceFromLocation:");

		static IntPtr class_ptr = Class.GetHandle ("CLLocation");

		public override IntPtr ClassHandle { get { return class_ptr; } }

		[Export ("init")]
		public CLLocation () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[Export ("initWithCoder:")]
		public CLLocation (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public CLLocation (NSObjectFlag t) : base (t) {}

		public CLLocation (IntPtr handle) : base (handle) {}

		[Export ("initWithLatitude:longitude:")]
		public CLLocation (System.Double latitude, System.Double longitude) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_Double_Double (this.Handle, selInitWithLatitudeLongitude, latitude, longitude);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_Double_Double (this.SuperHandle, selInitWithLatitudeLongitude, latitude, longitude);
			}
		}

		[Export ("initWithCoordinate:altitude:horizontalAccuracy:verticalAccuracy:timestamp:")]
		public CLLocation (CLLocationCoordinate2D coordinate, System.Double altitude, System.Double hAccuracy, System.Double vAccuracy, NSDate timestamp) : base (NSObjectFlag.Empty)
		{
			if (timestamp == null)
				throw new ArgumentNullException ("timestamp");
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_Double_Double_IntPtr (this.Handle, selInitWithCoordinateAltitudeHorizontalAccuracyVerticalAccuracyTimestamp, coordinate, altitude, hAccuracy, vAccuracy, timestamp.Handle);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_Double_Double_IntPtr (this.SuperHandle, selInitWithCoordinateAltitudeHorizontalAccuracyVerticalAccuracyTimestamp, coordinate, altitude, hAccuracy, vAccuracy, timestamp.Handle);
			}
		}

		[Export ("description")]
		public virtual string Description ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDescription));
			} else {
				return NSString.FromHandle (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDescription));
			}
		}

		[Export ("getDistanceFrom:")]
		public virtual System.Double Distancefrom (CLLocation location)
		{
			if (location == null)
				throw new ArgumentNullException ("location");
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSend_IntPtr (this.Handle, selGetDistanceFrom, location.Handle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSendSuper_IntPtr (this.SuperHandle, selGetDistanceFrom, location.Handle);
			}
		}

		[Export ("distanceFromLocation:")]
		public virtual System.Double DistanceFrom (CLLocation location)
		{
			if (location == null)
				throw new ArgumentNullException ("location");
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSend_IntPtr (this.Handle, selDistanceFromLocation, location.Handle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSendSuper_IntPtr (this.SuperHandle, selDistanceFromLocation, location.Handle);
			}
		}

		public virtual CLLocationCoordinate2D Coordinate {
			[Export ("coordinate")]
			get {
				CLLocationCoordinate2D ret;
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, this.Handle, selCoordinate);
				} else {
					MonoMac.ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret (out ret, this.SuperHandle, selCoordinate);
				}
				return ret;
			}

		}

		public virtual System.Double Altitude {
			[Export ("altitude")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selAltitude);
				} else {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selAltitude);
				}
			}

		}

		public virtual System.Double HorizontalAccuracy {
			[Export ("horizontalAccuracy")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selHorizontalAccuracy);
				} else {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selHorizontalAccuracy);
				}
			}

		}

		public virtual System.Double VerticalAccuracy {
			[Export ("verticalAccuracy")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selVerticalAccuracy);
				} else {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selVerticalAccuracy);
				}
			}

		}

		public virtual System.Double Course {
			[Export ("course")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selCourse);
				} else {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selCourse);
				}
			}

		}

		public virtual System.Double Speed {
			[Export ("speed")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selSpeed);
				} else {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selSpeed);
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

	
	} /* class CLLocation */
}
