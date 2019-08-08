﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleXamApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> messageList = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
            listView.ItemsSource = messageList;
        }

        private async void SendButton_Clicked(object sender, EventArgs e)
        {
            var message = messageEntry.Text;
            await DisplayAlert(Device.RuntimePlatform == Device.iOS ? "Message Sent thru iOS" : "Message Sent thru Android", $"Message: {message}", "OK");
            messageList.Add(message);
        }
    }
}
