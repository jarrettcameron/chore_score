using Microsoft.AspNetCore.Http.HttpResults;

namespace chore_score.Services;

public class ChoresService
{
    private readonly ChoresRepository _repository;

    public ChoresService(ChoresRepository repository)
    {
        _repository = repository;
    }

    public Chore GetChoreById(int ChoreId)
    {
        Chore chore = _repository.GetChoreById(ChoreId);
        if (chore == null)
        {
            throw new Exception($"Invalid ChoreId: {ChoreId}.");
        }

        return chore;
    }

    public List<Chore> GetChores()
    {
        return _repository.GetChores();
    }

    public Chore CreateChore(Chore choreData)
    {
        return _repository.CreateChore(choreData);
    }

    public string DestroyChore(int ChoreId)
    {
        if (GetChoreById(ChoreId) != null)
        {
            _repository.DestroyChore(ChoreId);
            return "Deleted chore.";
        }
        return "Invalid chore.";
    }
}