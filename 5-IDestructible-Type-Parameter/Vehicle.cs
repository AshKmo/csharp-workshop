abstract class Vehicle {
	private string _name;
	private int _distanceTravelled;

	public Vehicle(string name) {
		_name = name;
		_distanceTravelled = 0;
	}

	public void Travel(int distance) {
		_distanceTravelled += distance;
	}
}
