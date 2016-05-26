using Foundation;
using ObjCRuntime;
using UIKit;
using CoreTelephony;
using OpenGLES;
using CoreMotion;
using AudioToolbox;
using AVFoundation;
using SystemConfiguration;


namespace pgyer.ios
{
	// @interface PgyManager : NSObject
	[BaseType (typeof(NSObject))]
	interface PgyManager
	{
		// @property (getter = isDebugLogEnabled, assign, nonatomic) BOOL enableDebugLog;
		[Export ("enableDebugLog")]
		bool EnableDebugLog { [Bind ("isDebugLogEnabled")] get; set; }

		// @property (assign, nonatomic) KPGYFeedbackActiveType feedbackActiveType;
		[Export ("feedbackActiveType", ArgumentSemantic.Assign)]
		KPGYFeedbackActiveType FeedbackActiveType { get; set; }

		// @property (getter = isFeedbackEnabled, assign, nonatomic) BOOL enableFeedback;
		[Export ("enableFeedback")]
		bool EnableFeedback { [Bind ("isFeedbackEnabled")] get; set; }

		// @property (retain, nonatomic) UIColor * themeColor;
		[Export ("themeColor", ArgumentSemantic.Retain)]
		UIColor ThemeColor { get; set; }

		// @property (assign, nonatomic) double shakingThreshold;
		[Export ("shakingThreshold")]
		double ShakingThreshold { get; set; }

		// +(PgyManager *)sharedPgyManager;
		[Static]
		[Export ("sharedPgyManager")]
		PgyManager SharedPgyManager { get; }

		// -(void)startManagerWithAppId:(NSString *)appId;
		[Export ("startManagerWithAppId:")]
		void StartManagerWithAppId (string appId);

		// -(void)showFeedbackView;
		[Export ("showFeedbackView")]
		void ShowFeedbackView ();

		// -(void)reportException:(NSException *)exception;
		[Export ("reportException:")]
		void ReportException (NSException exception);
	}


	[BaseType (typeof(NSObject))]
	interface PgyUpdateManager
	{
		// +(PgyUpdateManager *)sharedPgyManager;
		[Static]
		[Export ("sharedPgyManager")]
		PgyUpdateManager SharedPgyManager { get; }

		// -(void)startManagerWithAppId:(NSString *)appId;
		[Export ("startManagerWithAppId:")]
		void StartManagerWithAppId (string appId);

		// -(void)checkUpdate;
		[Export ("checkUpdate")]
		void CheckUpdate ();

		// -(void)checkUpdateWithDelegete:(id)delegate selector:(SEL)updateMethodWithDictionary;
		[Export ("checkUpdateWithDelegete:selector:")]
		void CheckUpdateWithDelegete (NSObject @delegate, Selector updateMethodWithDictionary);

		// -(void)updateLocalBuildNumber;
		[Export ("updateLocalBuildNumber")]
		void UpdateLocalBuildNumber ();
	}

}

