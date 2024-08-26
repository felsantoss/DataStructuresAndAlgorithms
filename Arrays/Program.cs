// A single-dimensional array is a linear data structure  that store elements of the same data type in contigous memory alocation.

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

long[] numbers = [ 0, 1, 2, 3, 4, 5 ];

// Access the last index of array.
long lastNumber = numbers[numbers.Length - 1];

// Access the element at index 2 in the array.
long indexTwo = numbers[2];

Console.WriteLine($"The index number two is {indexTwo}");
Console.Clear();

// Inserting element at the end of an array
int[] intArray = new int[6];
int length = 0;

for (int i = 0; i < 3; i++)
{
	intArray[length] = i; 
	length++;
}

intArray[length] = 10;
length++;

// Inserting element at the start of an array
for (int i = 3; i >= 0; i--)
{
	intArray[i + 1] = intArray[i];
}

intArray[0] = 20;

// Inserting element anywhere in the array
// Inserting element at the index 2

// Create space for the new element
for (int i = 4; i >= 2; i--)
{
	// Shift each element one position to the right
	intArray[i + 1] = intArray[i];
}

intArray[2] = 30;

for (int i = 0; i < intArray.Length; i++)
{
	Console.WriteLine("Index " + i + " contains " + intArray[i]);
}