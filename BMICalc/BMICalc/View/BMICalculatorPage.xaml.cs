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
        FrameFemale.FadeTo(0.5);
        FrameFemale.ScaleTo(0.5);
        FrameFemale.TranslateTo(FrameMale.X - 40, FrameFemale.Y);

        FrameMale.FadeTo(1);
        FrameMale.ScaleTo(1.5);
        FrameMale.TranslateTo(FrameMale.X, FrameFemale.Y);

        FrameMale.BorderColor = Color.FromArgb("#ff0000");
        FrameFemale.BorderColor = Color.FromArgb("#474747");
    }

    private void TapFemale_Tapped(object sender, TappedEventArgs e)
    {
        FrameMale.FadeTo(0.5);
        FrameMale.ScaleTo(0.5);
        FrameMale.TranslateTo(FrameMale.X - 40, FrameFemale.Y);

        FrameFemale.FadeTo(1);
        FrameFemale.ScaleTo(1.5);
        FrameFemale.TranslateTo(FrameMale.X, FrameFemale.Y);

        FrameFemale.BorderColor = Color.FromArgb("#ff0000");
        FrameMale.BorderColor = Color.FromArgb("#474747");
    }


}
