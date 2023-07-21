using Microsoft.AspNetCore.Mvc;
using SQLRelations.Data;

namespace SQLRelations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly DataContext _datacontext;

        public CharacterController(DataContext dataContext)
        {
            _datacontext = dataContext;
        }


        //[HttpGet]
        //public List<Character> Get(int userId)
        //{
        //    var characters = _datacontext.Characters.Where(c => c.UserId == userId).ToList();
        //    return characters;
        //}

        //[HttpPost]
        //public async Task<ActionResult<List<Character>>> Create(CreateCharacterDTO request)
        //{
        //    var users = await _datacontext.Users.FindAsync(request.UserId);

        //    var newCharacter = new Character { Name = request.Name, RpgClass = request.RpgClass, UserId = users };

        //    _datacontext.Characters.Add(newCharacter);
        //    await _datacontext.SaveChangesAsync();

        //    return await Get(newCharacter.UserId);
        //}
    }
}
