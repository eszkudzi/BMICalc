namespace BMICalc;

public partial class BMICalculatorPage : ContentPage
{
	public BMICalculatorPage()
	{
        InitializeComponent();
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

    void BtnCalcBMI_Clicked(System.Object sender, System.EventArgs e)
    {
        double height = double.Parse (LblHeight.Text);
        double weight = double.Parse(LblWeight.Text);

        double bmi = (weight / height / height) * 10000;
        Navigation.PushAsync(new BMIResultPage(bmi));
    }
}
