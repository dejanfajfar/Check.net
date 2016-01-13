using NUnit.Framework;

namespace Check.net.Tests
{
	[TestFixture]
	public class CheckFixture
	{
		[Test]
		public void Foo(){
			Check.IsNot.Null ("Something");
		}
	}
}

