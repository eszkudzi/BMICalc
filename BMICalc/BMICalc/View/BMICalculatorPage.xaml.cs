using BMICalc.Components;
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
        AnimateImageFrameComponent(FrameFemale, FrameMale);
    }

    private void TapFemale_Tapped(object sender, TappedEventArgs e)
    {
        AnimateImageFrameComponent(FrameMale, FrameFemale);
    }

    private void AnimateImageFrameComponent(ImageFrameComponent toHide, ImageFrameComponent toShow)
    {
        toHide.FadeTo(0.5);
        toHide.ScaleTo(0.5);
        toHide.TranslateTo(toHide.X - 40, toHide.Y);

        toShow.FadeTo(1);
        toShow.ScaleTo(1.5);
        toShow.TranslateTo(toShow.X, toShow.Y);

        toShow.BorderColor = Color.FromArgb("#ff0000");
        toHide.BorderColor = Color.FromArgb("#474747");
    }

}
