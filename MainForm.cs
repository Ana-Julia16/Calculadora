/*
 * Created by SharpDevelop.
 * User: Rm20222930058
 * Date: 12/04/2023
 * Time: 10:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_2
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		TextBox txt1 = new TextBox();
		TextBox txt2 = new TextBox();
		TextBox txt3 = new TextBox();
		
		void MainFormLoad(object sender, EventArgs e)
		{
			Button bt1 = new Button(); 
			bt1.Parent = this;
			bt1.Left = 100;
			bt1.Top = 130;
			bt1.BackColor = Color.Purple;
			bt1.Text = "Somar";
			bt1.Click += Bt1Click;
			
			Button bt2 = new Button(); 
			bt2.Parent = this;
			bt2.Left = 100;
			bt2.Top = 160;
			bt2.BackColor = Color.DarkViolet;
			bt2.Text = "Subitrair";
			bt2.Click += Bt2Click;
			
			Button bt3 = new Button(); 
			bt3.Parent = this;
			bt3.Left = 180;
			bt3.Top = 130;
			bt3.BackColor = Color.MediumPurple;
			bt3.Text = "Dividir";
			bt3.Click += Bt3Click;
			
			Button bt4 = new Button(); 
			bt4.Parent = this;
			bt4.Left = 180;
			bt4.Top = 160;
			bt4.BackColor = Color.Lavender;
			bt4.Text = "Multiplicar";
			bt4.Click += Bt4Click;
			
			txt1.Parent = this;
			txt1.Left = 130;
			txt1.Top = 30;
			
			txt2.Parent = this;
			txt2.Left = 130;
			txt2.Top = 60;
			
			txt3.Parent = this;
			txt3.Left = 130;
			txt3.Top = 90;
		}
		void Bt1Click(object sender, EventArgs e)
		{
			int n1 = int.Parse(txt1.Text);
			int n2 = int.Parse(txt2.Text);
			int soma = n1 + n2;
			
			txt3.Text = soma.ToString();
		}
		
		void Bt2Click(object sender, EventArgs e)
		{
			int n1 = int.Parse(txt1.Text);
			int n2 = int.Parse(txt2.Text);
			int subitrair = n1 - n2;
			
			txt3.Text = subitrair.ToString();
		}
		
		void Bt3Click(object sender, EventArgs e)
		{
			int n1 = int.Parse(txt1.Text);
			int n2 = int.Parse(txt2.Text);
			int dividir = n1 / n2;
			
			txt3.Text = dividir.ToString();
		}
		
		void Bt4Click(object sender, EventArgs e)
		{
			int n1 = int.Parse(txt1.Text);
			int n2 = int.Parse(txt2.Text);
			int multiplicar = n1 * n2;
			
			txt3.Text = multiplicar.ToString();
		}
		
	}
}
