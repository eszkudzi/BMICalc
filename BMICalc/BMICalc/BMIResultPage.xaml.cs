namespace BMICalc;

public partial class BMIResultPage : ContentPage
{
	public BMIResultPage(double bmi)
	{
		InitializeComponent();
		LblBMI.Text = $"{bmi:F2}";
		LblBMIMessage.Text = $"You are {GetResult(bmi)}!";
	}

    private string GetResult(double bmi)
    {
        if(bmi >= 25)
		{
			return "too fat";
		}
		else if(bmi > 18.5)
		{
			return "perfect";
		}
		else
		{
			return "too skinny";
		}
	} 
}
