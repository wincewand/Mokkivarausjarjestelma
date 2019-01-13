using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Paaikkuna
{
    public partial class frmPaaikkuna : Form
    {
        int nRowIndex;
        int valitturivi;  // Datagridin käyttöön
        int laskutushistorianvalitturivi = 0;
        bool lisataanUusi = false;
        private int turvaluokitus;
        string valittuAsiakas;
        int nakyvasumma;
        int valittuAsiakasNro;
        int varausid;
        int asiakasid;
        int laskuttamattomatRivimaara;

        public frmPaaikkuna()
        {
            InitializeComponent();
            //Alustetaan käyttäjä comboboxi
            Fillcboxkayttajat();
            //Haetaan käyttäjän turvaluokitus
            turvaluokitus = LoginScreen.tuluokitus;
            rbtnKayttaja.Checked = true;
            //Tarkastetaan mikä turvaluokitus on käytössä ja aktivoidaan välilehtiä sen mukaan
            if (turvaluokitus == 1)
            {
                tabPage3.Enabled = false;
                tabControl1.TabPages.Remove(tabPage3);

                tabPage4.Enabled = false;
                tabControl1.TabPages.Remove(tabPage4);

                tabPage5.Enabled = false;
                tabControl1.TabPages.Remove(tabPage5);

                tabPage7.Enabled = false;
                tabControl1.TabPages.Remove(tabPage7);
            }
            else if (turvaluokitus == 2)
            {
                tabPage7.Enabled = false;
                tabControl1.TabPages.Remove(tabPage7);
            }
            else
            {

            }
            Asiakashallinta asiakashallinta = new Asiakashallinta();

            // Estetään sorttausmahdollisuus datagridviewissä.
            foreach (DataGridViewColumn column in asiakasDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn column in toimipisteDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn column in palveluDataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn column in laskuttamattomatDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn column in laskunOstotDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn column in laskutushistoriaDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Varauksenkirjaukseen kalenterin alkuarvot. Eilistä ei voi varata, eikä päättymispäivä voi olla sama ei edellinen sisäänkirjaukseen verrattuna.
            dtpAloitusVaraus.MinDate = DateTime.Today;
            dtpLopetusVaraus.MinDate = dtpAloitusVaraus.Value.AddDays(1);


        }

        private void frmPaaikkuna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villagepDataSet.Asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.villagepDataSet.Asiakas);
        }

        private void frmPaaikkuna_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villagepDataSet.LaskunTiedot2' table. You can move, or remove it, as needed.
            this.laskunTiedot2TableAdapter.Fill(this.villagepDataSet.LaskunTiedot2);
            // TODO: This line of code loads data into the 'villagepDataSet.LaskunTiedot' table. You can move, or remove it, as needed.
            this.laskunTiedotTableAdapter.Fill(this.villagepDataSet.LaskunTiedot);
            // TODO: This line of code loads data into the 'villagepDataSet.LaskunTiedot' table. You can move, or remove it, as needed.
            this.laskunTiedotTableAdapter.Fill(this.villagepDataSet.LaskunTiedot);
            // TODO: This line of code loads data into the 'villagepDataSet.Palveluhistoria2' table. You can move, or remove it, as needed.
            this.palveluhistoria2TableAdapter.Fill(this.villagepDataSet.Palveluhistoria2);
            // TODO: This line of code loads data into the 'villagepDataSet.LaskunLoppusumma' table. You can move, or remove it, as needed.
            this.laskunLoppusummaTableAdapter.Fill(this.villagepDataSet.LaskunLoppusumma);
            // TODO: This line of code loads data into the 'villagepDataSet.LaskunOstot' table. You can move, or remove it, as needed.
            this.laskunOstotTableAdapter.Fill(this.villagepDataSet.LaskunOstot);
            // TODO: This line of code loads data into the 'villagepDataSet.Toimipistenimet' table. You can move, or remove it, as needed.
            this.toimipistenimetTableAdapter.Fill(this.villagepDataSet.Toimipistenimet);
            // TODO: This line of code loads data into the 'villagepDataSet.Varauksen_palvelut' table. You can move, or remove it, as needed.
            this.varauksen_palvelutTableAdapter.Fill(this.villagepDataSet.Varauksen_palvelut);
            // TODO: This line of code loads data into the 'villagepDataSet.Varaus' table. You can move, or remove it, as needed.
            this.varausTableAdapter.Fill(this.villagepDataSet.Varaus);
            // TODO: This line of code loads data into the 'villagepDataSet.Asiakastiedot' table. You can move, or remove it, as needed.
            this.asiakastiedotTableAdapter.Fill(this.villagepDataSet.Asiakastiedot);
            // TODO: This line of code loads data into the 'villagepDataSet.Ostoskori' table. You can move, or remove it, as needed.
            this.ostoskoriTableAdapter.Fill(this.villagepDataSet.Ostoskori);
            // TODO: This line of code loads data into the 'villagepDataSet.Laskutushistoria' table. You can move, or remove it, as needed.
            this.laskutushistoriaTableAdapter.Fill(this.villagepDataSet.Laskutushistoria);
            // TODO: This line of code loads data into the 'villagepDataSet.Lasku' table. You can move, or remove it, as needed.
            this.laskuTableAdapter.Fill(this.villagepDataSet.Lasku);
            // TODO: This line of code loads data into the 'villagepDataSet.Laskuttamattomat' table. You can move, or remove it, as needed.
            this.laskuttamattomatTableAdapter.Fill(this.villagepDataSet.Laskuttamattomat);
            // TODO: This line of code loads data into the 'villagepDataSet.Toimipiste' table. You can move, or remove it, as needed.
            this.toimipisteTableAdapter.Fill(this.villagepDataSet.Toimipiste);
            // TODO: This line of code loads data into the 'villagepDataSet.Palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.villagepDataSet.Palvelu);
            // TODO: This line of code loads data into the 'villagepDataSet.Asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.villagepDataSet.Asiakas);
            // tehdään yhteys login databaseen joka on paikallinen, joutuu varmaan muuttamaan tuota osotetta vielä
            MySqlConnection connection = new MySqlConnection("server=159.89.214.80;database=villagep;uid=villageuser;password=opGUFWUtBOmB7w5k");
            connection.Open();
            MySqlCommand sc = new MySqlCommand("SELECT toimipiste_id, nimi FROM Toimipiste", connection);
            MySqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("toimipiste_id", typeof(string));
            dt.Columns.Add("nimi", typeof(string));
            dt.Load(reader);

            cbToimipisteVaraus.ValueMember = "toimipiste_id";
            cbToimipisteVaraus.DisplayMember = "nimi";
            cbToimipisteVaraus.DataSource = dt;

            MySqlCommand sc2 = new MySqlCommand("SELECT palvelu_id, nimi FROM Palvelu", connection);
            MySqlDataReader reader2;

            reader2 = sc2.ExecuteReader();
            DataTable dt2 = new DataTable();

            dt2.Columns.Add("palvelu_id", typeof(string));
            dt2.Columns.Add("nimi", typeof(string));
            dt2.Load(reader2);

            cbPalveluVaraus.ValueMember = "palvelu_id";
            cbPalveluVaraus.DisplayMember = "nimi";
            cbPalveluVaraus.DataSource = dt2;

            connection.Close();

        }

        private void frmPaaikkuna_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Lopetetaan prosessi asiallisesti ohjelman lopuksi. Muuten prosessi jää roikkumaan ja se pitää tappaa task managerilla.
            System.Windows.Forms.Application.Exit();
        }

        private void btnHaeLaskutushistoria_Click(object sender, EventArgs e)
        {
            laskutushistoriaDataGridView.DataSource = laskutushistoriaTableAdapter.GetDataByLaskutushistoria(laskutusKalenteriAlku.SelectionRange.Start, laskutusKalenteriLoppu.SelectionRange.Start);
        }

        private void txbHaeAsiakas_TextChanged_1(object sender, EventArgs e)
        {
            // Asiakashallinta
            // Haetaan asiakasDataGridViewiin asiakkaita nimen, emailin tai puhelinnumeron perusteella. Datagridiä päivitetään aina, kun txbHaeAsiakas-kenttään kirjoitetaan.
            asiakasDataGridView.DataSource = asiakasTableAdapter.GetDataByHaku("%" + txbHaeAsiakas.Text + "%");
            if (txbHaeAsiakas.Text == "")
            {
                // Jos hakukenttä pyyhitään tyhjäksi.
            }
        }


        private void asiakasDataGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            valitturivi = asiakasDataGridView.CurrentCell.RowIndex;
            PaivitaAsiakasKentat(valitturivi);
        }

        private void toimipisteDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kun palveluhallinan datagridin valinta muuttuu, päivitetään textboxien sisällöt vastaaviksi.
            valitturivi = toimipisteDataGridView.CurrentCell.RowIndex;
            PaivitaToimipisteKentat(valitturivi);
        }


        private void btnPoistaToimipiste_Click(object sender, EventArgs e)
        // Poistetaan valittu toimipiste.
        {
            try
            {
                string nimi = toimipisteDataGridView.Rows[valitturivi].Cells[1].Value.ToString();
                if (MessageBox.Show("Haluatko poistaa toimipisteen " + nimi + "?", "Poisto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = int.Parse(toimipisteDataGridView.Rows[valitturivi].Cells[0].Value.ToString());
                    toimipisteTableAdapter.DeleteQuery(id);
                    toimipisteDataGridView.DataSource = toimipisteTableAdapter.GetData();
                    MessageBox.Show("Toimipiste " + nimi + " on poistettu onnistuneesti.", "Poisto onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbHaeToimipiste.Clear();
                    txbHaeToimipiste.Select();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Virhe toimipisteen poistossa", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLisaaToimipiste_Click(object sender, EventArgs e)
        {
            lisataanUusi = true;
            ToimipisteClear();
            ToimipisteNapitOff();
            txbToimipisteNimi.Select();
        }


        private void ToimipisteClear()
        {
            //Tyhjentää toimipisteen kentät
            txbToimipisteNimi.Text = "";
            txbToimipisteLahiosoite.Text = "";
            txbToimipistePostitoimipaikka.Text = "";
            txbToimipistePostinro.Text = "";
            txbToimipisteEmail.Text = "";
            txbToimipistePuhelinnro.Text = "";
        }

        private void ToimipisteNapitOn()
        {
            txbHaeToimipiste.Enabled = true;
            btnLisaaToimipiste.Enabled = true;
            btnPoistaToimipiste.Enabled = true;
            btnPeruutaToimipiste.Enabled = false;
            btnPeruutaToimipiste.Visible = false;
            toimipisteDataGridView.Visible = true;
            toimipisteDataGridView.Enabled = true;
            btnPoistaToimipiste.Visible = true;
            btnLisaaToimipiste.Visible = true;
            lblHaeToimipiste.Visible = true;
            txbHaeToimipiste.Visible = true;
        }
        private void ToimipisteNapitOff()
        {
            txbHaeToimipiste.Enabled = false;
            btnLisaaToimipiste.Enabled = false;
            btnPoistaToimipiste.Enabled = false;
            btnPeruutaToimipiste.Enabled = true;
            btnPeruutaToimipiste.Visible = true;
            toimipisteDataGridView.Visible = false;
            toimipisteDataGridView.Enabled = false;
            btnPoistaToimipiste.Visible = false;
            btnLisaaToimipiste.Visible = false;
            lblHaeToimipiste.Visible = false;
            txbHaeToimipiste.Visible = false;
        }
        private void btnTallennaToimipiste_Click(object sender, EventArgs e)
        // Toimipisteen tietojen tallennus
        {
            // Ennen mitään tallennusta tarkistetaan, että vähintään etu- ja sukunimi on annettu.
            if (TarkistaToimipiste() == false)
            {
                MessageBox.Show("Anna vähintään nimi, lähiosoite, postinumero ja postitoimipaikka.", "Virhe syötteessä", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string nimi = txbToimipisteNimi.Text;
                if (lisataanUusi == true)  // Kokonaan uuden toimipisteen tallennus
                {
                    try
                    {
                        toimipisteTableAdapter.InsertQuery(
                                            txbToimipisteNimi.Text,
                                            txbToimipisteLahiosoite.Text,
                                            txbToimipistePostitoimipaikka.Text,
                                            txbToimipistePostinro.Text,
                                            txbToimipisteEmail.Text,
                                            txbToimipistePuhelinnro.Text
                                            );
                        MessageBox.Show("Toimipiste " + nimi + " lisätty onnistuneesti", "Tallennus", MessageBoxButtons.OK);
                        toimipisteDataGridView.DataSource = toimipisteTableAdapter.GetData();
                        //Valitsee alimman, eli uusimman rivin
                        toimipisteDataGridView.Rows[toimipisteDataGridView.Rows.Count - 1].Selected = true;
                        PaivitaToimipisteKentat(toimipisteDataGridView.Rows.Count - 1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Virhe tietojen lisäämisessä.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    ToimipisteNapitOn();
                    lisataanUusi = false;

                }
                else // Tallennetaan toimipisteen muuttuneet tiedot jo olemassa olevaan toimipisteeseen.
                {
                    try
                    {
                        // Tallennetaan toimipisteen muuttuneet tiedot tietokantaan.
                        int id = int.Parse(toimipisteDataGridView.Rows[valitturivi].Cells[0].Value.ToString());
                        //int temp = valitturivi;
                        string temp = txbToimipisteNimi.Text;
                        toimipisteTableAdapter.UpdateQueryToimipiste(
                            txbToimipisteNimi.Text,
                            txbToimipisteLahiosoite.Text,
                            txbToimipistePostitoimipaikka.Text,
                            txbToimipistePostinro.Text,
                            txbToimipisteEmail.Text,
                            txbToimipistePuhelinnro.Text,
                            id);
                        MessageBox.Show("Toimipisteen " + nimi + " muutokset tallennettu onnistuneesti!", "Muutokset tallennettu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        toimipisteDataGridView.DataSource = toimipisteTableAdapter.GetData();
                        txbHaeToimipiste.Text = temp;
                        txbHaeToimipiste.Focus();
                        txbHaeToimipiste.SelectAll();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tietokantayhteys on poikki. Tarkista internet-yhteys ja kokeile uudelleen.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void txbHaeToimipiste_TextChanged(object sender, EventArgs e)
        {
            toimipisteDataGridView.DataSource = toimipisteTableAdapter.GetDataByToimipistehaku("%" + txbHaeToimipiste.Text + "%");

        }

        private void btnTallennaAsiakas_Click_1(object sender, EventArgs e)
        // Asiakashallinnasta painettu TallennaAsiakas-nappia

        {
            // Ennen mitään tallennusta tarkistetaan, että vähintään etu- ja sukunimi on annettu.
            if (TarkistaAsiakas() == false)
            {
                MessageBox.Show("Anna etu- ja sukunimi.", "Virhe syötteessä", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string kokonimi = txbAsiakasEtunimi.Text + " " + txbAsiakasSukunimi.Text;
                // Jos on painettu uuden asiakkaan lisäämistä, tehdään sen tallennus tietokantaan tässä.
                if (lisataanUusi == true)
                {
                    try
                    {
                        asiakasTableAdapter.InsertQueryAsiakas(
                            txbAsiakasEtunimi.Text,
                            txbAsiakasSukunimi.Text,
                            txbAsiakasLahiosoite.Text,
                            txbAsiakasPostitoimipaikka.Text,
                            txbAsiakasPostinro.Text,
                            txbAsiakasEmail.Text,
                            txbAsiakasPuhelinnro.Text);
                        MessageBox.Show("Uusi käyttäjä " + kokonimi + " tallennettu onnistuneesti!", "Tiedot tallennettu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        asiakasDataGridView.DataSource = asiakasTableAdapter.GetData();
                        asiakasDataGridView.Controls[1].Enabled = true; // Jostain syystä vertikaalinen scrollbar on disabled-tilassa, joten aktivoidaan se.
                        asiakasDataGridView.Rows[asiakasDataGridView.Rows.Count - 1].Selected = true;
                        PaivitaAsiakasKentat(asiakasDataGridView.Rows.Count - 1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tietokantayhteys on poikki. Tarkista internet-yhteys ja kokeile uudelleen.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    lisataanUusi = false;
                    AsiakasNapitAlkutilaan();
                }
                else
                {
                    // Jos olemassa olevan asiakkaan tietoja on muutettu, tallennetaan ne tässä.
                    try
                    {
                        // Tallennetaan asiakkaan muuttuneet tiedot tietokantaan.
                        int id = int.Parse(asiakasDataGridView.Rows[valitturivi].Cells[0].Value.ToString());
                        //int temp = valitturivi;
                        string temp = txbAsiakasEmail.Text;
                        asiakasTableAdapter.UpdateQueryAsiakas(
                            txbAsiakasEtunimi.Text,
                            txbAsiakasSukunimi.Text,
                            txbAsiakasLahiosoite.Text,
                            txbAsiakasPostitoimipaikka.Text,
                            txbAsiakasPostinro.Text,
                            txbAsiakasEmail.Text,
                            txbAsiakasPuhelinnro.Text,
                            id);
                        MessageBox.Show("Asiakkaan " + kokonimi + " muutokset tallennettu onnistuneesti!", "Muutokset tallennettu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        asiakasDataGridView.DataSource = asiakasTableAdapter.GetData();
                        txbHaeAsiakas.Text = temp;
                        txbHaeAsiakas.Focus();
                        txbHaeAsiakas.SelectAll();
                        //asiakasDataGridView.Rows[temp].Selected = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tietokantayhteys on poikki. Tarkista internet-yhteys ja kokeile uudelleen.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnLisaaAsiakas_Click_1(object sender, EventArgs e)
        {
            // Luodaan uusi asiakas. Tyhjennetään ensin kentät ja viedään kursori etunimi-kenttään
            txbHaeAsiakas.Clear();
            lisataanUusi = true;
            TyhjennaAsiakasKentat();
            PiilotaAsiakasnappulat();
            txbAsiakasEtunimi.Select();
        }

        private void txbAsiakasPuhelinnro_KeyPress_1(object sender, KeyPressEventArgs e)
        // Tarkistetaan asiakkaan puhelinnumero, jotta vain haluttuja merkkejä voi syöttää.
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '-') && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }

        private void txbAsiakasPostinro_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Tarkistetaan asiakkaan postinumero, vain numeroita voi syöttää.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TyhjennaAsiakasKentat()
        {
            txbAsiakasEtunimi.Clear();
            txbAsiakasSukunimi.Clear();
            txbAsiakasLahiosoite.Clear();
            txbAsiakasPostinro.Clear();
            txbAsiakasPostitoimipaikka.Clear();
            txbAsiakasEmail.Clear();
            txbAsiakasPuhelinnro.Clear();
        }

        private void btnPoistaAsiakas_Click_1(object sender, EventArgs e)
        // Poistetaan datagridistä valittu asiakas
        {
            // Yritetään poistaa valittu asiakas
            try
            {
                // Haetaan datagridistä valittu valitun asiakkaan nimi
                string kokonimi = asiakasDataGridView.Rows[valitturivi].Cells[1].Value.ToString() + " " + asiakasDataGridView.Rows[valitturivi].Cells[2].Value.ToString();
                // Varmistetaan poistaminen messageboxilla.
                if (MessageBox.Show("Haluatko varmasti poistaa asiakkaan " + kokonimi + "?", "Poistetaanko", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(asiakasDataGridView.Rows[valitturivi].Cells[0].Value.ToString());
                    asiakasTableAdapter.DeleteQuery(id);
                    asiakasDataGridView.DataSource = asiakasTableAdapter.GetData();
                    //asiakasDataGridView.Update();
                    MessageBox.Show("Asiakas " + kokonimi + " on poistettu onnistuneesti.", "Poisto onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbHaeAsiakas.Clear();
                    txbHaeAsiakas.Select();
                }
            }
            catch (Exception ex)
            {
                // Jos asiakkaan poistaminen ei onnistu, ilmoitetaan siitä käyttäjälle.
                MessageBox.Show("Asiakkaan poistaminen ei onnistunut. Tarkista internet-yhteys.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnTallennaVaraus_Click(object sender, EventArgs e)
        {
            varausTableAdapter.UpdateQueryVahvistus();
            OstoskoriPaivitys();
            MessageBox.Show("Varaukset vahvistettu onnistuneesti!");
        }

        private void cbPalveluVaraus_Click(object sender, EventArgs e)
        {

        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            // Määritetään yhteys tietokantaan
            MySqlConnection connection = new MySqlConnection("server=159.89.214.80;database=villagep;uid=villageuser;password=opGUFWUtBOmB7w5k");
            // Tehdään kyselykäsky
            MySqlCommand cmd = new MySqlCommand();
            // Luodaan Yhteys tietokantaan
            cmd.Connection = connection;
            // Tarkastetaan, että on käyttäjänimi ja salasana
            if (cboxkayttajat.SelectedText != "" || txbxSalasana.Text != "")
            {

                try
                {
                    //Aukaistaan yhteys
                    connection.Open();
                    //Tehdään käsky tietokantaan
                    cmd.CommandText = "INSERT INTO Login(Username, Password,tId) VALUES(?kayttaja,?salasana,?luokitus)";
                    //Muunnetaan käyttäjänimi oikeaan muotoon
                    cmd.Parameters.Add("?kayttaja", MySqlDbType.VarChar).Value = cboxkayttajat.Text;
                    //Muunnetaan salasana oikeaan muotoon
                    cmd.Parameters.Add("?salasana", MySqlDbType.VarChar).Value = txbxSalasana.Text;
                    //Tarkistetaan mikä turvallisuusluokitus laitetaan tietokantaan
                    if (rbtnKayttaja.Checked)
                    {
                        cmd.Parameters.Add("?luokitus", MySqlDbType.Int32).Value = 1;
                    }
                    else if (rbtnLaskutus.Checked)
                    {
                        cmd.Parameters.Add("?luokitus", MySqlDbType.Int32).Value = 2;
                    }
                    else
                    {
                        cmd.Parameters.Add("?luokitus", MySqlDbType.Int32).Value = 3;
                    }

                    //Toteutetaan käsky
                    cmd.ExecuteNonQuery();
                    //Päivitetään comboboxin käyttäjälista
                    Fillcboxkayttajat();
                    cboxkayttajat.SelectedItem = null;
                    txbxSalasana.Clear();
                    connection.Close();
                    MessageBox.Show("Käyttäjänimen luonti onnistui");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe ! " + ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Käyttäjänimi ja salasana eivät voi olla tyhjiä");
            }
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            // tehdään yhteys login databaseen joka on paikallinen, joutuu varmaan muuttamaan tuota osotetta vielä
            MySqlConnection connection = new MySqlConnection("server=159.89.214.80;database=villagep;uid=villageuser;password=opGUFWUtBOmB7w5k");
            connection.Open();
            // Tehdään kysely tietokantaan, jossa haetaan Usename ja Password
            string strQuery = "Select * from Login where Username='" + cboxkayttajat.Text + "'";
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
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Login WHERE Username='" + cboxkayttajat.Text + "'", connection);
                cmd.ExecuteNonQuery();
                Fillcboxkayttajat();
                cboxkayttajat.SelectedItem = null;
                connection.Close();
                MessageBox.Show("Käyttäjänimen poisto onnistui");
            }
            else
            {
                MessageBox.Show("Käyttäjänimeä ei löydy");
            }
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            // tehdään yhteys login databaseen joka on paikallinen, joutuu varmaan muuttamaan tuota osotetta vielä
            MySqlConnection connection = new MySqlConnection("server=159.89.214.80;database=villagep;uid=villageuser;password=opGUFWUtBOmB7w5k");
            connection.Open();
            // Tehdään kysely tietokantaan, jossa haetaan Usename ja Password
            string strQuery = "Select * from Login where Username='" + cboxkayttajat.Text + "'";
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
                // Tarkastellaan valittu turvaluokitus
                int tluokka;
                if (rbtnKayttaja.Checked)
                {
                    tluokka = 1;
                }
                else if (rbtnLaskutus.Checked)
                {
                    tluokka = 2;
                }
                else
                {
                    tluokka = 3;
                }
                //Tehdää päivityslauseke
                MySqlCommand cmd = new MySqlCommand("UPDATE Login SET Password='" + txbxSalasana.Text + "',tId= '" + tluokka + "'WHERE Username='" + cboxkayttajat.Text + "'", connection);
                //Toteutetaan käsky
                cmd.ExecuteNonQuery();
                Fillcboxkayttajat();
                cboxkayttajat.SelectedItem = null;
                txbxSalasana.Clear();
                //Suljetaan yhteys
                connection.Close();
                MessageBox.Show("Salasanan ja turvallisuusluokituksen vaihto onnistui");

            }
            else
            {
                MessageBox.Show("Käyttäjänimeä ei löydy");
            }
        }

        private void cboxkayttajat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Fillcboxkayttajat()
        {
            // Metodi Käyttäjänimien hakuun comboboxiin
            // Luodaan Yhteys tietokantaan
            MySqlConnection connection = new MySqlConnection("server=159.89.214.80;database=villagep;uid=villageuser;password=opGUFWUtBOmB7w5k");
            // Luodaan Kyselylauseke
            string sqlQuery = "SELECT * FROM Login;";
            // Tehdään kyselykäsky
            MySqlCommand cmdDataBase = new MySqlCommand(sqlQuery, connection);
            try
            {
                //Aukaistaan yhteys
                connection.Open();
                //Tehdään tietokantalukija
                MySqlDataReader reader = cmdDataBase.ExecuteReader();
                //Tehdään uusi datataulu
                DataTable dt = new DataTable();
                //Muokataan ja täytetään taulu
                dt.Columns.Add("ID", typeof(string));
                dt.Columns.Add("Username", typeof(string));
                dt.Load(reader);
                //Suljetaan yhteys
                connection.Close();
                //Yhdistetään datataulun tiedot näkymään comboboxissa
                cboxkayttajat.DataSource = dt;
                cboxkayttajat.ValueMember = "ID";
                cboxkayttajat.DisplayMember = "Username";
                cboxkayttajat.SelectedItem = null;

            }
            catch (Exception ex)
            {
                //Virheilmoitus jos metodi epäonnistuu
                MessageBox.Show("Can not open connection ! " + ex.ToString());
            }
        }

        private void kirjauduUlosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginScreen ls = new LoginScreen();
            ls.Show();
            this.Hide();
        }
        private Boolean Varauksentarkistus()
        {

            if (valittuAsiakas == null) //Tarkistaa että asiakas on valittuna
            {
                MessageBox.Show("Valitse asiakas ennen tuotteiden lisäämistä.");
                return false;
            }
            if (numHenkilotVaraus.Value == 0)
            {
                MessageBox.Show("Henkilöitä täytyy olla vähintään yksi.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnLisaaTuote_Click(object sender, EventArgs e)
        {
            //Lisätään tuote ostoskoriin ja päivitetään näkymä

            if (Varauksentarkistus() == true) //Tarkistaa että tiedot ovat järkevät
            {

                int valittuToimipiste = Convert.ToInt32(cbToimipisteVaraus.SelectedValue);
                int valittuPalvelu = Convert.ToInt32(cbPalveluVaraus.SelectedValue);
                int valittuLkm = Convert.ToInt32(numHenkilotVaraus.Value);
                DateTime dateValue = DateTime.Now;
                string MySQLFormatDate = dateValue.ToString("yyyy-MM-dd HH:mm:ss");

                MySqlConnection yhteys = new MySqlConnection("server=159.89.214.80;database=villagep;uid=villageuser;password=opGUFWUtBOmB7w5k");
                yhteys.Open();
                MySqlCommand komento = new MySqlCommand();
                komento.Connection = yhteys;

                komento.CommandText = "INSERT INTO `Varaus` (`asiakas_id`, `toimipiste_id`, `varattu_pvm`) VALUES (@p1, @p2, @p3);";
                komento.Parameters.AddWithValue("@p1", valittuAsiakasNro);
                komento.Parameters.AddWithValue("@p2", valittuToimipiste);
                komento.Parameters.AddWithValue("@p3", MySQLFormatDate);
                komento.ExecuteScalar();

                komento.CommandText = "SELECT LAST_INSERT_ID() FROM Varaus;";

                string viimeisinid = Convert.ToString(komento.ExecuteScalar());
                komento.CommandText = "INSERT INTO `Varauksen_palvelut` (`varaus_id`, `palvelu_id`, `lkm`) VALUES (@viimeisinid, @pa, @pb)";
                komento.Parameters.AddWithValue("@viimeisinid", viimeisinid);
                komento.Parameters.AddWithValue("@pa", valittuPalvelu);
                komento.Parameters.AddWithValue("@pb", valittuLkm);
                komento.ExecuteScalar();
                yhteys.Close();

                MessageBox.Show("Varaus lisättiin ostoskoriin!");
                OstoskoriPaivitys();
                SummaPaivitys();
            }
        }

        private void OstoskoriPaivitys()
        {
            this.ostoskoriTableAdapter.Fill(this.villagepDataSet.Ostoskori);
        }

        private void SummaPaivitys()
        {
            object nakyvasummaobj;
            MySqlConnection yhteys = new MySqlConnection("server=159.89.214.80;database=villagep;uid=villageuser;password=opGUFWUtBOmB7w5k");
            yhteys.Open();
            MySqlCommand komento = new MySqlCommand();
            komento.Connection = yhteys;

            komento.CommandText = "SELECT Yhteensa FROM OstoskorinLoppusumma WHERE (AsiakasID=@p1) LIMIT 1";
            komento.Parameters.AddWithValue("@p1", lisataanUusi);
            nakyvasummaobj = komento.ExecuteScalar();
            nakyvasumma = Convert.ToInt32(nakyvasummaobj);
            yhteys.Close();
            //yhteensaTextBox.Text = nakyvasumma.ToString();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        private void PaivitaAsiakasKentat(int rivinumero)
        {
            txbAsiakasEtunimi.Text = asiakasDataGridView.Rows[rivinumero].Cells[1].Value.ToString();
            txbAsiakasSukunimi.Text = asiakasDataGridView.Rows[rivinumero].Cells[2].Value.ToString();
            txbAsiakasLahiosoite.Text = asiakasDataGridView.Rows[rivinumero].Cells[3].Value.ToString();
            txbAsiakasPostinro.Text = asiakasDataGridView.Rows[rivinumero].Cells[4].Value.ToString();
            txbAsiakasPostitoimipaikka.Text = asiakasDataGridView.Rows[rivinumero].Cells[5].Value.ToString();
            txbAsiakasEmail.Text = asiakasDataGridView.Rows[rivinumero].Cells[6].Value.ToString();
            txbAsiakasPuhelinnro.Text = asiakasDataGridView.Rows[rivinumero].Cells[7].Value.ToString();

        }
        private void btnPeruutaAsiakas_Click_1(object sender, EventArgs e)
        {
            AsiakasNapitAlkutilaan();
        }

        private void AsiakasNapitAlkutilaan()
        {
            btnLisaaAsiakas.Enabled = true;
            btnPoistaAsiakas.Enabled = true;
            asiakasDataGridView.Enabled = true;
            asiakasDataGridView.Visible = true;
            btnPeruutaAsiakas.Enabled = false;
            btnPeruutaAsiakas.Visible = false;
            lblHaeAsiakasta.Visible = true;
            txbHaeAsiakas.Visible = true;
            txbHaeAsiakas.Enabled = true;
            btnPoistaAsiakas.Visible = true;
            btnLisaaAsiakas.Visible = true;
        }
        private void PiilotaAsiakasnappulat()
        {
            btnLisaaAsiakas.Enabled = false;
            btnPoistaAsiakas.Enabled = false;
            asiakasDataGridView.Enabled = false;
            asiakasDataGridView.Visible = false;
            btnPeruutaAsiakas.Enabled = true;
            btnPeruutaAsiakas.Visible = true;
            lblHaeAsiakasta.Visible = false;
            txbHaeAsiakas.Visible = false;
            txbHaeAsiakas.Enabled = false;
            btnPoistaAsiakas.Visible = false;
            btnLisaaAsiakas.Visible = false;
        }

        private bool TarkistaAsiakas()
        // Asiakastietoja tallennettaessa tarkistetaan, että vähintään etu- ja sukunimi on annettu.
        {
            if (txbAsiakasEtunimi.Text == "" || txbAsiakasSukunimi.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void tbAsiakasHaku_TextChanged(object sender, EventArgs e)
        {
            asiakastiedotDataGridView.DataSource = asiakastiedotTableAdapter.GetDataByAsiakastiedot("%" + tbAsiakasHaku.Text + "%");
        }

        private void btnValitseAsiakas_Click(object sender, EventArgs e)
        {
            valittuAsiakas = asiakastiedotDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            valittuAsiakasNro = Convert.ToInt32(valittuAsiakas);
            MessageBox.Show("Asiakkaan valinta onnistui!");
            SummaPaivitys();
        }

        private void btnTyhjaa_Click(object sender, EventArgs e)
        {
            PalveluVarausClear();

        }
        private void PalveluVarausClear()
        {

            //Tyhjentää varauksen kentät
            cbToimipisteVaraus.SelectionLength = 0;
            cbPalveluVaraus.SelectionLength = 0;
            numHenkilotVaraus.Value = 1;
            dtpAloitusVaraus.Value = DateTime.Today;
            //dtpLopetusVaraus.Value = DateTime.Today;
            dtpLopetusVaraus.MinDate = dtpAloitusVaraus.Value.AddDays(1);
            tbAsiakasHaku.Text = "";
        }

        private void btnPeruutaToimipiste_Click(object sender, EventArgs e)
        {
            ToimipisteNapitOn();
        }

        private void puhelinnroTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Tarkistetaan puhelinnumeron syöttö
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '-') && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }
        private void postinroTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Tarkistetaan asiakkaan postinumero, vain numeroita voi syöttää.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void PaivitaPalveluDataDrid(object sender, EventArgs e)
        // Päivitetään palveluhallinnan datagridviewiä valittujen hakuehtojen mukaisesti.
        {
            if (lisataanUusi == true)
            {
                //TyhjennaPalvelukentat();
                //toimipisteDataGridView.DataSource = toimipisteTableAdapter.GetData();
            }
            else
            {
                var source = (DataRowView)cmbPHToimipiste.SelectedItem;
                int id = int.Parse(source["ID"].ToString());
                //palveluDataGridView.DataSource
                if (radioPHPalveluKaikki.Checked == true)
                {
                    // Haetaan tietokannasta datagridiin sekä majoitukset, että muut palvelut valitusta toimipisteestä.
                    palveluDataGridView1.DataSource = palveluTableAdapter.GetDataByToimipiste(id);
                }
                else if (radioPHPalveluMajoitukset.Checked == true)
                {
                    // Haetaan tietokannasta datagridiin majoitukset valitusta toimipisteestä.
                    palveluDataGridView1.DataSource = palveluTableAdapter.GetDataByHaeMajoitus(id);
                }
                else
                {
                    // Haetaan tietokannasta datagridiin muut palvelut valitusta toimipisteestä.
                    palveluDataGridView1.DataSource = palveluTableAdapter.GetDataByHaeMuutPalvelut(id);
                }

                // Jos hakutuloksia ei ole, pitää tallenna-nappi disabloida. Muuten voisi yrittää tallennusta, joka jostaisi virheeseen.
                if (palveluDataGridView1.Rows.Count == 0)
                {
                    btnPHTallennaPalvelu.Enabled = false;
                    btnPHPoistaPalvelu.Enabled = false;
                    //MessageBox.Show("Ei hakutuloksia", "Virhe", MessageBoxButtons.OK);
                    statusLabel2.Text = "Ei hakutuloksia";
                }
                else
                {
                    btnPHTallennaPalvelu.Enabled = true;
                    btnPHPoistaPalvelu.Enabled = true;
                    statusLabel2.Text = "Hakutuloksia " + palveluDataGridView1.Rows.Count + " kpl.";
                }
            }
        }

        private void PaivitaPalveluDataDrid()
        {
            // Päivitetään palveluhallinnan datagridviewiä valittujen hakuehtojen mukaisesti.
            var source = (DataRowView)cmbPHToimipiste.SelectedItem;
            int id = int.Parse(source["ID"].ToString());
            //palveluDataGridView.DataSource
            if (radioPHPalveluKaikki.Checked == true)
            {
                // Haetaan tietokannasta datagridiin sekä majoitukset, että muut palvelut valitusta toimipisteestä.
                palveluDataGridView1.DataSource = palveluTableAdapter.GetDataByToimipiste(id);
            }
            else if (radioPHPalveluMajoitukset.Checked == true)
            {
                // Haetaan tietokannasta datagridiin majoitukset valitusta toimipisteestä.
                palveluDataGridView1.DataSource = palveluTableAdapter.GetDataByHaeMajoitus(id);
            }
            else
            {
                // Haetaan tietokannasta datagridiin muut palvelut valitusta toimipisteestä.
                palveluDataGridView1.DataSource = palveluTableAdapter.GetDataByHaeMuutPalvelut(id);
            }
        }
        private void txbPHPalvelunHinta_TextChanged(object sender, EventArgs e)
        {
            // Kun hintaa muutetaan, lasketaan alv uudelleen perustuen alv%-kentän arvoon.
            // Aluksi tarkastetaan syötteet. Jos kentät pyyhitään tyhjiksi, asetaan arvot nolliksi ja valitaan kaikki.
            if (txbPHPalvelunAlvProsentti.Text == "")
            {
                txbPHPalvelunAlvProsentti.Text = "0";
                txbPHPalvelunAlvProsentti.SelectAll();
            }
            if (txbPHPalvelunHinta.Text == "")
            {
                txbPHPalvelunHinta.Text = "0";
                txbPHPalvelunHinta.SelectAll();
            }
            // Varsinainen rimpsu alv:n laskentaan.
            txbPHPalvelunAlv.Text = (float.Parse(txbPHPalvelunHinta.Text) * (float.Parse(txbPHPalvelunAlvProsentti.Text)) / 100).ToString();
        }

        private void btnPHLisaaUusiPalvelu_Click(object sender, EventArgs e)
        {
            // Palveluhallinnasta lisätään uusi palvelu.
            lisataanUusi = true;
            PiilotaPalvelunappulat();
            TyhjennaPalvelukentat();
            //cmbPHValitseToimipiste.Focus();
            toimipisteDataGridView.DataSource = toimipisteTableAdapter.GetData();
            //txbPHPalvelunNimi.Select();
        }

        private void btnPHTallennaPalvelu_Click(object sender, EventArgs e)
        {
            // Palveluhallinnasta tallennetaan uusi tai muuttunut tieto.
            // Ennen mitään tallennusta tarkistetaan, että nimi- ja kuvaus-kentissä on jotain tietoa.
            if (TarkistaPalvelu() == false)
            {
                MessageBox.Show("Anna palvelun nimi ja kuvaus.", "Virhe syötteessä", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Jos on painettu uuden palvelun lisäämistä, tehdään sen tallennus tietokantaan tässä.
                string nimi = txbPHPalvelunNimi.Text;
                // Luetaan valitun toimipisteen ID.
                var source = (DataRowView)cmbPHToimipiste.SelectedItem;
                string iidee = source["ID"].ToString();

                if (lisataanUusi == true)
                {
                    try
                    {
                        int tyyppi;
                        if (radioPHPalveluMajoitukset.Checked)
                        {
                            tyyppi = 1;
                        }
                        else
                        {
                            tyyppi = 2;
                        }

                        palveluTableAdapter.InsertQueryUusiPalvelu(
                            int.Parse(iidee),
                            txbPHPalvelunNimi.Text,
                            tyyppi,
                            txbPHPalvelunKuvaus.Text,
                            decimal.Parse(txbPHPalvelunHinta.Text),
                            decimal.Parse(txbPHPalvelunAlv.Text)
                            );
                        MessageBox.Show("Uusi palvelu " + nimi + " tallennettu onnistuneesti!", "Tiedot tallennettu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //palveluDataGridView1.DataSource = palveluTableAdapter.GetData();
                        //cmbPHValitseToimipiste.DataSource = toimipisteBindingSource;
                        //palveluDataGridView1.Controls[1].Enabled = true; // Jostain syystä vertikaalinen scrollbar on disabled-tilassa, joten aktivoidaan se.
                        PaivitaPalveluDataDrid();
                        palveluDataGridView1.Rows[palveluDataGridView1.Rows.Count - 1].Selected = true;
                        PaivitaPalveluKentat(palveluDataGridView1.Rows.Count - 1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Tietokantayhteys on poikki. Tarkista internet-yhteys ja kokeile uudelleen.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    lisataanUusi = false;
                    PalautaPalvelunappulat();
                }
                else
                {
                    // Jos olemassa olevan palvelun tietoja on muutettu, tallennetaan ne tässä.
                    try
                    {
                        // Tallennetaan asiakkaan muuttuneet tiedot tietokantaan.
                        int id = int.Parse(palveluDataGridView1.Rows[valitturivi].Cells[0].Value.ToString());
                        int temp = valitturivi;
                        palveluTableAdapter.UpdateQuery(
                            txbPHPalvelunNimi.Text,
                            txbPHPalvelunKuvaus.Text,
                            decimal.Parse(txbPHPalvelunHinta.Text),
                            decimal.Parse(txbPHPalvelunAlv.Text),
                            id);
                        //palveluDataGridView1.Rows[id - 1].Selected = true;
                        MessageBox.Show("Palvelun " + nimi + " muutokset tallennettu onnistuneesti!", "Muutokset tallennettu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //palveluDataGridView1.DataSource = palveluTableAdapter.GetData();
                        PaivitaPalveluDataDrid();
                        palveluDataGridView1.Rows[temp].Selected = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tietokantayhteys on poikki. Tarkista internet-yhteys ja kokeile uudelleen.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnPHPoistaPalvelu_Click(object sender, EventArgs e)
        {
            // Palveluhallinnasta poistetaan datagridistä valittu palvelu.
            try
            {
                // Haetaan palveludatagridistä valittu valitun palvelun nimi
                string nimi = palveluDataGridView1.Rows[valitturivi].Cells[1].Value.ToString();
                // Varmistetaan poistaminen messageboxilla.
                if (MessageBox.Show("Haluatko varmasti poistaa palvelun " + nimi + "?", "Poistetaanko", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(palveluDataGridView1.Rows[valitturivi].Cells[0].Value.ToString());
                    palveluTableAdapter.DeleteQuery(id);
                    PaivitaPalveluDataDrid();
                    MessageBox.Show("Palvelu " + nimi + " on poistettu onnistuneesti.", "Poisto onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Jos palvelun poistaminen ei onnistu, ilmoitetaan siitä käyttäjälle.
                MessageBox.Show("Palvelun poistaminen ei onnistunut. Tarkista internet-yhteys.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private bool TarkistaPalvelu()
        // Asiakastietoja tallennettaessa tarkistetaan, että vähintään etu- ja sukunimi on annettu.
        // Hintaa ei tarkisteta, se voi olla 0. Palveluhan voi olla ilmainen kaupanpäällinen esim.
        // Hinta-kenttää ei voi pyyhkimällä pyyhkiä tyhjäksi, sillä kentään tulee tällöin 0. Se on hoidettu toisaalla koodissa.
        {
            if (txbPHPalvelunNimi.Text == "" || txbPHPalvelunKuvaus.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void PiilotaPalvelunappulat()
        {
            // Piilotetaan osa komponenteista uuden palvelun lisäämisen ajaksi.
            radioPHPalveluKaikki.Enabled = false;
            radioPHPalveluKaikki.Visible = false;
            radioPHPalveluMajoitukset.Checked = true;
            btnPHLisaaUusiPalvelu.Enabled = false;
            btnPHLisaaUusiPalvelu.Visible = false;
            btnPHPoistaPalvelu.Enabled = false;
            btnPHPoistaPalvelu.Visible = false;
            palveluDataGridView1.Enabled = false;
            palveluDataGridView1.Visible = false;
            btnPHPeruuta.Visible = true;
            btnPHPeruuta.Enabled = true;
            btnPHTallennaPalvelu.Enabled = true;
            btnPHPoistaPalvelu.Enabled = true;
        }

        private void PalautaPalvelunappulat()
        {
            // Palautetaan piilotetut komponentit palvelun lisäämisen tai peruutuksen jälkeen.
            radioPHPalveluKaikki.Enabled = true;
            radioPHPalveluKaikki.Visible = true;
            radioPHPalveluKaikki.Checked = true;
            btnPHLisaaUusiPalvelu.Enabled = true;
            btnPHLisaaUusiPalvelu.Visible = true;
            btnPHPoistaPalvelu.Enabled = true;
            btnPHPoistaPalvelu.Visible = true;
            palveluDataGridView1.Enabled = true;
            palveluDataGridView1.Visible = true;
            btnPHPeruuta.Visible = false;
            btnPHPeruuta.Enabled = false;
        }

        private void btnPHPeruuta_Click(object sender, EventArgs e)
        {
            // Peruuta-napin painalluksen jälkeen tyhjennetään palveluhallinnan kentät ja palautetaan komponentit alkutilaan.
            PalautaPalvelunappulat();
            TyhjennaPalvelukentat();
            lisataanUusi = false;
        }

        private void TyhjennaPalvelukentat()
        {
            // Tyhjennetään palveluhallinnan tietokentät.
            txbPHPalvelunNimi.Clear();
            txbPHPalvelunKuvaus.Clear();
            txbPHPalvelunHinta.Clear();
            txbPHPalvelunAlvProsentti.Text = "24";  // Asetetaan alv:n oletusprosentti uudelle palvelulle.
            txbPHPalvelunAlv.Clear();
        }

        private void palveluDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Kun palveluhallinan datagridin valinta muuttuu, päivitetään textboxien sisällöt vastaaviksi.
            valitturivi = palveluDataGridView1.CurrentCell.RowIndex;
            PaivitaPalveluKentat(valitturivi);
        }

        private void PaivitaPalveluKentat(int rivinumero)
        {
            // Palveluhallinnan textboxit päivitetään palveluDataGridView1:stä valitusta rivistä.
            txbPHPalvelunNimi.Text = palveluDataGridView1.Rows[rivinumero].Cells[1].Value.ToString();
            txbPHPalvelunKuvaus.Text = palveluDataGridView1.Rows[rivinumero].Cells[2].Value.ToString();
            txbPHPalvelunHinta.Text = palveluDataGridView1.Rows[rivinumero].Cells[3].Value.ToString();
            // Laketaan alv% textboxiin tietokannan alv-summan mukaan, koska tietokanta ei sisällä tietoa alvprosentista.
            txbPHPalvelunAlvProsentti.Text = ((int)Math.Round(float.Parse(palveluDataGridView1.Rows[rivinumero].Cells[4].Value.ToString()) / float.Parse(palveluDataGridView1.Rows[rivinumero].Cells[3].Value.ToString()) * 100, 0)).ToString();
        }

        private void txbPHPalvelunHinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Tarkistetaan hinnan syöttö. Sallitaan vain numeroita ja yksi pilkku.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbPHPalvelunAlvProsentti_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Tarkistetaan ALV-prosentin syöttö, sallitaan vain numeroita.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbPHToimipiste_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            var source = (DataRowView)cmbPHToimipiste.SelectedItem;
            string testi = source["ID"].ToString();
            MessageBox.Show(testi, "Testi", MessageBoxButtons.OK);
            */
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Valitaan tapahtumat, jotka tapahtuvat välilehdelle siirryttöessä.
            if (tabControl1.SelectedTab.Name == "tabPage1")
            {
                tbAsiakasHaku.Focus();
                statusLabel1.Text = "Tee uusi varaus asiakkaalle.";
                statusLabel2.Text = "";
            }
            else if (tabControl1.SelectedTab.Name == "tabPage3")
            {
                txbHaeLaskutettava.Focus();
                statusLabel1.Text = "Katso avoimet laskut ja laskuta asiakas.";
                statusLabel2.Text = "Kirjoita hakukenttään laskutettava varaus tai valitse suoraan listasta.";

            }
            else if (tabControl1.SelectedTab.Name == "tabPage6")
            {
                txbHaeAsiakas.Select();
                statusLabel1.Text = "Asiakasrekisteri.";
                statusLabel2.Text = "";
            }
            else if (tabControl1.SelectedTab.Name == "tabPage2")
            {
                txbHaeToimipiste.Select();
                statusLabel1.Text = "Toimipisteiden hallinta.";
                statusLabel2.Text = "";
            }
            else if (tabControl1.SelectedTab.Name == "tabPagePalveluhallinta.")
            {
                PaivitaPalveluDataDrid();
                cmbPHToimipiste.Focus();
                statusLabel1.Text = "Palveluiden ja majoitusten hallinta.";
                statusLabel2.Text = "";
            }
            else if (tabControl1.SelectedTab.Name == "tabPage4")
            {
                txbHaeToimipiste.Select();
                statusLabel1.Text = "Hae vanhoja laskuja.";
                statusLabel2.Text = "";
            }
            else if (tabControl1.SelectedTab.Name == "tabPage5")
            {
                txbHaeToimipiste.Select();
                statusLabel1.Text = "Tutki majoitus- ja palveluhistoriaa.";
                statusLabel2.Text = "";
                //lsbPalveluhistoriaToimipisteet.ClearSelected();
                lsbPalveluhistoriaToimipisteet.SelectedIndex = 0;

            }
            else if (tabControl1.SelectedTab.Name == "tabPage7")
            {
                txbHaeToimipiste.Select();
                statusLabel1.Text = "Ohjeman käyttäjien hallinta.";
                statusLabel2.Text = "";
            }
        }

        private void PaivitaToimipisteKentat(int valitturivi)
        {
            txbToimipisteNimi.Text = toimipisteDataGridView.Rows[valitturivi].Cells[1].Value.ToString();
            txbToimipisteLahiosoite.Text = toimipisteDataGridView.Rows[valitturivi].Cells[2].Value.ToString();
            txbToimipistePostinro.Text = toimipisteDataGridView.Rows[valitturivi].Cells[3].Value.ToString();
            txbToimipistePostitoimipaikka.Text = toimipisteDataGridView.Rows[valitturivi].Cells[4].Value.ToString();
            txbToimipisteEmail.Text = toimipisteDataGridView.Rows[valitturivi].Cells[5].Value.ToString();
            txbToimipistePuhelinnro.Text = toimipisteDataGridView.Rows[valitturivi].Cells[6].Value.ToString();
        }

        private bool TarkistaToimipiste()
        // Toimipistettä tallennettaessa tarkistetaan, että tarpeelliset tiedot on annettu.
        {
            if (txbToimipisteNimi.Text == "" || txbToimipisteLahiosoite.Text == "" || txbToimipistePostinro.Text == "" || txbToimipistePostitoimipaikka.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgOstoskori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Haetaan laskuttamattomia varauksia. Datagridiä päivitetään aina, kun kenttään kirjoitetaan.
            laskuttamattomatDataGridView.DataSource = laskuttamattomatTableAdapter.GetDataByHaku("%" + txbHaeLaskutettava.Text + "%");
            if (laskuttamattomatRivimaara == 0)
            {
                statusLabel2.Text = "Ei hakutuloksia.";

            }
            else
            {
                statusLabel2.Text = "Valitse laskutettava varaus.";
            }
            if (txbHaeLaskutettava.Text == "")
            {
                // Jos hakukenttä pyyhitään tyhjäksi.
                statusLabel2.Text = "Kirjoita hakukenttään laskutettava varaus tai valitse suoraan listasta.";
            }
        }

        private void laskuttamattomatDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kun laskuttamaton varaus valitaan, kopioidaan tiedot textboxeihin.
            valitturivi = laskuttamattomatDataGridView.CurrentCell.RowIndex;
            varausid = int.Parse(laskuttamattomatDataGridView.Rows[valitturivi].Cells[0].Value.ToString());
            asiakasid = int.Parse(laskuttamattomatDataGridView.Rows[valitturivi].Cells[1].Value.ToString());
            laskunOstotDataGridView.DataSource = laskunOstotTableAdapter.GetDataByVarauksenTuotteet(varausid);
            laskuAsiakasDataGridView.DataSource = asiakasTableAdapter.GetDataByAsiakasID(asiakasid);
            TyhjennaLaskutusosoite();

            // Laskun loppusumma + alv
            float loppusumma = 0;
            float loppusummaalv0 = 0;

            for (int i = 0; i < laskunOstotDataGridView.RowCount; i++)
            {
                loppusumma = loppusumma + float.Parse(laskunOstotDataGridView.Rows[i].Cells[7].Value.ToString());
            }
            txbLaskunSumma.Text = Math.Round(loppusumma, 2).ToString();

            for (int i = 0; i < laskunOstotDataGridView.RowCount; i++)
            {
                loppusummaalv0 += float.Parse(laskunOstotDataGridView.Rows[i].Cells[6].Value.ToString());
            }
            txbLaskunAlv.Text = Math.Round((loppusumma - loppusummaalv0), 2).ToString();

        }

        private void laskunOstotDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Laskun loppusumma + alv
            
            float loppusumma = 0;

            for (int i = 0; i < laskunOstotDataGridView.RowCount; i++)
            {
                loppusumma = loppusumma + float.Parse(laskunOstotDataGridView.Rows[i].Cells[7].Value.ToString());
            }
            txbLaskunSumma.Text = loppusumma.ToString();

            //statusLabel1.Text = "Tuoterivejä: " + laskunOstotDataGridView.Rows.Count.ToString();
            //statusLabel2.Text = laskunOstotDataGridView.Rows[0].Cells[7].Value.ToString();

            //int varausid = int.Parse(laskuttamattomatDataGridView.Rows[valitturivi].Cells[0].Value.ToString());
            //statusLabel2.Text = "Varausid: " + varausid;
            //txbLaskunSumma.Text = (laskunLoppusummaTableAdapter.GetDataByYhteensa(varausid)).ToString();
            //txbLaskunAlv.Text = laskuttamattomatDataGridView.Rows[valitturivi].Cells[2].Value.ToString();

        }

        private void btlKopioiLaskutusosoite_Click(object sender, EventArgs e)
        {
            txbLaskunNimi.Text = laskuttamattomatDataGridView.Rows[valitturivi].Cells[2].Value.ToString();
            txbLaskunLahiosoite.Text = laskuAsiakasDataGridView.Rows[0].Cells[2].Value.ToString();
            txbLaskunPostinro.Text = laskuAsiakasDataGridView.Rows[0].Cells[3].Value.ToString();
            txbLaskunPostitoimipaikka.Text = laskuAsiakasDataGridView.Rows[0].Cells[4].Value.ToString();


        }

        private void TyhjennaLaskutusosoite()
        {
            txbLaskunNimi.Clear();
            txbLaskunLahiosoite.Clear();
            txbLaskunPostinro.Clear();
            txbLaskunPostitoimipaikka.Clear();
            txbLaskunAlv.Clear();
            txbLaskunSumma.Clear();

        }

        private void btnMaksuKateisella_Click(object sender, EventArgs e)
        {
            // Käteis- ja korttiasiakkaan maksusuoritus. Laskutusosoitetietoja ei vaadita.
            try
            {
                string kokonimi = laskuttamattomatDataGridView.Rows[valitturivi].Cells[2].Value.ToString();
                laskuTableAdapter.InsertQueryKateinen(
                    int.Parse(laskuttamattomatDataGridView.Rows[valitturivi].Cells[0].Value.ToString()),
                    int.Parse(laskuttamattomatDataGridView.Rows[valitturivi].Cells[1].Value.ToString()),
                    laskuttamattomatDataGridView.Rows[valitturivi].Cells[2].Value.ToString(),
                    decimal.Parse(txbLaskunSumma.Text),
                    decimal.Parse(txbLaskunAlv.Text));
                laskuttamattomatDataGridView.DataSource = laskuttamattomatTableAdapter.GetData();
                TyhjennaLaskutusosoite();
                txbHaeLaskutettava.Clear();
                txbHaeLaskutettava.Focus();
                MessageBox.Show("Asiakkaan " + kokonimi + " varaus on maksettu käteisellä.");
            }
            catch (Exception)
            {
                MessageBox.Show("Nyt meni jokin pieleen. Tarkista internet-yhteys ja kokeile uudelleen.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLaskutaVaraus_Click(object sender, EventArgs e)
        {
            // Laskutusasiakkaan varauksen käsittely. Laskutustiedot vaaditaan.
            if (TarkistaLaskutus())
            {
                try
                {
                    string kokonimi = txbLaskunNimi.Text;
                    laskuTableAdapter.InsertQueryLasku(
                        int.Parse(laskuttamattomatDataGridView.Rows[valitturivi].Cells[0].Value.ToString()),
                        int.Parse(laskuttamattomatDataGridView.Rows[valitturivi].Cells[1].Value.ToString()),
                        txbLaskunNimi.Text,
                        txbLaskunLahiosoite.Text,
                        txbLaskunPostitoimipaikka.Text,
                        txbLaskunPostinro.Text,
                        decimal.Parse(txbLaskunSumma.Text),
                        decimal.Parse(txbLaskunAlv.Text));
                    laskuttamattomatDataGridView.DataSource = laskuttamattomatTableAdapter.GetData();
                    TyhjennaLaskutusosoite();
                    txbHaeLaskutettava.Clear();
                    txbHaeLaskutettava.Focus();
                    MessageBox.Show("Asiakkaan " + kokonimi + " varauksen maksu on siirretty laskutukseen.");
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Nyt meni jokin pieleen. Tarkista internet-yhteys ja kokeile uudelleen.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Laskutusta varten tarvitaan täydelliset yhteystiedot. Tarkista nimi, lähiosoite, postinumero ja postitoimipaikka.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TarkistaLaskutus()
        {
            // Tarkistetaan ennen laskutusta, että kaikki kentät on täytetty.
            if (txbLaskunNimi.Text == "" || txbLaskunLahiosoite.Text == "" || txbLaskunPostitoimipaikka.Text == "" || txbLaskunPostinro.Text == "")
            {
                return false;
            }
            else
                return true;
        }

        private void dtpAloitusVaraus_ValueChanged(object sender, EventArgs e)
        {
            dtpLopetusVaraus.MinDate = dtpAloitusVaraus.Value.AddDays(1);
        }

        private void laskuttamattomatDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            laskuttamattomatRivimaara = laskuttamattomatDataGridView.RowCount;
            if (laskuttamattomatRivimaara == 0)
            {
                laskunOstotDataGridView.DataSource = null;
                laskuAsiakasDataGridView.DataSource = null;
                txbLaskunAlv.Clear();
                txbLaskunSumma.Clear();
                btnLaskutaVaraus.Enabled = false;
                btnMaksuKateisella.Enabled = false;
                btlKopioiLaskutusosoite.Enabled = false;
                //MessageBox.Show("Ei ole hakutuloksia.", "Tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                btnLaskutaVaraus.Enabled = true;
                btnMaksuKateisella.Enabled = true;
                btlKopioiLaskutusosoite.Enabled = true;
            }
        }

        private void txbLaskunPostinro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Tarkistetaan laskun postinumero, vain numeroita voi syöttää.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void palvelukalenteriLoppu_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime alku = palvelukalenteriAlku.SelectionRange.Start;
            DateTime loppu = palvelukalenteriLoppu.SelectionRange.Start;
            if (alku > loppu)
            {
                palvelukalenteriAlku.MaxDate = loppu;
            }
        }

        private void palvelukalenteriAlku_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void cbToimipisteVaraus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Toimipisteen valinnan jälkeen tarjotaan valittavaksi vain kyseisen toimipisteen palvelut.
            // cbPalveluVaraus.DataSource
        }

        private void btnHaePalveluRaportti_Click(object sender, EventArgs e)
        {
            float loppusumma = 0;
            float alv = 0;
            int lkm = 0;
            var source = (DataRowView)lsbPalveluhistoriaToimipisteet.SelectedItem;
            int toimipistevalinta = int.Parse(source["ID"].ToString());
            //MessageBox.Show("ID = " + toimipistevalinta);
            /*
            string toimipistevalinnat = "";
            foreach (var item in lsbPalveluhistoriaToimipisteet.SelectedItems)
            {
                toimipistevalinnat += ((DataRowView)item)["toimipiste_id"].ToString() + ",";
                //MessageBox.Show("ID = " + ((DataRowView)item)["toimipiste_id"].ToString());
            }
            toimipistevalinnat = toimipistevalinnat.Remove(toimipistevalinnat.Length - 1);
            MessageBox.Show("Valinnat ovat: " + toimipistevalinnat);
            */

            if (radioPalveluhistoriaKaikki.Checked)
            {
                palveluhistoria2DataGridView.DataSource = palveluhistoria2TableAdapter.GetDataByKaikkiPalvelut(palvelukalenteriAlku.SelectionRange.Start, palvelukalenteriLoppu.SelectionRange.Start, toimipistevalinta);
            }
            else if (radioPalveluhistoriaMajoitukset.Checked)
            {
                palveluhistoria2DataGridView.DataSource = palveluhistoria2TableAdapter.GetDataByHakuMajoitukset(palvelukalenteriAlku.SelectionRange.Start, palvelukalenteriLoppu.SelectionRange.Start, toimipistevalinta);
            }
            else
            {
                palveluhistoria2DataGridView.DataSource = palveluhistoria2TableAdapter.GetDataByMuutPalvelut(palvelukalenteriAlku.SelectionRange.Start, palvelukalenteriLoppu.SelectionRange.Start, toimipistevalinta);
            }

            for (int i = 0; i < palveluhistoria2DataGridView.RowCount; i++)
            {
                loppusumma = loppusumma + float.Parse(palveluhistoria2DataGridView.Rows[i].Cells[6].Value.ToString());
                alv += float.Parse(palveluhistoria2DataGridView.Rows[i].Cells[7].Value.ToString());
                lkm += int.Parse(palveluhistoria2DataGridView.Rows[i].Cells[4].Value.ToString());
            }

            txbHistoriaSumma.Text = Math.Round(loppusumma, 2).ToString();
            txbHistoriaAlv.Text = Math.Round((alv), 2).ToString();
            txbHistoriaLkm.Text = lkm.ToString();

        }

        private void lsbPalveluhistoriaToimipisteet_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusLabel2.Text = "";
        }

        private void laskutusKalenteriLoppu_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime alku = laskutusKalenteriAlku.SelectionRange.Start;
            DateTime loppu = laskutusKalenteriLoppu.SelectionRange.Start;
            if (alku > loppu)
            {
                laskutusKalenteriAlku.MaxDate = loppu;
            }

        }

        private void btnEmailUudelleen_Click(object sender, EventArgs e)
        {
            int laskuid = int.Parse(laskutushistoriaDataGridView.Rows[laskutushistorianvalitturivi].Cells[0].Value.ToString());
            string email = laskutushistoriaDataGridView.Rows[laskutushistorianvalitturivi].Cells[9].Value.ToString();
            string otsikko = "Lasku Village People -varauksesta " + laskutushistoriaDataGridView.Rows[laskutushistorianvalitturivi].Cells[10].Value.ToString();
            //MessageBox.Show("laskutushistorianvalitturivi " + laskutushistorianvalitturivi);
            string viesti = rakennaLaskunSisalto(
                int.Parse(laskunTiedotDataGridView.Rows[0].Cells[0].Value.ToString()),
                int.Parse(laskunTiedotDataGridView.Rows[0].Cells[1].Value.ToString()),
                int.Parse(laskunTiedotDataGridView.Rows[0].Cells[2].Value.ToString()),
                laskunTiedotDataGridView.Rows[0].Cells[3].Value.ToString(),
                laskunTiedotDataGridView.Rows[0].Cells[4].Value.ToString(),
                laskunTiedotDataGridView.Rows[0].Cells[5].Value.ToString(),
                laskunTiedotDataGridView.Rows[0].Cells[6].Value.ToString(),
                laskunTiedotDataGridView.Rows[0].Cells[7].Value.ToString(),
                laskunTiedotDataGridView.Rows[0].Cells[8].Value.ToString(),
                laskunTiedotDataGridView.Rows[0].Cells[9].Value.ToString(),
                laskunTiedotDataGridView.Rows[0].Cells[10].Value.ToString(),
                laskunTiedotDataGridView.Rows[0].Cells[11].Value.ToString(),
                int.Parse(laskunTiedotDataGridView.Rows[0].Cells[12].Value.ToString()),
                laskunTiedotDataGridView.Rows[0].Cells[13].Value.ToString(),
                decimal.Parse(laskunTiedotDataGridView.Rows[0].Cells[14].Value.ToString()),
                decimal.Parse(laskunTiedotDataGridView.Rows[0].Cells[15].Value.ToString()));
            LahetaEmailLasku(email, otsikko, viesti);
        }

        private void btnPoistaVaraus_Click(object sender, EventArgs e)
        {
            // Yritetään poistaa valittu varaus
            try
            {
                int poistettavaVarausId = int.Parse(laskuttamattomatDataGridView.Rows[valitturivi].Cells[0].Value.ToString());
                string poistettavanVarauksenNimi = laskuttamattomatDataGridView.Rows[valitturivi].Cells[2].Value.ToString();
                // Varmistetaan poistaminen messageboxilla.
                if (MessageBox.Show("Haluatko varmasti poistaa varauksen " + poistettavaVarausId + ", jonka on tehnyt " + poistettavanVarauksenNimi + "?", "Poistetaanko", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    varausTableAdapter.DeleteQueryVaraus(poistettavaVarausId);
                    laskuttamattomatDataGridView.DataSource = laskuttamattomatTableAdapter.GetData();
                    //asiakasDataGridView.Update();
                    MessageBox.Show("Varaus " + poistettavaVarausId + " poistettu asiakkaalta " + poistettavanVarauksenNimi + " onnistuneesti.", "Poisto onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Jos asiakkaan poistaminen ei onnistu, ilmoitetaan siitä käyttäjälle.
                MessageBox.Show("Varauksen poistaminen ei onnistunut. Tarkista internet-yhteys.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void LahetaEmailLasku(string email, string otsikko, string viesti)
        {
            // Lähetetään lasku sähköpostilla. Viesti on ennakkoon rakennettu.
            Process.Start("mailto:" + email + "?subject=" + otsikko + "&body=" + viesti);
        }

        private string rakennaLaskunSisalto(int laskuid, int varausid, int asiakas_id, string maksaja, string lahiosoite, string postinumero, string postitoimipaikka, string asiakas, string email, string laskupvm, string alkupvm, string loppupvm, int toimipisteid, string toimipistenimi, decimal summa, decimal alv)
        {
            // Tehdään laskuun sisältöä.

            DateTime paivaus = DateTime.Parse(laskupvm);
            paivaus = paivaus.Date;

            DateTime erapaiva = DateTime.Parse(laskupvm);
            erapaiva = erapaiva.AddDays(14);
            DateTime erapaivapvm = erapaiva.Date;
            string laskunsisalto =
                "Village People kiittää käynnistä! Tässä ohessa on palveluidenne lasku.%0d%0A %0d%0A" +
                "Lasku nro: " + laskuid + ", varaustunnus " + varausid + "%0d%0A" +
                " Päivämäärä: " + paivaus.ToString("d") + "%0d%0A %0d%0A" +
                "Village People Oy%0d%0A" +
                "PL 555555   %0d%0A" +
                "00001 Village %0d%0A" +
                "%0d%0A" +
                "Maksaja:%0d%0A" +
                maksaja + "%0d%0A" +
                lahiosoite + "%0d%0A" +
                postinumero + " " + postitoimipaikka + "%0d%0A" +
                "%0d%0A" +
                "Asiakas:" + "%0d%0A" +
                asiakas + "%0d%0A" +
                email +
                "%0d%0A%0d%0A" +
                "Toimipiste: " + toimipistenimi + "%0d%0A" +
                "Varaus alkoi: " + alkupvm + "%0d%0A" +
                "Varaus päättyi: " + loppupvm + "%0d%0A%0d%0A" +
                "Varauksen loppusumma (Sis alv): " + summa + "%0d%0A" +
                "ALV: " + alv + "%0d%0A" +
                "Laskun eräpäivä: " + erapaivapvm.ToString("d") + "%0d%0A%0d%0A";
            return laskunsisalto;
        }

        private void laskutushistoriaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            laskutushistorianvalitturivi = laskutushistoriaDataGridView.CurrentCell.RowIndex;
            laskunTiedotDataGridView.DataSource = laskunTiedotTableAdapter.GetDataByLaskuunTiedot(int.Parse(laskutushistoriaDataGridView.Rows[laskutushistorianvalitturivi].Cells[0].Value.ToString()));
            laskunPalveluRivitDataGridView.DataSource = laskunOstotTableAdapter.GetDataByLaskurivit(int.Parse(laskunTiedotDataGridView.Rows[valitturivi].Cells[1].Value.ToString()));
        }

        private void laskunTiedotDataGridView_SelectionChanged(object sender, EventArgs e)
        {
        }
    }
}
