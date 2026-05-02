static class Program {
	static void Main() {
		Car myCar = new Car( "Subaru Liberty", 100_000, new Horn("BEEP!") );

		myCar.Beep();
	}
}
