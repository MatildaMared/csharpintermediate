internal class Car : Vehicle {
	public Car(string registrationNumber) : base(registrationNumber) {
		Console.WriteLine("Car is being initialized with registration number {0}", registrationNumber);
	}
}