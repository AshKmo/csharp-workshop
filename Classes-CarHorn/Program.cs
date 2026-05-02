class Car {
	private string _name;
	private int _distanceDriven = 0;
	private Horn _horn;

	public Car(string name, int distanceDriven, Horn horn) {
		_name = name;
		_horn = horn;
	}

	public void Drive(int distance) {
		_distanceDriven += distance;
	}

	public void Beep() {
		_horn.Activate();
	}
}

class Horn {
	private string _hornSound;

	public Horn(string hornSound) {
		_hornSound = hornSound;
	}

	public void Activate() {
		Console.WriteLine(_hornSound);
	}
}

static class Program {
	static void Main() {
		Car myCar = new Car( "Subaru Liberty", 100_000, new Horn("BEEP!") );

		myCar.Beep();
	}
}
