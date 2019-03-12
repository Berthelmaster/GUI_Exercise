using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using BMICalculator.Annotations;
using BMICalculator.Model;

namespace BMICalculator.ViewModel
{
    public class BMIViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        BMIModel bmiModel = new BMIModel();
        private double _bmi;

        public double Height
        {
            get => bmiModel.Height;
            set
            {
                if (value != bmiModel.Height)
                {
                    bmiModel.Height = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Weight
        {
            get => bmiModel.Weight;
            set
            {
                if (value != bmiModel.Weight)
                {
                    bmiModel.Weight = value;
                    OnPropertyChanged();
                }
            }
        }

        public double BMI
        {
            get; private set;
        }

        private ICommand _calcBMICommand;
        public ICommand CalcBMICommand
        {
            get
            {
                // If it doesn't exists, create a new one
                return _calcBMICommand ?? (_calcBMICommand = 
                    new RelayCommand(CalcBMI, CalcBMICanExecute));
            }
        }

        private void CalcBMI()
        {
            BMI = bmiModel.CalculateBMI();
            OnPropertyChanged("BMI");
        }
        private bool CalcBMICanExecute()
        {
            bool paramsAreValid = (Weight != 0.0 && Height != 0.0);
            return paramsAreValid;
        }
    }
}