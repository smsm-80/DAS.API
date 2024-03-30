using DAS.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAS.Application.Helpers.Model
{
    public class RequestModel<T>
    {
        public T? Model { get; set; }
        public UserInfo? UserInfo { get; set; }
    }
}
