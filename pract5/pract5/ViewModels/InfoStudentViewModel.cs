using pract5.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace pract5.ViewModels
{
	public class InfoStudentViewModel : INotifyPropertyChanged
    {
        public ICommand CreateStudentListCommand { set; get; }
        public ICommand DeleteStudentListCommand { set; get; } 

        public string Prizv { get; set; }
        public string Name { get; set; }

        InfoStrudent selectedStudent;

        public InfoStrudent SelectedStudent
        {
            get { return selectedStudent; }
            set
            {
                if (selectedStudent != value)
                {
                    InfoStrudent tempFriend = value;
                    selectedStudent = null;
                    OnPropertyChanged(nameof(SelectedStudent));
                }
            }
        }

        private string _studentPIB;
        public string StudentPIB
        {
            get => _studentPIB;
            set
            {
                _studentPIB = value;
                OnPropertyChanged(nameof(StudentPIB));
            }
        }

        private string _birsday;
        public string Birsday
        {
            get => _birsday;
            set
            {
                _birsday = value;
                OnPropertyChanged(nameof(Birsday));
            }
        }

        private int _phone;
        public int Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        private ObservableCollection<InfoStrudent> _infoStrudent;
        public ObservableCollection<InfoStrudent> Students
        {
            get => _infoStrudent;
            set
            {
                _infoStrudent = value;
                OnPropertyChanged(nameof(Students));
            }
        }


        public InfoStudentViewModel()
        {
            Students = new ObservableCollection<InfoStrudent>();
            CreateStudentListCommand = new Command(CreateStudentList);
            DeleteStudentListCommand = new Command(DeleteStudent);
        }

        private void CreateStudentList()
        {
            var Student = new InfoStrudent
            {
                StudentPIB = ToString(),
                Birsday = this.Birsday,
                Phone = this.Phone
            };
            Students.Add(Student);

        }

        private void DeleteStudent(object studentObject)
        {
            InfoStrudent Student = studentObject as InfoStrudent;
            if (Student != null)
            {
                Students.Remove(Student);
            }
        }

        public override string ToString()
        {
            return this.Prizv + " " + this.Name;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

    }
}