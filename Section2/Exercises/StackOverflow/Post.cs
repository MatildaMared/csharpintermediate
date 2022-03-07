namespace StackOverflow; 

public class Post {
	public string Title { get; set; }
	public string Description { get; set; }
	public DateTime CreatedAt;
	public int Votes { get; private set; }

	public Post() {
		CreatedAt = DateTime.Now;
		Votes = 0;
	}

	public void UpVote() {
		Votes += 1;
	}

	public void DownVote() {
		Votes -= 1;
	}
}