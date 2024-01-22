namespace egitimportaliBE.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }
        public decimal CoursePrice { get; set; }
        public int CourseTime { get; set;}
        public DateTime ExpDate { get; set; }
        public string ImageUrl { get; set; }
        public string DocumentUrl { get; set; }
        public int Status { get; set; }

    }
}
