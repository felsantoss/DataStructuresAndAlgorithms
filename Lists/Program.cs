// Listas são flexiveis e não tem um tamanho definido
List<string> shoppingList = new List<string>();

shoppingList.Add("Dreams");
shoppingList.Add("Miracles");
shoppingList.Add("Rainbows");
shoppingList.Add("Pony");

foreach (string item in shoppingList)
{
	Console.WriteLine(item);
}

shoppingList.Remove("Dreams");
shoppingList.RemoveAt(1);

Console.WriteLine("\nNew list after remove itens");

for (int i = 0; i < shoppingList.Count; i++)
{
	Console.WriteLine(shoppingList[i]);
}	