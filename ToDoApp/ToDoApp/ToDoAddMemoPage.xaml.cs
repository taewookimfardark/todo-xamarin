using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ToDoApp
{
    public partial class ToDoAddMemoPage : ContentPage
    {
        public ToDoAddMemoPage()
        {
            InitializeComponent();
            //BindingContext = new ToDooViewModel();
        }

        async void OnDismissButtonClicked(object sender, EventArgs args)
        {
            // Page appearance not animated
            await Navigation.PopModalAsync(false);
        }
    }
}
