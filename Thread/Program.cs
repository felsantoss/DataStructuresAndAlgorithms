Thread thread = new Thread(NewThread);
thread.Start();

for (int i = 0; i < 5; i++)
{
	Console.WriteLine("Main Thread: " + i);
	Thread.Sleep(1000);
}

static void NewThread()
{
	for (int i = 0; i < 5; i++)
	{
		Console.WriteLine("New Thread: " + i);
		Thread.Sleep(1000);
	}
}