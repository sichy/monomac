
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

using MonoMac.ObjCRuntime;
using MonoMac.Foundation;
using MonoMac.AppKit;

namespace SamplesButtonMadness
{
	public partial class TestWindowController : MonoMac.AppKit.NSWindowController
	{
		#region members
		
		NSPopUpButton codeBasedPopUpDown;
		NSPopUpButton codeBasedPopUpRight;
		
		NSButton codeBasedButtonRound;
		NSButton codeBasedButtonSquare;
		
		NSSegmentedControl codeBasedSegmentControl;
		
		NSLevelIndicator codeBasedIndicator;
		
		#endregion
		
		#region Constructors

		// Called when created from unmanaged code
		public TestWindowController (IntPtr handle) : base(handle)
		{
			Initialize ();
		}

		// Called when created directly from a XIB file
		[Export("initWithCoder:")]
		public TestWindowController (NSCoder coder) : base(coder)
		{
			Initialize ();
		}

		// Call to load from the XIB/NIB file
		public TestWindowController () : base("TestWindow")
		{
			Initialize ();
		}

		// Shared initialization code
		void Initialize ()
		{
		}

		#endregion

		//strongly typed window accessor
		public new TestWindow Window {
			get { return (TestWindow)base.Window; }
		}
		
		#region implementation
		
		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();
			
			#region first two buttons 
			
			// add the image menu item back to the first menu item
			NSMenuItem menuItem = new NSMenuItem ("", new Selector (""), "");
			
			menuItem.Image = NSImage.ImageNamed (@"moof.png");
			buttonMenu.InsertItematIndex (menuItem, 0);
			
			nibBasedPopUpDown.Menu = buttonMenu;
			nibBasedPopUpRight.Menu = buttonMenu;
		
			// create the pull down button pointing DOWN
			RectangleF buttonFrame = placeHolder1.Frame;
			codeBasedPopUpDown = new NSPopUpButton (buttonFrame, true);
			
			((NSPopUpButtonCell)codeBasedPopUpDown.Cell).ArrowPosition = NSPopUpArrowPosition.Bottom;
			((NSPopUpButtonCell)codeBasedPopUpDown.Cell).BezelStyle = NSBezelStyle.ThickSquare;
			codeBasedPopUpDown.Menu = buttonMenu;
			popupBox.AddSubview (codeBasedPopUpDown);
			placeHolder1.RemoveFromSuperview ();
		
			// create the pull down button pointing RIGHT
			buttonFrame = placeHolder2.Frame;
			codeBasedPopUpRight = new NSPopUpButton (buttonFrame, true);
			
			((NSPopUpButtonCell)codeBasedPopUpRight.Cell).ArrowPosition = NSPopUpArrowPosition.Bottom;
			((NSPopUpButtonCell)codeBasedPopUpRight.Cell).PreferredEdge = NSRectEdge.MaxXEdge;
			((NSPopUpButtonCell)codeBasedPopUpRight.Cell).BezelStyle = NSBezelStyle.Circular;
			codeBasedPopUpRight.Menu = buttonMenu;
			((NSPopUpButtonCell)codeBasedPopUpRight.Cell).HighlightsBy = (int)NSCellMask.ChangeGrayCell;
			popupBox.AddSubview (codeBasedPopUpRight);
			placeHolder2.RemoveFromSuperview ();
			
			#endregion
			
			#region second two buttons
			
			// create the rounded button
			buttonFrame = placeHolder3.Frame;
			codeBasedButtonRound = new NSButton (buttonFrame);
			// note: this button we want alternate title and image, so we need to call this:
			codeBasedButtonRound.SetButtonType (NSButtonType.MomentaryChange);
			codeBasedButtonRound.Title = @"NSButton";
			codeBasedButtonRound.AlternateTitle = @"(pressed)";
			codeBasedButtonRound.Image = NSImage.ImageNamed (@"moof.png");
			codeBasedButtonRound.AlternateImage = NSImage.ImageNamed (@"moof2.png");
			codeBasedButtonRound.BezelStyle = NSBezelStyle.RegularSquare;
			codeBasedButtonRound.ImagePosition = NSCellImagePosition.ImageLeft;
			codeBasedButtonRound.Cell.Alignment = NSTextAlignment.Left;
			codeBasedButtonRound.Font = NSFont.SystemFontOfSize (NSFont.SmallSystemFontSize);
			codeBasedButtonRound.Sound = NSSound.FromName (@"Pop");
			codeBasedButtonRound.Target = this;
			codeBasedButtonRound.Action = new Selector (@"buttonAction:");
			buttonBox.AddSubview (codeBasedButtonRound);
			placeHolder3.RemoveFromSuperview (); 			// we are done with the place holder, remove it from the window
			
			// create the square button
			buttonFrame = placeHolder4.Frame;
			codeBasedButtonSquare = new NSButton (buttonFrame);
			codeBasedButtonSquare.Title = @"NSButton";
			codeBasedButtonSquare.BezelStyle = NSBezelStyle.ShadowlessSquare;
			codeBasedButtonSquare.ImagePosition = NSCellImagePosition.ImageLeft;
			codeBasedButtonSquare.Cell.Alignment = NSTextAlignment.Left;
			codeBasedButtonSquare.Image = NSImage.ImageNamed (@"moof.png");
			codeBasedButtonSquare.Font = NSFont.SystemFontOfSize (NSFont.SmallSystemFontSize);
			codeBasedButtonSquare.Sound = NSSound.FromName (@"Pop");
			codeBasedButtonSquare.Target = this;
			codeBasedButtonSquare.Action = new Selector (@"buttonAction:");
			buttonBox.AddSubview (codeBasedButtonSquare);
			placeHolder4.RemoveFromSuperview (); 			// we are done with the place holder, remove it from the window
			
			#endregion
			
			#region segmented control
			
			buttonFrame = placeHolder5.Frame;
			codeBasedSegmentControl = new NSSegmentedControl(buttonFrame);
			codeBasedSegmentControl.SegmentCount = 3;
			codeBasedSegmentControl.SetWidth (nibBasedSegControl.GetWidth(0), 0);
			codeBasedSegmentControl.SetWidth (nibBasedSegControl.GetWidth (1), 1);
			codeBasedSegmentControl.SetWidth (nibBasedSegControl.GetWidth (2), 2);
			codeBasedSegmentControl.SetLabel (@"One", 0);
			codeBasedSegmentControl.SetLabel (@"Two", 1);
			codeBasedSegmentControl.SetLabel (@"Three", 2);
			codeBasedSegmentControl.Target = this;
			codeBasedSegmentControl.Action = new Selector(@"segmentAction:");
			segmentBox.AddSubview (codeBasedSegmentControl);
			placeHolder5.RemoveFromSuperview ();
	
			// use a menu to the first segment (applied to both nib-based and code-based)
			codeBasedSegmentControl.SetMenu (buttonMenu, 0);
			nibBasedSegControl.SetMenu (buttonMenu, 0);
			
			// add icons to each segment (applied to both nib-based and code-based)
			NSImage segmentIcon1 = NSWorkspace.SharedWorkspace.IconForFileType(NSFileTypeForHFSTypeCode.ComputerIcon);
			segmentIcon1.Size = new SizeF(16, 16);
			nibBasedSegControl.SetImage (segmentIcon1, 0);
			codeBasedSegmentControl.SetImage (segmentIcon1, 0);
			
			NSImage segmentIcon2 = NSWorkspace.SharedWorkspace.IconForFileType (NSFileTypeForHFSTypeCode.DesktopIcon);
			segmentIcon2.Size = new SizeF (16, 16);
			nibBasedSegControl.SetImage (segmentIcon2, 1);
			codeBasedSegmentControl.SetImage (segmentIcon2, 1);
			
			NSImage segmentIcon3 = NSWorkspace.SharedWorkspace.IconForFileType (NSFileTypeForHFSTypeCode.FinderIcon);
			segmentIcon3.Size = new SizeF (16, 16);
			nibBasedSegControl.SetImage (segmentIcon3, 2);
			codeBasedSegmentControl.SetImage (segmentIcon3, 2);
		
			#endregion
			
			#region level indicator
			
			buttonFrame = placeHolder8.Frame;
			codeBasedIndicator = new NSLevelIndicator(buttonFrame);
			codeBasedIndicator.MaxValue = 10;
			codeBasedIndicator.MajorTickMarkCount = 4;
			codeBasedIndicator.TickMarkCount = 7;
			codeBasedIndicator.WarningValue = 5;
			codeBasedIndicator.CriticalValue = 8;
			codeBasedIndicator.Cell.LevelIndicatorStyle = NSLevelIndicatorStyle.DiscreteCapacity;
			codeBasedIndicator.Action = new Selector(@"levelAction:");
			indicatorBox.AddSubview(codeBasedIndicator);
			placeHolder8.RemoveFromSuperview();
			
			
			#endregion
		}
		
		#endregion
		
		#region event handlers
		
		partial void dropDownAction (NSObject sender)
		{
			Console.WriteLine ("Drop down button clicked");
		}
		
		partial void buttonAction (NSObject sender)
		{
			Console.WriteLine ("Button clicked");
		}
		
		partial void segmentAction (NSObject sender)
		{
			Console.WriteLine ("Segment button clicked");
		}
		
		partial void levelAction (NSObject sender)
		{
			Console.WriteLine (@"Level action clicked");
		}
		
		partial void unselectAction (NSObject sender)
		{
			nibBasedSegControl.UnselectAllSegments();
			codeBasedSegmentControl.UnselectAllSegments();
		}
		
		partial void levelAdjustAction (NSObject sender)
		{
			NSStepper stepper = sender as NSStepper;
			
			Console.WriteLine (@"Change level: %ld", stepper.IntValue);
			
			nibBasedIndicator.IntValue = stepper.IntValue;
			codeBasedIndicator.IntValue = stepper.IntValue;
		}
		
		
		
		#endregion
	}
}

