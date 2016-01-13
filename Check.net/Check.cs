namespace Check.net
{
	public static class Check
	{
		public static NegativeCheck IsNot {
			get {
				return new NegativeCheck();
			}
		}
	}
}

