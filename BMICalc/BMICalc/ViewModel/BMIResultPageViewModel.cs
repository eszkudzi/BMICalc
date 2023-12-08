using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BMICalc.ViewModel
{
	public class BMIResultPageViewModel : INotifyPropertyChanged
	{
        private string userBMI;
        private string bMIMessage;

        public string UserBMI
        {
            get => userBMI;
            set => SetProperty(ref userBMI, value);
        }

        public string BMIMessage
        {
            get => bMIMessage;
            set => SetProperty(ref bMIMessage, value);
        }

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

        public BMIResultPageViewModel(double bmi)
		{
            UserBMI = $"{bmi:F2}";
		    BMIMessage = $"You are {GetResult(bmi)}!";
		}

		public void OnPropertyChanged([CallerMemberName] string name = "") =>
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public event PropertyChangedEventHandler? PropertyChanged;

        private string GetResult(double bmi)
          {
              if (bmi >= 25)
              {
                  return "too fat";
              }
              else if (bmi > 18.5)
              {
                  return "perfect";
              }
              else
              {
                  return "too skinny";
              }


          }
    }

}

