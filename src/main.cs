namespace Calculator.src
{

    internal static class main
    {

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new calculator());
        }
    }
}