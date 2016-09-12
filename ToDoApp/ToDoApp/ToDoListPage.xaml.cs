using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.ViewModels;
using ToDoApp.Models;
using Xamarin.Forms;

namespace ToDoApp
{
    public partial class ToDoListPage : ContentPage
    {

        public ToDoListPage()
        {
            InitializeComponent();
            BindingContext = new MemoViewModel();
        }

        public void AddClicked(object sender, EventArgs e)
        {
            OnAddClicked(null, null);
        }

        //public void OnItemTapped(object o, ItemTappedEventArgs e)
        //{
        //    var memo = e.Item as MemoToDoo;
        //    OnItemSelected(o,null);

        //}

        //public void OnItemClicked(object o, SelectedItemChangedEventArgs e)
        //{
        //    var memo = e.SelectedItem as MemoToDoo;
        //    OnItemSelected(memo, null);
        //}

        public async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMemo = e.SelectedItem as Memo;
            var detailPage = new ToDoDetailPage() { BindingContext = BindingContext };

            await Navigation.PushModalAsync(detailPage);
        }

        public async void OnAddClicked(object sender, SelectedItemChangedEventArgs e)
        {

            var addMemoPage = new ToDoAddMemoPage() { BindingContext = BindingContext };

            await Navigation.PushModalAsync(addMemoPage);
        }
    }
}
