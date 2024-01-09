/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 08/05/2023
 * Time: 12:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodiceFiscale
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private String n_mese_to_string(int n_mese)
		{
			switch (n_mese) {
				case 1:
					return "Gennaio";
				case 2:
					return "Febbraio";
				case 3:
					return "Marzo";
				case 4:
					return "Aprile";
				case 5:
					return "Maggio";
				case 6:
					return "Giugno";
				case 7:
					return "Luglio";
				case 8:
					return "Agosto";
				case 9:
					return "Settembre";
				case 10:
					return "Ottobre";
				case 11:
					return "Novembre";
				case 12:
					return "Dicembre";
				default:
					throw new Exception("Mese invalido");
			}
		}
		
		private int mese_str_to_int(String mese)
		{
			switch (mese) {
				case "Gennaio":
					return 1;
				case "Febbraio":
					return 2;
				case "Marzo":
					return 3;
				case "Aprile":
					return 4;
				case "Maggio":
					return 5;
				case "Giugno":
					return 6;
				case "Luglio":
					return 7;
				case "Agosto":
					return 8;
				case "Settembre":
					return 9;
				case "Ottobre":
					return 10;
				case "Novembre":
					return 11;
				case "Dicembre":
					return 12;
				default:
					throw new Exception("Mese invalido");
			}
		}
		
		private int mese_to_giorni(int n_mese)
		{
			if (n_mese == 2)	// Febbraio
				return 28;
			if (n_mese % 2 != 0)	// I mese dispari sono quasi sempre con 31 giorni
				return 31;
			if (n_mese % 2 == 0)
			if (n_mese != 8 || n_mese != 10 || n_mese != 12)	// Alcuni mesi hanno 31 anche se sono pari
					return 30;
			else
				return 31;
			throw new Exception("Mese invalido");
		}
		
		private void FillData()
		{
			for (int i = 1; i < 13; i++) {
				var new_mese = new ComboBoxGiorno();
				mese.Items.Add(n_mese_to_string(i));
			}
		}
		
		private Mesi mesi = new Mesi();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			FillData();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private string parse_nome()
		{
			var nome_parsed = "";
			int cont = 1, cons = 0;
			foreach (char x in nome.Text.ToUpper())
				if (!"AEIOU".Contains(x))
					cons++;
			if (cons <= 3) {
				foreach (char x in nome.Text.ToUpper()) {
					if (!"AEIOU".Contains(x) && nome_parsed.Length < 3)
						nome_parsed += x.ToString();
				}
				if (nome_parsed.Length != 3) {
					foreach (char x in nome.Text.ToUpper()) {
						if ("AEIOU".Contains(x) && nome_parsed.Length < 3)
							nome_parsed += x.ToString();
					}
				}
			} else {
				foreach (char x in nome.Text.ToUpper()) {
					if (!"AEIOU".Contains(x) && nome_parsed.Length < 3 && cont != 2)
						nome_parsed += x.ToString();
					if (!"AEIOU".Contains(x))
						cont++;
				}
				if (nome_parsed.Length != 3) {
					foreach (char x in nome.Text.ToUpper()) {
						if ("AEIOU".Contains(x) && nome_parsed.Length < 3)
							nome_parsed += x.ToString();
					}
				}
			}
			return nome_parsed;
		}
		
		private string parse_cognome()
		{
			var cognome_parsed = "";
			foreach (char x in cognome.Text.ToUpper()) {
				if (!"AEIOU".Contains(x) && cognome_parsed.Length < 3)
					cognome_parsed += x.ToString();
			}
			if (cognome_parsed.Length != 3) {
				foreach (char x in cognome.Text.ToUpper()) {
					if ("AEIOU".Contains(x) && cognome_parsed.Length < 3)
						cognome_parsed += x.ToString();
				}
			}
			return cognome_parsed;
		}
		void Button1Click(object sender, EventArgs e)
		{
			String nome_parsed = parse_nome();
			String cognome_parsed = parse_cognome();
			var anno_selected = anno.Text[2].ToString() + anno.Text[3].ToString();
			if (mesi.IsEmpty())
				mesi.Init();
			var mese_code = mesi.Get_Mese_Code(mese.SelectedItem.ToString().ToLower());
			var selected_day = giorno.SelectedItem.ToString();
			var codice_catastale = Comune.GetCodiceCatastale(citta.Text.ToUpper());
			var cf = cognome_parsed + nome_parsed + anno_selected + mese_code + selected_day + codice_catastale;
			cf += CifraControllo.CodiceControllo(cf);
			MessageBox.Show(cf);
		}
		void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
		{
			var combobox = sender as ComboBox;
			var n_mese = mese_str_to_int(mese.SelectedItem.ToString());
			giorno.Items.Clear();
			for (int j = 1; j < mese_to_giorni(n_mese) + 1; j++) {
				giorno.Items.Add(j.ToString());
			}
		}
		
		private int parse_year(int year) {
			if(year > 23) {
				year += 1900;
			}else {
				year += 2000;
			}
			return year;
		}
		void Button2Click(object sender, EventArgs e)
		{
			if(codice_fiscale.Text.Count() == 16){
				var cf = codice_fiscale.Text;
				var iniziali_nome = cf.Substring(0, 3);
				var iniziali_cognome = cf.Substring(3, 3);
				var anno_partial = cf.Substring(6, 2);
				if(mesi.IsEmpty())
					mesi.Init();
				var mese_parsed = mesi.Get_Mese_From_Code(cf[8]);
				var day = cf.Substring(9,2);
				var city = Comune.GetComune(cf.Substring(11, 4));
				new Inverso(iniziali_nome, iniziali_cognome, String.Format("{0}/{1}/{2}", day, mesi.GetMeseNumber(mese_parsed), parse_year(int.Parse(anno_partial))), city, cf[15].ToString(), cf).Show();
			}else {
				MessageBox.Show("Codice fiscale invalido, riprovare", "Codice fiscale invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
	}
}
