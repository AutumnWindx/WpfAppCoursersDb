using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Helper
    {
        public static WineProjectContext db = new WineProjectContext();
        public static User userSession;
        public static Task task;
        public static User search;
    }
}
