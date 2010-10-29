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
	[Register("CLLocationManager")]
	public partial class CLLocationManager : NSObject {
		static IntPtr selDelegate = Selector.GetHandle ("delegate");
		static IntPtr selSetDelegate = Selector.GetHandle ("setDelegate:");
		static IntPtr selLocationServicesEnabled = Selector.GetHandle ("locationServicesEnabled");
		static IntPtr selDistanceFilter = Selector.GetHandle ("distanceFilter");
		static IntPtr selSetDistanceFilter = Selector.GetHandle ("setDistanceFilter:");
		static IntPtr selDesiredAccuracy = Selector.GetHandle ("desiredAccuracy");
		static IntPtr selSetDesiredAccuracy = Selector.GetHandle ("setDesiredAccuracy:");
		static IntPtr selLocation = Selector.GetHandle ("location");
		static IntPtr selHeadingFilter = Selector.GetHandle ("headingFilter");
		static IntPtr selSetHeadingFilter = Selector.GetHandle ("setHeadingFilter:");
		static IntPtr selHeadingAvailable = Selector.GetHandle ("headingAvailable");
		static IntPtr selPurpose = Selector.GetHandle ("purpose");
		static IntPtr selSetPurpose = Selector.GetHandle ("setPurpose:");
		static IntPtr selSignificantLocationChangeMonitoringAvailable = Selector.GetHandle ("significantLocationChangeMonitoringAvailable");
		static IntPtr selRegionMonitoringAvailable = Selector.GetHandle ("regionMonitoringAvailable");
		static IntPtr selRegionMonitoringEnabled = Selector.GetHandle ("regionMonitoringEnabled");
		static IntPtr selHeadingOrientation = Selector.GetHandle ("headingOrientation");
		static IntPtr selSetHeadingOrientation = Selector.GetHandle ("setHeadingOrientation:");
		static IntPtr selHeading = Selector.GetHandle ("heading");
		static IntPtr selMaximumRegionMonitoringDistance = Selector.GetHandle ("maximumRegionMonitoringDistance");
		static IntPtr selMonitoredRegions = Selector.GetHandle ("monitoredRegions");
		static IntPtr selStartUpdatingLocation = Selector.GetHandle ("startUpdatingLocation");
		static IntPtr selStopUpdatingLocation = Selector.GetHandle ("stopUpdatingLocation");
		static IntPtr selStartUpdatingHeading = Selector.GetHandle ("startUpdatingHeading");
		static IntPtr selStopUpdatingHeading = Selector.GetHandle ("stopUpdatingHeading");
		static IntPtr selDismissHeadingCalibrationDisplay = Selector.GetHandle ("dismissHeadingCalibrationDisplay");
		static IntPtr selStartMonitoringSignificantLocationChanges = Selector.GetHandle ("startMonitoringSignificantLocationChanges");
		static IntPtr selStopMonitoringSignificantLocationChanges = Selector.GetHandle ("stopMonitoringSignificantLocationChanges");
		static IntPtr selStartMonitoringForRegionDesiredAccuracy = Selector.GetHandle ("startMonitoringForRegion:desiredAccuracy:");
		static IntPtr selStopMonitoringForRegion = Selector.GetHandle ("stopMonitoringForRegion:");

		static IntPtr class_ptr = Class.GetHandle ("CLLocationManager");

		public override IntPtr ClassHandle { get { return class_ptr; } }

		[Export ("init")]
		public CLLocationManager () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[Export ("initWithCoder:")]
		public CLLocationManager (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public CLLocationManager (NSObjectFlag t) : base (t) {}

		public CLLocationManager (IntPtr handle) : base (handle) {}

		[Export ("startUpdatingLocation")]
		public virtual void StartUpdatingLocation ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStartUpdatingLocation);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selStartUpdatingLocation);
			}
		}

		[Export ("stopUpdatingLocation")]
		public virtual void StopUpdatingLocation ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopUpdatingLocation);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selStopUpdatingLocation);
			}
		}

		[Export ("startUpdatingHeading")]
		public virtual void StartUpdatingHeading ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStartUpdatingHeading);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selStartUpdatingHeading);
			}
		}

		[Export ("stopUpdatingHeading")]
		public virtual void StopUpdatingHeading ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopUpdatingHeading);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selStopUpdatingHeading);
			}
		}

		[Export ("dismissHeadingCalibrationDisplay")]
		public virtual void DismissHeadingCalibrationDisplay ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDismissHeadingCalibrationDisplay);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDismissHeadingCalibrationDisplay);
			}
		}

		[Export ("startMonitoringSignificantLocationChanges")]
		public virtual void StartMonitoringSignificantLocationChanges ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStartMonitoringSignificantLocationChanges);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selStartMonitoringSignificantLocationChanges);
			}
		}

		[Export ("stopMonitoringSignificantLocationChanges")]
		public virtual void StopMonitoringSignificantLocationChanges ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopMonitoringSignificantLocationChanges);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selStopMonitoringSignificantLocationChanges);
			}
		}

		[Export ("startMonitoringForRegion:desiredAccuracy:")]
		public virtual void StartMonitoring (CLRegion region, System.Double desiredAccuracy)
		{
			if (region == null)
				throw new ArgumentNullException ("region");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_Double (this.Handle, selStartMonitoringForRegionDesiredAccuracy, region.Handle, desiredAccuracy);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_Double (this.SuperHandle, selStartMonitoringForRegionDesiredAccuracy, region.Handle, desiredAccuracy);
			}
		}

		[Export ("stopMonitoringForRegion:")]
		public virtual void StopMonitoring (CLRegion region)
		{
			if (region == null)
				throw new ArgumentNullException ("region");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selStopMonitoringForRegion, region.Handle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selStopMonitoringForRegion, region.Handle);
			}
		}

		public CLLocationManagerDelegate Delegate {
			get { return WeakDelegate as CLLocationManagerDelegate; }
			set { WeakDelegate = value; }
		}

		MonoMac.Foundation.NSObject __mt_WeakDelegate_var;
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegate));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegate));
				}
				__mt_WeakDelegate_var = ret;
				return ret;
			}

			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate, value == null ? IntPtr.Zero : value.Handle);
				}
				__mt_WeakDelegate_var = value;
			}
		}

		internal virtual bool _LocationServicesEnabledInstance {
			[Export ("locationServicesEnabled")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.Boolean_objc_msgSend (this.Handle, selLocationServicesEnabled);
				} else {
					return MonoMac.ObjCRuntime.Messaging.Boolean_objc_msgSendSuper (this.SuperHandle, selLocationServicesEnabled);
				}
			}

		}

		public virtual System.Double DistanceFilter {
			[Export ("distanceFilter", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDistanceFilter);
				} else {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selDistanceFilter);
				}
			}

			[Export ("setDistanceFilter:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetDistanceFilter, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSetDistanceFilter, value);
				}
			}
		}

		public virtual System.Double DesiredAccuracy {
			[Export ("desiredAccuracy", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDesiredAccuracy);
				} else {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selDesiredAccuracy);
				}
			}

			[Export ("setDesiredAccuracy:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetDesiredAccuracy, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSetDesiredAccuracy, value);
				}
			}
		}

		MonoMac.CoreLocation.CLLocation __mt_Location_var;
		public virtual CLLocation Location {
			[Export ("location")]
			get {
				CLLocation ret;
				if (IsDirectBinding) {
					ret = (CLLocation) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLocation));
				} else {
					ret = (CLLocation) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLocation));
				}
				__mt_Location_var = ret;
				return ret;
			}

		}

		public virtual System.Double HeadingFilter {
			[Export ("headingFilter", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selHeadingFilter);
				} else {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selHeadingFilter);
				}
			}

			[Export ("setHeadingFilter:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetHeadingFilter, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSetHeadingFilter, value);
				}
			}
		}

		internal virtual bool _HeadingAvailableInstance {
			[Export ("headingAvailable")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.Boolean_objc_msgSend (this.Handle, selHeadingAvailable);
				} else {
					return MonoMac.ObjCRuntime.Messaging.Boolean_objc_msgSendSuper (this.SuperHandle, selHeadingAvailable);
				}
			}

		}

		public virtual string Purpose {
			[Export ("purpose", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPurpose));
				} else {
					return NSString.FromHandle (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPurpose));
				}
			}

			[Export ("setPurpose:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
			var nsvalue = new NSString (value);

				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPurpose, nsvalue.Handle);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPurpose, nsvalue.Handle);
				}
							nsvalue.Dispose ();

			}
		}

		internal static bool _LocationServicesEnabledStatic {
			[Export ("locationServicesEnabled")]
			get {
				return MonoMac.ObjCRuntime.Messaging.Boolean_objc_msgSend (class_ptr, selLocationServicesEnabled);
			}

		}

		internal static bool _HeadingAvailableStatic {
			[Export ("headingAvailable")]
			get {
				return MonoMac.ObjCRuntime.Messaging.Boolean_objc_msgSend (class_ptr, selHeadingAvailable);
			}

		}

		public static bool SignificantLocationChangeMonitoringAvailable {
			[Export ("significantLocationChangeMonitoringAvailable")]
			get {
				return MonoMac.ObjCRuntime.Messaging.Boolean_objc_msgSend (class_ptr, selSignificantLocationChangeMonitoringAvailable);
			}

		}

		public static bool RegionMonitoringAvailable {
			[Export ("regionMonitoringAvailable")]
			get {
				return MonoMac.ObjCRuntime.Messaging.Boolean_objc_msgSend (class_ptr, selRegionMonitoringAvailable);
			}

		}

		public static bool RegionMonitoringEnabled {
			[Export ("regionMonitoringEnabled")]
			get {
				return MonoMac.ObjCRuntime.Messaging.Boolean_objc_msgSend (class_ptr, selRegionMonitoringEnabled);
			}

		}

		public virtual CLDeviceOrientation HeadingOrientation {
			[Export ("headingOrientation")]
			get {
				if (IsDirectBinding) {
					return (CLDeviceOrientation) MonoMac.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selHeadingOrientation);
				} else {
					return (CLDeviceOrientation) MonoMac.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selHeadingOrientation);
				}
			}

			[Export ("setHeadingOrientation:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetHeadingOrientation, (int)value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetHeadingOrientation, (int)value);
				}
			}
		}

		MonoMac.CoreLocation.CLHeading __mt_Heading_var;
		public virtual CLHeading Heading {
			[Export ("heading")]
			get {
				CLHeading ret;
				if (IsDirectBinding) {
					ret = (CLHeading) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selHeading));
				} else {
					ret = (CLHeading) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selHeading));
				}
				__mt_Heading_var = ret;
				return ret;
			}

		}

		public virtual System.Double MaximumRegionMonitoringDistance {
			[Export ("maximumRegionMonitoringDistance")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selMaximumRegionMonitoringDistance);
				} else {
					return MonoMac.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selMaximumRegionMonitoringDistance);
				}
			}

		}

		MonoMac.Foundation.NSSet __mt_MonitoredRegions_var;
		public virtual NSSet MonitoredRegions {
			[Export ("monitoredRegions")]
			get {
				NSSet ret;
				if (IsDirectBinding) {
					ret = (NSSet) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMonitoredRegions));
				} else {
					ret = (NSSet) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMonitoredRegions));
				}
				__mt_MonitoredRegions_var = ret;
				return ret;
			}

		}

		//
		// Events and properties from the delegate
		//

		_CLLocationManagerDelegate EnsureCLLocationManagerDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _CLLocationManagerDelegate))){
				del = new _CLLocationManagerDelegate ();
				WeakDelegate = del;
			}
			return (_CLLocationManagerDelegate) del;
		}

		[Register]
		class _CLLocationManagerDelegate : CLLocationManagerDelegate { 
			public _CLLocationManagerDelegate () {}

			internal EventHandler<CLLocationUpdatedEventArgs> updatedLocation;
			[Preserve (Conditional = true)]
			public override Void UpdatedLocation (CLLocationManager manager, CLLocation newLocation, CLLocation oldLocation)
			{
				if (updatedLocation != null)
					updatedLocation (manager, new CLLocationUpdatedEventArgs (newLocation, oldLocation));
			}

			internal EventHandler<CLHeadingUpdatedEventArgs> updatedHeading;
			[Preserve (Conditional = true)]
			public override Void UpdatedHeading (CLLocationManager manager, CLHeading newHeading)
			{
				if (updatedHeading != null)
					updatedHeading (manager, new CLHeadingUpdatedEventArgs (newHeading));
			}

			internal CLLocationManagerEventArgs shouldDisplayHeadingCalibration;
			[Preserve (Conditional = true)]
			public override bool ShouldDisplayHeadingCalibration (CLLocationManager manager)
			{
				if (shouldDisplayHeadingCalibration != null)
					return shouldDisplayHeadingCalibration (manager);
				return true;
			}

			internal EventHandler<NSErrorEventArgs> failed;
			[Preserve (Conditional = true)]
			public override Void Failed (CLLocationManager manager, NSError error)
			{
				if (failed != null)
					failed (manager, new NSErrorEventArgs (error));
			}

			internal EventHandler<CLRegionEventArgs> regionEntered;
			[Preserve (Conditional = true)]
			public override Void RegionEntered (CLLocationManager manager, CLRegion region)
			{
				if (regionEntered != null)
					regionEntered (manager, new CLRegionEventArgs (region));
			}

			internal EventHandler<CLRegionEventArgs> regionLeft;
			[Preserve (Conditional = true)]
			public override Void RegionLeft (CLLocationManager manager, CLRegion region)
			{
				if (regionLeft != null)
					regionLeft (manager, new CLRegionEventArgs (region));
			}

			internal EventHandler<CLRegionErrorEventArgs> monitoringFailed;
			[Preserve (Conditional = true)]
			public override Void MonitoringFailed (CLLocationManager manager, CLRegion region, NSError error)
			{
				if (monitoringFailed != null)
					monitoringFailed (manager, new CLRegionErrorEventArgs (region, error));
			}

		}
		
		public event EventHandler<CLLocationUpdatedEventArgs> UpdatedLocation {
			add { EnsureCLLocationManagerDelegate ().updatedLocation += value; }
			remove { EnsureCLLocationManagerDelegate ().updatedLocation -= value; }
		}

		public event EventHandler<CLHeadingUpdatedEventArgs> UpdatedHeading {
			add { EnsureCLLocationManagerDelegate ().updatedHeading += value; }
			remove { EnsureCLLocationManagerDelegate ().updatedHeading -= value; }
		}

		public CLLocationManagerEventArgs ShouldDisplayHeadingCalibration {
			get { return EnsureCLLocationManagerDelegate ().shouldDisplayHeadingCalibration; }
			set { EnsureCLLocationManagerDelegate ().shouldDisplayHeadingCalibration = value; }
		}

		public event EventHandler<NSErrorEventArgs> Failed {
			add { EnsureCLLocationManagerDelegate ().failed += value; }
			remove { EnsureCLLocationManagerDelegate ().failed -= value; }
		}

		public event EventHandler<CLRegionEventArgs> RegionEntered {
			add { EnsureCLLocationManagerDelegate ().regionEntered += value; }
			remove { EnsureCLLocationManagerDelegate ().regionEntered -= value; }
		}

		public event EventHandler<CLRegionEventArgs> RegionLeft {
			add { EnsureCLLocationManagerDelegate ().regionLeft += value; }
			remove { EnsureCLLocationManagerDelegate ().regionLeft -= value; }
		}

		public event EventHandler<CLRegionErrorEventArgs> MonitoringFailed {
			add { EnsureCLLocationManagerDelegate ().monitoringFailed += value; }
			remove { EnsureCLLocationManagerDelegate ().monitoringFailed -= value; }
		}

	
	} /* class CLLocationManager */
	

	//
	// EventArgs classes
	//
	public partial class CLLocationUpdatedEventArgs : EventArgs {
		public CLLocationUpdatedEventArgs (CLLocation newLocation, CLLocation oldLocation)
		{
			this.NewLocation = newLocation;
			this.OldLocation = oldLocation;
		}
		public CLLocation NewLocation { get; set; }
		public CLLocation OldLocation { get; set; }
	}

	public partial class CLHeadingUpdatedEventArgs : EventArgs {
		public CLHeadingUpdatedEventArgs (CLHeading newHeading)
		{
			this.NewHeading = newHeading;
		}
		public CLHeading NewHeading { get; set; }
	}

	public partial class NSErrorEventArgs : EventArgs {
		public NSErrorEventArgs (NSError error)
		{
			this.Error = error;
		}
		public NSError Error { get; set; }
	}

	public partial class CLRegionEventArgs : EventArgs {
		public CLRegionEventArgs (CLRegion region)
		{
			this.Region = region;
		}
		public CLRegion Region { get; set; }
	}

	public partial class CLRegionErrorEventArgs : EventArgs {
		public CLRegionErrorEventArgs (CLRegion region, NSError error)
		{
			this.Region = region;
			this.Error = error;
		}
		public CLRegion Region { get; set; }
		public NSError Error { get; set; }
	}

	

	//
	// Delegate classes
	//
	public delegate bool CLLocationManagerEventArgs (CLLocationManager manager);
}
