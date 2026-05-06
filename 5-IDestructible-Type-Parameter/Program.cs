static class Program {
	public static void Main() {
		IDeconstructible<PlanePart> selectedObject = new Plane( "Boeing 747", new LandingGear("Buzzzzz! Click!") );

		List<PlanePart> planeParts = selectedObject.Deconstruct();

		foreach (PlanePart part in planeParts) {
			Console.WriteLine(part);
		}
	}
}
