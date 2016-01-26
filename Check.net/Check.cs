namespace Check.net
{
	public static class Check
	{

        public static Checker<T> That<T>(T value)
        {
            return new Checker<T>(value);
        }
	}
}

