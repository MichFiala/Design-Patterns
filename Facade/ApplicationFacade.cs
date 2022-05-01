namespace Facade
{
	public class ApplicationFacade
	{
		private readonly Calculation _calculation;
		private readonly Initialization _initialization;
		public ApplicationFacade(Calculation calculation, Initialization initialization)
		{
			_initialization = initialization;
			_calculation = calculation;
		}

		public void Operate()
		{
			Console.WriteLine("Started");

			_initialization.Init();
			_calculation.Calculate();

			Console.WriteLine("Finished");  
		}
	}
}