class Car : Vehicle, IDeconstructible<CarPart> {
	private Horn _horn;

	public Car(string name, Horn horn) : base(name) {
		_horn = horn;
	}

	public void TootHorn() {
		_horn.Activate();
	}

	public List<CarPart> Deconstruct() {
		Console.WriteLine("Deconstructing Car...");

		return new List<CarPart> {
			new Wheel(),
			new Wheel(),
			new Wheel(),
			new Wheel(),

			new Radio()
		};
	}
}
