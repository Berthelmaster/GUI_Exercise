using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMICalculator.Model;

namespace BMICalculator.ViewModel
{
    public class ViewModelLocator
    {
        public BMIViewModel BmiViewModel
        {
            get { return new BMIViewModel(); }
        }
    }
}
