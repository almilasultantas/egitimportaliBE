using egitimportaliBE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace egitimportaliBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public UsersController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("registration")]
        public Response register(Users users)
        {
            Response response = new Response();
            DAL dal = new DAL();
            SqlConnection connection= new SqlConnection(_configuration.GetConnectionString("EPCon").ToString());
            response = dal.register(users, connection);
            return response;
        }

        [HttpPost]
        [Route("login")]
        public Response login (Users users)
        {
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EPCon").ToString());
            Response response = dal.Login(users, connection);
            return response;
        }

        [HttpPost]
        [Route("viewUser")]
        public Response viewUser(Users users)
        {
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EPCon").ToString());
            Response response = dal.viewUser(users,connection);
            return response;
        }

        [HttpPost]
        [Route("updateProfile")]
        public Response updateProfile(Users users)
        {
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EPCon").ToString());
            Response response = dal.updateProfile(users,connection);
            return response;
        }

        [HttpGet]
        [Route("getUsers")]
        public JsonResult GetUsers()
        {
            string query = "select * from Users";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EPCon");
            SqlDataReader myReader;
            using (SqlConnection connection = new SqlConnection(sqlDataSource))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    myReader = cmd.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    connection.Close();
                }
            }
            return new JsonResult(table);
        }
    }
}
