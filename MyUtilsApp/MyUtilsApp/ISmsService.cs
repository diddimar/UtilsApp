using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilsApp
{
    public interface ISmsService
    {
        void SendSMS(string phoneNumber, string text);
    }
}
