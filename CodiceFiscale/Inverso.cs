/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 10/05/2023
 * Time: 16:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CodiceFiscale
{
	/// <summary>
	/// Description of Inverso.
	/// </summary>
	public partial class Inverso : Form
	{
		public Inverso(string name, string surname, string data_nascita, string cit, string cc, string old_cf)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			nome.Text = name;
			cognome.Text = surname;
			nascita.Text = data_nascita;
			city.Text = cit;
			codice_controllo.Text = cc;
			label1.Text += old_cf;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}
