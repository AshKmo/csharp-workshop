class Car : Vehicle {
	private Horn _horn;

	public Car(string name, Horn horn) : base(name) {
		_horn = horn;
	}

	public void TootHorn() {
		_horn.Activate();
	}
}
