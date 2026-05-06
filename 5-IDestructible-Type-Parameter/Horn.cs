class Horn {
	private string _hornSound;

	public Horn(string hornSound) {
		_hornSound = hornSound;
	}

	public void Activate() {
		Console.WriteLine(_hornSound);
	}
}
