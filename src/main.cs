namespace Calculator.src
{

	internal static class main
	{
		/*  Main - Inicialize and run the program. */
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			Application.Run(new calculator());
		}
	}
}