var stack = new Stack();

stack.Push("Hello");
stack.Push("World");
stack.Push(321);

Console.WriteLine("Number of items in stack: " + stack.storedStack.Count);
Console.WriteLine(stack.storedStack[0]);
Console.WriteLine(stack.storedStack[1]);
Console.WriteLine(stack.storedStack[2]);

stack.Pop();
stack.Pop();

Console.WriteLine(stack.storedStack[0]);
Console.WriteLine("Number of items in stack: " + stack.storedStack.Count);

stack.Pop();
stack.Pop();