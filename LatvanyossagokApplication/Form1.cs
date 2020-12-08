using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    public partial class LakossagNum : Form
    {
        MySqlConnection conn;
        public LakossagNum()
        {
            InitializeComponent();
            try
            {
                conn = new MySqlConnection("Server=localhost; Database=latvanyossagokdb; Uid=root; Pwd=;");
                conn.Open();

                this.FormClosed += (sender, args) =>
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                };
            }
            catch (MySqlException)
            {
                MessageBox.Show("Hiba az adatbázis kapcsolódáskor!");
                this.Close();
            }
            tablaCreate();
        }
        private void tablaCreate()
        {
            string sql = @"Create table IF NOT EXISTS varosok(
                        id int NOT NULL AUTO_INCREMENT,
                        nev varchar(52) NOT NULL UNIQUE,
                        lakossag int NOT NULL,
                        PRIMARY KEY (id)
                        );";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.ExecuteNonQuery();
            sql = @"Create table IF NOT EXISTS latvanyossagok(
                        id int NOT NULL AUTO_INCREMENT,
                        nev varchar(52) NOT NULL,
                        leiras text(152) NOT NULL,
                        ar int NOT NULL,
                        varos_id int NOT NULL,
                        PRIMARY KEY (id),
                        FOREIGN KEY (varos_id) REFERENCES varosok(id) 
                        ON DELETE CASCADE ON UPDATE RESTRICT
                        );";
            comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.ExecuteNonQuery();
        }

        private void VarosSubmit_Click(object sender, EventArgs e)
        {
            string nev = nevtb.Text;
            var comm = this.conn.CreateCommand();
            string sql = @"SELECT count(*)
                         FROM varosok
                         WHERE @nev=varosok.nev";
            comm.Parameters.AddWithValue("@nev",nev);
            comm.CommandText = sql;
            int count;
            using (var reader = comm.ExecuteReader())
            {
                count = Convert.ToInt32(reader.ToString());
            }
            if (count > 0)
            {

            }
            else
            {
                sql = @"Insert into varosok
                        Values (@nev,@lakossag)";
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@lakossag", numLakossag);
                VarosSubmit.Enabled = true;
            }
        }
    }
}
