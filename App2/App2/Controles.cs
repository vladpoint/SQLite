using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App2
{
    public class Controles : ContentPage
    {
        public Controles()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" },
                    new Button { Text = "Boton" }
                }
            };
        }
    }
}
