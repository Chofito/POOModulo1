namespace POOTarea1.Models
{
    public class Book : Publication
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public bool Readed { get; set; }
        public int TimeReaded { get; set; }
    }
}