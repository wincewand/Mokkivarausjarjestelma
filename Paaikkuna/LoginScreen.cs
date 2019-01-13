using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Paaikkuna
{
    public partial class LoginScreen : Form
    {
        //Luodaan turvaluokitus muuttuja, joka siirretään frmPaaikkunaan
        private static int tluokitus;
        public static int tuluokitus
        {
            //Tehdään getteri, jolla kutsutaan muuttujaa frmPaaikkunassa
            get
            {
                return tluokitus;
            }
        }
        public LoginScreen()
        {
            InitializeComponent();
   
        }

      private void btnLogin_Click(object sender, EventArgs e)
        {
            // tehdään yhteys login databaseen joka on paikallinen, joutuu varmaan muuttamaan tuota osotetta vielä
            MySqlConnection connection = new MySqlConnection("server=159.89.214.80;database=villagep;uid=villageuser;password=opGUFWUtBOmB7w5k");
            connection.Open();
            // Tehdään kysely tietokantaan, jossa haetaan Usename ja Password
            string strQuery = "Select * from Login where Username='" + txbxUsername.Text + "' and Password='" + txbxPassword.Text + "'";
            // Tehdään kyselykomento tietokantaan
            MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(strQuery, connection);
            // Ajetaan kyselykomento tietokantaan
            MySql.Data.MySqlClient.MySqlDataAdapter MyAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(myCommand);
            // Tehdään tyhja taulu
            DataTable dt = new DataTable();
            // syötetään haetut tiedot tyhjään tauluun
            MyAdapter.Fill(dt);
            // Tarkistetaan onko tiedot oikein taulussa
            if (dt.Rows.Count == 1)
            {
                //Käännetään login taulun tID luku int32 muotoon ja syötetään se turvaluokitusmuuttujaan
                tluokitus = Convert.ToInt32(dt.Rows[0][2]);
                this.Hide();
                frmPaaikkuna pi = new frmPaaikkuna();
                pi.Show();

            }
            else
            {
                MessageBox.Show("Tarkista kirjautumistunnukset");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
