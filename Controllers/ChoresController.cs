namespace chore_score.Controllers;

[ApiController]
[Route("api/chores")]
public class ChoresController : ControllerBase
{
    private readonly ChoresService _choresService;

    public ChoresController(ChoresService choresService)
    {
        _choresService = choresService;
    }

    [HttpGet("{ChoreId}")]
    public ActionResult<Chore> GetChoreById(int ChoreId)
    {
        try
        {
            return Ok(_choresService.GetChoreById(ChoreId));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public ActionResult<List<Chore>> GetChores()
    {
        try
        {
            return Ok(_choresService.GetChores());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
    {
        try
        {
            return Ok(_choresService.CreateChore(choreData));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{ChoreId}")]
    public ActionResult<string> DestroyChore(int ChoreId)
    {
        try
        {
            return Ok(_choresService.DestroyChore(ChoreId));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}