using System;
using NoteKeeper.ViewModels;
using System.ComponentModel;
using NoteKeeper.Models;
using Xamarin.Forms;

namespace NoteKeeper.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public Note Note { get; set; }

        public ItemDetailPage()
        {
            InitializeComponent();
            InitializeData();

            //BindingContext = new ItemDetailViewModel();
            BindingContext = Note;
        }

        private void InitializeData()
        {
            Note = new Note
            {
                Heading = "Test note",
                Text = "Text for a test note"
            };
        }

        private void CancelMenuItem_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Cancel option", "Cancel was selected", "Accept Button", "Cancel Button");
        }

        private void SaveMenuItem_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Save option", "Save was selected", "Accept Button", "Cancel Button");
        }
    }
}