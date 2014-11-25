using NUnit.Framework;
using System;

namespace blazey.configuration.management.specs
{
	public class when_configuration_is_built : context_specification
	{

		Exception _exception;

		public override void Given ()
		{

		}

		public override void When()
		{
			_exception = Catch.Exception (() => new Configuration ());
		}

		[Test]
		public void should_not_throw(){
			Assert.That(_exception, Is.Null);
		}

	}
}

