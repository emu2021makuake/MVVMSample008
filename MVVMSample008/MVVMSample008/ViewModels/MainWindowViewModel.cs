using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.ComponentModel.DataAnnotations;
using System.Windows.Input;

namespace MVVMSample008.ViewModels
{
    public class MainWindowViewModel : ObservableValidator
    {
        private string _fullName;
        [Required(ErrorMessage = "{0} is a required field.")]
        [StringLength(20, ErrorMessage = "Character length is too long.")]
        public string FullName
        {
            get => _fullName;
            set => SetProperty(ref _fullName, value);
        }

        private int _age;
        public int Age
        {
            get => _age;
            set => SetProperty(ref _age, value);
        }

        private string _note;
        public string Note
        {
            get => _note;
            set => SetProperty(ref _note, value);
        }

        public bool IsNormal { get => !this.HasErrors; }

        public ICommand ValidateCommand { get; }
        public ICommand ClearErrorCommand { get; }

        /// <summary>
        /// constructor
        /// </summary>
        public MainWindowViewModel()
        {
            ValidateCommand = new RelayCommand(() =>
            {
                this.ValidateAllProperties();
            });

            ClearErrorCommand = new RelayCommand(() =>
            {
                this.ClearErrors();
            });
        }
    }
}
