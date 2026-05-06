static class Program {
	public static void Main() {
		Car myCar = new Car( "Subaru Liberty", new Horn("BEEP!") );

		Plane myPlane = new Plane( "Boeing 747", new LandingGear("Buzzzzz! Click!") );

		myCar.TootHorn();

		myPlane.DeployGear();
	}
}
