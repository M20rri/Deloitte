using Deloitte.Repository;

namespace Deloitte.Service
{
	public class TestService : ITestRepository
	{
		public string PrintMessage()
		{
			return "Test Service";
		}
	}
}