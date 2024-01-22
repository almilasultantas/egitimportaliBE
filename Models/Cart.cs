namespace egitimportaliBE.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int CourseID { get; set; }
        public decimal CoursePrice { get; set; }
        public int CourseTime { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
