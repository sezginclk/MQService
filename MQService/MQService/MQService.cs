using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQService
{

    public class MQService
    {

        internal string _queue;

        public Dictionary<int, string> projectsInfo = new Dictionary<int, string>();

        public void InsertLog(int ProjectCode, string ProjectPassword, string LogInfo)
        {
            projectsInfo.Add(1, "123");
            projectsInfo.Add(2, "123");

            foreach (var item in projectsInfo)
            {
                if (item.Key == ProjectCode && item.Value == ProjectPassword)
                {
                    _queue = LogInfo;
                    Publisher publisher = new Publisher($"{ProjectCode}" + " " + "LogInfo", _queue);
                    MessageBox.Show("Başarı ile Eklendi..");
                    break;
                }
                MessageBox.Show("Project Kodunuz veya Project Şifreniz Hatalı..");
                break;
            }
            
            projectsInfo.Clear();

        }
    }
}
