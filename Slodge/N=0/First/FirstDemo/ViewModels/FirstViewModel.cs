using System;
using Cirrious.MvvmCross.ViewModels;

namespace FirstDemo.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}

        private string _firstName;

        public string FirstName {
            get { return _firstName; }
            set
            {
                _firstName = value;
                RaisePropertyChanged(()=>FirstName);
                RaisePropertyChanged(() => FullName);
            }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                RaisePropertyChanged(() => LastName);
                RaisePropertyChanged(() => FullName);
            }
        }

        public string FullName
        {
            get { return String.Format("{0} {1}", _firstName, _lastName); }
        }
    }
}
