namespace Properties {
	class Program {
		public static void Main(string[] args) {
			var person = new Person(new DateTime(1990, 07, 07));
			Console.WriteLine(person.Age);
		}
	}
}