using ElectricSheep.Model.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ElectricSheep.Controllers
{
    public class PlaylistController : Controller
    {
        //here we must inject our service
        //also a logger is needed
        [Route("[controller]/MyPlaylists")]
        [HttpPost]
        public Playlist NewPlaylist([FromBody] Guid userID)
        {
            return new Playlist("DemoPlaylist", "some descriptive Text", userID);
        }
        [HttpPost]
        public List<Playlist> GetPlaylists([FromBody] Guid userID)
        {
            return new List<Playlist>();
        }
    }
}
