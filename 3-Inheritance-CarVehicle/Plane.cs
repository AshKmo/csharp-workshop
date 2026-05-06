class Plane : Vehicle {
	private LandingGear _gear;

	public Plane(string name, LandingGear gear) : base(name) {
		_gear = gear;
	}

	public void DeployGear() {
		_gear.Deploy();
	}
}
