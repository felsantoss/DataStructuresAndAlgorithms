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