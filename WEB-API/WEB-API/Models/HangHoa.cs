namespace WEB_API.Models
{
    public class HangHoaVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string Description { get; set; }
    }

    public class HangHoa : HangHoaVM
    {
        
        public Guid MaHangHoa { get; set; }
    }


}
