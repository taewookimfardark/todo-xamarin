using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ToDoApp.Models;
using Xamarin.Forms;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ToDoApp.ViewModels
{
    public class MemoViewModel: INotifyPropertyChanged
    {
        private Memo _memo;
        private Memo _selectedMemo;
        private ObservableCollection<string> _memoJson;
        private ObservableCollection<Memo> _memos;

        public ObservableCollection<string> MemosJson
        {
            get { return _memoJson; }
            set
            {
                _memoJson = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Memo> Memos
        {
            get { return _memos; }
            set
            {
                _memos = value;
                OnPropertyChanged();
            }
        }

        public Memo Memo
        {
            get { return _memo; }
            set
            {
                _memo = value;
                OnPropertyChanged();
            }
        }

        public Memo SelectedMemo
        {
            get { return _selectedMemo; }
            set
            {
                _selectedMemo = value;
                OnPropertyChanged();
            }
        }

        public Command AddMemoCommand
        {
            get
            {
                return new Command(() =>
                {
                    Memos.Add(Memo);
                    string json = JsonConvert.SerializeObject(Memo);
                    MemosJson.Add(json);
                });
            }
        }

        //public Command EditMemoCommand
        //{
        //    get
        //    {
        //        return new Command(() =>
        //        {
        //            Memos.Add(Memo);
        //            string json = JsonConvert.SerializeObject(Memo);
        //            MemosJson.Add(json);
        //        });
        //    }
        //}

        //public Command DeleteMemoCommand
        //{
        //    get
        //    {
        //        return new Command(() =>
        //        {
        //            var currentMemo = SelectedMemo;
        //            var currentMemos = JsonConvert.DeserializeObject<Memo>(Memos);
        //            var index = currentMemos.FindIndex()

        //        });
        //    }
        //}



        public MemoViewModel()
        {
            Memo = new Memo()
            {
                Name = "",
                IsChecked = true
            };

            Memos = new ObservableCollection<Memo>();
            MemosJson = new ObservableCollection<string>();

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
