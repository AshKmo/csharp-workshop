class Plane : Vehicle, IDeconstructible {
	private LandingGear _gear;

	public Plane(string name, LandingGear gear) : base(name) {
		_gear = gear;
	}

	public void DeployGear() {
		_gear.Deploy();
	}

	public void Deconstruct() {
		Console.WriteLine("Deconstructing Plane...");
	}
}
