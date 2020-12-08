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
            adatbetoltes();
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
        private void adatbetoltes()
        {
            string sql = @"SELECT `id`, `nev`, `lakossag` 
                           FROM `varosok`";
            var comm = conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader.GetString(0));
                    string nev = reader.GetString(1);
                    int lakossag = Convert.ToInt32(reader.GetString(2));
                    Varosok v = new Varosok(id, nev, lakossag);
                    VarosokListBox.Items.Add(v);
                }
            }
            sql = @"SELECT * 
                    FROM latvanyossagok";
            comm = conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader.GetString(0));
                    string nev = reader.GetString(1);
                    string leiras =reader.GetString(2);
                    int ar = Convert.ToInt32(reader.GetString(3));
                    int varos_id = Convert.ToInt32(reader.GetString(4));
                    Latvanyossag lv = new Latvanyossag(id, nev, leiras,ar,varos_id);
                    LatvanyossagList.Items.Add(lv);
                }
            }
        }

        private void VarosSubmit_Click(object sender, EventArgs e)
        {
            string nev = nevtb.Text;
            var comm = this.conn.CreateCommand();
            string sql = @"SELECT count(id) as db
                         FROM varosok
                         WHERE @nev=nev";
            comm.Parameters.AddWithValue("@nev", nev);
            comm.CommandText = sql;
            int count = 0;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    count = reader.GetInt32("db");
                }

            }
            if (count > 0)
            {
                MessageBox.Show("A név már létezik");
                VarosokListBox.SelectedIndex = -1;
            }
            else
            {
                sql = @"Insert into varosok(nev,lakossag)
                        Values (@nev,@lakossag)";
                comm.CommandText = sql;

                comm.Parameters.AddWithValue("@lakossag", numLakossag.Value);
                comm.ExecuteNonQuery();
                sql = @"SELECT id
                        FROM varosok
                        WHERE nev=@nev";
                comm.CommandText = sql;
                int id=0;
                using (var reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader.GetString(0));
                    }

                }
                VarosokListBox.Items.Add(new Varosok(id,nev,Convert.ToInt32(numLakossag.Value)));
            }
           
            
        }

        private void varosTorles()
        {
            Varosok v = (Varosok)VarosokListBox.SelectedItem;
            if (VarosokListBox.SelectedIndex>-1)
            {
                List<Latvanyossag> lv = new List<Latvanyossag>();
                foreach (var item in LatvanyossagList.Items)
                {
                    lv.Add((Latvanyossag)item);
                }
                int db = 0;
                foreach (var item in lv)
                {
                    if (item.Varos_id == v.Id)
                    {
                        db++;
                    }
                }
                if (db==0)
                {
                    string sql = @"DELETE FROM varosok 
                                       WHERE id=@id";
                    var comm = conn.CreateCommand();
                    comm.CommandText = sql;
                    comm.Parameters.AddWithValue("@id", v.Id);
                    comm.ExecuteNonQuery();
                    VarosokListBox.Items.RemoveAt(VarosokListBox.SelectedIndex);
                    VarosokListBox.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Nem törölhető mert tartozik hozzá látványosság");
                }
            }
        }

        private void latvTorles()
        {
            Latvanyossag lv = (Latvanyossag)LatvanyossagList.SelectedItem;
            if (LatvanyossagList.SelectedIndex>-1)
            {
                string sql = @"DELETE FROM latvanyossagok 
                                       WHERE id=@id";
                var comm = conn.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@id", lv.Id);
                comm.ExecuteNonQuery();
                LatvanyossagList.Items.RemoveAt(LatvanyossagList.SelectedIndex);
                LatvanyossagList.SelectedIndex = -1;
            }
        }

        private void LatvanyossagSubmit_Click(object sender, EventArgs e)
        {
            string nev = LatNevText.Text;
            string leiras = LeirasText.Text;
            int ar = Convert.ToInt32(numAr.Value);
            Varosok v = (Varosok)VarosokListBox.SelectedItem;
            if (nev == "" && leiras == "" && VarosokListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Hiányzó adat");
            }
            else
            {
                string sql = @"INSERT INTO latvanyossagok(nev,leiras,ar,varos_id)
                               VALUES (@nev,@leiras,@ar,@varos_id)";
                var comm = conn.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@nev", nev);
                comm.Parameters.AddWithValue("@leiras", leiras);
                comm.Parameters.AddWithValue("@ar", ar);
                comm.Parameters.AddWithValue("@varos_id", v.Id);
                comm.ExecuteNonQuery();
                sql = @"SELECT id
                        FROM latvanyossagok
                        WHERE nev=@nev";
                comm.CommandText = sql;
                int id = 0;
                using (var reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader.GetString(0));
                    }

                }
                Latvanyossag lv = new Latvanyossag(id, nev, leiras, ar, v.Id);
                LatvanyossagList.Items.Add(lv);
            }
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            if (VarosokListBox.SelectedIndex>-1||LatvanyossagList.SelectedIndex>-1)
            {
                varosTorles();
                latvTorles();
            }
            else
            {
                MessageBox.Show("Nincs kijelölve semmi");
            }
            
        }

        private void VarosokListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Varosok v = (Varosok)VarosokListBox.SelectedItem;
            btnModositV.Visible = true;
            nevtb.Text = v.Nev;
            numLakossag.Value = v.Lakossag;
        }

        
        private void btnModositV_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModositL_Click(object sender, EventArgs e)
        {
            string nev = LatNevText.Text;
            string leiras = LeirasText.Text;
            int ar = Convert.ToInt32(numAr.Value);
            Varosok v = (Varosok)VarosokListBox.SelectedItem;
            var comm = this.conn.CreateCommand();
            comm.Parameters.AddWithValue("@nev", nev);
            string sql = "";
            
            sql = @"SELECT id
                        FROM latvanyossagok
                        WHERE nev=@nev";
            comm.CommandText = sql;
            int id = 0;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader.GetString(0));
                }

            }
            sql = @"UPDATE latvanyossagok 
                    SET nev=@nev,leiras=@leiras,ar=@ar,varos_id=@varosid
                    WHERE id=@id";
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@id", id);
           
            comm.Parameters.AddWithValue("@leiras", leiras);
            comm.Parameters.AddWithValue("@ar", ar);
            comm.Parameters.AddWithValue("@varosid", v.Id);
            comm.ExecuteNonQuery();
            LatvanyossagList.Items.RemoveAt(LatvanyossagList.SelectedIndex);
            LatvanyossagList.Items.Add(new Latvanyossag(id, nev, leiras, ar, v.Id));
            LatvanyossagList.SelectedIndex = -1;
            
        }

        private void LatvanyossagList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LatvanyossagList.SelectedIndex>-1)
            {
                Latvanyossag lv = (Latvanyossag)LatvanyossagList.SelectedItem;
                btnModositL.Visible = true;
                LatNevText.Text = lv.Nev;
                LeirasText.Text = lv.Leiras;
                numAr.Value = lv.Ar;
                VarosokListBox.SelectedIndex = 0;
            }
        }  
    }
}
