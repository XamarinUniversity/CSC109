using Xamarin.Forms;
using System.Collections.Generic;

namespace DerivedTypes
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            List<string> Messages = new List<string>();

            List<Operation> operations = new List<Operation>();
            operations.Add(new AddOperation(10, 20));
            operations.Add(new MultiplyOperation(10, 20));

            foreach (Operation op in operations) {
                Messages.Add(op.Calculate());
            }

            // Display content into our UI
            Padding = new Thickness(0, Device.OnPlatform(20.0, 0, 0), 0, 0);
            Content = new ListView() { 
                ItemsSource = Messages, 
                SeparatorVisibility = SeparatorVisibility.None };

        }
    }
}


