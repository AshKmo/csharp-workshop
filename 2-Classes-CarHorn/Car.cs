class Car {
	private string _name;
	private int _distanceDriven;
	private Horn _horn;

	public Car(string name, int distanceDriven, Horn horn) {
		_name = name;
		_distanceDriven = 0;
		_horn = horn;
	}

	public void Drive(int distance) {
		_distanceDriven += distance;
	}

	public void Beep() {
		_horn.Activate();
	}
}
