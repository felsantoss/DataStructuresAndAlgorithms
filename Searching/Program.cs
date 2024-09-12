// Linear search algorithm

string[] fruits = { "Orange", "Apple", "Banana" };
string target = "Apple";
int index = -1;

for (int i = 0; i < fruits.Length; i++)
{
	if (fruits[i] == target)
	{
		index = i;
		break;
	}
}

if (index != 0)
{
	Console.WriteLine($"Element found at index: {index}");
}
else
{
	Console.WriteLine("Element not found.");
}

// Declare a new array of 6 elements
int[] array = new int[6];

// Variable to keep track of the length of the array
int length = 0;

// Iterate through the 6 indexes of the array
for (int i = 0; i < 6; i++)
{
	// Add a new element and increment the length as well
	array[length++] = i;
}

Console.WriteLine("Does the array contain the element 4? - " + LinearSearch(array, length, 4));

Console.WriteLine("Does the array contain the element 30? - " + LinearSearch(array, length, 30));

bool LinearSearch(int[] array, int length, int element)
{
	if (array == null || length == 0)
		return false;

	// Carry out the linear search by checing each element
	// Starting from the first one
	for (int i = 0; i < length; i++)
	{
		// We found the element at index i
		// So we return true to say it exists.
		if (array[i] == element)
		{
			return true;
		}
	}
	return false;
}

// Applying conditional statements and loops for filtering
List<string> filteredFtruits = new List<string>();

for (int i = 0; i < fruits.Length; i++)
{
	if (fruits[i].Length > 5)
	{
		filteredFtruits.Add(fruits[i]);
	}
}

foreach (var fruit in filteredFtruits)
{
	Console.WriteLine(fruit);
}