using System.Dynamic;

namespace blazey.configuration.management
{

	public class Configuration
	{
		private readonly dynamic _table = new ExpandoObject();

		public Configuration ()
		{
			
		}


	}

}

