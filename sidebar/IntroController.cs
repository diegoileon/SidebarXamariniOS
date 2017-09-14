using Foundation;
using System;
using UIKit;

namespace sidebar
{
	public partial class IntroController : UIViewController
	{
		// provide access to the sidebar controller to all inheriting controllers
		protected SidebarNavigation.SidebarController SidebarController
		{
			get
			{
				return (UIApplication.SharedApplication.Delegate as AppDelegate).RootViewController.SidebarController;
			}
		}

		// provide access to the navigation controller to all inheriting controllers
		protected NavigationController NavController
		{
			get
			{
				return (UIApplication.SharedApplication.Delegate as AppDelegate).RootViewController.NavController;
			}
		}

		// provide access to the storyboard to all inheriting controllers
		public override UIStoryboard Storyboard
		{
			get
			{
				return (UIApplication.SharedApplication.Delegate as AppDelegate).RootViewController.Storyboard;

			}
		}

		public IntroController(IntPtr handle) : base(handle)
		{
		}
	}
}