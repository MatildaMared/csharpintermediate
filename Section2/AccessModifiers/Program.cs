﻿namespace AccessModifiers {
	class Program {
		static void Main(string[] args) {
			var person = new Person();
			person.SetBirthdate(new DateTime(1990, 7, 7));
			Console.WriteLine(person.GetBirthdate());
		}
	}

	public class Person {
		private DateTime _birthdate;

		public void SetBirthdate(DateTime birthdate) {
			_birthdate = birthdate;
		}

		public DateTime GetBirthdate() {
			return _birthdate;
		}
	}
}