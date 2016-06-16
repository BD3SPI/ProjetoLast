using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Classes;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MVC.Telas;

namespace MVC.Classes
{
    public static class Sessao
    {
        public static string cod { get; set; }
        public static string nome { get; set; }
        public static string email { get; set; }
        public static char tipo { get; set; }

    }
}
