using System.Web.Http;
using ProtoBufWebApi.Models;

namespace ProtoBufWebApi.Controllers
{
    [RoutePrefix("T")]
    public class TestController : ApiController
    {
        [HttpGet]
        [Route("get/{id}")]
        public ProtobufModelDto Get(int id)
        {
            return new ProtobufModelDto()
            {
                Id = 1,
                Name = "HelloWorld",
                StringValue = "My first Protobuf web api service"
            };
        }
    }
}