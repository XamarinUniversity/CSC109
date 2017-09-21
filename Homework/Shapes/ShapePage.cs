using System.Collections.Generic;
using Xamarin.Forms;

namespace Shapes
{
    public class ShapePage : ContentPage
    {
        private List<Shape> shapes;
        public ShapePage()
        {
            shapes = new List<Shape>();
            shapes.Add(new Rectangle(50, 100));
            shapes.Add(new Rectangle(22, 44));
            shapes.Add(new Triangle(10, 12));
            shapes.Add(new Square(5));

            //Listview
            ListView listView = new ListView();
            listView.ItemsSource = shapes;
            listView.ItemSelected += ListView_ItemSelected;

            Content = listView;
            
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Shape selectedShape = e.SelectedItem as Shape;
            //Check to make sure it really is a shape object
            if (selectedShape != null)
            {
                //Now I can use it
                DisplayAlert("The area is...",selectedShape.GetArea().ToString(),"Okay");
            }
            //Clear selection
            //The sender is an object but it really is a listview. Lets cast it.
            ListView listView = sender as ListView;
            if (listView != null)
            {
                listView.SelectedItem = null;
            }

        }
    }
}
