using Cirrious.MvvmCross.ViewModels;
using TipCalc.Core.Services;

namespace TipCalc.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
        private readonly ICalculationService _calculationService;

        public FirstViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        private double _generosity;

        public double Generosity
        {
            get { return _generosity; }
            set;
        }

        private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}
    }
}
