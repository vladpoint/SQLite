using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Reflection;
using SQLite;

namespace App2
{
    public class App : Application
    {
        public App()
        {
            SQLiteConnection database;
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Datos>();
            var elemento = new Datos();
            //elemento.dato1 = "Hola Mundo";
            //elemento.Numero1 = "111111111";
            //database.Insert(elemento);
            //database.Delete(elemento);
            //var query = database.Query<Datos>("SELECT * FROM [Tabla]");
            //var list = query.ToList();
            //var dato = list.Last();
            var texto = new Entry();
            var insertar = new Button();
            insertar.Text = "Inserta Dato";
            insertar.Clicked += (sender, args) =>
            {
                elemento.dato1 = texto.Text;
                elemento.Numero1 = texto.Text;
                database.Insert(elemento);
                var query = database.Query<Datos>("SELECT * FROM [Tabla]");
                var list = query.ToList();
                var dato = list.Last();
                MainPage.DisplayAlert("Dato Insertado", "" + dato.dato1, "OK");
            };
            database.Insert(elemento);
            // The root page of your application
            int count = 0;
            Button button = new Button
            {
                Text = String.Format("Click me!!!")
            };
            var image = new Image
            {
                Aspect = Aspect.AspectFit
            };
            //image.Source = ImageSource.FromFile("TESH.png");
            //image.Source = ImageSource.FromUri(new Uri("http://xamarin.com/content/images/pages/forms/example-app.png"));
            image.Source = ImageSource.FromResource("App2.waterfront.jpg");
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "HOLA",
                            FontSize = 30
                        },
                        new Label
                        {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "HOLA3",
                            FontSize = 30 
                        },
                        button,
                        texto,
                        insertar,
                        new Entry
                        {
                            Keyboard = Keyboard.Numeric,
                            BackgroundColor = Color.Blue
                        },
                        new WebView
                        {
                            Source = new Uri ("http://google.com")
                            },
                        image
                        
        }
                }
            };
            button.Clicked += (sender, args) =>
            {
                count++;
                button.Text = String.Format("{0} click{1}!", count, count == 1 ? "" : "s");
                MainPage.DisplayAlert("Alerta", "Esto es una alerta", "Cancelar");
            };
            //var tabs = new TabbedPage();
            //tabs.Children.Add(new Controles { Title = "Controles1", Icon = "csharp.png" });
            //tabs.Children.Add(new Controles2 { Title = "Controles2" });
            //MainPage = tabs;
            //MainPage.DisplayAlert("Alerta", "Esto es una alerta", "Cancelar");

        }
        [Table("Tabla")]
        public class Datos
        {
            public string dato1 { get; set; }
            public string Numero1 { get; set; }
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
// assuming these values are ints
//int val1 = int.Parse(entry1.Text);
//int val2 = int.Parse(entry2.Text);
//entry3.Text = val1 + val2;
