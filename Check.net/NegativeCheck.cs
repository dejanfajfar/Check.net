using System;

namespace Check.net
{
	public class NegativeCheck
	{
		internal NegativeCheck ()
		{
		}

		public void Null<T>(T value, string message = "The given value is not null"){
			if(value == null){
				throw new CheckException (message);
			}
		}
	}
}

