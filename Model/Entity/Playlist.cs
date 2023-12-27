namespace ElectricSheep.Model.Entity
{
    public class Playlist
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Guid creator { get; set; }
        public int songCount { get; set; }
        public string totalDuration { get; set; }
        public List<string> Songs { get; set; }
        public Byte[] CoverImage { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updatedDate { get; set; }
        public Playlist(string nombre, string descripcion, Guid creador) 
        {
            id = Guid.NewGuid();
            name = nombre;
            description = descripcion;
            creator = creador;
            songCount = 0;
            totalDuration = "00:00";
            Songs = new List<string>();
            CoverImage = new Byte[0];
            createdDate = DateTime.Now;
            updatedDate = DateTime.Now;
        }
    }
}
