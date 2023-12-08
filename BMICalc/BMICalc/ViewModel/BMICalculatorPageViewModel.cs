using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using BMICalc.View;

namespace BMICalc.ViewModel
{
    public class BMICalculatorPageViewModel : INotifyPropertyChanged
    {
        private double heightSliderValue;

        public double HeightSliderValue {
            get => heightSliderValue;
            set => SetProperty(ref heightSliderValue, value);
        }

        private double weightSliderValue;

        public double WeightSliderValue {
            get => weightSliderValue;
            set => SetProperty(ref weightSliderValue, value);
        }

        public BMICalculatorPageViewModel()
        {
            ButtonClickedCommand = new Command(FirstButtonClicked);
        }

        private void FirstButtonClicked()
        {
            double height = HeightSliderValue;
            double weight = WeightSliderValue;

            double bmi = (weight / height / height) * 10000;
            Application.Current?.MainPage?.Navigation.PushAsync(new BMIResultPage(bmi));
        }

        public ICommand ButtonClickedCommand { get; }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public event PropertyChangedEventHandler? PropertyChanged;

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }

    }
}

