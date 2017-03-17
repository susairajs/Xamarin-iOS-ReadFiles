using System;
using UIKit;

using System.IO;
using System.Threading;

namespace XamariniOSReadFile
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Perform any additional setup after loading the view, typically from a nib.
		}

		private int ReadFile()
		{
			int count=0;

			using (StreamReader reader = new StreamReader("/Users/DELPIN/Desktop/xamarin.txt"))
			{
				string filecontent = reader.ReadToEnd();

				count = filecontent.Length;
				Thread.Sleep(5000);

			}
			return count;
		}

		partial void BtnRead_TouchUpInside(UIButton sender)
		{

			int count = ReadFile();
			lblDisplay.Text = count.ToString();		
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


