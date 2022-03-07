/*
 * Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
 * provide two methods: Start and Stop. We call the start method first, and the stop method next.
 * Then we ask the stopwatch about the duration between start and stop. Duration should be a
 * value in TimeSpan. Display the duration on the console.
 * 
 * We should also be able to use a stopwatch multiple times. So we may start and stop it and then
 * start and stop it again. Make sure the duration value each time is calculated properly.
 * We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
 * start time). So the class should throw an InvalidOperationException if its started twice. 
*/

Console.WriteLine("Hi! 🙂 This is a stopwatch.\n\nWrite 'start' to start the stopwatch, 'stop' to stop it, and 'display' to display the duration. To reset the stopwatch write 'reset'.");
Console.WriteLine("\nWrite 'exit' to exit the program.\n");

var stopwatch = new StopWatch.StopWatch();

while (true) {
 var userInput = Console.ReadLine();
 
 if (userInput == "start") {
  stopwatch.Start();
  Console.WriteLine("\nStopwatch started... Write 'stop' to stop it or 'exit' to quit the program.");
 } else if (userInput == "stop") {
  Console.WriteLine("\nStopwatch stopped... Write 'start' to start again, 'display' to display the duration or 'exit' to quit the program.");
  stopwatch.Stop();
 } else if (userInput == "display") {
  Console.WriteLine("\nDuration is: " + stopwatch.Duration);
 } else if (userInput == "reset") {
  stopwatch.Reset();
  Console.WriteLine("\nStopwatch reset... Write 'start' to start again, 'display' to display the duration or 'exit' to quit the program.");
 } else if (userInput == "exit") {
  Environment.Exit(0);
 } else {
  Console.WriteLine("\nInvalid input. Please try again.");
 }
}