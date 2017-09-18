using System;
using CalculationInterface;
using UIKit;

namespace Calculator
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

			LocalEnvironment.InitLocalEnvironment();

			UITextField tfNumber1 = new UITextField();
			tfNumber1.Placeholder = "Number1";
			tfNumber1.Frame = new CoreGraphics.CGRect(50, 50, 100, 30);
			this.Add(tfNumber1);

			UITextField tfNumber2 = new UITextField();
			tfNumber2.Placeholder = "Number2";
			tfNumber2.Frame = new CoreGraphics.CGRect(50, 100, 100, 30);
			this.Add(tfNumber2);

			UITextField tfNumber3 = new UITextField();
			tfNumber3.Placeholder = "Operator";
			tfNumber3.Frame = new CoreGraphics.CGRect(50, 150, 100, 30);
			this.Add(tfNumber3);

			UIButton btnGetResult = new UIButton(UIButtonType.System);
			btnGetResult.Frame = new CoreGraphics.CGRect(50, 200, 100, 30);
			btnGetResult.SetTitle("GetResult", UIControlState.Normal);
			this.Add(btnGetResult);

			btnGetResult.TouchUpInside += delegate {
				ICalculation calculator = CalculFactory.GetCalculatorByOperator(tfNumber3.Text);
				if (null == calculator)
				{
					new UIAlertView("Error", "Unsupported operator.", null, "Close", null).Show();
				}
				else
				{ 
					try
					{
						double number1 = Convert.ToDouble(tfNumber1.Text);
						double number2 = Convert.ToDouble(tfNumber2.Text);
						calculator.Number1 = number1;
						calculator.Number2 = number2;
						string result = calculator.GetResult();
						new UIAlertView("Succeeded", "Result = " + result, null, "Close", null).Show();
					}
					catch (Exception ex)
					{
						new UIAlertView("Error", "Please check your input, error message = "+ex.Message, null, "Close", null).Show();
					}
				}
			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
