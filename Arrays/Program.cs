

// Declare and set array element values.
string[] heroes = { "Spider Man", "Batman", "Iron Man" };

for (int i = 0; i < heroes.Length; i++)
{
	var rank = i + 1;

	Console.WriteLine($"{rank}. {heroes[i]}");
}

// Declare a single-dimensional arraay of 4 strings.
string[] animes = new string[4];

animes[0] = "Attack On Titan";
animes[1] = "Fullmetal";
animes[2] = "Mob Psycho 100";
animes[3] = "Death Note";

for (int i = 0; i < animes.Length; i++)
{
	var rank = i + 1;

	Console.WriteLine($"{rank}. {animes[i]}");
}

Console.Clear();

long[] numbers = [ 0, 1, 2, 3, 4, 5 ];

long lastNumber = numbers[numbers.Length - 1];

Console.WriteLine(lastNumber);