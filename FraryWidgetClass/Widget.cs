using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace FraryWidgetClass
{
    internal class Widget
    {



        //Properties
        // readonly are like const - so must be uppercase
        public static readonly string SMALL = "small";
        public static readonly string MEDIUM = "medium";
        public static readonly string LARGE = "large";
        public string WidgetName {get;set;}
        public string WidgetColor { get;set;}
        public double WidgetPrice { get;set;}
        public string WidgetSize { get;set;}
        // build constructors
        public Widget() {  // no parameters -  the default constructor 
            WidgetSize = MEDIUM;
            WidgetName = "";
            WidgetColor = "Blue";
            WidgetPrice = 10;
        } 

        public Widget (string widgetName)
        {
            WidgetName = widgetName;
            WidgetSize = MEDIUM ;
            WidgetColor = "Blue";
            WidgetPrice = 10;
        }

        public Widget(string n, string s,  string c, double p)
        {
            WidgetName = n;
            WidgetSize = s;
            WidgetColor = c;
            WidgetPrice = p;
        }

        public override string ToString()
        {
            return ("The widget name is " + WidgetName + 
                " the widget size " + WidgetSize +
                " the widget color " + WidgetColor +
                " the widget price " + WidgetPrice.ToString("C") );
        } 
    }
}
