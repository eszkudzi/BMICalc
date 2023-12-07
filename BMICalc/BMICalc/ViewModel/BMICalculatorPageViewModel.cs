using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace BMICalc.ViewModel
{
	public class BMICalculatorPageViewModel : INotifyPropertyChanged
    {
		public BMICalculatorPageViewModel()
		{
            ButtonClickedCommand = new Command(FirstButtonClicked);

        }

        private void FirstButtonClicked()
        {
            double height = double.Parse (LblHeight.Text);
            double weight = double.Parse(LblWeight.Text);

            double bmi = (weight / height / height) * 10000;
            Navigation.PushAsync(new BMIResultPage(bmi));
        }

        public ICommand ButtonClickedCommand { get; }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public event PropertyChangedEventHandler? PropertyChanged;


    }
}

