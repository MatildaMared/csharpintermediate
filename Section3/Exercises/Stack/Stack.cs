class Stack {
	public List<object> storedStack;
	
	public Stack() {
		storedStack = new List<object>();
	}
	
	public void Push(object item) {
		if (item == null) {
			throw new InvalidOperationException("Cannot push null onto stack");
		}
		storedStack.Add(item);
	}

	public object Pop() {
		if (storedStack.Count == 0) {
			throw new InvalidOperationException("Cannot pop from empty stack");
		}
		object item = storedStack[storedStack.Count - 1];
		storedStack.RemoveAt(storedStack.Count - 1);
		return item;
	}

	public void Clear() {
		storedStack.Clear();
	}
}