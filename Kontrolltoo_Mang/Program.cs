using Kontrolltoo_Mang;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Text;

/*Tegelane character1 = new Tegelane("Rolan");

character1.Info();*/


/*Ese item = new Ese("Test", 9);
 * 
Tegelane tegelane = new Tegelane("Rolan");
item.info();
tegelane.info();*/

Tegelane tegelane = new Tegelane("Rolan");
tegelane.info();


tegelane.LisaEse(Convert.ToInt32(Console.ReadLine()));
