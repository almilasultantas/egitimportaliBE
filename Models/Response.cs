namespace egitimportaliBE.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public List<Users> listUsers { get; set; }
        public Users user { get; set; }
        public List<Course> listCourse { get; set; }
        public Course course { get; set; }
        public List<Cart> listCart { get; set; }   
        public List<UsersCourse> listUserCourse { get; set; }
        public UsersCourse userCours { get; set; }

    }
}
