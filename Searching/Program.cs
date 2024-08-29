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