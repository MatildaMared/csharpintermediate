namespace Classes {
	public class Person {
		public string Name;

		public void Introduce(string toName) {
			Console.WriteLine("Hi, {0}! 👋 😄 I am {1}.", toName, Name);
		}

		public static Person Parse(string str) {
			var person = new Person();
			person.Name = str;
			return person;
		}
	}
	class Program {
		static void Main(string[] args) {
			var person = Person.Parse("Matilda");
			person.Introduce("Vincent");
		}
	}
}