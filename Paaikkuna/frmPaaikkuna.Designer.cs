namespace Paaikkuna
{
    partial class frmPaaikkuna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblAsiakasEtunimi;
            System.Windows.Forms.Label lblAsiakasSukunimi;
            System.Windows.Forms.Label lblAsiakasLahiosoite;
            System.Windows.Forms.Label lblAsiakasPostitoimipaikka;
            System.Windows.Forms.Label lblAsiakasPostinro;
            System.Windows.Forms.Label lblAsiakasEmail;
            System.Windows.Forms.Label lblAsiakasPuhelinnro;
            System.Windows.Forms.Label nimiLabel;
            System.Windows.Forms.Label lahiosoiteLabel;
            System.Windows.Forms.Label postitoimipaikkaLabel;
            System.Windows.Forms.Label postinroLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label puhelinnroLabel;
            System.Windows.Forms.Label lblPHPalvelunhinta;
            System.Windows.Forms.Label lblPHPalvelunnimi;
            System.Windows.Forms.Label lblPHPalvelunAlvProsentti;
            System.Windows.Forms.Label lblPHPalvelunkuvaus;
            System.Windows.Forms.Label lblPHPalvelunAlv;
            System.Windows.Forms.Label lblLaskutusNimi;
            System.Windows.Forms.Label lblLaskutusLahiosoite;
            System.Windows.Forms.Label lblLaskutusPostitoimipaikka;
            System.Windows.Forms.Label lblLaskutusPostinumero;
            System.Windows.Forms.Label lblLaskunSumma;
            System.Windows.Forms.Label lblLaskunAlv;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ostoskoriDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ostoskoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villagepDataSet = new Paaikkuna.villagepDataSet();
            this.btnTyhjaa = new System.Windows.Forms.Button();
            this.btnAsiakashallintaan = new System.Windows.Forms.Button();
            this.btnValitseAsiakas = new System.Windows.Forms.Button();
            this.asiakastiedotDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakastiedotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tbAsiakasHaku = new System.Windows.Forms.TextBox();
            this.btnLisaaTuote = new System.Windows.Forms.Button();
            this.btnTallennaVaraus = new System.Windows.Forms.Button();
            this.cbToimipisteVaraus = new System.Windows.Forms.ComboBox();
            this.numHenkilotVaraus = new System.Windows.Forms.NumericUpDown();
            this.dtpLopetusVaraus = new System.Windows.Forms.DateTimePicker();
            this.dtpAloitusVaraus = new System.Windows.Forms.DateTimePicker();
            this.cbPalveluVaraus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnPoistaVaraus = new System.Windows.Forms.Button();
            this.grpLaskunYhteenveto = new System.Windows.Forms.GroupBox();
            this.lblAsiakasTilaaja = new System.Windows.Forms.Label();
            this.laskuAsiakasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMaksuKateisella = new System.Windows.Forms.Button();
            this.grpLaskutusOsoite = new System.Windows.Forms.GroupBox();
            this.btlKopioiLaskutusosoite = new System.Windows.Forms.Button();
            this.txbLaskunAlv = new System.Windows.Forms.TextBox();
            this.txbLaskunNimi = new System.Windows.Forms.TextBox();
            this.btnLaskutaVaraus = new System.Windows.Forms.Button();
            this.txbLaskunLahiosoite = new System.Windows.Forms.TextBox();
            this.txbLaskunPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.txbLaskunSumma = new System.Windows.Forms.TextBox();
            this.txbLaskunPostinro = new System.Windows.Forms.TextBox();
            this.laskunOstotDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laskunOstotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblValitseLaskutettava = new System.Windows.Forms.Label();
            this.txbHaeLaskutettava = new System.Windows.Forms.TextBox();
            this.lblHaeLaskutettava = new System.Windows.Forms.Label();
            this.laskuttamattomatDataGridView = new System.Windows.Forms.DataGridView();
            this.varausIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varausAlkoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varausPaattyiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laskuttamattomatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.asiakasDataGridView = new System.Windows.Forms.DataGridView();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sukunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postitoimipaikkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLisaaAsiakas = new System.Windows.Forms.Button();
            this.btnPoistaAsiakas = new System.Windows.Forms.Button();
            this.txbAsiakasEtunimi = new System.Windows.Forms.TextBox();
            this.txbAsiakasSukunimi = new System.Windows.Forms.TextBox();
            this.txbAsiakasLahiosoite = new System.Windows.Forms.TextBox();
            this.txbAsiakasPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.txbAsiakasPostinro = new System.Windows.Forms.TextBox();
            this.txbAsiakasEmail = new System.Windows.Forms.TextBox();
            this.txbAsiakasPuhelinnro = new System.Windows.Forms.TextBox();
            this.btnTallennaAsiakas = new System.Windows.Forms.Button();
            this.lblHaeAsiakasta = new System.Windows.Forms.Label();
            this.txbHaeAsiakas = new System.Windows.Forms.TextBox();
            this.btnPeruutaAsiakas = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLisaaToimipiste = new System.Windows.Forms.Button();
            this.txbHaeToimipiste = new System.Windows.Forms.TextBox();
            this.lblHaeToimipiste = new System.Windows.Forms.Label();
            this.btnTallennaToimipiste = new System.Windows.Forms.Button();
            this.txbToimipisteNimi = new System.Windows.Forms.TextBox();
            this.toimipisteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txbToimipisteLahiosoite = new System.Windows.Forms.TextBox();
            this.txbToimipistePostitoimipaikka = new System.Windows.Forms.TextBox();
            this.txbToimipistePostinro = new System.Windows.Forms.TextBox();
            this.txbToimipisteEmail = new System.Windows.Forms.TextBox();
            this.txbToimipistePuhelinnro = new System.Windows.Forms.TextBox();
            this.toimipisteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPeruutaToimipiste = new System.Windows.Forms.Button();
            this.btnPoistaToimipiste = new System.Windows.Forms.Button();
            this.tabPagePalveluhallinta = new System.Windows.Forms.TabPage();
            this.grpPHValitsePalvelutyyppi = new System.Windows.Forms.GroupBox();
            this.radioPHPalveluKaikki = new System.Windows.Forms.RadioButton();
            this.radioPHPalveluMajoitukset = new System.Windows.Forms.RadioButton();
            this.radioPHPalveluMuut = new System.Windows.Forms.RadioButton();
            this.palveluDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpPHPalveluhallintaMuokkaa = new System.Windows.Forms.GroupBox();
            this.btnPHLisaaUusiPalvelu = new System.Windows.Forms.Button();
            this.btnPHTallennaPalvelu = new System.Windows.Forms.Button();
            this.txbPHPalvelunNimi = new System.Windows.Forms.TextBox();
            this.txbPHPalvelunAlv = new System.Windows.Forms.TextBox();
            this.txbPHPalvelunAlvProsentti = new System.Windows.Forms.TextBox();
            this.txbPHPalvelunKuvaus = new System.Windows.Forms.TextBox();
            this.txbPHPalvelunHinta = new System.Windows.Forms.TextBox();
            this.btnPHPeruuta = new System.Windows.Forms.Button();
            this.btnPHPoistaPalvelu = new System.Windows.Forms.Button();
            this.grpPHValitseToimipiste = new System.Windows.Forms.GroupBox();
            this.cmbPHToimipiste = new System.Windows.Forms.ComboBox();
            this.toimipistenimetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.laskunPalveluRivitDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn81 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn83 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn84 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn85 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn86 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn89 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn90 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn91 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn92 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laskunTiedotDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn70 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn71 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn72 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn73 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn74 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn75 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn76 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn77 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn78 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn79 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laskunTiedotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEmailUudelleen = new System.Windows.Forms.Button();
            this.lblLaskuhistoriaLoppuPvm = new System.Windows.Forms.Label();
            this.lblLaskuhistoriaAlkuPvm = new System.Windows.Forms.Label();
            this.btnHaeLaskutushistoria = new System.Windows.Forms.Button();
            this.laskutusKalenteriLoppu = new System.Windows.Forms.MonthCalendar();
            this.laskutusKalenteriAlku = new System.Windows.Forms.MonthCalendar();
            this.laskutushistoriaDataGridView = new System.Windows.Forms.DataGridView();
            this.LaskuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laskutushistoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.palveluhistoria2DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palveluhistoria2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpPalveluhistoria = new System.Windows.Forms.GroupBox();
            this.lblHistoriaAlv = new System.Windows.Forms.Label();
            this.lblHistoriaSumma = new System.Windows.Forms.Label();
            this.lblHistoriaLkm = new System.Windows.Forms.Label();
            this.txbHistoriaAlv = new System.Windows.Forms.TextBox();
            this.txbHistoriaSumma = new System.Windows.Forms.TextBox();
            this.txbHistoriaLkm = new System.Windows.Forms.TextBox();
            this.btnHaePalveluRaportti = new System.Windows.Forms.Button();
            this.grpPalveluhistoriaToimipiste = new System.Windows.Forms.GroupBox();
            this.lsbPalveluhistoriaToimipisteet = new System.Windows.Forms.ListBox();
            this.grpPalvelukalenteri = new System.Windows.Forms.GroupBox();
            this.palvelukalenteriLoppu = new System.Windows.Forms.MonthCalendar();
            this.palvelukalenteriAlku = new System.Windows.Forms.MonthCalendar();
            this.grpPalveluhistoriaValitseTyyppi = new System.Windows.Forms.GroupBox();
            this.radioPalveluhistoriaKaikki = new System.Windows.Forms.RadioButton();
            this.radioPalveluhistoriaMajoitukset = new System.Windows.Forms.RadioButton();
            this.radioPalveluhistoriaMuutPalvelut = new System.Windows.Forms.RadioButton();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.lbSalasana = new System.Windows.Forms.Label();
            this.lbKayttaja = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.rbtnLaskutus = new System.Windows.Forms.RadioButton();
            this.rbtnKayttaja = new System.Windows.Forms.RadioButton();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.txbxSalasana = new System.Windows.Forms.TextBox();
            this.cboxkayttajat = new System.Windows.Forms.ComboBox();
            this.ostoskorinLoppusummaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirjauduUlosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ohjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ohjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tietojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.varauksen_palvelutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laskuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asiakasTableAdapter = new Paaikkuna.villagepDataSetTableAdapters.AsiakasTableAdapter();
            this.tableAdapterManager = new Paaikkuna.villagepDataSetTableAdapters.TableAdapterManager();
            this.palveluTableAdapter = new Paaikkuna.villagepDataSetTableAdapters.PalveluTableAdapter();
            this.toimipisteTableAdapter = new Paaikkuna.villagepDataSetTableAdapters.ToimipisteTableAdapter();
            this.laskuttamattomatTableAdapter = new Paaikkuna.villagepDataSetTableAdapters.LaskuttamattomatTableAdapter();
            this.laskuTableAdapter = new Paaikkuna.villagepDataSetTableAdapters.LaskuTableAdapter();
            this.laskutushistoriaTableAdapter = new Paaikkuna.villagepDataSetTableAdapters.LaskutushistoriaTableAdapter();
            this.asiakastiedotTableAdapter = new Paaikkuna.villagepDataSetTableAdapters.AsiakastiedotTableAdapter();
            this.varausTableAdapter = new Paaikkuna.villagepDataSetTableAdapters.VarausTableAdapter();
            this.varauksen_palvelutTableAdapter = new Paaikkuna.villagepDataSetTableAdapters.Varauksen_palvelutTableAdapter();
            this.ostoskoriTableAdapter = new Paaikkuna.villagepDataSetTableAdapters.OstoskoriTableAdapter();
            this.toimipistenimetTableAdapter = new Paaikkuna.villagepDataSetTableAdapters.ToimipistenimetTableAdapter();
            this.laskunOstotTableAdapter = new Paaikkuna.villagepDataSetTableAdapters.LaskunOstotTableAdapter();
            this.laskunLoppusummaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laskunLoppusummaTableAdapter = new Paaikkuna.villagepDataSetTableAdapters.LaskunLoppusummaTableAdapter();
            this.laskunLoppusummaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.laskunLoppusummaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ostoskorinLoppusummaTableAdapter = new Paaikkuna.villagepDataSetTableAdapters.OstoskorinLoppusummaTableAdapter();
            this.palveluhistoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.palveluhistoria2TableAdapter = new Paaikkuna.villagepDataSetTableAdapters.Palveluhistoria2TableAdapter();
            this.laskunTiedotTableAdapter = new Paaikkuna.villagepDataSetTableAdapters.LaskunTiedotTableAdapter();
            this.laskunTiedot2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laskunTiedot2TableAdapter = new Paaikkuna.villagepDataSetTableAdapters.LaskunTiedot2TableAdapter();
            this.lblLaskunPalvelut = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            lblAsiakasEtunimi = new System.Windows.Forms.Label();
            lblAsiakasSukunimi = new System.Windows.Forms.Label();
            lblAsiakasLahiosoite = new System.Windows.Forms.Label();
            lblAsiakasPostitoimipaikka = new System.Windows.Forms.Label();
            lblAsiakasPostinro = new System.Windows.Forms.Label();
            lblAsiakasEmail = new System.Windows.Forms.Label();
            lblAsiakasPuhelinnro = new System.Windows.Forms.Label();
            nimiLabel = new System.Windows.Forms.Label();
            lahiosoiteLabel = new System.Windows.Forms.Label();
            postitoimipaikkaLabel = new System.Windows.Forms.Label();
            postinroLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            puhelinnroLabel = new System.Windows.Forms.Label();
            lblPHPalvelunhinta = new System.Windows.Forms.Label();
            lblPHPalvelunnimi = new System.Windows.Forms.Label();
            lblPHPalvelunAlvProsentti = new System.Windows.Forms.Label();
            lblPHPalvelunkuvaus = new System.Windows.Forms.Label();
            lblPHPalvelunAlv = new System.Windows.Forms.Label();
            lblLaskutusNimi = new System.Windows.Forms.Label();
            lblLaskutusLahiosoite = new System.Windows.Forms.Label();
            lblLaskutusPostitoimipaikka = new System.Windows.Forms.Label();
            lblLaskutusPostinumero = new System.Windows.Forms.Label();
            lblLaskunSumma = new System.Windows.Forms.Label();
            lblLaskunAlv = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ostoskoriDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostoskoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villagepDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakastiedotDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakastiedotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHenkilotVaraus)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.grpLaskunYhteenveto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laskuAsiakasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            this.grpLaskutusOsoite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laskunOstotDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskunOstotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuttamattomatDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuttamattomatBindingSource)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteDataGridView)).BeginInit();
            this.tabPagePalveluhallinta.SuspendLayout();
            this.grpPHValitsePalvelutyyppi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.palveluDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            this.grpPHPalveluhallintaMuokkaa.SuspendLayout();
            this.grpPHValitseToimipiste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toimipistenimetBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laskunPalveluRivitDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskunTiedotDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskunTiedotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskutushistoriaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskutushistoriaBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.palveluhistoria2DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluhistoria2BindingSource)).BeginInit();
            this.grpPalveluhistoria.SuspendLayout();
            this.grpPalveluhistoriaToimipiste.SuspendLayout();
            this.grpPalvelukalenteri.SuspendLayout();
            this.grpPalveluhistoriaValitseTyyppi.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ostoskorinLoppusummaBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varauksen_palvelutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskunLoppusummaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskunLoppusummaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskunLoppusummaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluhistoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskunTiedot2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAsiakasEtunimi
            // 
            lblAsiakasEtunimi.AutoSize = true;
            lblAsiakasEtunimi.Location = new System.Drawing.Point(26, 47);
            lblAsiakasEtunimi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAsiakasEtunimi.Name = "lblAsiakasEtunimi";
            lblAsiakasEtunimi.Size = new System.Drawing.Size(45, 13);
            lblAsiakasEtunimi.TabIndex = 25;
            lblAsiakasEtunimi.Text = "Etunimi*";
            // 
            // lblAsiakasSukunimi
            // 
            lblAsiakasSukunimi.AutoSize = true;
            lblAsiakasSukunimi.Location = new System.Drawing.Point(18, 73);
            lblAsiakasSukunimi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAsiakasSukunimi.Name = "lblAsiakasSukunimi";
            lblAsiakasSukunimi.Size = new System.Drawing.Size(54, 13);
            lblAsiakasSukunimi.TabIndex = 27;
            lblAsiakasSukunimi.Text = "Sukunimi*";
            // 
            // lblAsiakasLahiosoite
            // 
            lblAsiakasLahiosoite.AutoSize = true;
            lblAsiakasLahiosoite.Location = new System.Drawing.Point(182, 49);
            lblAsiakasLahiosoite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAsiakasLahiosoite.Name = "lblAsiakasLahiosoite";
            lblAsiakasLahiosoite.Size = new System.Drawing.Size(55, 13);
            lblAsiakasLahiosoite.TabIndex = 29;
            lblAsiakasLahiosoite.Text = "Lähiosoite";
            // 
            // lblAsiakasPostitoimipaikka
            // 
            lblAsiakasPostitoimipaikka.AutoSize = true;
            lblAsiakasPostitoimipaikka.Location = new System.Drawing.Point(154, 98);
            lblAsiakasPostitoimipaikka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAsiakasPostitoimipaikka.Name = "lblAsiakasPostitoimipaikka";
            lblAsiakasPostitoimipaikka.Size = new System.Drawing.Size(83, 13);
            lblAsiakasPostitoimipaikka.TabIndex = 31;
            lblAsiakasPostitoimipaikka.Text = "Postitoimipaikka";
            // 
            // lblAsiakasPostinro
            // 
            lblAsiakasPostinro.AutoSize = true;
            lblAsiakasPostinro.Location = new System.Drawing.Point(175, 71);
            lblAsiakasPostinro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAsiakasPostinro.Name = "lblAsiakasPostinro";
            lblAsiakasPostinro.Size = new System.Drawing.Size(65, 13);
            lblAsiakasPostinro.TabIndex = 33;
            lblAsiakasPostinro.Text = "Postinumero";
            // 
            // lblAsiakasEmail
            // 
            lblAsiakasEmail.AutoSize = true;
            lblAsiakasEmail.Location = new System.Drawing.Point(392, 43);
            lblAsiakasEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAsiakasEmail.Name = "lblAsiakasEmail";
            lblAsiakasEmail.Size = new System.Drawing.Size(32, 13);
            lblAsiakasEmail.TabIndex = 35;
            lblAsiakasEmail.Text = "Email";
            // 
            // lblAsiakasPuhelinnro
            // 
            lblAsiakasPuhelinnro.AutoSize = true;
            lblAsiakasPuhelinnro.Location = new System.Drawing.Point(366, 73);
            lblAsiakasPuhelinnro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAsiakasPuhelinnro.Name = "lblAsiakasPuhelinnro";
            lblAsiakasPuhelinnro.Size = new System.Drawing.Size(57, 13);
            lblAsiakasPuhelinnro.TabIndex = 37;
            lblAsiakasPuhelinnro.Text = "Puhelinnro";
            // 
            // nimiLabel
            // 
            nimiLabel.AutoSize = true;
            nimiLabel.Location = new System.Drawing.Point(84, 58);
            nimiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nimiLabel.Name = "nimiLabel";
            nimiLabel.Size = new System.Drawing.Size(31, 13);
            nimiLabel.TabIndex = 17;
            nimiLabel.Text = "Nimi*";
            // 
            // lahiosoiteLabel
            // 
            lahiosoiteLabel.AutoSize = true;
            lahiosoiteLabel.Location = new System.Drawing.Point(56, 82);
            lahiosoiteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lahiosoiteLabel.Name = "lahiosoiteLabel";
            lahiosoiteLabel.Size = new System.Drawing.Size(59, 13);
            lahiosoiteLabel.TabIndex = 19;
            lahiosoiteLabel.Text = "Lähiosoite*";
            // 
            // postitoimipaikkaLabel
            // 
            postitoimipaikkaLabel.AutoSize = true;
            postitoimipaikkaLabel.Location = new System.Drawing.Point(28, 130);
            postitoimipaikkaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            postitoimipaikkaLabel.Name = "postitoimipaikkaLabel";
            postitoimipaikkaLabel.Size = new System.Drawing.Size(87, 13);
            postitoimipaikkaLabel.TabIndex = 21;
            postitoimipaikkaLabel.Text = "Postitoimipaikka*";
            // 
            // postinroLabel
            // 
            postinroLabel.AutoSize = true;
            postinroLabel.Location = new System.Drawing.Point(46, 106);
            postinroLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            postinroLabel.Name = "postinroLabel";
            postinroLabel.Size = new System.Drawing.Size(69, 13);
            postinroLabel.TabIndex = 23;
            postinroLabel.Text = "Postinumero*";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(335, 106);
            emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 25;
            emailLabel.Text = "Email";
            // 
            // puhelinnroLabel
            // 
            puhelinnroLabel.AutoSize = true;
            puhelinnroLabel.Location = new System.Drawing.Point(290, 130);
            puhelinnroLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            puhelinnroLabel.Name = "puhelinnroLabel";
            puhelinnroLabel.Size = new System.Drawing.Size(77, 13);
            puhelinnroLabel.TabIndex = 27;
            puhelinnroLabel.Text = "Puhelinnumero";
            // 
            // lblPHPalvelunhinta
            // 
            lblPHPalvelunhinta.AutoSize = true;
            lblPHPalvelunhinta.Location = new System.Drawing.Point(340, 21);
            lblPHPalvelunhinta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPHPalvelunhinta.Name = "lblPHPalvelunhinta";
            lblPHPalvelunhinta.Size = new System.Drawing.Size(32, 13);
            lblPHPalvelunhinta.TabIndex = 10;
            lblPHPalvelunhinta.Text = "Hinta";
            // 
            // lblPHPalvelunnimi
            // 
            lblPHPalvelunnimi.AutoSize = true;
            lblPHPalvelunnimi.Location = new System.Drawing.Point(30, 25);
            lblPHPalvelunnimi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPHPalvelunnimi.Name = "lblPHPalvelunnimi";
            lblPHPalvelunnimi.Size = new System.Drawing.Size(31, 13);
            lblPHPalvelunnimi.TabIndex = 4;
            lblPHPalvelunnimi.Text = "Nimi*";
            // 
            // lblPHPalvelunAlvProsentti
            // 
            lblPHPalvelunAlvProsentti.AutoSize = true;
            lblPHPalvelunAlvProsentti.Location = new System.Drawing.Point(334, 43);
            lblPHPalvelunAlvProsentti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPHPalvelunAlvProsentti.Name = "lblPHPalvelunAlvProsentti";
            lblPHPalvelunAlvProsentti.Size = new System.Drawing.Size(38, 13);
            lblPHPalvelunAlvProsentti.TabIndex = 14;
            lblPHPalvelunAlvProsentti.Text = "ALV %";
            // 
            // lblPHPalvelunkuvaus
            // 
            lblPHPalvelunkuvaus.AutoSize = true;
            lblPHPalvelunkuvaus.Location = new System.Drawing.Point(14, 45);
            lblPHPalvelunkuvaus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPHPalvelunkuvaus.Name = "lblPHPalvelunkuvaus";
            lblPHPalvelunkuvaus.Size = new System.Drawing.Size(47, 13);
            lblPHPalvelunkuvaus.TabIndex = 8;
            lblPHPalvelunkuvaus.Text = "Kuvaus*";
            // 
            // lblPHPalvelunAlv
            // 
            lblPHPalvelunAlv.AutoSize = true;
            lblPHPalvelunAlv.Location = new System.Drawing.Point(345, 67);
            lblPHPalvelunAlv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPHPalvelunAlv.Name = "lblPHPalvelunAlv";
            lblPHPalvelunAlv.Size = new System.Drawing.Size(27, 13);
            lblPHPalvelunAlv.TabIndex = 12;
            lblPHPalvelunAlv.Text = "ALV";
            // 
            // lblLaskutusNimi
            // 
            lblLaskutusNimi.AutoSize = true;
            lblLaskutusNimi.Location = new System.Drawing.Point(69, 25);
            lblLaskutusNimi.Name = "lblLaskutusNimi";
            lblLaskutusNimi.Size = new System.Drawing.Size(31, 13);
            lblLaskutusNimi.TabIndex = 8;
            lblLaskutusNimi.Text = "Nimi*";
            // 
            // lblLaskutusLahiosoite
            // 
            lblLaskutusLahiosoite.AutoSize = true;
            lblLaskutusLahiosoite.Location = new System.Drawing.Point(41, 51);
            lblLaskutusLahiosoite.Name = "lblLaskutusLahiosoite";
            lblLaskutusLahiosoite.Size = new System.Drawing.Size(59, 13);
            lblLaskutusLahiosoite.TabIndex = 10;
            lblLaskutusLahiosoite.Text = "Lähiosoite*";
            // 
            // lblLaskutusPostitoimipaikka
            // 
            lblLaskutusPostitoimipaikka.AutoSize = true;
            lblLaskutusPostitoimipaikka.Location = new System.Drawing.Point(13, 77);
            lblLaskutusPostitoimipaikka.Name = "lblLaskutusPostitoimipaikka";
            lblLaskutusPostitoimipaikka.Size = new System.Drawing.Size(87, 13);
            lblLaskutusPostitoimipaikka.TabIndex = 12;
            lblLaskutusPostitoimipaikka.Text = "Postitoimipaikka*";
            // 
            // lblLaskutusPostinumero
            // 
            lblLaskutusPostinumero.AutoSize = true;
            lblLaskutusPostinumero.Location = new System.Drawing.Point(31, 103);
            lblLaskutusPostinumero.Name = "lblLaskutusPostinumero";
            lblLaskutusPostinumero.Size = new System.Drawing.Size(69, 13);
            lblLaskutusPostinumero.TabIndex = 14;
            lblLaskutusPostinumero.Text = "Postinumero*";
            // 
            // lblLaskunSumma
            // 
            lblLaskunSumma.AutoSize = true;
            lblLaskunSumma.Location = new System.Drawing.Point(295, 21);
            lblLaskunSumma.Name = "lblLaskunSumma";
            lblLaskunSumma.Size = new System.Drawing.Size(42, 13);
            lblLaskunSumma.TabIndex = 16;
            lblLaskunSumma.Text = "Summa";
            // 
            // lblLaskunAlv
            // 
            lblLaskunAlv.AutoSize = true;
            lblLaskunAlv.Location = new System.Drawing.Point(310, 47);
            lblLaskunAlv.Name = "lblLaskunAlv";
            lblLaskunAlv.Size = new System.Drawing.Size(27, 13);
            lblLaskunAlv.TabIndex = 18;
            lblLaskunAlv.Text = "ALV";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPagePalveluhallinta);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 601);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.ostoskoriDataGridView);
            this.tabPage1.Controls.Add(this.btnTyhjaa);
            this.tabPage1.Controls.Add(this.btnAsiakashallintaan);
            this.tabPage1.Controls.Add(this.btnValitseAsiakas);
            this.tabPage1.Controls.Add(this.asiakastiedotDataGridView);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbAsiakasHaku);
            this.tabPage1.Controls.Add(this.btnLisaaTuote);
            this.tabPage1.Controls.Add(this.btnTallennaVaraus);
            this.tabPage1.Controls.Add(this.cbToimipisteVaraus);
            this.tabPage1.Controls.Add(this.numHenkilotVaraus);
            this.tabPage1.Controls.Add(this.dtpLopetusVaraus);
            this.tabPage1.Controls.Add(this.dtpAloitusVaraus);
            this.tabPage1.Controls.Add(this.cbPalveluVaraus);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(677, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tee varaus";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ostoskoriDataGridView
            // 
            this.ostoskoriDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ostoskoriDataGridView.AutoGenerateColumns = false;
            this.ostoskoriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ostoskoriDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn52,
            this.dataGridViewTextBoxColumn53,
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn55});
            this.ostoskoriDataGridView.DataSource = this.ostoskoriBindingSource;
            this.ostoskoriDataGridView.Location = new System.Drawing.Point(3, 202);
            this.ostoskoriDataGridView.Name = "ostoskoriDataGridView";
            this.ostoskoriDataGridView.Size = new System.Drawing.Size(668, 366);
            this.ostoskoriDataGridView.TabIndex = 29;
            this.ostoskoriDataGridView.TabStop = false;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn47.DataPropertyName = "Nimi";
            this.dataGridViewTextBoxColumn47.HeaderText = "Nimi";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn48.DataPropertyName = "Tyyppi";
            this.dataGridViewTextBoxColumn48.HeaderText = "Tyyppi";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn49.DataPropertyName = "Lkm";
            this.dataGridViewTextBoxColumn49.HeaderText = "Lkm";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn52.DataPropertyName = "A-hinta";
            this.dataGridViewTextBoxColumn52.HeaderText = "A-hinta";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn53.DataPropertyName = "ALV";
            this.dataGridViewTextBoxColumn53.HeaderText = "ALV";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn54.DataPropertyName = "Yhteensa";
            this.dataGridViewTextBoxColumn54.HeaderText = "Yhteensä";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn55.DataPropertyName = "YhteensaALV24";
            this.dataGridViewTextBoxColumn55.HeaderText = "Yhteensä ALV24";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            // 
            // ostoskoriBindingSource
            // 
            this.ostoskoriBindingSource.DataMember = "Ostoskori";
            this.ostoskoriBindingSource.DataSource = this.villagepDataSet;
            // 
            // villagepDataSet
            // 
            this.villagepDataSet.DataSetName = "villagepDataSet";
            this.villagepDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTyhjaa
            // 
            this.btnTyhjaa.Location = new System.Drawing.Point(274, 127);
            this.btnTyhjaa.Margin = new System.Windows.Forms.Padding(2);
            this.btnTyhjaa.Name = "btnTyhjaa";
            this.btnTyhjaa.Size = new System.Drawing.Size(62, 25);
            this.btnTyhjaa.TabIndex = 8;
            this.btnTyhjaa.Text = "Tyhjennä";
            this.btnTyhjaa.UseVisualStyleBackColor = true;
            this.btnTyhjaa.Click += new System.EventHandler(this.btnTyhjaa_Click);
            // 
            // btnAsiakashallintaan
            // 
            this.btnAsiakashallintaan.Location = new System.Drawing.Point(275, 42);
            this.btnAsiakashallintaan.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsiakashallintaan.Name = "btnAsiakashallintaan";
            this.btnAsiakashallintaan.Size = new System.Drawing.Size(79, 26);
            this.btnAsiakashallintaan.TabIndex = 28;
            this.btnAsiakashallintaan.Text = "Uusi asiakas";
            this.btnAsiakashallintaan.UseVisualStyleBackColor = true;
            // 
            // btnValitseAsiakas
            // 
            this.btnValitseAsiakas.Location = new System.Drawing.Point(275, 13);
            this.btnValitseAsiakas.Margin = new System.Windows.Forms.Padding(2);
            this.btnValitseAsiakas.Name = "btnValitseAsiakas";
            this.btnValitseAsiakas.Size = new System.Drawing.Size(97, 27);
            this.btnValitseAsiakas.TabIndex = 2;
            this.btnValitseAsiakas.Text = "Valitse asiakas";
            this.btnValitseAsiakas.UseVisualStyleBackColor = true;
            this.btnValitseAsiakas.Click += new System.EventHandler(this.btnValitseAsiakas_Click);
            // 
            // asiakastiedotDataGridView
            // 
            this.asiakastiedotDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.asiakastiedotDataGridView.AutoGenerateColumns = false;
            this.asiakastiedotDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asiakastiedotDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.asiakastiedotDataGridView.DataSource = this.asiakastiedotBindingSource;
            this.asiakastiedotDataGridView.Location = new System.Drawing.Point(359, 47);
            this.asiakastiedotDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.asiakastiedotDataGridView.Name = "asiakastiedotDataGridView";
            this.asiakastiedotDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.asiakastiedotDataGridView.Size = new System.Drawing.Size(312, 150);
            this.asiakastiedotDataGridView.TabIndex = 26;
            this.asiakastiedotDataGridView.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Asiakastiedot";
            this.dataGridViewTextBoxColumn2.HeaderText = "Asiakastiedot";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // asiakastiedotBindingSource
            // 
            this.asiakastiedotBindingSource.DataMember = "Asiakastiedot";
            this.asiakastiedotBindingSource.DataSource = this.villagepDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Hae asiakas nimen tai muiden tietojen perusteella";
            // 
            // tbAsiakasHaku
            // 
            this.tbAsiakasHaku.Location = new System.Drawing.Point(389, 24);
            this.tbAsiakasHaku.Margin = new System.Windows.Forms.Padding(2);
            this.tbAsiakasHaku.Name = "tbAsiakasHaku";
            this.tbAsiakasHaku.Size = new System.Drawing.Size(259, 20);
            this.tbAsiakasHaku.TabIndex = 1;
            this.tbAsiakasHaku.TextChanged += new System.EventHandler(this.tbAsiakasHaku_TextChanged);
            // 
            // btnLisaaTuote
            // 
            this.btnLisaaTuote.Location = new System.Drawing.Point(275, 73);
            this.btnLisaaTuote.Name = "btnLisaaTuote";
            this.btnLisaaTuote.Size = new System.Drawing.Size(79, 24);
            this.btnLisaaTuote.TabIndex = 6;
            this.btnLisaaTuote.Text = "Lisää tuote";
            this.btnLisaaTuote.UseVisualStyleBackColor = true;
            this.btnLisaaTuote.Click += new System.EventHandler(this.btnLisaaTuote_Click);
            // 
            // btnTallennaVaraus
            // 
            this.btnTallennaVaraus.Location = new System.Drawing.Point(275, 102);
            this.btnTallennaVaraus.Margin = new System.Windows.Forms.Padding(2);
            this.btnTallennaVaraus.Name = "btnTallennaVaraus";
            this.btnTallennaVaraus.Size = new System.Drawing.Size(61, 21);
            this.btnTallennaVaraus.TabIndex = 7;
            this.btnTallennaVaraus.Text = "Vahvista";
            this.btnTallennaVaraus.UseVisualStyleBackColor = true;
            this.btnTallennaVaraus.Click += new System.EventHandler(this.btnTallennaVaraus_Click);
            // 
            // cbToimipisteVaraus
            // 
            this.cbToimipisteVaraus.FormattingEnabled = true;
            this.cbToimipisteVaraus.Location = new System.Drawing.Point(110, 10);
            this.cbToimipisteVaraus.Margin = new System.Windows.Forms.Padding(2);
            this.cbToimipisteVaraus.Name = "cbToimipisteVaraus";
            this.cbToimipisteVaraus.Size = new System.Drawing.Size(151, 21);
            this.cbToimipisteVaraus.TabIndex = 3;
            this.cbToimipisteVaraus.SelectedIndexChanged += new System.EventHandler(this.cbToimipisteVaraus_SelectedIndexChanged);
            // 
            // numHenkilotVaraus
            // 
            this.numHenkilotVaraus.Location = new System.Drawing.Point(110, 60);
            this.numHenkilotVaraus.Margin = new System.Windows.Forms.Padding(2);
            this.numHenkilotVaraus.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHenkilotVaraus.Name = "numHenkilotVaraus";
            this.numHenkilotVaraus.Size = new System.Drawing.Size(151, 20);
            this.numHenkilotVaraus.TabIndex = 5;
            this.numHenkilotVaraus.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpLopetusVaraus
            // 
            this.dtpLopetusVaraus.Location = new System.Drawing.Point(110, 108);
            this.dtpLopetusVaraus.Margin = new System.Windows.Forms.Padding(2);
            this.dtpLopetusVaraus.MinDate = new System.DateTime(2018, 5, 24, 19, 46, 55, 207);
            this.dtpLopetusVaraus.Name = "dtpLopetusVaraus";
            this.dtpLopetusVaraus.Size = new System.Drawing.Size(151, 20);
            this.dtpLopetusVaraus.TabIndex = 8;
            this.dtpLopetusVaraus.Value = new System.DateTime(2018, 5, 24, 19, 46, 55, 207);
            // 
            // dtpAloitusVaraus
            // 
            this.dtpAloitusVaraus.Location = new System.Drawing.Point(110, 84);
            this.dtpAloitusVaraus.Margin = new System.Windows.Forms.Padding(2);
            this.dtpAloitusVaraus.MinDate = new System.DateTime(2018, 5, 23, 0, 0, 0, 0);
            this.dtpAloitusVaraus.Name = "dtpAloitusVaraus";
            this.dtpAloitusVaraus.Size = new System.Drawing.Size(151, 20);
            this.dtpAloitusVaraus.TabIndex = 7;
            this.dtpAloitusVaraus.ValueChanged += new System.EventHandler(this.dtpAloitusVaraus_ValueChanged);
            // 
            // cbPalveluVaraus
            // 
            this.cbPalveluVaraus.FormattingEnabled = true;
            this.cbPalveluVaraus.Location = new System.Drawing.Point(110, 35);
            this.cbPalveluVaraus.Margin = new System.Windows.Forms.Padding(2);
            this.cbPalveluVaraus.Name = "cbPalveluVaraus";
            this.cbPalveluVaraus.Size = new System.Drawing.Size(151, 21);
            this.cbPalveluVaraus.TabIndex = 4;
            this.cbPalveluVaraus.Click += new System.EventHandler(this.cbPalveluVaraus_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lopetuspäivä";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aloituspäivä";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toimipiste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Henkilöiden määrä";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palvelu";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.btnPoistaVaraus);
            this.tabPage3.Controls.Add(this.grpLaskunYhteenveto);
            this.tabPage3.Controls.Add(this.lblValitseLaskutettava);
            this.tabPage3.Controls.Add(this.txbHaeLaskutettava);
            this.tabPage3.Controls.Add(this.lblHaeLaskutettava);
            this.tabPage3.Controls.Add(this.laskuttamattomatDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(677, 575);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Laskutus";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnPoistaVaraus
            // 
            this.btnPoistaVaraus.Location = new System.Drawing.Point(518, 40);
            this.btnPoistaVaraus.Name = "btnPoistaVaraus";
            this.btnPoistaVaraus.Size = new System.Drawing.Size(133, 23);
            this.btnPoistaVaraus.TabIndex = 5;
            this.btnPoistaVaraus.Text = "Poista valittu varaus";
            this.btnPoistaVaraus.UseVisualStyleBackColor = true;
            this.btnPoistaVaraus.Click += new System.EventHandler(this.btnPoistaVaraus_Click);
            // 
            // grpLaskunYhteenveto
            // 
            this.grpLaskunYhteenveto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLaskunYhteenveto.Controls.Add(this.lblAsiakasTilaaja);
            this.grpLaskunYhteenveto.Controls.Add(this.laskuAsiakasDataGridView);
            this.grpLaskunYhteenveto.Controls.Add(this.btnMaksuKateisella);
            this.grpLaskunYhteenveto.Controls.Add(this.grpLaskutusOsoite);
            this.grpLaskunYhteenveto.Controls.Add(this.laskunOstotDataGridView);
            this.grpLaskunYhteenveto.Location = new System.Drawing.Point(4, 228);
            this.grpLaskunYhteenveto.Name = "grpLaskunYhteenveto";
            this.grpLaskunYhteenveto.Size = new System.Drawing.Size(647, 353);
            this.grpLaskunYhteenveto.TabIndex = 4;
            this.grpLaskunYhteenveto.TabStop = false;
            this.grpLaskunYhteenveto.Text = "Laskun yhteenveto";
            // 
            // lblAsiakasTilaaja
            // 
            this.lblAsiakasTilaaja.AutoSize = true;
            this.lblAsiakasTilaaja.Location = new System.Drawing.Point(8, 144);
            this.lblAsiakasTilaaja.Name = "lblAsiakasTilaaja";
            this.lblAsiakasTilaaja.Size = new System.Drawing.Size(130, 13);
            this.lblAsiakasTilaaja.TabIndex = 22;
            this.lblAsiakasTilaaja.Text = "Asiakas eli palvelun tilaaja";
            // 
            // laskuAsiakasDataGridView
            // 
            this.laskuAsiakasDataGridView.AllowUserToAddRows = false;
            this.laskuAsiakasDataGridView.AllowUserToDeleteRows = false;
            this.laskuAsiakasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laskuAsiakasDataGridView.AutoGenerateColumns = false;
            this.laskuAsiakasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.laskuAsiakasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.laskuAsiakasDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.laskuAsiakasDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.laskuAsiakasDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.laskuAsiakasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laskuAsiakasDataGridView.ColumnHeadersVisible = false;
            this.laskuAsiakasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn56,
            this.dataGridViewTextBoxColumn62,
            this.dataGridViewTextBoxColumn61,
            this.dataGridViewTextBoxColumn63,
            this.dataGridViewTextBoxColumn64});
            this.laskuAsiakasDataGridView.DataSource = this.asiakasBindingSource;
            this.laskuAsiakasDataGridView.Location = new System.Drawing.Point(11, 160);
            this.laskuAsiakasDataGridView.Name = "laskuAsiakasDataGridView";
            this.laskuAsiakasDataGridView.ReadOnly = true;
            this.laskuAsiakasDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.laskuAsiakasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.laskuAsiakasDataGridView.Size = new System.Drawing.Size(630, 38);
            this.laskuAsiakasDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "etunimi";
            this.dataGridViewTextBoxColumn6.HeaderText = "etunimi";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 5;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "sukunimi";
            this.dataGridViewTextBoxColumn51.HeaderText = "sukunimi";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.ReadOnly = true;
            this.dataGridViewTextBoxColumn51.Width = 5;
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "lahiosoite";
            this.dataGridViewTextBoxColumn56.HeaderText = "lahiosoite";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn56.ReadOnly = true;
            this.dataGridViewTextBoxColumn56.Width = 5;
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.DataPropertyName = "postinro";
            this.dataGridViewTextBoxColumn62.HeaderText = "postinro";
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            this.dataGridViewTextBoxColumn62.ReadOnly = true;
            this.dataGridViewTextBoxColumn62.Width = 5;
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.DataPropertyName = "postitoimipaikka";
            this.dataGridViewTextBoxColumn61.HeaderText = "postitoimipaikka";
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn61.ReadOnly = true;
            this.dataGridViewTextBoxColumn61.Width = 5;
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn63.HeaderText = "email";
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            this.dataGridViewTextBoxColumn63.ReadOnly = true;
            this.dataGridViewTextBoxColumn63.Width = 5;
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.DataPropertyName = "puhelinnro";
            this.dataGridViewTextBoxColumn64.HeaderText = "puhelinnro";
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            this.dataGridViewTextBoxColumn64.ReadOnly = true;
            this.dataGridViewTextBoxColumn64.Width = 5;
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "Asiakas";
            this.asiakasBindingSource.DataSource = this.villagepDataSet;
            // 
            // btnMaksuKateisella
            // 
            this.btnMaksuKateisella.Location = new System.Drawing.Point(526, 217);
            this.btnMaksuKateisella.Name = "btnMaksuKateisella";
            this.btnMaksuKateisella.Size = new System.Drawing.Size(94, 23);
            this.btnMaksuKateisella.TabIndex = 21;
            this.btnMaksuKateisella.Text = "Maksu käteisellä";
            this.btnMaksuKateisella.UseVisualStyleBackColor = true;
            this.btnMaksuKateisella.Click += new System.EventHandler(this.btnMaksuKateisella_Click);
            // 
            // grpLaskutusOsoite
            // 
            this.grpLaskutusOsoite.Controls.Add(this.label7);
            this.grpLaskutusOsoite.Controls.Add(this.btlKopioiLaskutusosoite);
            this.grpLaskutusOsoite.Controls.Add(lblLaskutusNimi);
            this.grpLaskutusOsoite.Controls.Add(this.txbLaskunAlv);
            this.grpLaskutusOsoite.Controls.Add(this.txbLaskunNimi);
            this.grpLaskutusOsoite.Controls.Add(this.btnLaskutaVaraus);
            this.grpLaskutusOsoite.Controls.Add(lblLaskutusLahiosoite);
            this.grpLaskutusOsoite.Controls.Add(lblLaskunAlv);
            this.grpLaskutusOsoite.Controls.Add(this.txbLaskunLahiosoite);
            this.grpLaskutusOsoite.Controls.Add(lblLaskutusPostitoimipaikka);
            this.grpLaskutusOsoite.Controls.Add(this.txbLaskunPostitoimipaikka);
            this.grpLaskutusOsoite.Controls.Add(this.txbLaskunSumma);
            this.grpLaskutusOsoite.Controls.Add(lblLaskutusPostinumero);
            this.grpLaskutusOsoite.Controls.Add(this.txbLaskunPostinro);
            this.grpLaskutusOsoite.Controls.Add(lblLaskunSumma);
            this.grpLaskutusOsoite.Location = new System.Drawing.Point(16, 204);
            this.grpLaskutusOsoite.Name = "grpLaskutusOsoite";
            this.grpLaskutusOsoite.Size = new System.Drawing.Size(493, 143);
            this.grpLaskutusOsoite.TabIndex = 20;
            this.grpLaskutusOsoite.TabStop = false;
            this.grpLaskutusOsoite.Text = "Laskutusosoite (Kirjoita uusi, tai klikkaa asiakkaan tiedot maksajaksi)";
            // 
            // btlKopioiLaskutusosoite
            // 
            this.btlKopioiLaskutusosoite.Location = new System.Drawing.Point(356, 70);
            this.btlKopioiLaskutusosoite.Name = "btlKopioiLaskutusosoite";
            this.btlKopioiLaskutusosoite.Size = new System.Drawing.Size(94, 40);
            this.btlKopioiLaskutusosoite.TabIndex = 23;
            this.btlKopioiLaskutusosoite.Text = "Kopioi asiakas maksajaksi";
            this.btlKopioiLaskutusosoite.UseVisualStyleBackColor = true;
            this.btlKopioiLaskutusosoite.Click += new System.EventHandler(this.btlKopioiLaskutusosoite_Click);
            // 
            // txbLaskunAlv
            // 
            this.txbLaskunAlv.Location = new System.Drawing.Point(343, 44);
            this.txbLaskunAlv.MaxLength = 6;
            this.txbLaskunAlv.Name = "txbLaskunAlv";
            this.txbLaskunAlv.ReadOnly = true;
            this.txbLaskunAlv.Size = new System.Drawing.Size(109, 20);
            this.txbLaskunAlv.TabIndex = 19;
            // 
            // txbLaskunNimi
            // 
            this.txbLaskunNimi.Location = new System.Drawing.Point(104, 22);
            this.txbLaskunNimi.MaxLength = 60;
            this.txbLaskunNimi.Name = "txbLaskunNimi";
            this.txbLaskunNimi.Size = new System.Drawing.Size(151, 20);
            this.txbLaskunNimi.TabIndex = 9;
            // 
            // btnLaskutaVaraus
            // 
            this.btnLaskutaVaraus.Location = new System.Drawing.Point(356, 117);
            this.btnLaskutaVaraus.Name = "btnLaskutaVaraus";
            this.btnLaskutaVaraus.Size = new System.Drawing.Size(94, 23);
            this.btnLaskutaVaraus.TabIndex = 1;
            this.btnLaskutaVaraus.Text = "Laskuta varaus";
            this.btnLaskutaVaraus.UseVisualStyleBackColor = true;
            this.btnLaskutaVaraus.Click += new System.EventHandler(this.btnLaskutaVaraus_Click);
            // 
            // txbLaskunLahiosoite
            // 
            this.txbLaskunLahiosoite.Location = new System.Drawing.Point(104, 48);
            this.txbLaskunLahiosoite.MaxLength = 40;
            this.txbLaskunLahiosoite.Name = "txbLaskunLahiosoite";
            this.txbLaskunLahiosoite.Size = new System.Drawing.Size(151, 20);
            this.txbLaskunLahiosoite.TabIndex = 11;
            // 
            // txbLaskunPostitoimipaikka
            // 
            this.txbLaskunPostitoimipaikka.Location = new System.Drawing.Point(104, 74);
            this.txbLaskunPostitoimipaikka.MaxLength = 30;
            this.txbLaskunPostitoimipaikka.Name = "txbLaskunPostitoimipaikka";
            this.txbLaskunPostitoimipaikka.Size = new System.Drawing.Size(151, 20);
            this.txbLaskunPostitoimipaikka.TabIndex = 13;
            // 
            // txbLaskunSumma
            // 
            this.txbLaskunSumma.Location = new System.Drawing.Point(343, 18);
            this.txbLaskunSumma.MaxLength = 6;
            this.txbLaskunSumma.Name = "txbLaskunSumma";
            this.txbLaskunSumma.ReadOnly = true;
            this.txbLaskunSumma.Size = new System.Drawing.Size(109, 20);
            this.txbLaskunSumma.TabIndex = 17;
            // 
            // txbLaskunPostinro
            // 
            this.txbLaskunPostinro.Location = new System.Drawing.Point(104, 100);
            this.txbLaskunPostinro.MaxLength = 5;
            this.txbLaskunPostinro.Name = "txbLaskunPostinro";
            this.txbLaskunPostinro.Size = new System.Drawing.Size(151, 20);
            this.txbLaskunPostinro.TabIndex = 15;
            this.txbLaskunPostinro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLaskunPostinro_KeyPress);
            // 
            // laskunOstotDataGridView
            // 
            this.laskunOstotDataGridView.AllowUserToAddRows = false;
            this.laskunOstotDataGridView.AllowUserToDeleteRows = false;
            this.laskunOstotDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laskunOstotDataGridView.AutoGenerateColumns = false;
            this.laskunOstotDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.laskunOstotDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laskunOstotDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn50,
            this.dataGridViewTextBoxColumn57,
            this.dataGridViewTextBoxColumn58,
            this.dataGridViewTextBoxColumn59,
            this.dataGridViewTextBoxColumn60});
            this.laskunOstotDataGridView.DataSource = this.laskunOstotBindingSource;
            this.laskunOstotDataGridView.Location = new System.Drawing.Point(11, 19);
            this.laskunOstotDataGridView.Name = "laskunOstotDataGridView";
            this.laskunOstotDataGridView.ReadOnly = true;
            this.laskunOstotDataGridView.Size = new System.Drawing.Size(630, 108);
            this.laskunOstotDataGridView.TabIndex = 0;
            this.laskunOstotDataGridView.SelectionChanged += new System.EventHandler(this.laskunOstotDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "PalveluID";
            this.dataGridViewTextBoxColumn30.HeaderText = "PalveluID";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Palvelu";
            this.dataGridViewTextBoxColumn34.HeaderText = "Palvelu";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "Tyyppi";
            this.dataGridViewTextBoxColumn46.HeaderText = "Tyyppi";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "Lkm";
            this.dataGridViewTextBoxColumn50.HeaderText = "Lkm";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "Ahinta";
            this.dataGridViewTextBoxColumn57.HeaderText = "A-hinta";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "ALV";
            this.dataGridViewTextBoxColumn58.HeaderText = "ALV";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "Yhteensa";
            this.dataGridViewTextBoxColumn59.HeaderText = "Yhteensä";
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.DataPropertyName = "YhteensaALV24";
            this.dataGridViewTextBoxColumn60.HeaderText = "Yhteensä ALV24";
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn60.ReadOnly = true;
            // 
            // laskunOstotBindingSource
            // 
            this.laskunOstotBindingSource.DataMember = "LaskunOstot";
            this.laskunOstotBindingSource.DataSource = this.villagepDataSet;
            // 
            // lblValitseLaskutettava
            // 
            this.lblValitseLaskutettava.AutoSize = true;
            this.lblValitseLaskutettava.Location = new System.Drawing.Point(17, 50);
            this.lblValitseLaskutettava.Name = "lblValitseLaskutettava";
            this.lblValitseLaskutettava.Size = new System.Drawing.Size(134, 13);
            this.lblValitseLaskutettava.TabIndex = 3;
            this.lblValitseLaskutettava.Text = "Valitse laskutettava varaus";
            // 
            // txbHaeLaskutettava
            // 
            this.txbHaeLaskutettava.Location = new System.Drawing.Point(111, 15);
            this.txbHaeLaskutettava.MaxLength = 50;
            this.txbHaeLaskutettava.Name = "txbHaeLaskutettava";
            this.txbHaeLaskutettava.Size = new System.Drawing.Size(225, 20);
            this.txbHaeLaskutettava.TabIndex = 2;
            this.txbHaeLaskutettava.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblHaeLaskutettava
            // 
            this.lblHaeLaskutettava.AutoSize = true;
            this.lblHaeLaskutettava.Location = new System.Drawing.Point(17, 18);
            this.lblHaeLaskutettava.Name = "lblHaeLaskutettava";
            this.lblHaeLaskutettava.Size = new System.Drawing.Size(88, 13);
            this.lblHaeLaskutettava.TabIndex = 1;
            this.lblHaeLaskutettava.Text = "Hae laskutettava";
            // 
            // laskuttamattomatDataGridView
            // 
            this.laskuttamattomatDataGridView.AllowUserToAddRows = false;
            this.laskuttamattomatDataGridView.AllowUserToDeleteRows = false;
            this.laskuttamattomatDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laskuttamattomatDataGridView.AutoGenerateColumns = false;
            this.laskuttamattomatDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.laskuttamattomatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laskuttamattomatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varausIDDataGridViewTextBoxColumn,
            this.asiakasIDDataGridViewTextBoxColumn1,
            this.nimiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn1,
            this.puhelinnroDataGridViewTextBoxColumn1,
            this.varausAlkoiDataGridViewTextBoxColumn,
            this.varausPaattyiDataGridViewTextBoxColumn});
            this.laskuttamattomatDataGridView.DataSource = this.laskuttamattomatBindingSource;
            this.laskuttamattomatDataGridView.Location = new System.Drawing.Point(15, 74);
            this.laskuttamattomatDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.laskuttamattomatDataGridView.MultiSelect = false;
            this.laskuttamattomatDataGridView.Name = "laskuttamattomatDataGridView";
            this.laskuttamattomatDataGridView.ReadOnly = true;
            this.laskuttamattomatDataGridView.RowTemplate.Height = 33;
            this.laskuttamattomatDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.laskuttamattomatDataGridView.Size = new System.Drawing.Size(636, 149);
            this.laskuttamattomatDataGridView.TabIndex = 0;
            this.laskuttamattomatDataGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.laskuttamattomatDataGridView_RowStateChanged);
            this.laskuttamattomatDataGridView.SelectionChanged += new System.EventHandler(this.laskuttamattomatDataGridView_SelectionChanged);
            // 
            // varausIDDataGridViewTextBoxColumn
            // 
            this.varausIDDataGridViewTextBoxColumn.DataPropertyName = "VarausID";
            this.varausIDDataGridViewTextBoxColumn.HeaderText = "VarausID";
            this.varausIDDataGridViewTextBoxColumn.Name = "varausIDDataGridViewTextBoxColumn";
            this.varausIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asiakasIDDataGridViewTextBoxColumn1
            // 
            this.asiakasIDDataGridViewTextBoxColumn1.DataPropertyName = "AsiakasID";
            this.asiakasIDDataGridViewTextBoxColumn1.HeaderText = "AsiakasID";
            this.asiakasIDDataGridViewTextBoxColumn1.Name = "asiakasIDDataGridViewTextBoxColumn1";
            this.asiakasIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "Nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "Nimi";
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
            this.nimiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // puhelinnroDataGridViewTextBoxColumn1
            // 
            this.puhelinnroDataGridViewTextBoxColumn1.DataPropertyName = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn1.HeaderText = "Puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn1.Name = "puhelinnroDataGridViewTextBoxColumn1";
            this.puhelinnroDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // varausAlkoiDataGridViewTextBoxColumn
            // 
            this.varausAlkoiDataGridViewTextBoxColumn.DataPropertyName = "Varaus alkoi";
            this.varausAlkoiDataGridViewTextBoxColumn.HeaderText = "Varaus alkoi";
            this.varausAlkoiDataGridViewTextBoxColumn.Name = "varausAlkoiDataGridViewTextBoxColumn";
            this.varausAlkoiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // varausPaattyiDataGridViewTextBoxColumn
            // 
            this.varausPaattyiDataGridViewTextBoxColumn.DataPropertyName = "Varaus paattyi";
            this.varausPaattyiDataGridViewTextBoxColumn.HeaderText = "Varaus paattyi";
            this.varausPaattyiDataGridViewTextBoxColumn.Name = "varausPaattyiDataGridViewTextBoxColumn";
            this.varausPaattyiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // laskuttamattomatBindingSource
            // 
            this.laskuttamattomatBindingSource.DataMember = "Laskuttamattomat";
            this.laskuttamattomatBindingSource.DataSource = this.villagepDataSet;
            // 
            // tabPage6
            // 
            this.tabPage6.AutoScroll = true;
            this.tabPage6.Controls.Add(this.asiakasDataGridView);
            this.tabPage6.Controls.Add(this.btnLisaaAsiakas);
            this.tabPage6.Controls.Add(this.btnPoistaAsiakas);
            this.tabPage6.Controls.Add(lblAsiakasEtunimi);
            this.tabPage6.Controls.Add(this.txbAsiakasEtunimi);
            this.tabPage6.Controls.Add(lblAsiakasSukunimi);
            this.tabPage6.Controls.Add(this.txbAsiakasSukunimi);
            this.tabPage6.Controls.Add(lblAsiakasLahiosoite);
            this.tabPage6.Controls.Add(this.txbAsiakasLahiosoite);
            this.tabPage6.Controls.Add(lblAsiakasPostitoimipaikka);
            this.tabPage6.Controls.Add(this.txbAsiakasPostitoimipaikka);
            this.tabPage6.Controls.Add(lblAsiakasPostinro);
            this.tabPage6.Controls.Add(this.txbAsiakasPostinro);
            this.tabPage6.Controls.Add(lblAsiakasEmail);
            this.tabPage6.Controls.Add(this.txbAsiakasEmail);
            this.tabPage6.Controls.Add(lblAsiakasPuhelinnro);
            this.tabPage6.Controls.Add(this.txbAsiakasPuhelinnro);
            this.tabPage6.Controls.Add(this.btnTallennaAsiakas);
            this.tabPage6.Controls.Add(this.lblHaeAsiakasta);
            this.tabPage6.Controls.Add(this.txbHaeAsiakas);
            this.tabPage6.Controls.Add(this.btnPeruutaAsiakas);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(677, 575);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Asiakashallinta";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // asiakasDataGridView
            // 
            this.asiakasDataGridView.AllowUserToAddRows = false;
            this.asiakasDataGridView.AllowUserToDeleteRows = false;
            this.asiakasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.asiakasDataGridView.AutoGenerateColumns = false;
            this.asiakasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.asiakasDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.asiakasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asiakasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asiakasidDataGridViewTextBoxColumn,
            this.etunimiDataGridViewTextBoxColumn,
            this.sukunimiDataGridViewTextBoxColumn,
            this.lahiosoiteDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.postitoimipaikkaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.puhelinnroDataGridViewTextBoxColumn});
            this.asiakasDataGridView.DataSource = this.asiakasBindingSource;
            this.asiakasDataGridView.Location = new System.Drawing.Point(2, 128);
            this.asiakasDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.asiakasDataGridView.MultiSelect = false;
            this.asiakasDataGridView.Name = "asiakasDataGridView";
            this.asiakasDataGridView.ReadOnly = true;
            this.asiakasDataGridView.RowTemplate.Height = 33;
            this.asiakasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.asiakasDataGridView.Size = new System.Drawing.Size(668, 445);
            this.asiakasDataGridView.TabIndex = 41;
            this.asiakasDataGridView.TabStop = false;
            this.asiakasDataGridView.SelectionChanged += new System.EventHandler(this.asiakasDataGridView_SelectionChanged_1);
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "Id";
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            this.asiakasidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etunimiDataGridViewTextBoxColumn
            // 
            this.etunimiDataGridViewTextBoxColumn.DataPropertyName = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.HeaderText = "Etunimi";
            this.etunimiDataGridViewTextBoxColumn.Name = "etunimiDataGridViewTextBoxColumn";
            this.etunimiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sukunimiDataGridViewTextBoxColumn
            // 
            this.sukunimiDataGridViewTextBoxColumn.DataPropertyName = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.HeaderText = "Sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.Name = "sukunimiDataGridViewTextBoxColumn";
            this.sukunimiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lahiosoiteDataGridViewTextBoxColumn
            // 
            this.lahiosoiteDataGridViewTextBoxColumn.DataPropertyName = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.HeaderText = "Lähiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.Name = "lahiosoiteDataGridViewTextBoxColumn";
            this.lahiosoiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "Postinumero";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            this.postinroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postitoimipaikkaDataGridViewTextBoxColumn
            // 
            this.postitoimipaikkaDataGridViewTextBoxColumn.DataPropertyName = "postitoimipaikka";
            this.postitoimipaikkaDataGridViewTextBoxColumn.HeaderText = "Postitoimipaikka";
            this.postitoimipaikkaDataGridViewTextBoxColumn.Name = "postitoimipaikkaDataGridViewTextBoxColumn";
            this.postitoimipaikkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // puhelinnroDataGridViewTextBoxColumn
            // 
            this.puhelinnroDataGridViewTextBoxColumn.DataPropertyName = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.HeaderText = "Puhelinnumero";
            this.puhelinnroDataGridViewTextBoxColumn.Name = "puhelinnroDataGridViewTextBoxColumn";
            this.puhelinnroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnLisaaAsiakas
            // 
            this.btnLisaaAsiakas.Location = new System.Drawing.Point(546, 49);
            this.btnLisaaAsiakas.Margin = new System.Windows.Forms.Padding(2);
            this.btnLisaaAsiakas.Name = "btnLisaaAsiakas";
            this.btnLisaaAsiakas.Size = new System.Drawing.Size(90, 22);
            this.btnLisaaAsiakas.TabIndex = 40;
            this.btnLisaaAsiakas.Text = "Lisää uusi";
            this.btnLisaaAsiakas.UseVisualStyleBackColor = true;
            this.btnLisaaAsiakas.Click += new System.EventHandler(this.btnLisaaAsiakas_Click_1);
            // 
            // btnPoistaAsiakas
            // 
            this.btnPoistaAsiakas.Location = new System.Drawing.Point(546, 83);
            this.btnPoistaAsiakas.Margin = new System.Windows.Forms.Padding(2);
            this.btnPoistaAsiakas.Name = "btnPoistaAsiakas";
            this.btnPoistaAsiakas.Size = new System.Drawing.Size(90, 22);
            this.btnPoistaAsiakas.TabIndex = 41;
            this.btnPoistaAsiakas.Text = "Poista";
            this.btnPoistaAsiakas.UseVisualStyleBackColor = true;
            this.btnPoistaAsiakas.Click += new System.EventHandler(this.btnPoistaAsiakas_Click_1);
            // 
            // txbAsiakasEtunimi
            // 
            this.txbAsiakasEtunimi.Location = new System.Drawing.Point(75, 46);
            this.txbAsiakasEtunimi.Margin = new System.Windows.Forms.Padding(2);
            this.txbAsiakasEtunimi.MaxLength = 20;
            this.txbAsiakasEtunimi.Name = "txbAsiakasEtunimi";
            this.txbAsiakasEtunimi.Size = new System.Drawing.Size(92, 20);
            this.txbAsiakasEtunimi.TabIndex = 26;
            // 
            // txbAsiakasSukunimi
            // 
            this.txbAsiakasSukunimi.Location = new System.Drawing.Point(75, 70);
            this.txbAsiakasSukunimi.Margin = new System.Windows.Forms.Padding(2);
            this.txbAsiakasSukunimi.MaxLength = 40;
            this.txbAsiakasSukunimi.Name = "txbAsiakasSukunimi";
            this.txbAsiakasSukunimi.Size = new System.Drawing.Size(92, 20);
            this.txbAsiakasSukunimi.TabIndex = 28;
            // 
            // txbAsiakasLahiosoite
            // 
            this.txbAsiakasLahiosoite.Location = new System.Drawing.Point(244, 44);
            this.txbAsiakasLahiosoite.Margin = new System.Windows.Forms.Padding(2);
            this.txbAsiakasLahiosoite.MaxLength = 40;
            this.txbAsiakasLahiosoite.Name = "txbAsiakasLahiosoite";
            this.txbAsiakasLahiosoite.Size = new System.Drawing.Size(122, 20);
            this.txbAsiakasLahiosoite.TabIndex = 30;
            // 
            // txbAsiakasPostitoimipaikka
            // 
            this.txbAsiakasPostitoimipaikka.Location = new System.Drawing.Point(244, 98);
            this.txbAsiakasPostitoimipaikka.Margin = new System.Windows.Forms.Padding(2);
            this.txbAsiakasPostitoimipaikka.MaxLength = 30;
            this.txbAsiakasPostitoimipaikka.Name = "txbAsiakasPostitoimipaikka";
            this.txbAsiakasPostitoimipaikka.Size = new System.Drawing.Size(122, 20);
            this.txbAsiakasPostitoimipaikka.TabIndex = 34;
            // 
            // txbAsiakasPostinro
            // 
            this.txbAsiakasPostinro.Location = new System.Drawing.Point(244, 71);
            this.txbAsiakasPostinro.Margin = new System.Windows.Forms.Padding(2);
            this.txbAsiakasPostinro.MaxLength = 5;
            this.txbAsiakasPostinro.Name = "txbAsiakasPostinro";
            this.txbAsiakasPostinro.Size = new System.Drawing.Size(122, 20);
            this.txbAsiakasPostinro.TabIndex = 32;
            this.txbAsiakasPostinro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAsiakasPostinro_KeyPress_1);
            // 
            // txbAsiakasEmail
            // 
            this.txbAsiakasEmail.Location = new System.Drawing.Point(429, 40);
            this.txbAsiakasEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txbAsiakasEmail.MaxLength = 50;
            this.txbAsiakasEmail.Name = "txbAsiakasEmail";
            this.txbAsiakasEmail.Size = new System.Drawing.Size(92, 20);
            this.txbAsiakasEmail.TabIndex = 36;
            // 
            // txbAsiakasPuhelinnro
            // 
            this.txbAsiakasPuhelinnro.Location = new System.Drawing.Point(429, 70);
            this.txbAsiakasPuhelinnro.Margin = new System.Windows.Forms.Padding(2);
            this.txbAsiakasPuhelinnro.MaxLength = 15;
            this.txbAsiakasPuhelinnro.Name = "txbAsiakasPuhelinnro";
            this.txbAsiakasPuhelinnro.Size = new System.Drawing.Size(92, 20);
            this.txbAsiakasPuhelinnro.TabIndex = 38;
            this.txbAsiakasPuhelinnro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAsiakasPuhelinnro_KeyPress_1);
            // 
            // btnTallennaAsiakas
            // 
            this.btnTallennaAsiakas.Location = new System.Drawing.Point(546, 17);
            this.btnTallennaAsiakas.Margin = new System.Windows.Forms.Padding(2);
            this.btnTallennaAsiakas.Name = "btnTallennaAsiakas";
            this.btnTallennaAsiakas.Size = new System.Drawing.Size(90, 22);
            this.btnTallennaAsiakas.TabIndex = 39;
            this.btnTallennaAsiakas.Text = "Tallenna";
            this.btnTallennaAsiakas.UseVisualStyleBackColor = true;
            this.btnTallennaAsiakas.Click += new System.EventHandler(this.btnTallennaAsiakas_Click_1);
            // 
            // lblHaeAsiakasta
            // 
            this.lblHaeAsiakasta.AutoSize = true;
            this.lblHaeAsiakasta.Location = new System.Drawing.Point(90, 17);
            this.lblHaeAsiakasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHaeAsiakasta.Name = "lblHaeAsiakasta";
            this.lblHaeAsiakasta.Size = new System.Drawing.Size(75, 13);
            this.lblHaeAsiakasta.TabIndex = 23;
            this.lblHaeAsiakasta.Text = "Hae asiakasta";
            // 
            // txbHaeAsiakas
            // 
            this.txbHaeAsiakas.Location = new System.Drawing.Point(185, 16);
            this.txbHaeAsiakas.Margin = new System.Windows.Forms.Padding(2);
            this.txbHaeAsiakas.MaxLength = 50;
            this.txbHaeAsiakas.Name = "txbHaeAsiakas";
            this.txbHaeAsiakas.Size = new System.Drawing.Size(180, 20);
            this.txbHaeAsiakas.TabIndex = 22;
            this.txbHaeAsiakas.TextChanged += new System.EventHandler(this.txbHaeAsiakas_TextChanged_1);
            // 
            // btnPeruutaAsiakas
            // 
            this.btnPeruutaAsiakas.Enabled = false;
            this.btnPeruutaAsiakas.Location = new System.Drawing.Point(546, 49);
            this.btnPeruutaAsiakas.Margin = new System.Windows.Forms.Padding(1);
            this.btnPeruutaAsiakas.Name = "btnPeruutaAsiakas";
            this.btnPeruutaAsiakas.Size = new System.Drawing.Size(90, 22);
            this.btnPeruutaAsiakas.TabIndex = 42;
            this.btnPeruutaAsiakas.Text = "Peruuta";
            this.btnPeruutaAsiakas.UseVisualStyleBackColor = true;
            this.btnPeruutaAsiakas.Visible = false;
            this.btnPeruutaAsiakas.Click += new System.EventHandler(this.btnPeruutaAsiakas_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLisaaToimipiste);
            this.tabPage2.Controls.Add(this.txbHaeToimipiste);
            this.tabPage2.Controls.Add(this.lblHaeToimipiste);
            this.tabPage2.Controls.Add(this.btnTallennaToimipiste);
            this.tabPage2.Controls.Add(nimiLabel);
            this.tabPage2.Controls.Add(this.txbToimipisteNimi);
            this.tabPage2.Controls.Add(lahiosoiteLabel);
            this.tabPage2.Controls.Add(this.txbToimipisteLahiosoite);
            this.tabPage2.Controls.Add(postitoimipaikkaLabel);
            this.tabPage2.Controls.Add(this.txbToimipistePostitoimipaikka);
            this.tabPage2.Controls.Add(postinroLabel);
            this.tabPage2.Controls.Add(this.txbToimipistePostinro);
            this.tabPage2.Controls.Add(emailLabel);
            this.tabPage2.Controls.Add(this.txbToimipisteEmail);
            this.tabPage2.Controls.Add(puhelinnroLabel);
            this.tabPage2.Controls.Add(this.txbToimipistePuhelinnro);
            this.tabPage2.Controls.Add(this.toimipisteDataGridView);
            this.tabPage2.Controls.Add(this.btnPeruutaToimipiste);
            this.tabPage2.Controls.Add(this.btnPoistaToimipiste);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(677, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Toimipistehallinta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLisaaToimipiste
            // 
            this.btnLisaaToimipiste.Location = new System.Drawing.Point(533, 61);
            this.btnLisaaToimipiste.Margin = new System.Windows.Forms.Padding(2);
            this.btnLisaaToimipiste.Name = "btnLisaaToimipiste";
            this.btnLisaaToimipiste.Size = new System.Drawing.Size(118, 27);
            this.btnLisaaToimipiste.TabIndex = 9;
            this.btnLisaaToimipiste.Text = "Lisää uusi toimipiste";
            this.btnLisaaToimipiste.UseVisualStyleBackColor = true;
            this.btnLisaaToimipiste.Click += new System.EventHandler(this.btnLisaaToimipiste_Click);
            // 
            // txbHaeToimipiste
            // 
            this.txbHaeToimipiste.Location = new System.Drawing.Point(273, 17);
            this.txbHaeToimipiste.MaxLength = 50;
            this.txbHaeToimipiste.Name = "txbHaeToimipiste";
            this.txbHaeToimipiste.Size = new System.Drawing.Size(135, 20);
            this.txbHaeToimipiste.TabIndex = 1;
            this.txbHaeToimipiste.TextChanged += new System.EventHandler(this.txbHaeToimipiste_TextChanged);
            // 
            // lblHaeToimipiste
            // 
            this.lblHaeToimipiste.AutoSize = true;
            this.lblHaeToimipiste.Location = new System.Drawing.Point(179, 20);
            this.lblHaeToimipiste.Name = "lblHaeToimipiste";
            this.lblHaeToimipiste.Size = new System.Drawing.Size(88, 13);
            this.lblHaeToimipiste.TabIndex = 33;
            this.lblHaeToimipiste.Text = "Hae toimipistettä:";
            // 
            // btnTallennaToimipiste
            // 
            this.btnTallennaToimipiste.Location = new System.Drawing.Point(533, 30);
            this.btnTallennaToimipiste.Margin = new System.Windows.Forms.Padding(2);
            this.btnTallennaToimipiste.Name = "btnTallennaToimipiste";
            this.btnTallennaToimipiste.Size = new System.Drawing.Size(118, 27);
            this.btnTallennaToimipiste.TabIndex = 8;
            this.btnTallennaToimipiste.Text = "Tallenna toimipiste";
            this.btnTallennaToimipiste.UseVisualStyleBackColor = true;
            this.btnTallennaToimipiste.Click += new System.EventHandler(this.btnTallennaToimipiste_Click);
            // 
            // txbToimipisteNimi
            // 
            this.txbToimipisteNimi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toimipisteBindingSource, "nimi", true));
            this.txbToimipisteNimi.Location = new System.Drawing.Point(118, 55);
            this.txbToimipisteNimi.Margin = new System.Windows.Forms.Padding(2);
            this.txbToimipisteNimi.MaxLength = 40;
            this.txbToimipisteNimi.Name = "txbToimipisteNimi";
            this.txbToimipisteNimi.Size = new System.Drawing.Size(160, 20);
            this.txbToimipisteNimi.TabIndex = 2;
            // 
            // toimipisteBindingSource
            // 
            this.toimipisteBindingSource.DataMember = "Toimipiste";
            this.toimipisteBindingSource.DataSource = this.villagepDataSet;
            // 
            // txbToimipisteLahiosoite
            // 
            this.txbToimipisteLahiosoite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toimipisteBindingSource, "lahiosoite", true));
            this.txbToimipisteLahiosoite.Location = new System.Drawing.Point(118, 79);
            this.txbToimipisteLahiosoite.Margin = new System.Windows.Forms.Padding(2);
            this.txbToimipisteLahiosoite.MaxLength = 40;
            this.txbToimipisteLahiosoite.Name = "txbToimipisteLahiosoite";
            this.txbToimipisteLahiosoite.Size = new System.Drawing.Size(160, 20);
            this.txbToimipisteLahiosoite.TabIndex = 3;
            // 
            // txbToimipistePostitoimipaikka
            // 
            this.txbToimipistePostitoimipaikka.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toimipisteBindingSource, "postitoimipaikka", true));
            this.txbToimipistePostitoimipaikka.Location = new System.Drawing.Point(118, 127);
            this.txbToimipistePostitoimipaikka.Margin = new System.Windows.Forms.Padding(2);
            this.txbToimipistePostitoimipaikka.MaxLength = 30;
            this.txbToimipistePostitoimipaikka.Name = "txbToimipistePostitoimipaikka";
            this.txbToimipistePostitoimipaikka.Size = new System.Drawing.Size(160, 20);
            this.txbToimipistePostitoimipaikka.TabIndex = 5;
            // 
            // txbToimipistePostinro
            // 
            this.txbToimipistePostinro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toimipisteBindingSource, "postinro", true));
            this.txbToimipistePostinro.Location = new System.Drawing.Point(118, 103);
            this.txbToimipistePostinro.Margin = new System.Windows.Forms.Padding(2);
            this.txbToimipistePostinro.MaxLength = 5;
            this.txbToimipistePostinro.Name = "txbToimipistePostinro";
            this.txbToimipistePostinro.Size = new System.Drawing.Size(160, 20);
            this.txbToimipistePostinro.TabIndex = 4;
            this.txbToimipistePostinro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.postinroTextBox_KeyPress);
            // 
            // txbToimipisteEmail
            // 
            this.txbToimipisteEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toimipisteBindingSource, "email", true));
            this.txbToimipisteEmail.Location = new System.Drawing.Point(374, 103);
            this.txbToimipisteEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txbToimipisteEmail.MaxLength = 50;
            this.txbToimipisteEmail.Name = "txbToimipisteEmail";
            this.txbToimipisteEmail.Size = new System.Drawing.Size(129, 20);
            this.txbToimipisteEmail.TabIndex = 6;
            // 
            // txbToimipistePuhelinnro
            // 
            this.txbToimipistePuhelinnro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toimipisteBindingSource, "puhelinnro", true));
            this.txbToimipistePuhelinnro.Location = new System.Drawing.Point(374, 127);
            this.txbToimipistePuhelinnro.Margin = new System.Windows.Forms.Padding(2);
            this.txbToimipistePuhelinnro.MaxLength = 15;
            this.txbToimipistePuhelinnro.Name = "txbToimipistePuhelinnro";
            this.txbToimipistePuhelinnro.Size = new System.Drawing.Size(129, 20);
            this.txbToimipistePuhelinnro.TabIndex = 7;
            this.txbToimipistePuhelinnro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.puhelinnroTextBox_KeyPress);
            // 
            // toimipisteDataGridView
            // 
            this.toimipisteDataGridView.AllowUserToAddRows = false;
            this.toimipisteDataGridView.AllowUserToDeleteRows = false;
            this.toimipisteDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toimipisteDataGridView.AutoGenerateColumns = false;
            this.toimipisteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.toimipisteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toimipisteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.toimipisteDataGridView.DataSource = this.toimipisteBindingSource;
            this.toimipisteDataGridView.Location = new System.Drawing.Point(4, 158);
            this.toimipisteDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.toimipisteDataGridView.MultiSelect = false;
            this.toimipisteDataGridView.Name = "toimipisteDataGridView";
            this.toimipisteDataGridView.ReadOnly = true;
            this.toimipisteDataGridView.RowTemplate.Height = 33;
            this.toimipisteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toimipisteDataGridView.Size = new System.Drawing.Size(666, 413);
            this.toimipisteDataGridView.TabIndex = 16;
            this.toimipisteDataGridView.TabStop = false;
            this.toimipisteDataGridView.SelectionChanged += new System.EventHandler(this.toimipisteDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "toimipiste_id";
            this.dataGridViewTextBoxColumn9.HeaderText = "Id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "nimi";
            this.dataGridViewTextBoxColumn10.HeaderText = "Nimi";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "lahiosoite";
            this.dataGridViewTextBoxColumn11.HeaderText = "Lähiosoite";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "postinro";
            this.dataGridViewTextBoxColumn13.HeaderText = "Postinumero";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "postitoimipaikka";
            this.dataGridViewTextBoxColumn12.HeaderText = "Postitoimipaikka";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn14.HeaderText = "Email";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "puhelinnro";
            this.dataGridViewTextBoxColumn15.HeaderText = "Puhelinnumero";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // btnPeruutaToimipiste
            // 
            this.btnPeruutaToimipiste.Enabled = false;
            this.btnPeruutaToimipiste.Location = new System.Drawing.Point(533, 62);
            this.btnPeruutaToimipiste.Margin = new System.Windows.Forms.Padding(2);
            this.btnPeruutaToimipiste.Name = "btnPeruutaToimipiste";
            this.btnPeruutaToimipiste.Size = new System.Drawing.Size(118, 27);
            this.btnPeruutaToimipiste.TabIndex = 11;
            this.btnPeruutaToimipiste.Text = "Peruuta";
            this.btnPeruutaToimipiste.UseVisualStyleBackColor = true;
            this.btnPeruutaToimipiste.Visible = false;
            this.btnPeruutaToimipiste.Click += new System.EventHandler(this.btnPeruutaToimipiste_Click);
            // 
            // btnPoistaToimipiste
            // 
            this.btnPoistaToimipiste.Location = new System.Drawing.Point(533, 92);
            this.btnPoistaToimipiste.Margin = new System.Windows.Forms.Padding(2);
            this.btnPoistaToimipiste.Name = "btnPoistaToimipiste";
            this.btnPoistaToimipiste.Size = new System.Drawing.Size(118, 27);
            this.btnPoistaToimipiste.TabIndex = 10;
            this.btnPoistaToimipiste.Text = "Poista toimipiste";
            this.btnPoistaToimipiste.UseVisualStyleBackColor = true;
            this.btnPoistaToimipiste.Click += new System.EventHandler(this.btnPoistaToimipiste_Click);
            // 
            // tabPagePalveluhallinta
            // 
            this.tabPagePalveluhallinta.Controls.Add(this.grpPHValitsePalvelutyyppi);
            this.tabPagePalveluhallinta.Controls.Add(this.palveluDataGridView1);
            this.tabPagePalveluhallinta.Controls.Add(this.grpPHPalveluhallintaMuokkaa);
            this.tabPagePalveluhallinta.Controls.Add(this.grpPHValitseToimipiste);
            this.tabPagePalveluhallinta.Location = new System.Drawing.Point(4, 22);
            this.tabPagePalveluhallinta.Name = "tabPagePalveluhallinta";
            this.tabPagePalveluhallinta.Size = new System.Drawing.Size(677, 575);
            this.tabPagePalveluhallinta.TabIndex = 7;
            this.tabPagePalveluhallinta.Text = "Palveluhallinta";
            this.tabPagePalveluhallinta.UseVisualStyleBackColor = true;
            // 
            // grpPHValitsePalvelutyyppi
            // 
            this.grpPHValitsePalvelutyyppi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPHValitsePalvelutyyppi.Controls.Add(this.radioPHPalveluKaikki);
            this.grpPHValitsePalvelutyyppi.Controls.Add(this.radioPHPalveluMajoitukset);
            this.grpPHValitsePalvelutyyppi.Controls.Add(this.radioPHPalveluMuut);
            this.grpPHValitsePalvelutyyppi.Location = new System.Drawing.Point(351, 10);
            this.grpPHValitsePalvelutyyppi.Name = "grpPHValitsePalvelutyyppi";
            this.grpPHValitsePalvelutyyppi.Size = new System.Drawing.Size(317, 59);
            this.grpPHValitsePalvelutyyppi.TabIndex = 2;
            this.grpPHValitsePalvelutyyppi.TabStop = false;
            this.grpPHValitsePalvelutyyppi.Text = "2. Valitse palvelutyyppi";
            // 
            // radioPHPalveluKaikki
            // 
            this.radioPHPalveluKaikki.AutoSize = true;
            this.radioPHPalveluKaikki.Checked = true;
            this.radioPHPalveluKaikki.Location = new System.Drawing.Point(13, 22);
            this.radioPHPalveluKaikki.Margin = new System.Windows.Forms.Padding(2);
            this.radioPHPalveluKaikki.Name = "radioPHPalveluKaikki";
            this.radioPHPalveluKaikki.Size = new System.Drawing.Size(54, 17);
            this.radioPHPalveluKaikki.TabIndex = 4;
            this.radioPHPalveluKaikki.TabStop = true;
            this.radioPHPalveluKaikki.Text = "Kaikki";
            this.radioPHPalveluKaikki.UseVisualStyleBackColor = true;
            this.radioPHPalveluKaikki.Click += new System.EventHandler(this.PaivitaPalveluDataDrid);
            // 
            // radioPHPalveluMajoitukset
            // 
            this.radioPHPalveluMajoitukset.AutoSize = true;
            this.radioPHPalveluMajoitukset.Location = new System.Drawing.Point(95, 22);
            this.radioPHPalveluMajoitukset.Margin = new System.Windows.Forms.Padding(2);
            this.radioPHPalveluMajoitukset.Name = "radioPHPalveluMajoitukset";
            this.radioPHPalveluMajoitukset.Size = new System.Drawing.Size(79, 17);
            this.radioPHPalveluMajoitukset.TabIndex = 0;
            this.radioPHPalveluMajoitukset.Text = "Majoitukset";
            this.radioPHPalveluMajoitukset.UseVisualStyleBackColor = true;
            this.radioPHPalveluMajoitukset.Click += new System.EventHandler(this.PaivitaPalveluDataDrid);
            // 
            // radioPHPalveluMuut
            // 
            this.radioPHPalveluMuut.AutoSize = true;
            this.radioPHPalveluMuut.Location = new System.Drawing.Point(201, 22);
            this.radioPHPalveluMuut.Margin = new System.Windows.Forms.Padding(2);
            this.radioPHPalveluMuut.Name = "radioPHPalveluMuut";
            this.radioPHPalveluMuut.Size = new System.Drawing.Size(89, 17);
            this.radioPHPalveluMuut.TabIndex = 1;
            this.radioPHPalveluMuut.Text = "Muut palvelut";
            this.radioPHPalveluMuut.UseVisualStyleBackColor = true;
            this.radioPHPalveluMuut.Click += new System.EventHandler(this.PaivitaPalveluDataDrid);
            // 
            // palveluDataGridView1
            // 
            this.palveluDataGridView1.AllowUserToAddRows = false;
            this.palveluDataGridView1.AllowUserToDeleteRows = false;
            this.palveluDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.palveluDataGridView1.AutoGenerateColumns = false;
            this.palveluDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.palveluDataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.palveluDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.palveluDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn45});
            this.palveluDataGridView1.DataSource = this.palveluBindingSource;
            this.palveluDataGridView1.Location = new System.Drawing.Point(14, 193);
            this.palveluDataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.palveluDataGridView1.MultiSelect = false;
            this.palveluDataGridView1.Name = "palveluDataGridView1";
            this.palveluDataGridView1.ReadOnly = true;
            this.palveluDataGridView1.RowTemplate.Height = 33;
            this.palveluDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.palveluDataGridView1.Size = new System.Drawing.Size(660, 380);
            this.palveluDataGridView1.TabIndex = 18;
            this.palveluDataGridView1.TabStop = false;
            this.palveluDataGridView1.SelectionChanged += new System.EventHandler(this.palveluDataGridView1_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "palvelu_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nimi";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nimi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "kuvaus";
            this.dataGridViewTextBoxColumn7.HeaderText = "Kuvaus";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "hinta";
            this.dataGridViewTextBoxColumn8.HeaderText = "Hinta";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "alv";
            this.dataGridViewTextBoxColumn45.HeaderText = "ALV";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataMember = "Palvelu";
            this.palveluBindingSource.DataSource = this.villagepDataSet;
            // 
            // grpPHPalveluhallintaMuokkaa
            // 
            this.grpPHPalveluhallintaMuokkaa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPHPalveluhallintaMuokkaa.Controls.Add(this.btnPHLisaaUusiPalvelu);
            this.grpPHPalveluhallintaMuokkaa.Controls.Add(this.btnPHTallennaPalvelu);
            this.grpPHPalveluhallintaMuokkaa.Controls.Add(lblPHPalvelunhinta);
            this.grpPHPalveluhallintaMuokkaa.Controls.Add(lblPHPalvelunnimi);
            this.grpPHPalveluhallintaMuokkaa.Controls.Add(lblPHPalvelunAlvProsentti);
            this.grpPHPalveluhallintaMuokkaa.Controls.Add(this.txbPHPalvelunNimi);
            this.grpPHPalveluhallintaMuokkaa.Controls.Add(this.txbPHPalvelunAlv);
            this.grpPHPalveluhallintaMuokkaa.Controls.Add(this.txbPHPalvelunAlvProsentti);
            this.grpPHPalveluhallintaMuokkaa.Controls.Add(lblPHPalvelunkuvaus);
            this.grpPHPalveluhallintaMuokkaa.Controls.Add(lblPHPalvelunAlv);
            this.grpPHPalveluhallintaMuokkaa.Controls.Add(this.txbPHPalvelunKuvaus);
            this.grpPHPalveluhallintaMuokkaa.Controls.Add(this.txbPHPalvelunHinta);
            this.grpPHPalveluhallintaMuokkaa.Controls.Add(this.btnPHPeruuta);
            this.grpPHPalveluhallintaMuokkaa.Controls.Add(this.btnPHPoistaPalvelu);
            this.grpPHPalveluhallintaMuokkaa.Location = new System.Drawing.Point(14, 74);
            this.grpPHPalveluhallintaMuokkaa.Margin = new System.Windows.Forms.Padding(2);
            this.grpPHPalveluhallintaMuokkaa.Name = "grpPHPalveluhallintaMuokkaa";
            this.grpPHPalveluhallintaMuokkaa.Padding = new System.Windows.Forms.Padding(2);
            this.grpPHPalveluhallintaMuokkaa.Size = new System.Drawing.Size(654, 115);
            this.grpPHPalveluhallintaMuokkaa.TabIndex = 17;
            this.grpPHPalveluhallintaMuokkaa.TabStop = false;
            this.grpPHPalveluhallintaMuokkaa.Text = "3. Muokkaa palvelua";
            // 
            // btnPHLisaaUusiPalvelu
            // 
            this.btnPHLisaaUusiPalvelu.Location = new System.Drawing.Point(490, 47);
            this.btnPHLisaaUusiPalvelu.Margin = new System.Windows.Forms.Padding(2);
            this.btnPHLisaaUusiPalvelu.Name = "btnPHLisaaUusiPalvelu";
            this.btnPHLisaaUusiPalvelu.Size = new System.Drawing.Size(90, 22);
            this.btnPHLisaaUusiPalvelu.TabIndex = 17;
            this.btnPHLisaaUusiPalvelu.Text = "Lisää uusi";
            this.btnPHLisaaUusiPalvelu.UseVisualStyleBackColor = true;
            this.btnPHLisaaUusiPalvelu.Click += new System.EventHandler(this.btnPHLisaaUusiPalvelu_Click);
            // 
            // btnPHTallennaPalvelu
            // 
            this.btnPHTallennaPalvelu.Location = new System.Drawing.Point(490, 16);
            this.btnPHTallennaPalvelu.Margin = new System.Windows.Forms.Padding(2);
            this.btnPHTallennaPalvelu.Name = "btnPHTallennaPalvelu";
            this.btnPHTallennaPalvelu.Size = new System.Drawing.Size(90, 22);
            this.btnPHTallennaPalvelu.TabIndex = 16;
            this.btnPHTallennaPalvelu.Text = "Tallenna";
            this.btnPHTallennaPalvelu.UseVisualStyleBackColor = true;
            this.btnPHTallennaPalvelu.Click += new System.EventHandler(this.btnPHTallennaPalvelu_Click);
            // 
            // txbPHPalvelunNimi
            // 
            this.txbPHPalvelunNimi.Location = new System.Drawing.Point(64, 19);
            this.txbPHPalvelunNimi.Margin = new System.Windows.Forms.Padding(2);
            this.txbPHPalvelunNimi.MaxLength = 40;
            this.txbPHPalvelunNimi.Name = "txbPHPalvelunNimi";
            this.txbPHPalvelunNimi.Size = new System.Drawing.Size(249, 20);
            this.txbPHPalvelunNimi.TabIndex = 5;
            // 
            // txbPHPalvelunAlv
            // 
            this.txbPHPalvelunAlv.Enabled = false;
            this.txbPHPalvelunAlv.Location = new System.Drawing.Point(386, 66);
            this.txbPHPalvelunAlv.Margin = new System.Windows.Forms.Padding(2);
            this.txbPHPalvelunAlv.Name = "txbPHPalvelunAlv";
            this.txbPHPalvelunAlv.ReadOnly = true;
            this.txbPHPalvelunAlv.Size = new System.Drawing.Size(70, 20);
            this.txbPHPalvelunAlv.TabIndex = 13;
            this.txbPHPalvelunAlv.TabStop = false;
            // 
            // txbPHPalvelunAlvProsentti
            // 
            this.txbPHPalvelunAlvProsentti.Location = new System.Drawing.Point(386, 42);
            this.txbPHPalvelunAlvProsentti.Margin = new System.Windows.Forms.Padding(2);
            this.txbPHPalvelunAlvProsentti.MaxLength = 2;
            this.txbPHPalvelunAlvProsentti.Name = "txbPHPalvelunAlvProsentti";
            this.txbPHPalvelunAlvProsentti.Size = new System.Drawing.Size(70, 20);
            this.txbPHPalvelunAlvProsentti.TabIndex = 15;
            this.txbPHPalvelunAlvProsentti.TextChanged += new System.EventHandler(this.txbPHPalvelunHinta_TextChanged);
            this.txbPHPalvelunAlvProsentti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPHPalvelunAlvProsentti_KeyPress);
            // 
            // txbPHPalvelunKuvaus
            // 
            this.txbPHPalvelunKuvaus.Location = new System.Drawing.Point(64, 42);
            this.txbPHPalvelunKuvaus.Margin = new System.Windows.Forms.Padding(2);
            this.txbPHPalvelunKuvaus.MaxLength = 255;
            this.txbPHPalvelunKuvaus.Multiline = true;
            this.txbPHPalvelunKuvaus.Name = "txbPHPalvelunKuvaus";
            this.txbPHPalvelunKuvaus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbPHPalvelunKuvaus.Size = new System.Drawing.Size(249, 61);
            this.txbPHPalvelunKuvaus.TabIndex = 9;
            // 
            // txbPHPalvelunHinta
            // 
            this.txbPHPalvelunHinta.Location = new System.Drawing.Point(386, 19);
            this.txbPHPalvelunHinta.Margin = new System.Windows.Forms.Padding(2);
            this.txbPHPalvelunHinta.MaxLength = 6;
            this.txbPHPalvelunHinta.Name = "txbPHPalvelunHinta";
            this.txbPHPalvelunHinta.Size = new System.Drawing.Size(70, 20);
            this.txbPHPalvelunHinta.TabIndex = 11;
            this.txbPHPalvelunHinta.TextChanged += new System.EventHandler(this.txbPHPalvelunHinta_TextChanged);
            this.txbPHPalvelunHinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPHPalvelunHinta_KeyPress);
            // 
            // btnPHPeruuta
            // 
            this.btnPHPeruuta.Enabled = false;
            this.btnPHPeruuta.Location = new System.Drawing.Point(490, 47);
            this.btnPHPeruuta.Margin = new System.Windows.Forms.Padding(2);
            this.btnPHPeruuta.Name = "btnPHPeruuta";
            this.btnPHPeruuta.Size = new System.Drawing.Size(90, 22);
            this.btnPHPeruuta.TabIndex = 19;
            this.btnPHPeruuta.Text = "Peruuta";
            this.btnPHPeruuta.UseVisualStyleBackColor = true;
            this.btnPHPeruuta.Visible = false;
            this.btnPHPeruuta.Click += new System.EventHandler(this.btnPHPeruuta_Click);
            // 
            // btnPHPoistaPalvelu
            // 
            this.btnPHPoistaPalvelu.Location = new System.Drawing.Point(490, 79);
            this.btnPHPoistaPalvelu.Margin = new System.Windows.Forms.Padding(2);
            this.btnPHPoistaPalvelu.Name = "btnPHPoistaPalvelu";
            this.btnPHPoistaPalvelu.Size = new System.Drawing.Size(90, 22);
            this.btnPHPoistaPalvelu.TabIndex = 18;
            this.btnPHPoistaPalvelu.Text = "Poista";
            this.btnPHPoistaPalvelu.UseVisualStyleBackColor = true;
            this.btnPHPoistaPalvelu.Click += new System.EventHandler(this.btnPHPoistaPalvelu_Click);
            // 
            // grpPHValitseToimipiste
            // 
            this.grpPHValitseToimipiste.Controls.Add(this.cmbPHToimipiste);
            this.grpPHValitseToimipiste.Location = new System.Drawing.Point(14, 10);
            this.grpPHValitseToimipiste.Margin = new System.Windows.Forms.Padding(2);
            this.grpPHValitseToimipiste.Name = "grpPHValitseToimipiste";
            this.grpPHValitseToimipiste.Padding = new System.Windows.Forms.Padding(2);
            this.grpPHValitseToimipiste.Size = new System.Drawing.Size(332, 59);
            this.grpPHValitseToimipiste.TabIndex = 1;
            this.grpPHValitseToimipiste.TabStop = false;
            this.grpPHValitseToimipiste.Text = "1. Valitse toimipiste, jonka palvelua muokkaat";
            // 
            // cmbPHToimipiste
            // 
            this.cmbPHToimipiste.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toimipistenimetBindingSource, "nimi", true));
            this.cmbPHToimipiste.DataSource = this.toimipistenimetBindingSource;
            this.cmbPHToimipiste.DisplayMember = "Nimi";
            this.cmbPHToimipiste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPHToimipiste.FormattingEnabled = true;
            this.cmbPHToimipiste.Location = new System.Drawing.Point(10, 19);
            this.cmbPHToimipiste.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPHToimipiste.Name = "cmbPHToimipiste";
            this.cmbPHToimipiste.Size = new System.Drawing.Size(278, 21);
            this.cmbPHToimipiste.TabIndex = 1;
            this.cmbPHToimipiste.ValueMember = "ID";
            this.cmbPHToimipiste.SelectedIndexChanged += new System.EventHandler(this.PaivitaPalveluDataDrid);
            // 
            // toimipistenimetBindingSource
            // 
            this.toimipistenimetBindingSource.DataMember = "Toimipistenimet";
            this.toimipistenimetBindingSource.DataSource = this.villagepDataSet;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.lblLaskunPalvelut);
            this.tabPage4.Controls.Add(this.laskunPalveluRivitDataGridView);
            this.tabPage4.Controls.Add(this.laskunTiedotDataGridView);
            this.tabPage4.Controls.Add(this.btnEmailUudelleen);
            this.tabPage4.Controls.Add(this.lblLaskuhistoriaLoppuPvm);
            this.tabPage4.Controls.Add(this.lblLaskuhistoriaAlkuPvm);
            this.tabPage4.Controls.Add(this.btnHaeLaskutushistoria);
            this.tabPage4.Controls.Add(this.laskutusKalenteriLoppu);
            this.tabPage4.Controls.Add(this.laskutusKalenteriAlku);
            this.tabPage4.Controls.Add(this.laskutushistoriaDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(677, 575);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Laskutushistoria";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // laskunPalveluRivitDataGridView
            // 
            this.laskunPalveluRivitDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laskunPalveluRivitDataGridView.AutoGenerateColumns = false;
            this.laskunPalveluRivitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laskunPalveluRivitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn81,
            this.dataGridViewTextBoxColumn83,
            this.dataGridViewTextBoxColumn84,
            this.dataGridViewTextBoxColumn85,
            this.dataGridViewTextBoxColumn86,
            this.dataGridViewTextBoxColumn89,
            this.dataGridViewTextBoxColumn90,
            this.dataGridViewTextBoxColumn91,
            this.dataGridViewTextBoxColumn92});
            this.laskunPalveluRivitDataGridView.DataSource = this.laskunOstotBindingSource;
            this.laskunPalveluRivitDataGridView.Location = new System.Drawing.Point(0, 479);
            this.laskunPalveluRivitDataGridView.Name = "laskunPalveluRivitDataGridView";
            this.laskunPalveluRivitDataGridView.Size = new System.Drawing.Size(669, 93);
            this.laskunPalveluRivitDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn81
            // 
            this.dataGridViewTextBoxColumn81.DataPropertyName = "VarausID";
            this.dataGridViewTextBoxColumn81.HeaderText = "VarausID";
            this.dataGridViewTextBoxColumn81.Name = "dataGridViewTextBoxColumn81";
            // 
            // dataGridViewTextBoxColumn83
            // 
            this.dataGridViewTextBoxColumn83.DataPropertyName = "PalveluID";
            this.dataGridViewTextBoxColumn83.HeaderText = "PalveluID";
            this.dataGridViewTextBoxColumn83.Name = "dataGridViewTextBoxColumn83";
            // 
            // dataGridViewTextBoxColumn84
            // 
            this.dataGridViewTextBoxColumn84.DataPropertyName = "Palvelu";
            this.dataGridViewTextBoxColumn84.HeaderText = "Palvelu";
            this.dataGridViewTextBoxColumn84.Name = "dataGridViewTextBoxColumn84";
            // 
            // dataGridViewTextBoxColumn85
            // 
            this.dataGridViewTextBoxColumn85.DataPropertyName = "Tyyppi";
            this.dataGridViewTextBoxColumn85.HeaderText = "Tyyppi";
            this.dataGridViewTextBoxColumn85.Name = "dataGridViewTextBoxColumn85";
            // 
            // dataGridViewTextBoxColumn86
            // 
            this.dataGridViewTextBoxColumn86.DataPropertyName = "Lkm";
            this.dataGridViewTextBoxColumn86.HeaderText = "Lkm";
            this.dataGridViewTextBoxColumn86.Name = "dataGridViewTextBoxColumn86";
            // 
            // dataGridViewTextBoxColumn89
            // 
            this.dataGridViewTextBoxColumn89.DataPropertyName = "Ahinta";
            this.dataGridViewTextBoxColumn89.HeaderText = "Ahinta";
            this.dataGridViewTextBoxColumn89.Name = "dataGridViewTextBoxColumn89";
            // 
            // dataGridViewTextBoxColumn90
            // 
            this.dataGridViewTextBoxColumn90.DataPropertyName = "ALV";
            this.dataGridViewTextBoxColumn90.HeaderText = "ALV";
            this.dataGridViewTextBoxColumn90.Name = "dataGridViewTextBoxColumn90";
            // 
            // dataGridViewTextBoxColumn91
            // 
            this.dataGridViewTextBoxColumn91.DataPropertyName = "Yhteensa";
            this.dataGridViewTextBoxColumn91.HeaderText = "Yhteensa";
            this.dataGridViewTextBoxColumn91.Name = "dataGridViewTextBoxColumn91";
            // 
            // dataGridViewTextBoxColumn92
            // 
            this.dataGridViewTextBoxColumn92.DataPropertyName = "YhteensaALV24";
            this.dataGridViewTextBoxColumn92.HeaderText = "YhteensaALV24";
            this.dataGridViewTextBoxColumn92.Name = "dataGridViewTextBoxColumn92";
            // 
            // laskunTiedotDataGridView
            // 
            this.laskunTiedotDataGridView.AllowUserToAddRows = false;
            this.laskunTiedotDataGridView.AllowUserToDeleteRows = false;
            this.laskunTiedotDataGridView.AutoGenerateColumns = false;
            this.laskunTiedotDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laskunTiedotDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn66,
            this.dataGridViewTextBoxColumn67,
            this.dataGridViewTextBoxColumn68,
            this.dataGridViewTextBoxColumn69,
            this.dataGridViewTextBoxColumn70,
            this.dataGridViewTextBoxColumn71,
            this.dataGridViewTextBoxColumn72,
            this.dataGridViewTextBoxColumn80,
            this.dataGridViewTextBoxColumn73,
            this.dataGridViewTextBoxColumn74,
            this.dataGridViewTextBoxColumn75,
            this.dataGridViewTextBoxColumn76,
            this.dataGridViewTextBoxColumn77,
            this.dataGridViewTextBoxColumn78,
            this.dataGridViewTextBoxColumn79});
            this.laskunTiedotDataGridView.DataSource = this.laskunTiedotBindingSource;
            this.laskunTiedotDataGridView.Location = new System.Drawing.Point(500, 147);
            this.laskunTiedotDataGridView.Name = "laskunTiedotDataGridView";
            this.laskunTiedotDataGridView.ReadOnly = true;
            this.laskunTiedotDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.laskunTiedotDataGridView.Size = new System.Drawing.Size(113, 54);
            this.laskunTiedotDataGridView.TabIndex = 7;
            this.laskunTiedotDataGridView.TabStop = false;
            this.laskunTiedotDataGridView.Visible = false;
            this.laskunTiedotDataGridView.SelectionChanged += new System.EventHandler(this.laskunTiedotDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "lasku_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "lasku_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn66
            // 
            this.dataGridViewTextBoxColumn66.DataPropertyName = "varaus_id";
            this.dataGridViewTextBoxColumn66.HeaderText = "varaus_id";
            this.dataGridViewTextBoxColumn66.Name = "dataGridViewTextBoxColumn66";
            this.dataGridViewTextBoxColumn66.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn67
            // 
            this.dataGridViewTextBoxColumn67.DataPropertyName = "asiakas_id";
            this.dataGridViewTextBoxColumn67.HeaderText = "asiakas_id";
            this.dataGridViewTextBoxColumn67.Name = "dataGridViewTextBoxColumn67";
            this.dataGridViewTextBoxColumn67.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn68
            // 
            this.dataGridViewTextBoxColumn68.DataPropertyName = "Maksaja";
            this.dataGridViewTextBoxColumn68.HeaderText = "Maksaja";
            this.dataGridViewTextBoxColumn68.Name = "dataGridViewTextBoxColumn68";
            this.dataGridViewTextBoxColumn68.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn69
            // 
            this.dataGridViewTextBoxColumn69.DataPropertyName = "lahiosoite";
            this.dataGridViewTextBoxColumn69.HeaderText = "lahiosoite";
            this.dataGridViewTextBoxColumn69.Name = "dataGridViewTextBoxColumn69";
            this.dataGridViewTextBoxColumn69.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn70
            // 
            this.dataGridViewTextBoxColumn70.DataPropertyName = "postinro";
            this.dataGridViewTextBoxColumn70.HeaderText = "postinro";
            this.dataGridViewTextBoxColumn70.Name = "dataGridViewTextBoxColumn70";
            this.dataGridViewTextBoxColumn70.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn71
            // 
            this.dataGridViewTextBoxColumn71.DataPropertyName = "postitoimipaikka";
            this.dataGridViewTextBoxColumn71.HeaderText = "postitoimipaikka";
            this.dataGridViewTextBoxColumn71.Name = "dataGridViewTextBoxColumn71";
            this.dataGridViewTextBoxColumn71.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn72
            // 
            this.dataGridViewTextBoxColumn72.DataPropertyName = "Asiakas";
            this.dataGridViewTextBoxColumn72.HeaderText = "Asiakas";
            this.dataGridViewTextBoxColumn72.Name = "dataGridViewTextBoxColumn72";
            this.dataGridViewTextBoxColumn72.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn80
            // 
            this.dataGridViewTextBoxColumn80.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn80.HeaderText = "email";
            this.dataGridViewTextBoxColumn80.Name = "dataGridViewTextBoxColumn80";
            this.dataGridViewTextBoxColumn80.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn73
            // 
            this.dataGridViewTextBoxColumn73.DataPropertyName = "Laskupvm";
            this.dataGridViewTextBoxColumn73.HeaderText = "Laskupvm";
            this.dataGridViewTextBoxColumn73.Name = "dataGridViewTextBoxColumn73";
            this.dataGridViewTextBoxColumn73.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn74
            // 
            this.dataGridViewTextBoxColumn74.DataPropertyName = "varattu_alkupvm";
            this.dataGridViewTextBoxColumn74.HeaderText = "varattu_alkupvm";
            this.dataGridViewTextBoxColumn74.Name = "dataGridViewTextBoxColumn74";
            this.dataGridViewTextBoxColumn74.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn75
            // 
            this.dataGridViewTextBoxColumn75.DataPropertyName = "varattu_loppupvm";
            this.dataGridViewTextBoxColumn75.HeaderText = "varattu_loppupvm";
            this.dataGridViewTextBoxColumn75.Name = "dataGridViewTextBoxColumn75";
            this.dataGridViewTextBoxColumn75.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn76
            // 
            this.dataGridViewTextBoxColumn76.DataPropertyName = "toimipiste_id";
            this.dataGridViewTextBoxColumn76.HeaderText = "toimipiste_id";
            this.dataGridViewTextBoxColumn76.Name = "dataGridViewTextBoxColumn76";
            this.dataGridViewTextBoxColumn76.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn77
            // 
            this.dataGridViewTextBoxColumn77.DataPropertyName = "Toimipiste";
            this.dataGridViewTextBoxColumn77.HeaderText = "Toimipiste";
            this.dataGridViewTextBoxColumn77.Name = "dataGridViewTextBoxColumn77";
            this.dataGridViewTextBoxColumn77.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn78
            // 
            this.dataGridViewTextBoxColumn78.DataPropertyName = "summa";
            this.dataGridViewTextBoxColumn78.HeaderText = "summa";
            this.dataGridViewTextBoxColumn78.Name = "dataGridViewTextBoxColumn78";
            this.dataGridViewTextBoxColumn78.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn79
            // 
            this.dataGridViewTextBoxColumn79.DataPropertyName = "alv";
            this.dataGridViewTextBoxColumn79.HeaderText = "alv";
            this.dataGridViewTextBoxColumn79.Name = "dataGridViewTextBoxColumn79";
            this.dataGridViewTextBoxColumn79.ReadOnly = true;
            // 
            // laskunTiedotBindingSource
            // 
            this.laskunTiedotBindingSource.DataMember = "LaskunTiedot";
            this.laskunTiedotBindingSource.DataSource = this.villagepDataSet;
            // 
            // btnEmailUudelleen
            // 
            this.btnEmailUudelleen.Location = new System.Drawing.Point(462, 99);
            this.btnEmailUudelleen.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmailUudelleen.Name = "btnEmailUudelleen";
            this.btnEmailUudelleen.Size = new System.Drawing.Size(128, 24);
            this.btnEmailUudelleen.TabIndex = 6;
            this.btnEmailUudelleen.Text = "Lähetä sähköpostilasku uudelleen";
            this.btnEmailUudelleen.UseVisualStyleBackColor = true;
            this.btnEmailUudelleen.Click += new System.EventHandler(this.btnEmailUudelleen_Click);
            // 
            // lblLaskuhistoriaLoppuPvm
            // 
            this.lblLaskuhistoriaLoppuPvm.AutoSize = true;
            this.lblLaskuhistoriaLoppuPvm.Location = new System.Drawing.Point(248, 29);
            this.lblLaskuhistoriaLoppuPvm.Name = "lblLaskuhistoriaLoppuPvm";
            this.lblLaskuhistoriaLoppuPvm.Size = new System.Drawing.Size(122, 13);
            this.lblLaskuhistoriaLoppuPvm.TabIndex = 5;
            this.lblLaskuhistoriaLoppuPvm.Text = "Valitse loppupäivämäärä";
            // 
            // lblLaskuhistoriaAlkuPvm
            // 
            this.lblLaskuhistoriaAlkuPvm.AutoSize = true;
            this.lblLaskuhistoriaAlkuPvm.Location = new System.Drawing.Point(15, 29);
            this.lblLaskuhistoriaAlkuPvm.Name = "lblLaskuhistoriaAlkuPvm";
            this.lblLaskuhistoriaAlkuPvm.Size = new System.Drawing.Size(116, 13);
            this.lblLaskuhistoriaAlkuPvm.TabIndex = 4;
            this.lblLaskuhistoriaAlkuPvm.Text = "Valitse alkupäivämäärä";
            // 
            // btnHaeLaskutushistoria
            // 
            this.btnHaeLaskutushistoria.Location = new System.Drawing.Point(462, 49);
            this.btnHaeLaskutushistoria.Margin = new System.Windows.Forms.Padding(6);
            this.btnHaeLaskutushistoria.Name = "btnHaeLaskutushistoria";
            this.btnHaeLaskutushistoria.Size = new System.Drawing.Size(134, 23);
            this.btnHaeLaskutushistoria.TabIndex = 3;
            this.btnHaeLaskutushistoria.Text = "Hae laskutushistoria";
            this.btnHaeLaskutushistoria.UseVisualStyleBackColor = true;
            this.btnHaeLaskutushistoria.Click += new System.EventHandler(this.btnHaeLaskutushistoria_Click);
            // 
            // laskutusKalenteriLoppu
            // 
            this.laskutusKalenteriLoppu.Location = new System.Drawing.Point(251, 49);
            this.laskutusKalenteriLoppu.Margin = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.laskutusKalenteriLoppu.MaxDate = new System.DateTime(2018, 5, 24, 0, 0, 0, 0);
            this.laskutusKalenteriLoppu.MaxSelectionCount = 1;
            this.laskutusKalenteriLoppu.Name = "laskutusKalenteriLoppu";
            this.laskutusKalenteriLoppu.ShowWeekNumbers = true;
            this.laskutusKalenteriLoppu.TabIndex = 2;
            this.laskutusKalenteriLoppu.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.laskutusKalenteriLoppu_DateChanged);
            // 
            // laskutusKalenteriAlku
            // 
            this.laskutusKalenteriAlku.Location = new System.Drawing.Point(18, 49);
            this.laskutusKalenteriAlku.Margin = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.laskutusKalenteriAlku.MaxDate = new System.DateTime(2018, 5, 24, 0, 0, 0, 0);
            this.laskutusKalenteriAlku.MaxSelectionCount = 1;
            this.laskutusKalenteriAlku.Name = "laskutusKalenteriAlku";
            this.laskutusKalenteriAlku.ShowToday = false;
            this.laskutusKalenteriAlku.ShowWeekNumbers = true;
            this.laskutusKalenteriAlku.TabIndex = 1;
            // 
            // laskutushistoriaDataGridView
            // 
            this.laskutushistoriaDataGridView.AllowUserToAddRows = false;
            this.laskutushistoriaDataGridView.AllowUserToDeleteRows = false;
            this.laskutushistoriaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laskutushistoriaDataGridView.AutoGenerateColumns = false;
            this.laskutushistoriaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.laskutushistoriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laskutushistoriaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LaskuID,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.email,
            this.dataGridViewTextBoxColumn44});
            this.laskutushistoriaDataGridView.DataSource = this.laskutushistoriaBindingSource;
            this.laskutushistoriaDataGridView.Location = new System.Drawing.Point(0, 260);
            this.laskutushistoriaDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.laskutushistoriaDataGridView.MultiSelect = false;
            this.laskutushistoriaDataGridView.Name = "laskutushistoriaDataGridView";
            this.laskutushistoriaDataGridView.ReadOnly = true;
            this.laskutushistoriaDataGridView.RowTemplate.Height = 33;
            this.laskutushistoriaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.laskutushistoriaDataGridView.Size = new System.Drawing.Size(673, 188);
            this.laskutushistoriaDataGridView.TabIndex = 0;
            this.laskutushistoriaDataGridView.SelectionChanged += new System.EventHandler(this.laskutushistoriaDataGridView_SelectionChanged);
            // 
            // LaskuID
            // 
            this.LaskuID.DataPropertyName = "LaskuID";
            this.LaskuID.HeaderText = "LaskuID";
            this.LaskuID.Name = "LaskuID";
            this.LaskuID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Laskutusasiakas";
            this.dataGridViewTextBoxColumn36.HeaderText = "Laskutusasiakas";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "lahiosoite";
            this.dataGridViewTextBoxColumn37.HeaderText = "Lähiosoite";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "postitoimipaikka";
            this.dataGridViewTextBoxColumn38.HeaderText = "Postitoimipaikka";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "postinro";
            this.dataGridViewTextBoxColumn39.HeaderText = "Postinumero";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "summa";
            this.dataGridViewTextBoxColumn40.HeaderText = "Summa";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "alv";
            this.dataGridViewTextBoxColumn41.HeaderText = "ALV";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "sukunimi";
            this.dataGridViewTextBoxColumn42.HeaderText = "Sukunimi";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "etunimi";
            this.dataGridViewTextBoxColumn43.HeaderText = "Etunimi";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "Laskupvm";
            this.dataGridViewTextBoxColumn44.HeaderText = "Laskupvm";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            // 
            // laskutushistoriaBindingSource
            // 
            this.laskutushistoriaBindingSource.DataMember = "Laskutushistoria";
            this.laskutushistoriaBindingSource.DataSource = this.villagepDataSet;
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.Controls.Add(this.palveluhistoria2DataGridView);
            this.tabPage5.Controls.Add(this.grpPalveluhistoria);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(677, 575);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Palveluhistoria";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // palveluhistoria2DataGridView
            // 
            this.palveluhistoria2DataGridView.AllowUserToAddRows = false;
            this.palveluhistoria2DataGridView.AllowUserToDeleteRows = false;
            this.palveluhistoria2DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.palveluhistoria2DataGridView.AutoGenerateColumns = false;
            this.palveluhistoria2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.palveluhistoria2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.palveluhistoria2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn65});
            this.palveluhistoria2DataGridView.DataSource = this.palveluhistoria2BindingSource;
            this.palveluhistoria2DataGridView.Location = new System.Drawing.Point(4, 334);
            this.palveluhistoria2DataGridView.MultiSelect = false;
            this.palveluhistoria2DataGridView.Name = "palveluhistoria2DataGridView";
            this.palveluhistoria2DataGridView.ReadOnly = true;
            this.palveluhistoria2DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.palveluhistoria2DataGridView.Size = new System.Drawing.Size(665, 238);
            this.palveluhistoria2DataGridView.TabIndex = 3;
            this.palveluhistoria2DataGridView.TabStop = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "palvelu_id";
            this.dataGridViewTextBoxColumn16.HeaderText = "PalveluID";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Palvelunimi";
            this.dataGridViewTextBoxColumn17.HeaderText = "Palvelu";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Toimipistenimi";
            this.dataGridViewTextBoxColumn18.HeaderText = "Toimipiste";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Tyyppi";
            this.dataGridViewTextBoxColumn19.HeaderText = "Tyyppi";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "lkm";
            this.dataGridViewTextBoxColumn20.HeaderText = "Lkm";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Pvm";
            this.dataGridViewTextBoxColumn21.HeaderText = "Päivämäärä";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "summa";
            this.dataGridViewTextBoxColumn22.HeaderText = "Summa";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.DataPropertyName = "alv";
            this.dataGridViewTextBoxColumn65.HeaderText = "ALV";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            this.dataGridViewTextBoxColumn65.ReadOnly = true;
            // 
            // palveluhistoria2BindingSource
            // 
            this.palveluhistoria2BindingSource.DataMember = "Palveluhistoria2";
            this.palveluhistoria2BindingSource.DataSource = this.villagepDataSet;
            // 
            // grpPalveluhistoria
            // 
            this.grpPalveluhistoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPalveluhistoria.Controls.Add(this.lblHistoriaAlv);
            this.grpPalveluhistoria.Controls.Add(this.lblHistoriaSumma);
            this.grpPalveluhistoria.Controls.Add(this.lblHistoriaLkm);
            this.grpPalveluhistoria.Controls.Add(this.txbHistoriaAlv);
            this.grpPalveluhistoria.Controls.Add(this.txbHistoriaSumma);
            this.grpPalveluhistoria.Controls.Add(this.txbHistoriaLkm);
            this.grpPalveluhistoria.Controls.Add(this.btnHaePalveluRaportti);
            this.grpPalveluhistoria.Controls.Add(this.grpPalveluhistoriaToimipiste);
            this.grpPalveluhistoria.Controls.Add(this.grpPalvelukalenteri);
            this.grpPalveluhistoria.Controls.Add(this.grpPalveluhistoriaValitseTyyppi);
            this.grpPalveluhistoria.Location = new System.Drawing.Point(4, 15);
            this.grpPalveluhistoria.Margin = new System.Windows.Forms.Padding(2);
            this.grpPalveluhistoria.Name = "grpPalveluhistoria";
            this.grpPalveluhistoria.Padding = new System.Windows.Forms.Padding(2);
            this.grpPalveluhistoria.Size = new System.Drawing.Size(670, 314);
            this.grpPalveluhistoria.TabIndex = 3;
            this.grpPalveluhistoria.TabStop = false;
            this.grpPalveluhistoria.Text = "Tutki palvelu- ja majoitushistoriaa";
            // 
            // lblHistoriaAlv
            // 
            this.lblHistoriaAlv.AutoSize = true;
            this.lblHistoriaAlv.Location = new System.Drawing.Point(418, 240);
            this.lblHistoriaAlv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHistoriaAlv.Name = "lblHistoriaAlv";
            this.lblHistoriaAlv.Size = new System.Drawing.Size(27, 13);
            this.lblHistoriaAlv.TabIndex = 12;
            this.lblHistoriaAlv.Text = "ALV";
            // 
            // lblHistoriaSumma
            // 
            this.lblHistoriaSumma.AutoSize = true;
            this.lblHistoriaSumma.Location = new System.Drawing.Point(313, 240);
            this.lblHistoriaSumma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHistoriaSumma.Name = "lblHistoriaSumma";
            this.lblHistoriaSumma.Size = new System.Drawing.Size(42, 13);
            this.lblHistoriaSumma.TabIndex = 11;
            this.lblHistoriaSumma.Text = "Summa";
            // 
            // lblHistoriaLkm
            // 
            this.lblHistoriaLkm.AutoSize = true;
            this.lblHistoriaLkm.Location = new System.Drawing.Point(202, 240);
            this.lblHistoriaLkm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHistoriaLkm.Name = "lblHistoriaLkm";
            this.lblHistoriaLkm.Size = new System.Drawing.Size(60, 13);
            this.lblHistoriaLkm.TabIndex = 4;
            this.lblHistoriaLkm.Text = "Lukumäärä";
            // 
            // txbHistoriaAlv
            // 
            this.txbHistoriaAlv.Location = new System.Drawing.Point(416, 261);
            this.txbHistoriaAlv.Name = "txbHistoriaAlv";
            this.txbHistoriaAlv.Size = new System.Drawing.Size(100, 20);
            this.txbHistoriaAlv.TabIndex = 10;
            // 
            // txbHistoriaSumma
            // 
            this.txbHistoriaSumma.Location = new System.Drawing.Point(310, 261);
            this.txbHistoriaSumma.Name = "txbHistoriaSumma";
            this.txbHistoriaSumma.Size = new System.Drawing.Size(100, 20);
            this.txbHistoriaSumma.TabIndex = 9;
            // 
            // txbHistoriaLkm
            // 
            this.txbHistoriaLkm.Location = new System.Drawing.Point(204, 261);
            this.txbHistoriaLkm.Name = "txbHistoriaLkm";
            this.txbHistoriaLkm.Size = new System.Drawing.Size(100, 20);
            this.txbHistoriaLkm.TabIndex = 8;
            // 
            // btnHaePalveluRaportti
            // 
            this.btnHaePalveluRaportti.Location = new System.Drawing.Point(26, 251);
            this.btnHaePalveluRaportti.Name = "btnHaePalveluRaportti";
            this.btnHaePalveluRaportti.Size = new System.Drawing.Size(98, 38);
            this.btnHaePalveluRaportti.TabIndex = 7;
            this.btnHaePalveluRaportti.Text = "Hae palveluraportti";
            this.btnHaePalveluRaportti.UseVisualStyleBackColor = true;
            this.btnHaePalveluRaportti.Click += new System.EventHandler(this.btnHaePalveluRaportti_Click);
            // 
            // grpPalveluhistoriaToimipiste
            // 
            this.grpPalveluhistoriaToimipiste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPalveluhistoriaToimipiste.Controls.Add(this.lsbPalveluhistoriaToimipisteet);
            this.grpPalveluhistoriaToimipiste.Location = new System.Drawing.Point(408, 98);
            this.grpPalveluhistoriaToimipiste.Name = "grpPalveluhistoriaToimipiste";
            this.grpPalveluhistoriaToimipiste.Size = new System.Drawing.Size(266, 129);
            this.grpPalveluhistoriaToimipiste.TabIndex = 6;
            this.grpPalveluhistoriaToimipiste.TabStop = false;
            this.grpPalveluhistoriaToimipiste.Text = "3. valitse yksi toimipiste";
            // 
            // lsbPalveluhistoriaToimipisteet
            // 
            this.lsbPalveluhistoriaToimipisteet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbPalveluhistoriaToimipisteet.DataSource = this.toimipistenimetBindingSource;
            this.lsbPalveluhistoriaToimipisteet.DisplayMember = "Nimi";
            this.lsbPalveluhistoriaToimipisteet.FormattingEnabled = true;
            this.lsbPalveluhistoriaToimipisteet.Location = new System.Drawing.Point(6, 19);
            this.lsbPalveluhistoriaToimipisteet.Name = "lsbPalveluhistoriaToimipisteet";
            this.lsbPalveluhistoriaToimipisteet.Size = new System.Drawing.Size(254, 95);
            this.lsbPalveluhistoriaToimipisteet.TabIndex = 5;
            this.lsbPalveluhistoriaToimipisteet.ValueMember = "ID";
            this.lsbPalveluhistoriaToimipisteet.SelectedIndexChanged += new System.EventHandler(this.lsbPalveluhistoriaToimipisteet_SelectedIndexChanged);
            // 
            // grpPalvelukalenteri
            // 
            this.grpPalvelukalenteri.Controls.Add(this.palvelukalenteriLoppu);
            this.grpPalvelukalenteri.Controls.Add(this.palvelukalenteriAlku);
            this.grpPalvelukalenteri.Location = new System.Drawing.Point(3, 33);
            this.grpPalvelukalenteri.Margin = new System.Windows.Forms.Padding(2);
            this.grpPalvelukalenteri.Name = "grpPalvelukalenteri";
            this.grpPalvelukalenteri.Padding = new System.Windows.Forms.Padding(2);
            this.grpPalvelukalenteri.Size = new System.Drawing.Size(400, 194);
            this.grpPalvelukalenteri.TabIndex = 4;
            this.grpPalvelukalenteri.TabStop = false;
            this.grpPalvelukalenteri.Text = "1. Valitse raportin alku- ja loppupäivät";
            // 
            // palvelukalenteriLoppu
            // 
            this.palvelukalenteriLoppu.Location = new System.Drawing.Point(201, 24);
            this.palvelukalenteriLoppu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.palvelukalenteriLoppu.MaxDate = new System.DateTime(2018, 5, 24, 0, 0, 0, 0);
            this.palvelukalenteriLoppu.MaxSelectionCount = 1;
            this.palvelukalenteriLoppu.Name = "palvelukalenteriLoppu";
            this.palvelukalenteriLoppu.ShowWeekNumbers = true;
            this.palvelukalenteriLoppu.TabIndex = 2;
            this.palvelukalenteriLoppu.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.palvelukalenteriLoppu_DateSelected);
            // 
            // palvelukalenteriAlku
            // 
            this.palvelukalenteriAlku.Location = new System.Drawing.Point(2, 15);
            this.palvelukalenteriAlku.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.palvelukalenteriAlku.MaxDate = new System.DateTime(2018, 5, 24, 0, 0, 0, 0);
            this.palvelukalenteriAlku.MaxSelectionCount = 1;
            this.palvelukalenteriAlku.Name = "palvelukalenteriAlku";
            this.palvelukalenteriAlku.ShowToday = false;
            this.palvelukalenteriAlku.ShowWeekNumbers = true;
            this.palvelukalenteriAlku.TabIndex = 1;
            this.palvelukalenteriAlku.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.palvelukalenteriAlku_DateChanged);
            // 
            // grpPalveluhistoriaValitseTyyppi
            // 
            this.grpPalveluhistoriaValitseTyyppi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPalveluhistoriaValitseTyyppi.Controls.Add(this.radioPalveluhistoriaKaikki);
            this.grpPalveluhistoriaValitseTyyppi.Controls.Add(this.radioPalveluhistoriaMajoitukset);
            this.grpPalveluhistoriaValitseTyyppi.Controls.Add(this.radioPalveluhistoriaMuutPalvelut);
            this.grpPalveluhistoriaValitseTyyppi.Location = new System.Drawing.Point(408, 33);
            this.grpPalveluhistoriaValitseTyyppi.Name = "grpPalveluhistoriaValitseTyyppi";
            this.grpPalveluhistoriaValitseTyyppi.Size = new System.Drawing.Size(257, 59);
            this.grpPalveluhistoriaValitseTyyppi.TabIndex = 3;
            this.grpPalveluhistoriaValitseTyyppi.TabStop = false;
            this.grpPalveluhistoriaValitseTyyppi.Text = "2. Valitse palvelutyyppi";
            // 
            // radioPalveluhistoriaKaikki
            // 
            this.radioPalveluhistoriaKaikki.AutoSize = true;
            this.radioPalveluhistoriaKaikki.Checked = true;
            this.radioPalveluhistoriaKaikki.Location = new System.Drawing.Point(13, 22);
            this.radioPalveluhistoriaKaikki.Margin = new System.Windows.Forms.Padding(2);
            this.radioPalveluhistoriaKaikki.Name = "radioPalveluhistoriaKaikki";
            this.radioPalveluhistoriaKaikki.Size = new System.Drawing.Size(54, 17);
            this.radioPalveluhistoriaKaikki.TabIndex = 4;
            this.radioPalveluhistoriaKaikki.TabStop = true;
            this.radioPalveluhistoriaKaikki.Text = "Kaikki";
            this.radioPalveluhistoriaKaikki.UseVisualStyleBackColor = true;
            // 
            // radioPalveluhistoriaMajoitukset
            // 
            this.radioPalveluhistoriaMajoitukset.AutoSize = true;
            this.radioPalveluhistoriaMajoitukset.Location = new System.Drawing.Point(73, 22);
            this.radioPalveluhistoriaMajoitukset.Margin = new System.Windows.Forms.Padding(2);
            this.radioPalveluhistoriaMajoitukset.Name = "radioPalveluhistoriaMajoitukset";
            this.radioPalveluhistoriaMajoitukset.Size = new System.Drawing.Size(79, 17);
            this.radioPalveluhistoriaMajoitukset.TabIndex = 0;
            this.radioPalveluhistoriaMajoitukset.Text = "Majoitukset";
            this.radioPalveluhistoriaMajoitukset.UseVisualStyleBackColor = true;
            // 
            // radioPalveluhistoriaMuutPalvelut
            // 
            this.radioPalveluhistoriaMuutPalvelut.AutoSize = true;
            this.radioPalveluhistoriaMuutPalvelut.Location = new System.Drawing.Point(158, 22);
            this.radioPalveluhistoriaMuutPalvelut.Margin = new System.Windows.Forms.Padding(2);
            this.radioPalveluhistoriaMuutPalvelut.Name = "radioPalveluhistoriaMuutPalvelut";
            this.radioPalveluhistoriaMuutPalvelut.Size = new System.Drawing.Size(89, 17);
            this.radioPalveluhistoriaMuutPalvelut.TabIndex = 1;
            this.radioPalveluhistoriaMuutPalvelut.Text = "Muut palvelut";
            this.radioPalveluhistoriaMuutPalvelut.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.lbSalasana);
            this.tabPage7.Controls.Add(this.lbKayttaja);
            this.tabPage7.Controls.Add(this.groupBox1);
            this.tabPage7.Controls.Add(this.btnPoista);
            this.tabPage7.Controls.Add(this.btnMuokkaa);
            this.tabPage7.Controls.Add(this.btnLisaa);
            this.tabPage7.Controls.Add(this.txbxSalasana);
            this.tabPage7.Controls.Add(this.cboxkayttajat);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(677, 575);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Käyttäjähallinta";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // lbSalasana
            // 
            this.lbSalasana.AutoSize = true;
            this.lbSalasana.Location = new System.Drawing.Point(44, 91);
            this.lbSalasana.Name = "lbSalasana";
            this.lbSalasana.Size = new System.Drawing.Size(51, 13);
            this.lbSalasana.TabIndex = 7;
            this.lbSalasana.Text = "Salasana";
            // 
            // lbKayttaja
            // 
            this.lbKayttaja.AutoSize = true;
            this.lbKayttaja.Location = new System.Drawing.Point(44, 39);
            this.lbKayttaja.Name = "lbKayttaja";
            this.lbKayttaja.Size = new System.Drawing.Size(63, 13);
            this.lbKayttaja.TabIndex = 6;
            this.lbKayttaja.Text = "Käyttäjänimi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnAdmin);
            this.groupBox1.Controls.Add(this.rbtnLaskutus);
            this.groupBox1.Controls.Add(this.rbtnKayttaja);
            this.groupBox1.Location = new System.Drawing.Point(232, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 107);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Käyttäjäluokka";
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Location = new System.Drawing.Point(22, 74);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(54, 17);
            this.rbtnAdmin.TabIndex = 2;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "Admin";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // rbtnLaskutus
            // 
            this.rbtnLaskutus.AutoSize = true;
            this.rbtnLaskutus.Location = new System.Drawing.Point(22, 51);
            this.rbtnLaskutus.Name = "rbtnLaskutus";
            this.rbtnLaskutus.Size = new System.Drawing.Size(68, 17);
            this.rbtnLaskutus.TabIndex = 1;
            this.rbtnLaskutus.TabStop = true;
            this.rbtnLaskutus.Text = "Laskutus";
            this.rbtnLaskutus.UseVisualStyleBackColor = true;
            // 
            // rbtnKayttaja
            // 
            this.rbtnKayttaja.AutoSize = true;
            this.rbtnKayttaja.Location = new System.Drawing.Point(22, 28);
            this.rbtnKayttaja.Name = "rbtnKayttaja";
            this.rbtnKayttaja.Size = new System.Drawing.Size(89, 17);
            this.rbtnKayttaja.TabIndex = 0;
            this.rbtnKayttaja.TabStop = true;
            this.rbtnKayttaja.Text = "Peruskäyttäjä";
            this.rbtnKayttaja.UseVisualStyleBackColor = true;
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(291, 170);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 23);
            this.btnPoista.TabIndex = 4;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(177, 170);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(75, 23);
            this.btnMuokkaa.TabIndex = 3;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(72, 170);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(75, 23);
            this.btnLisaa.TabIndex = 2;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // txbxSalasana
            // 
            this.txbxSalasana.Location = new System.Drawing.Point(47, 107);
            this.txbxSalasana.Name = "txbxSalasana";
            this.txbxSalasana.Size = new System.Drawing.Size(100, 20);
            this.txbxSalasana.TabIndex = 1;
            // 
            // cboxkayttajat
            // 
            this.cboxkayttajat.FormattingEnabled = true;
            this.cboxkayttajat.Location = new System.Drawing.Point(47, 55);
            this.cboxkayttajat.Name = "cboxkayttajat";
            this.cboxkayttajat.Size = new System.Drawing.Size(121, 21);
            this.cboxkayttajat.TabIndex = 0;
            this.cboxkayttajat.SelectedIndexChanged += new System.EventHandler(this.cboxkayttajat_SelectedIndexChanged);
            // 
            // ostoskorinLoppusummaBindingSource
            // 
            this.ostoskorinLoppusummaBindingSource.DataMember = "OstoskorinLoppusumma";
            this.ostoskorinLoppusummaBindingSource.DataSource = this.villagepDataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.ohjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kirjauduUlosToolStripMenuItem,
            this.lopetaToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // kirjauduUlosToolStripMenuItem
            // 
            this.kirjauduUlosToolStripMenuItem.Name = "kirjauduUlosToolStripMenuItem";
            this.kirjauduUlosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.kirjauduUlosToolStripMenuItem.Text = "Kirjaudu ulos";
            this.kirjauduUlosToolStripMenuItem.Click += new System.EventHandler(this.kirjauduUlosToolStripMenuItem_Click);
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.lopetaToolStripMenuItem.Text = "Lopeta";
            this.lopetaToolStripMenuItem.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // ohjeToolStripMenuItem
            // 
            this.ohjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ohjeToolStripMenuItem1,
            this.tietojaToolStripMenuItem});
            this.ohjeToolStripMenuItem.Name = "ohjeToolStripMenuItem";
            this.ohjeToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.ohjeToolStripMenuItem.Text = "Ohje";
            // 
            // ohjeToolStripMenuItem1
            // 
            this.ohjeToolStripMenuItem1.Name = "ohjeToolStripMenuItem1";
            this.ohjeToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.ohjeToolStripMenuItem1.Text = "Ohje";
            // 
            // tietojaToolStripMenuItem
            // 
            this.tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            this.tietojaToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.tietojaToolStripMenuItem.Text = "Tietoja";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1,
            this.statusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 633);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.statusStrip1.Size = new System.Drawing.Size(685, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel1
            // 
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(146, 17);
            this.statusLabel1.Text = "Tee uusi varaus asiakkaalle";
            // 
            // statusLabel2
            // 
            this.statusLabel2.Name = "statusLabel2";
            this.statusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // laskuBindingSource
            // 
            this.laskuBindingSource.DataMember = "Lasku";
            this.laskuBindingSource.DataSource = this.villagepDataSet;
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsiakasTableAdapter = this.asiakasTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LaskuTableAdapter = null;
            this.tableAdapterManager.PalveluTableAdapter = null;
            this.tableAdapterManager.ToimipisteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Paaikkuna.villagepDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Varauksen_palvelutTableAdapter = null;
            this.tableAdapterManager.VarausTableAdapter = null;
            // 
            // palveluTableAdapter
            // 
            this.palveluTableAdapter.ClearBeforeFill = true;
            // 
            // toimipisteTableAdapter
            // 
            this.toimipisteTableAdapter.ClearBeforeFill = true;
            // 
            // laskuttamattomatTableAdapter
            // 
            this.laskuttamattomatTableAdapter.ClearBeforeFill = true;
            // 
            // laskuTableAdapter
            // 
            this.laskuTableAdapter.ClearBeforeFill = true;
            // 
            // laskutushistoriaTableAdapter
            // 
            this.laskutushistoriaTableAdapter.ClearBeforeFill = true;
            // 
            // asiakastiedotTableAdapter
            // 
            this.asiakastiedotTableAdapter.ClearBeforeFill = true;
            // 
            // varausTableAdapter
            // 
            this.varausTableAdapter.ClearBeforeFill = true;
            // 
            // varauksen_palvelutTableAdapter
            // 
            this.varauksen_palvelutTableAdapter.ClearBeforeFill = true;
            // 
            // ostoskoriTableAdapter
            // 
            this.ostoskoriTableAdapter.ClearBeforeFill = true;
            // 
            // toimipistenimetTableAdapter
            // 
            this.toimipistenimetTableAdapter.ClearBeforeFill = true;
            // 
            // laskunOstotTableAdapter
            // 
            this.laskunOstotTableAdapter.ClearBeforeFill = true;
            // 
            // laskunLoppusummaBindingSource
            // 
            this.laskunLoppusummaBindingSource.DataSource = this.villagepDataSet;
            this.laskunLoppusummaBindingSource.Position = 0;
            // 
            // laskunLoppusummaTableAdapter
            // 
            this.laskunLoppusummaTableAdapter.ClearBeforeFill = true;
            // 
            // laskunLoppusummaBindingSource1
            // 
            this.laskunLoppusummaBindingSource1.DataSource = this.villagepDataSet;
            this.laskunLoppusummaBindingSource1.Position = 0;
            // 
            // laskunLoppusummaBindingSource2
            // 
            this.laskunLoppusummaBindingSource2.DataSource = this.villagepDataSet;
            this.laskunLoppusummaBindingSource2.Position = 0;
            // 
            // ostoskorinLoppusummaTableAdapter
            // 
            this.ostoskorinLoppusummaTableAdapter.ClearBeforeFill = true;
            // 
            // palveluhistoria2TableAdapter
            // 
            this.palveluhistoria2TableAdapter.ClearBeforeFill = true;
            // 
            // laskunTiedotTableAdapter
            // 
            this.laskunTiedotTableAdapter.ClearBeforeFill = true;
            // 
            // laskunTiedot2BindingSource
            // 
            this.laskunTiedot2BindingSource.DataSource = this.villagepDataSet;
            this.laskunTiedot2BindingSource.Position = 0;
            // 
            // laskunTiedot2TableAdapter
            // 
            this.laskunTiedot2TableAdapter.ClearBeforeFill = true;
            // 
            // lblLaskunPalvelut
            // 
            this.lblLaskunPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLaskunPalvelut.AutoSize = true;
            this.lblLaskunPalvelut.Location = new System.Drawing.Point(70, 460);
            this.lblLaskunPalvelut.Name = "lblLaskunPalvelut";
            this.lblLaskunPalvelut.Size = new System.Drawing.Size(118, 13);
            this.lblLaskunPalvelut.TabIndex = 9;
            this.lblLaskunPalvelut.Text = "Laskulla olevat palvelut";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Lähetä sähköposti Laskutushistoriasta";
            // 
            // frmPaaikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(685, 655);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPaaikkuna";
            this.Text = "Mökkivarausjärjestelmä";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPaaikkuna_FormClosing);
            this.Load += new System.EventHandler(this.frmPaaikkuna_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ostoskoriDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostoskoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villagepDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakastiedotDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakastiedotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHenkilotVaraus)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.grpLaskunYhteenveto.ResumeLayout(false);
            this.grpLaskunYhteenveto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laskuAsiakasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            this.grpLaskutusOsoite.ResumeLayout(false);
            this.grpLaskutusOsoite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laskunOstotDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskunOstotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuttamattomatDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuttamattomatBindingSource)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteDataGridView)).EndInit();
            this.tabPagePalveluhallinta.ResumeLayout(false);
            this.grpPHValitsePalvelutyyppi.ResumeLayout(false);
            this.grpPHValitsePalvelutyyppi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.palveluDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            this.grpPHPalveluhallintaMuokkaa.ResumeLayout(false);
            this.grpPHPalveluhallintaMuokkaa.PerformLayout();
            this.grpPHValitseToimipiste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toimipistenimetBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laskunPalveluRivitDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskunTiedotDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskunTiedotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskutushistoriaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskutushistoriaBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.palveluhistoria2DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluhistoria2BindingSource)).EndInit();
            this.grpPalveluhistoria.ResumeLayout(false);
            this.grpPalveluhistoria.PerformLayout();
            this.grpPalveluhistoriaToimipiste.ResumeLayout(false);
            this.grpPalvelukalenteri.ResumeLayout(false);
            this.grpPalveluhistoriaValitseTyyppi.ResumeLayout(false);
            this.grpPalveluhistoriaValitseTyyppi.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ostoskorinLoppusummaBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varauksen_palvelutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskunLoppusummaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskunLoppusummaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskunLoppusummaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluhistoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskunTiedot2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ohjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ohjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tietojaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel2;
        private villagepDataSet villagepDataSet;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private villagepDataSetTableAdapters.AsiakasTableAdapter asiakasTableAdapter;
        private villagepDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private villagepDataSetTableAdapters.PalveluTableAdapter palveluTableAdapter;
        private System.Windows.Forms.BindingSource toimipisteBindingSource;
        private villagepDataSetTableAdapters.ToimipisteTableAdapter toimipisteTableAdapter;
        private System.Windows.Forms.BindingSource laskuttamattomatBindingSource;
        private System.Windows.Forms.DataGridView laskuttamattomatDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private villagepDataSetTableAdapters.LaskuttamattomatTableAdapter laskuttamattomatTableAdapter;
        private System.Windows.Forms.BindingSource laskuBindingSource;
        private villagepDataSetTableAdapters.LaskuTableAdapter laskuTableAdapter;
        private System.Windows.Forms.BindingSource laskutushistoriaBindingSource;
        private villagepDataSetTableAdapters.LaskutushistoriaTableAdapter laskutushistoriaTableAdapter;
        private System.Windows.Forms.DataGridView laskutushistoriaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.MonthCalendar laskutusKalenteriAlku;
        private System.Windows.Forms.Button btnHaeLaskutushistoria;
        private System.Windows.Forms.MonthCalendar laskutusKalenteriLoppu;
        private System.Windows.Forms.Label lblLaskuhistoriaLoppuPvm;
        private System.Windows.Forms.Label lblLaskuhistoriaAlkuPvm;
        private System.Windows.Forms.ComboBox cbToimipisteVaraus;
        private System.Windows.Forms.NumericUpDown numHenkilotVaraus;
        private System.Windows.Forms.DateTimePicker dtpLopetusVaraus;
        private System.Windows.Forms.DateTimePicker dtpAloitusVaraus;
        private System.Windows.Forms.ComboBox cbPalveluVaraus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLisaaAsiakas;
        private System.Windows.Forms.Button btnPoistaAsiakas;
        private System.Windows.Forms.TextBox txbAsiakasEtunimi;
        private System.Windows.Forms.TextBox txbAsiakasSukunimi;
        private System.Windows.Forms.TextBox txbAsiakasLahiosoite;
        private System.Windows.Forms.TextBox txbAsiakasPostitoimipaikka;
        private System.Windows.Forms.TextBox txbAsiakasPostinro;
        private System.Windows.Forms.TextBox txbAsiakasEmail;
        private System.Windows.Forms.TextBox txbAsiakasPuhelinnro;
        private System.Windows.Forms.Button btnTallennaAsiakas;
        private System.Windows.Forms.Label lblHaeAsiakasta;
        private System.Windows.Forms.TextBox txbHaeAsiakas;
        private System.Windows.Forms.Button btnPoistaToimipiste;
        private System.Windows.Forms.Button btnLisaaToimipiste;
        private System.Windows.Forms.Button btnTallennaToimipiste;
        private System.Windows.Forms.TextBox txbToimipisteNimi;
        private System.Windows.Forms.TextBox txbToimipisteLahiosoite;
        private System.Windows.Forms.TextBox txbToimipistePostitoimipaikka;
        private System.Windows.Forms.TextBox txbToimipistePostinro;
        private System.Windows.Forms.TextBox txbToimipisteEmail;
        private System.Windows.Forms.TextBox txbToimipistePuhelinnro;
        private System.Windows.Forms.DataGridView toimipisteDataGridView;
        private System.Windows.Forms.DataGridView asiakasDataGridView;
        private System.Windows.Forms.Button btnTallennaVaraus;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label lbSalasana;
        private System.Windows.Forms.Label lbKayttaja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.RadioButton rbtnLaskutus;
        private System.Windows.Forms.RadioButton rbtnKayttaja;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.TextBox txbxSalasana;
        private System.Windows.Forms.ComboBox cboxkayttajat;
        private System.Windows.Forms.ToolStripMenuItem kirjauduUlosToolStripMenuItem;
        private System.Windows.Forms.Button btnLisaaTuote;
        private System.Windows.Forms.BindingSource ostoskoriBindingSource;
        private System.Windows.Forms.Button btnPeruutaAsiakas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAsiakasHaku;
        private System.Windows.Forms.BindingSource asiakastiedotBindingSource;
        private villagepDataSetTableAdapters.AsiakastiedotTableAdapter asiakastiedotTableAdapter;
        private System.Windows.Forms.Button btnAsiakashallintaan;
        private System.Windows.Forms.Button btnValitseAsiakas;
        private System.Windows.Forms.DataGridView asiakastiedotDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage tabPagePalveluhallinta;
        private System.Windows.Forms.GroupBox grpPHValitseToimipiste;
        private System.Windows.Forms.RadioButton radioPHPalveluMuut;
        private System.Windows.Forms.RadioButton radioPHPalveluMajoitukset;
        private System.Windows.Forms.GroupBox grpPHPalveluhallintaMuokkaa;
        private System.Windows.Forms.Button btnPHPoistaPalvelu;
        private System.Windows.Forms.Button btnPHLisaaUusiPalvelu;
        private System.Windows.Forms.Button btnPHTallennaPalvelu;
        private System.Windows.Forms.TextBox txbPHPalvelunNimi;
        private System.Windows.Forms.TextBox txbPHPalvelunAlv;
        private System.Windows.Forms.TextBox txbPHPalvelunAlvProsentti;
        private System.Windows.Forms.TextBox txbPHPalvelunKuvaus;
        private System.Windows.Forms.TextBox txbPHPalvelunHinta;
        private System.Windows.Forms.DataGridView palveluDataGridView1;
        private System.Windows.Forms.RadioButton radioPHPalveluKaikki;
        private System.Windows.Forms.Button btnPeruutaToimipiste;
        private System.Windows.Forms.TextBox txbHaeToimipiste;
        private System.Windows.Forms.Label lblHaeToimipiste;
        private System.Windows.Forms.Button btnTyhjaa;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private villagepDataSetTableAdapters.VarausTableAdapter varausTableAdapter;
        private System.Windows.Forms.BindingSource varauksen_palvelutBindingSource;
        private villagepDataSetTableAdapters.Varauksen_palvelutTableAdapter varauksen_palvelutTableAdapter;
        private System.Windows.Forms.GroupBox grpPHValitsePalvelutyyppi;
        private System.Windows.Forms.Button btnPHPeruuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sukunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lahiosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postitoimipaikkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhelinnroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.BindingSource toimipistenimetBindingSource;
        private System.Windows.Forms.ComboBox cmbPHToimipiste;
        private villagepDataSetTableAdapters.OstoskoriTableAdapter ostoskoriTableAdapter;
        private villagepDataSetTableAdapters.ToimipistenimetTableAdapter toimipistenimetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.TextBox txbHaeLaskutettava;
        private System.Windows.Forms.Label lblHaeLaskutettava;
        private System.Windows.Forms.DataGridView ostoskoriDataGridView;
        private System.Windows.Forms.BindingSource ostoskorinLoppusummaBindingSource;
        private villagepDataSetTableAdapters.OstoskorinLoppusummaTableAdapter ostoskorinLoppusummaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarausID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsiakasID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhelinnro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.Label lblValitseLaskutettava;
        private System.Windows.Forms.GroupBox grpLaskunYhteenveto;
        private System.Windows.Forms.BindingSource laskunOstotBindingSource;
        private villagepDataSetTableAdapters.LaskunOstotTableAdapter laskunOstotTableAdapter;
        private System.Windows.Forms.DataGridView laskunOstotDataGridView;
        private System.Windows.Forms.TextBox txbLaskunNimi;
        private System.Windows.Forms.TextBox txbLaskunLahiosoite;
        private System.Windows.Forms.TextBox txbLaskunPostitoimipaikka;
        private System.Windows.Forms.TextBox txbLaskunPostinro;
        private System.Windows.Forms.TextBox txbLaskunSumma;
        private System.Windows.Forms.TextBox txbLaskunAlv;
        private System.Windows.Forms.Button btnLaskutaVaraus;
        private System.Windows.Forms.BindingSource laskunLoppusummaBindingSource;
        private villagepDataSetTableAdapters.LaskunLoppusummaTableAdapter laskunLoppusummaTableAdapter;
        private System.Windows.Forms.Button btnMaksuKateisella;
        private System.Windows.Forms.GroupBox grpLaskutusOsoite;
        private System.Windows.Forms.BindingSource laskunLoppusummaBindingSource1;
        private System.Windows.Forms.BindingSource laskunLoppusummaBindingSource2;
        private System.Windows.Forms.DataGridView laskuAsiakasDataGridView;
        private System.Windows.Forms.Button btlKopioiLaskutusosoite;
        private System.Windows.Forms.Label lblAsiakasTilaaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private System.Windows.Forms.BindingSource palveluhistoriaBindingSource;
        private System.Windows.Forms.BindingSource palveluhistoria2BindingSource;
        private villagepDataSetTableAdapters.Palveluhistoria2TableAdapter palveluhistoria2TableAdapter;
        private System.Windows.Forms.DataGridView palveluhistoria2DataGridView;
        private System.Windows.Forms.GroupBox grpPalveluhistoria;
        private System.Windows.Forms.Label lblHistoriaAlv;
        private System.Windows.Forms.Label lblHistoriaSumma;
        private System.Windows.Forms.Label lblHistoriaLkm;
        private System.Windows.Forms.TextBox txbHistoriaAlv;
        private System.Windows.Forms.TextBox txbHistoriaSumma;
        private System.Windows.Forms.TextBox txbHistoriaLkm;
        private System.Windows.Forms.Button btnHaePalveluRaportti;
        private System.Windows.Forms.GroupBox grpPalveluhistoriaToimipiste;
        private System.Windows.Forms.ListBox lsbPalveluhistoriaToimipisteet;
        private System.Windows.Forms.GroupBox grpPalvelukalenteri;
        private System.Windows.Forms.MonthCalendar palvelukalenteriLoppu;
        private System.Windows.Forms.MonthCalendar palvelukalenteriAlku;
        private System.Windows.Forms.GroupBox grpPalveluhistoriaValitseTyyppi;
        private System.Windows.Forms.RadioButton radioPalveluhistoriaKaikki;
        private System.Windows.Forms.RadioButton radioPalveluhistoriaMajoitukset;
        private System.Windows.Forms.RadioButton radioPalveluhistoriaMuutPalvelut;
        private System.Windows.Forms.Button btnEmailUudelleen;
        private System.Windows.Forms.Button btnPoistaVaraus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhelinnroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausAlkoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausPaattyiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaskuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.BindingSource laskunTiedotBindingSource;
        private villagepDataSetTableAdapters.LaskunTiedotTableAdapter laskunTiedotTableAdapter;
        private System.Windows.Forms.BindingSource laskunTiedot2BindingSource;
        private villagepDataSetTableAdapters.LaskunTiedot2TableAdapter laskunTiedot2TableAdapter;
        private System.Windows.Forms.DataGridView laskunTiedotDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn80;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn74;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn75;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn76;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn77;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn78;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn79;
        private System.Windows.Forms.DataGridView laskunPalveluRivitDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn81;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn83;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn84;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn85;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn86;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn89;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn90;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn91;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn92;
        private System.Windows.Forms.Label lblLaskunPalvelut;
        private System.Windows.Forms.Label label7;
    }
}

