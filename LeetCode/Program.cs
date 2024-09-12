// 1346 - Check if N and Its Double Exists

bool CheckIfExist(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		for (int j = i + 1; j < arr.Length; j++)
		{
			if (arr[i] == 2 * arr[j] || arr[j] == 2 * arr[i])
			{
				return true;
			}
		}
	}
	return false;
}