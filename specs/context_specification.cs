using System;
using NUnit.Framework;

namespace blazey.configuration.management.specs
{
	[TestFixture]
	public abstract class context_specification
	{
		[SetUp]
		public void Setup()
		{
			Given();
            When();
		}

		public abstract void Given();

		public abstract void When();  
    
	}


}

