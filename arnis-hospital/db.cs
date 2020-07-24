using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace arnis_hospital
{
    class db
    {
        public MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=hospital;Uid=root;Pwd='';");
        public MySqlCommand cmd = new MySqlCommand();
        public MySqlDataReader dr;
        public MySqlDataAdapter da;
        public DataTable dt = new DataTable();

        public bool baglanti_kontrol()
        {
            try
            {
                baglanti.Open();
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }
    }
}
