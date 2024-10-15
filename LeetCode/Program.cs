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

// 941 - Valid Mountain Array

bool ValidMountainArray(int[] arr)
{
	int i = 0;

	while (i < arr.Length && i + 1 < arr.Length && arr[i] < arr[i + 1])
		i++;
	

	if (i == 0 || i + 1 >= arr.Length)
		return false;
	

	while (i < arr.Length && i + 1 < arr.Length)
	{
		if (arr[i] <= arr[i++ + 1])
			return false;
	}

	return true;	
}

// 1299 - Replace Elements with Greatest Element on Right Side

int[] ReplaceElements(int[] arr)
{
	// Start from the end of the array
	int maxValue = -1;

	for (var i = arr.Length - 1; i >= 0; i--)
	{
		int currentValue = arr[i]; // Store the current value

		arr[i] = maxValue; // Replace the current element with the max of elements to its right

		maxValue = Math.Max(maxValue, currentValue); // Update the maxValue with the maximum between maxValue and currentValue
	}

	return arr;
}

// 26 - Remove Duplicates from Sorted Array

int RemoveDuplicate(int[] nums)
{
	int index = 1;

	for (int i = 0; i < nums.Length - 1; i++)
	{
		if (nums[i] != nums[i + 1])
		{
			nums[index++] = nums[i + 1];
		}
	}

	return index;
}

// 283 - Move Zeroes
void MoveZeroes(int[] nums)
{
	int lastZero = 0;

	for (int i = 0; i < nums.Length; i++)
	{
		if (nums[i] != 0)
		{
			int temp = nums[lastZero];

			nums[lastZero] = nums[i];

			nums[i] = temp;

			lastZero++;
		}
	}
}

// 905 - Sort Array By Parity

int[] SortArrayByParity(int[] nums)
{
	int count = 0;
	
	for (int i = 0; i < nums.Length; i++)
	{
		if (nums[i] % 2 == 0)
		{
			int temp = nums[count];

			nums[count] = nums[i];

			nums[i] = temp;

			count++;
		}
	}

	return nums;
}

// 27 - Remove Elements

int RemoveElements(int[] nums, int val)
{
	int k = 0;

	for (int i = 0; i < nums.Length; i++)
	{
		if (nums[i] != val)
		{
			nums[k] = nums[i];
			k++;
		}
	}

	return k;
}
