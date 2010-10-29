
	[BaseType (typeof (NSControl))]
	interface NSSegmentedControl {
		[Export ("selectSegmentWithTag:")]
		bool SelectSegmentWithTag (int tag);

		[Export ("setWidth:forSegment:")]
		void SetWidthforSegment (float width, int segment);

		[Export ("widthForSegment:")]
		float WidthForSegment (int segment);

		[Export ("setImage:forSegment:")]
		void SetImageforSegment (NSImage image, int segment);

		[Export ("imageForSegment:")]
		NSImage ImageForSegment (int segment);

		[Export ("setImageScaling:forSegment:")]
		void SetImageScalingforSegment (NSImageScaling scaling, int segment);

		[Export ("imageScalingForSegment:")]
		NSImageScaling ImageScalingForSegment (int segment);

		[Export ("setLabel:forSegment:")]
		void SetLabelforSegment (string label, int segment);

		[Export ("labelForSegment:")]
		string LabelForSegment (int segment);

		[Export ("setMenu:forSegment:")]
		void SetMenuforSegment (NSMenu menu, int segment);

		[Export ("menuForSegment:")]
		NSMenu MenuForSegment (int segment);

		[Export ("setSelected:forSegment:")]
		void SetSelectedforSegment (bool selected, int segment);

		[Export ("isSelectedForSegment:")]
		bool IsSelectedForSegment (int segment);

		[Export ("setEnabled:forSegment:")]
		void SetEnabledforSegment (bool enabled, int segment);

		[Export ("isEnabledForSegment:")]
		bool IsEnabledForSegment (int segment);

		//Detected properties
		[Export ("segmentCount")]
		int SegmentCount { get; set; }

		[Export ("selectedSegment")]
		int SelectedSegment { get; set; }

		[Export ("segmentStyle")]
		NSSegmentStyle SegmentStyle { get; set; }

	}
