using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App11
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            var time = DateTime.Now;
            var tuple = new Tuple<DateTime>(time);
            try
            {
                
               var t = Expression.Property(Expression.Constant(tuple), "Item1");
                
            }
            catch (Exception ex)
            {
                msg.Text+= ex.Message;
            }

        }
    }
}
