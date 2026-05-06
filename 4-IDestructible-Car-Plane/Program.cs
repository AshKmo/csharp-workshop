static class Program {
	public static void Main() {
		IDeconstructible selectedObject = new Car( "Subaru Liberty", new Horn("BEEP!") );

		selectedObject.Deconstruct();

		selectedObject = new Plane( "Boeing 747", new LandingGear("Buzzzzz! Click!") );

		selectedObject.Deconstruct();
	}
}
