namespace Indexers {
	class Program {
		static void Main(string[] args) {
			var cookie = new HttpCookie();
			cookie["name"] = "Matilda";
			Console.WriteLine(cookie["name"]);
		}
	}
}