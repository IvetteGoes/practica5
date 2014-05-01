/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 28/04/2014
 * Time: 04:17 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practica5
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		int resp=0;
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void BtnContestarClick(object sender, EventArgs e)
		{
			
			resp=0;
			
			if(this.chbReino.Checked)
			{
				resp += 20;
				
			}
			if(this.chbJap.Checked)
			{
				
			}
			if(this.chbAle.Checked)
			{
				
			}
			if(this.chbRus.Checked)
			{
				resp += 20;
				
			}
			
			
			if(this.rdbHit.Checked)
			{
				
			}
			if(this.rdbMusso.Checked)
			{
				resp += 20;
				
			}
			if(this.rdbBerlu.Checked)
			{
				
			}
			
			if(this.numEstados.Text=="31")
			{
				resp += 20;
			}
			
			if(this.monthCalendar1.SelectionStart.Date.ToShortDateString() == "16/09/1810"){
				resp += 20;
			}
		
			
			MessageBox.Show(resp.ToString());
			
		}
		
		
		
		void TxtCaliTextChanged(object sender, EventArgs e)
		{
		   
		}
	}
}
