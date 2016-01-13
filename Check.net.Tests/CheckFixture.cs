using NUnit.Framework;

namespace Check.net.Tests
{
	[TestFixture]
	public class CheckFixture
	{
		[Test]
		public void Given_NonNullValue_And_CheckThatNotNull_Pass(){
			Check.IsNot.Null ("Something");
		}
	}
}

