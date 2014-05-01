/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 28/04/2014
 * Time: 04:17 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practica5
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCod = new System.Windows.Forms.TextBox();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.chbReino = new System.Windows.Forms.CheckBox();
			this.chbJap = new System.Windows.Forms.CheckBox();
			this.chbAle = new System.Windows.Forms.CheckBox();
			this.chbRus = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.rdbHit = new System.Windows.Forms.RadioButton();
			this.rdbMusso = new System.Windows.Forms.RadioButton();
			this.rdbBerlu = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.numEstados = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.btnContestar = new System.Windows.Forms.Button();
			this.txtCali = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.numEstados)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(385, 18);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(222, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Practica 5 EXAMEN";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Maroon;
			this.label2.Location = new System.Drawing.Point(587, 57);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 30);
			this.label2.TabIndex = 1;
			this.label2.Text = "Código";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Maroon;
			this.label3.Location = new System.Drawing.Point(833, 57);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 30);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nombre";
			// 
			// txtCod
			// 
			this.txtCod.Location = new System.Drawing.Point(587, 93);
			this.txtCod.Margin = new System.Windows.Forms.Padding(4);
			this.txtCod.Name = "txtCod";
			this.txtCod.Size = new System.Drawing.Size(184, 22);
			this.txtCod.TabIndex = 3;
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(833, 91);
			this.txtNom.Margin = new System.Windows.Forms.Padding(4);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(194, 22);
			this.txtNom.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 94);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(178, 78);
			this.label4.TabIndex = 5;
			this.label4.Text = "1. Seleccione los países aliados en la segunda guerra mundial";
			// 
			// chbReino
			// 
			this.chbReino.Location = new System.Drawing.Point(22, 176);
			this.chbReino.Margin = new System.Windows.Forms.Padding(4);
			this.chbReino.Name = "chbReino";
			this.chbReino.Size = new System.Drawing.Size(138, 32);
			this.chbReino.TabIndex = 7;
			this.chbReino.Text = "Reino Unido";
			this.chbReino.UseVisualStyleBackColor = true;
			// 
			// chbJap
			// 
			this.chbJap.Location = new System.Drawing.Point(22, 215);
			this.chbJap.Margin = new System.Windows.Forms.Padding(4);
			this.chbJap.Name = "chbJap";
			this.chbJap.Size = new System.Drawing.Size(138, 32);
			this.chbJap.TabIndex = 8;
			this.chbJap.Text = "Japón";
			this.chbJap.UseVisualStyleBackColor = true;
			// 
			// chbAle
			// 
			this.chbAle.Location = new System.Drawing.Point(22, 255);
			this.chbAle.Margin = new System.Windows.Forms.Padding(4);
			this.chbAle.Name = "chbAle";
			this.chbAle.Size = new System.Drawing.Size(138, 32);
			this.chbAle.TabIndex = 9;
			this.chbAle.Text = "Alemania";
			this.chbAle.UseVisualStyleBackColor = true;
			// 
			// chbRus
			// 
			this.chbRus.Location = new System.Drawing.Point(22, 294);
			this.chbRus.Margin = new System.Windows.Forms.Padding(4);
			this.chbRus.Name = "chbRus";
			this.chbRus.Size = new System.Drawing.Size(138, 32);
			this.chbRus.TabIndex = 10;
			this.chbRus.Text = "Rusia";
			this.chbRus.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(22, 401);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(199, 59);
			this.label6.TabIndex = 11;
			this.label6.Text = "2. Seleccione el gobernante de Italia durante la 2 guerra mundial";
			// 
			// rdbHit
			// 
			this.rdbHit.Location = new System.Drawing.Point(22, 473);
			this.rdbHit.Margin = new System.Windows.Forms.Padding(4);
			this.rdbHit.Name = "rdbHit";
			this.rdbHit.Size = new System.Drawing.Size(138, 32);
			this.rdbHit.TabIndex = 12;
			this.rdbHit.TabStop = true;
			this.rdbHit.Text = "Hitler";
			this.rdbHit.UseVisualStyleBackColor = true;
			// 
			// rdbMusso
			// 
			this.rdbMusso.Location = new System.Drawing.Point(22, 511);
			this.rdbMusso.Margin = new System.Windows.Forms.Padding(4);
			this.rdbMusso.Name = "rdbMusso";
			this.rdbMusso.Size = new System.Drawing.Size(138, 32);
			this.rdbMusso.TabIndex = 13;
			this.rdbMusso.TabStop = true;
			this.rdbMusso.Text = "Mussoini";
			this.rdbMusso.UseVisualStyleBackColor = true;
			// 
			// rdbBerlu
			// 
			this.rdbBerlu.Location = new System.Drawing.Point(22, 551);
			this.rdbBerlu.Margin = new System.Windows.Forms.Padding(4);
			this.rdbBerlu.Name = "rdbBerlu";
			this.rdbBerlu.Size = new System.Drawing.Size(138, 32);
			this.rdbBerlu.TabIndex = 14;
			this.rdbBerlu.TabStop = true;
			this.rdbBerlu.Text = "Berlusconi";
			this.rdbBerlu.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(300, 104);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(178, 53);
			this.label7.TabIndex = 15;
			this.label7.Text = "3.Número de estados de la Republica Mexicana";
			// 
			// numEstados
			// 
			this.numEstados.Location = new System.Drawing.Point(300, 177);
			this.numEstados.Margin = new System.Windows.Forms.Padding(4);
			this.numEstados.Maximum = new decimal(new int[] {
									67,
									0,
									0,
									0});
			this.numEstados.Name = "numEstados";
			this.numEstados.Size = new System.Drawing.Size(160, 22);
			this.numEstados.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(300, 316);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(196, 45);
			this.label8.TabIndex = 17;
			this.label8.Text = "4.Fecha de independencia de México";
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(300, 378);
			this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 18;
			// 
			// btnContestar
			// 
			this.btnContestar.Location = new System.Drawing.Point(721, 199);
			this.btnContestar.Margin = new System.Windows.Forms.Padding(4);
			this.btnContestar.Name = "btnContestar";
			this.btnContestar.Size = new System.Drawing.Size(168, 64);
			this.btnContestar.TabIndex = 19;
			this.btnContestar.Text = "Contestar";
			this.btnContestar.UseVisualStyleBackColor = true;
			this.btnContestar.Click += new System.EventHandler(this.BtnContestarClick);
			// 
			// txtCali
			// 
			this.txtCali.Location = new System.Drawing.Point(665, 304);
			this.txtCali.Margin = new System.Windows.Forms.Padding(4);
			this.txtCali.Name = "txtCali";
			this.txtCali.Size = new System.Drawing.Size(302, 182);
			this.txtCali.TabIndex = 20;
			this.txtCali.Text = "";
			this.txtCali.TextChanged += new System.EventHandler(this.TxtCaliTextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.ClientSize = new System.Drawing.Size(1040, 598);
			this.Controls.Add(this.txtCali);
			this.Controls.Add(this.btnContestar);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.numEstados);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.rdbBerlu);
			this.Controls.Add(this.rdbMusso);
			this.Controls.Add(this.rdbHit);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.chbRus);
			this.Controls.Add(this.chbAle);
			this.Controls.Add(this.chbJap);
			this.Controls.Add(this.chbReino);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNom);
			this.Controls.Add(this.txtCod);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Practica5";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.numEstados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.RichTextBox txtCali;
		private System.Windows.Forms.Button btnContestar;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		public System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown numEstados;
		public System.Windows.Forms.Label label7;
		private System.Windows.Forms.RadioButton rdbBerlu;
		private System.Windows.Forms.RadioButton rdbMusso;
		private System.Windows.Forms.RadioButton rdbHit;
		public System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox chbRus;
		private System.Windows.Forms.CheckBox chbAle;
		private System.Windows.Forms.CheckBox chbJap;
		private System.Windows.Forms.CheckBox chbReino;
		public System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.TextBox txtCod;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
