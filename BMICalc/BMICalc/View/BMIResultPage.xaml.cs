using BMICalc.ViewModel;

namespace BMICalc.View;

public partial class BMIResultPage : ContentPage
{
	public BMIResultPage(double bmi)
	{
		InitializeComponent();
        BindingContext = new BMIResultPageViewModel(bmi);

	}
}
