public class Workflow
{
    private List<Activity> _activity;

    public Workflow()
    {
        _activity = new List<Activity>();
    }
    
    public void AddActivity(Activity activity)
    {
        _activity.Add(activity);
    }
    
    public IEnumerable<Activity> GetActivities()
    {
        return _activity;
    }
}