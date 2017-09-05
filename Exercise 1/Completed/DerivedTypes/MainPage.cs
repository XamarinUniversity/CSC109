using Xamarin.Forms;
using System.Collections.Generic;

namespace DerivedTypes
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            List<string> Messages = new List<string>();

            // Perform an "Add" operation
            AddOperation add = new AddOperation(10, 20);
            Messages.Add(add.Calculate());

            // TODO: perform a "Multiply" operation
            MultiplyOperation multiply = new MultiplyOperation(10, 20);
            Messages.Add(multiply.Calculate());

            // Display content into our UI
            Padding = new Thickness(0, Device.OnPlatform(20.0, 0, 0), 0, 0);
            Content = new ListView() { 
                ItemsSource = Messages, 
                SeparatorVisibility = SeparatorVisibility.None };

        }
    }
}


