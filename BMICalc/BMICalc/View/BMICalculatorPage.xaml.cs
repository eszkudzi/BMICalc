using BMICalc.ViewModel;

namespace BMICalc.View;

public partial class BMICalculatorPage : ContentPage
{
	public BMICalculatorPage()
	{
        InitializeComponent();
        BindingContext = new BMICalculatorPageViewModel();

    }

	private void TapMale_Tapped(object sender, TappedEventArgs e)
	{
        FrameMale.BorderColor = Color.FromArgb("#ff0000");
        FrameFemale.BorderColor = Color.FromArgb("#474747");
    }

    private void TapFemale_Tapped(object sender, TappedEventArgs e)
    {
        FrameFemale.BorderColor = Color.FromArgb("#ff0000");
        FrameMale.BorderColor = Color.FromArgb("#474747");
    }


}
