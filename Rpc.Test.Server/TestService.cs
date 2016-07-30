using Rpc.Attributes;
using Rpc.Test.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpc.Test.Server
{
    [Service("TestService")]
    public interface ITestService
    {
        [Action("Hello")]
        string Hello(string input);

        [Action("Login")]
        SimpleResponse Login(User user);
    }

    public class TestService : ITestService
    {
        public string Hello(string input)
        {
            return "Hello, " + input;
        }

        public SimpleResponse Login(User user)
        {
            var response = new SimpleResponse();

            if(null != user &&
                user.Name == "alex" &&
                user.Pwd == "sjtu")
            {
                response.IsSuccess = true;
            }
            else
            {
                response.IsSuccess = false;
                response.ErrorDesc = "用户名或密码错误";
            }

            return response;
        }
    }
}
