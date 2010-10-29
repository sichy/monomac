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
	[Register("CLLocationManagerDelegate")]
	[Model]
	public partial class CLLocationManagerDelegate : NSObject {

		static IntPtr class_ptr = Class.GetHandle ("CLLocationManagerDelegate");

		[Export ("init")]
		public CLLocationManagerDelegate () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[Export ("initWithCoder:")]
		public CLLocationManagerDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public CLLocationManagerDelegate (NSObjectFlag t) : base (t) {}

		public CLLocationManagerDelegate (IntPtr handle) : base (handle) {}

		[Export ("locationManager:didUpdateToLocation:fromLocation:")]
		public virtual void UpdatedLocation (CLLocationManager manager, CLLocation newLocation, CLLocation oldLocation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}

		[Export ("locationManager:didUpdateHeading:")]
		public virtual void UpdatedHeading (CLLocationManager manager, CLHeading newHeading)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}

		[Export ("locationManagerShouldDisplayHeadingCalibration:")]
		public virtual bool ShouldDisplayHeadingCalibration (CLLocationManager manager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}

		[Export ("locationManager:didFailWithError:")]
		public virtual void Failed (CLLocationManager manager, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}

		[Export ("locationManager:didEnterRegion:")]
		public virtual void RegionEntered (CLLocationManager manager, CLRegion region)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}

		[Export ("locationManager:didExitRegion:")]
		public virtual void RegionLeft (CLLocationManager manager, CLRegion region)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}

		[Export ("locationManager:monitoringDidFailForRegion:withError:")]
		public virtual void MonitoringFailed (CLLocationManager manager, CLRegion region, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}

	
	} /* class CLLocationManagerDelegate */
}
