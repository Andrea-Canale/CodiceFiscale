/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 08/05/2023
 * Time: 12:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CodiceFiscale
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox cognome;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox citta;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ComboBox giorno;
		private System.Windows.Forms.ComboBox mese;
		private System.Windows.Forms.TextBox anno;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox codice_fiscale;
		private System.Windows.Forms.Button button2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.nome = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cognome = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.citta = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.giorno = new System.Windows.Forms.ComboBox();
			this.mese = new System.Windows.Forms.ComboBox();
			this.anno = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.codice_fiscale = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.nome);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this.cognome);
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.Controls.Add(this.citta);
			this.flowLayoutPanel1.Controls.Add(this.label4);
			this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(159, 81);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(234, 213);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome";
			// 
			// nome
			// 
			this.nome.Location = new System.Drawing.Point(109, 3);
			this.nome.Name = "nome";
			this.nome.Size = new System.Drawing.Size(100, 20);
			this.nome.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Cognome";
			// 
			// cognome
			// 
			this.cognome.Location = new System.Drawing.Point(109, 29);
			this.cognome.Name = "cognome";
			this.cognome.Size = new System.Drawing.Size(100, 20);
			this.cognome.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Città";
			// 
			// citta
			// 
			this.citta.Location = new System.Drawing.Point(109, 55);
			this.citta.Name = "citta";
			this.citta.Size = new System.Drawing.Size(100, 20);
			this.citta.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(3, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Data di nascita";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.27027F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.72973F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
			this.tableLayoutPanel1.Controls.Add(this.giorno, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.mese, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.anno, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label7, 2, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 104);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 67);
			this.tableLayoutPanel1.TabIndex = 7;
			// 
			// giorno
			// 
			this.giorno.FormattingEnabled = true;
			this.giorno.Location = new System.Drawing.Point(3, 30);
			this.giorno.Name = "giorno";
			this.giorno.Size = new System.Drawing.Size(34, 21);
			this.giorno.TabIndex = 0;
			// 
			// mese
			// 
			this.mese.FormattingEnabled = true;
			this.mese.Location = new System.Drawing.Point(43, 30);
			this.mese.Name = "mese";
			this.mese.Size = new System.Drawing.Size(87, 21);
			this.mese.TabIndex = 1;
			this.mese.SelectedIndexChanged += new System.EventHandler(this.ComboBox2SelectedIndexChanged);
			// 
			// anno
			// 
			this.anno.Location = new System.Drawing.Point(136, 30);
			this.anno.Name = "anno";
			this.anno.Size = new System.Drawing.Size(52, 20);
			this.anno.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(3, 7);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 20);
			this.label5.TabIndex = 3;
			this.label5.Text = "Giorno";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(43, 7);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 20);
			this.label6.TabIndex = 4;
			this.label6.Text = "Mese";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(136, 7);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 20);
			this.label7.TabIndex = 5;
			this.label7.Text = "Anno";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 177);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Calcola";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(121, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(306, 59);
			this.label8.TabIndex = 2;
			this.label8.Text = "Calcolo codice fiscale";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(77, 331);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(417, 59);
			this.label9.TabIndex = 3;
			this.label9.Text = "Calcolo codice fiscale inverso";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(193, 390);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(158, 29);
			this.label10.TabIndex = 4;
			this.label10.Text = "Codice fiscale";
			// 
			// codice_fiscale
			// 
			this.codice_fiscale.Location = new System.Drawing.Point(217, 422);
			this.codice_fiscale.Name = "codice_fiscale";
			this.codice_fiscale.Size = new System.Drawing.Size(100, 20);
			this.codice_fiscale.TabIndex = 5;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(229, 448);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Converti";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(537, 572);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.codice_fiscale);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "MainForm";
			this.Text = "CodiceFiscale";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
