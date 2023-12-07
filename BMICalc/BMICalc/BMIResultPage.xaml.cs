using BMICalc.ViewModel;

namespace BMICalc;

public partial class BMIResultPage : ContentPage
{
	public BMIResultPage(double bmi)
	{
		InitializeComponent();
		BindingContext = new BMIResultPageViewModel();

	}
}
