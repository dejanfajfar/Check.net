using System;

namespace Check.net
{
	public class CheckException : Exception
	{
		public CheckException(string message) 
			: base(message){
			
		}
	}

}

