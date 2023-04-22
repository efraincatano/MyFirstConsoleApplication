using System;

// Outputting name and location
string name = "Efrain";
string country = "Chile";
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}My name is {name}, I am from {country}!");
string formattedDate = currentDate.ToString("MM/dd");
// Outputting current day but with a different year
Console.WriteLine($"{Environment.NewLine} Time: {formattedDate}/1830");

//Outputing the number of days until Christmas this year
DateTime christmasDay = new DateTime(DateTime.Now.Year, 12, 25);
TimeSpan timeUntilChristmas = christmasDay - DateTime.Today;
int daysUntilChristmas = (int)timeUntilChristmas.TotalDays;
Console.WriteLine("There are " + daysUntilChristmas + " days until Christmas");

//Program example from section 2.1 in the 'C# Programming Yellow Book'
double width, height, woodLength, glassArea;
string widthString, heightString;
Console.WriteLine("Enter the width of the window in feet:");
widthString = Console.ReadLine();
width = double.Parse(widthString);
Console.WriteLine("Enter the height of the window in feet:");
heightString = Console.ReadLine();
height = double.Parse(heightString);
woodLength = 2 * (width + height) * 3.25;
glassArea = 2 * (width * height);
Console.WriteLine ( "The length of the wood is " + woodLength + " feet" ) ;
Console.WriteLine( "The area of the glass is " + glassArea + " square metres" ) ;



Console.Write($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);
