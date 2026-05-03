static class Program {
	public static void Main() {
		Car myCar = new Car( "Subaru Liberty", new Horn("BEEP!") );

		myCar.Beep();
	}
}
