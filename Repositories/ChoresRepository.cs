namespace chore_score.Repositories;

public class ChoresRepository
{

    private readonly IDbConnection _db;

    public ChoresRepository(IDbConnection db)
    {
        _db = db;
    }

    public Chore GetChoreById(int ChoreId)
    {
        string sql = "SELECT * FROM chores WHERE id = @ChoreId";
        Chore chore = _db.Query<Chore>(sql, new { ChoreId }).FirstOrDefault();
        return chore;
    }

    public List<Chore> GetChores()
    {
        string sql = "SELECT * FROM chores;";
        List<Chore> chores = _db.Query<Chore>(sql).ToList();
        return chores;
    }

    public Chore CreateChore(Chore choreData)
    {
        string sql = "INSERT INTO chores(name, description, isComplete) VALUES (@Name, @Description, @IsComplete); SELECT * FROM chores WHERE id = LAST_INSERT_ID();";
        Chore chore = _db.Query<Chore>(sql, choreData).FirstOrDefault();
        return chore;
    }

    public void DestroyChore(int ChoreId)
    {
        string sql = "DELETE FROM chores WHERE id = @ChoreId;";
        _db.Execute(sql, new { ChoreId });
    }
}