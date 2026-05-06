class LandingGear {
	private string _deploySound;

	public LandingGear(string deploySound) {
		_deploySound = deploySound;
	}

	public void Deploy() {
		Console.WriteLine(_deploySound);
	}
}
