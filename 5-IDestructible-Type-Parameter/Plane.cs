class Plane : Vehicle, IDeconstructible<PlanePart> {
	private LandingGear _gear;

	public Plane(string name, LandingGear gear) : base(name) {
		_gear = gear;
	}

	public void DeployGear() {
		_gear.Deploy();
	}

	public List<PlanePart> Deconstruct() {
		Console.WriteLine("Deconstructing Plane...");

		return new List<PlanePart> {
			new Wheel(),
			new Wheel(),
			new Wheel(),
			new Wheel(),

			new Wing(),
			new Wing(),

			new Radio()
		};
	}
}
