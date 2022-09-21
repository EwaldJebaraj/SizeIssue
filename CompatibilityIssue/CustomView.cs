using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompatibilityIssue
{
    internal class CustomView : ContentView
    {
        internal HorizontalStackLayout horizontalStackLayout;

        internal Label label;

        internal ContentView content;

        public CustomView()
        {
            this.InitializeControl();
            this.Content = horizontalStackLayout;
        }

        void InitializeControl()
        {
            horizontalStackLayout = new HorizontalStackLayout();
            content = new ContentView();
            label = new Label();
            label.Text = "Test";

            content.Content = label;
            horizontalStackLayout.Children.Add(content);
        }
    }
}
