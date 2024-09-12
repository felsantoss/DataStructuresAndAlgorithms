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

int[] numbersArray = new int[16];

for (int index = 0; index <= numbersArray.Length - 2; index++)
{
	numbersArray[index] = index;
}

numbersArray[numbersArray.Length - 1] = 66;

for (int i = 0; i < numbersArray.Length; i++)
{
	Console.WriteLine("Index " + i + " contains " + numbersArray[i]);
}

// Copy elements into another array
int[] arrayOne = { 0, 1, 2, 3, 4 };

int[] arrayOneCopy = new int[arrayOne.Length];

for (int i = 0; i < arrayOneCopy.Length; i++)
{
	arrayOneCopy[i] = arrayOne[i];
}

Console.Clear();

int n = 10;
int[] oldArray = new int[n];
int idx;

// Initial array of size 10
for (idx = 0; idx < n; idx++)
{
	oldArray[idx] = idx + 1;
}

// Print original array
for (idx = 0; idx < n; idx++)
{
	Console.Write(oldArray[idx] + " ");
}
Console.WriteLine();
// element to be inserted
int x = 50;

// position at witch element is to be inserted
int pos = 5;

// create new array with size + 1
int[] newArray = new int[n + 1];

// insert the elements from the old array int the new array, insert all elements till pos, then insert x at pos, then insert rest of elements
for (idx = 0; idx < n + 1; idx++)
{
	if (idx < pos - 1)
		newArray[idx] = oldArray[idx];

	else if (idx == pos - 1)
		newArray[idx] = x;

	else
		newArray[idx] = oldArray[idx - 1];
}

for (idx = 0; idx < n + 1; idx++)
{
	Console.Write(newArray[idx] + " ");
}

Console.Clear();

// Deleting From The End of an Array

int[] arrayDeleting = new int[10];

int item = 0;

for (int i = 0; i < 7; i++)
{
	arrayDeleting[item] = i;
	item++;
}

item--;

for (int i = 0; i < item; i++)
{
	Console.WriteLine($"Index {i} contains {arrayDeleting[i]}");
}

// Deleting From The Start of an Array

for (int i = 1; i < item; i++)
{
	// Shift each element one position to the left
	arrayDeleting[i - 1] = arrayDeleting[i];
}

item--;

for (int i = 0; i < item; i++)
{
	Console.WriteLine($"Index {i} contains {arrayDeleting[i]}");
}
Console.Clear();
// Deleting From Anywhere in the Array

// Delete the element at index 1

for (int i = 2; i < item; i++)
{
	arrayDeleting[i - 1] = arrayDeleting[i];
}

item--;

for (int i = 0; i < item; i++)
{
	Console.WriteLine($"Index {i} contains {arrayDeleting[i]}");
}