/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 10/05/2023
 * Time: 16:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CodiceFiscale
{
	partial class Inverso
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label nome;
		private System.Windows.Forms.Label cognome;
		private System.Windows.Forms.Label nascita;
		private System.Windows.Forms.Label city;
		private System.Windows.Forms.Label codice_controllo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.nome = new System.Windows.Forms.Label();
			this.cognome = new System.Windows.Forms.Label();
			this.nascita = new System.Windows.Forms.Label();
			this.city = new System.Windows.Forms.Label();
			this.codice_controllo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.nome, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.cognome, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.nascita, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.city, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.codice_controllo, 1, 4);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(172, 43);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 232);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nome";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Cognome";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(3, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Data di Nascita";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(3, 83);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 22);
			this.label5.TabIndex = 3;
			this.label5.Text = "Città";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(3, 105);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "Codice di controllo";
			// 
			// nome
			// 
			this.nome.Location = new System.Drawing.Point(103, 0);
			this.nome.Name = "nome";
			this.nome.Size = new System.Drawing.Size(94, 23);
			this.nome.TabIndex = 5;
			// 
			// cognome
			// 
			this.cognome.Location = new System.Drawing.Point(103, 27);
			this.cognome.Name = "cognome";
			this.cognome.Size = new System.Drawing.Size(94, 23);
			this.cognome.TabIndex = 6;
			// 
			// nascita
			// 
			this.nascita.Location = new System.Drawing.Point(103, 54);
			this.nascita.Name = "nascita";
			this.nascita.Size = new System.Drawing.Size(94, 23);
			this.nascita.TabIndex = 7;
			// 
			// city
			// 
			this.city.Location = new System.Drawing.Point(103, 83);
			this.city.Name = "city";
			this.city.Size = new System.Drawing.Size(94, 22);
			this.city.TabIndex = 8;
			// 
			// codice_controllo
			// 
			this.codice_controllo.Location = new System.Drawing.Point(103, 105);
			this.codice_controllo.Name = "codice_controllo";
			this.codice_controllo.Size = new System.Drawing.Size(94, 23);
			this.codice_controllo.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(457, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Il codice fiscale immesso è: ";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(229, 326);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Chiudi";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Inverso
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 497);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Inverso";
			this.Text = "Inverso";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
