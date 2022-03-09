public class DbCommand
{
    public DbConnection Connection { get; set; }
    public string Instruction { get; set; }
    
    public DbCommand(DbConnection connection, string instruction)
    {
        if (connection == null)
        {
            throw new ArgumentNullException("Can't pass null as an argument");
        }
        this.Connection = connection;
        
        if (instruction == null)
        {
            throw new ArgumentNullException("Can't pass null as an argument");
        }
        this.Instruction = instruction;

    }   
    
    public void Execute()
    {
        Connection.OpenConnection();
        Console.WriteLine("Running the instruction...");
        Console.WriteLine(Instruction);
        Connection.CloseConnection();
    }
}