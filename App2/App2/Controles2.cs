using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App2
{
    public class Controles2 : ContentPage
    {
        public Controles2()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Controles 2" },
                    new Entry { Text = "Agregar datos" }
                }
            };
        }
    }
}
