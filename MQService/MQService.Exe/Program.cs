using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQService.Exe
{
    class Program
    {
        static void Main(string[] args)
        {


            MQService mQService = new MQService();
            mQService.InsertLog(1, "1243", "LogEkledim.");

        }
    }
}
