namespace StopWatch; 

public class StopWatch {
	private bool _isRunning;
	private DateTime _startTime;
	private DateTime _stopTime;
	public TimeSpan Duration { get; set; }

	public StopWatch() {
		_isRunning = false;
	}
	
	public void Start() {
		if (_isRunning) {
			throw new InvalidOperationException("Stopwatch is already running");
		}
		_isRunning = true;
		_startTime = DateTime.Now;
	}

	public void Stop() {
		if (!_isRunning) {
			throw new InvalidOperationException(("Stopwatch is not running"));
		}
		
		_isRunning = false;
		_stopTime = DateTime.Now;

		Duration = _stopTime - _startTime;
	}

	public void Reset() {
		_isRunning = false;
		_startTime = DateTime.MinValue;
		_stopTime = DateTime.MinValue;
		Duration = TimeSpan.Zero;
	}
}