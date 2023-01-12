using Reflection.Models;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Reflection;

Flute flute = new Flute();
flute.Price = 21;
flute.Model = "2SP";
flute.Brand = "Gemeinhardt";
flute.Color = "Pink";
flute.Holes = 7;


Violin violin = new Violin();
violin.Price = 99;
violin.Model = "ST 1500";
violin.Brand = "Stentor";
violin.Color = "Lime";
violin.Strings = 4;


Guitar guitar = new Guitar();
guitar.Price = 120;
guitar.Model = "Strato 1954";
guitar.Brand = "Stratocaster";
guitar.Color = "B-Black";
guitar.Strings = 9;


Piano piano = new Piano();
piano.Price = 1500;
piano.Model = "Arius YDP-145";
piano.Brand = "Yamaha";
piano.Keys = 88;


ArrayList instruments = new ArrayList();
instruments.Add(flute);
instruments.Add(violin);
instruments.Add(guitar);
instruments.Add(piano);
//Type[] instrumentTypes = instruments.GetType().GetProperties();


Assembly assembly = Assembly.GetExecutingAssembly();
Type[] types = assembly.GetTypes();

PropertyInfo[] fluteProp = flute.GetType().GetProperties(); 
PropertyInfo[] violinProp = violin.GetType().GetProperties(); 
PropertyInfo[] guitarProp = guitar.GetType().GetProperties(); 
PropertyInfo[] pianoProp = piano.GetType().GetProperties(); 

//var property = instruments.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
//property.GetValue(guitar);

foreach (var instrument in instruments)
{
	foreach (Type type in types)
	{
		Console.WriteLine("Types:   " + type.Name);

		foreach (var item in type.GetProperties())
		{
			Console.WriteLine("Properties:   " + item.Name + ":   " + instruments.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance));
			//Console.WriteLine("Properties:   " + item.Name + ":   ");
			//for(int i = 0; i<fluteProp.Length; i++)
			//{
			//	Console.WriteLine(instruments[i]);
			//}
		}
	}
}

//Assembly assembly = Assembly.GetExecutingAssembly();
//Type[] types = assembly.GetTypes();

//foreach (Type type in types)
//{
//    Console.WriteLine("Types:   " +type);
//    foreach (var item in type.GetProperties())
//    {
//        Console.WriteLine("Properties:   " +item);
//    }
//}


void PrintAllInstruments()
{

}
