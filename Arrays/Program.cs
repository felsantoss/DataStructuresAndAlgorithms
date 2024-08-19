// Array com valores definidos

string[] heroes = { "Spider Man", "Batman", "Iron Man" };

for (int i = 0; i < heroes.Length; i++)
{
	var rank = i + 1;

	Console.WriteLine($"{rank}. {heroes[i]}");
}
Console.Clear();
// Array sem valor definido

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