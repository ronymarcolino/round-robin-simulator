/*
 * Criado por SharpDevelop.
 * Usuário: Rony Marcolino
 * Data: 28/5/2010
 * Hora: 5:47
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimuladorRoundRobin
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Int32 P1 = 0;
		Int32 P2 = 0;
		Int32 P3 = 0;
		Int32 P4 = 0;
		Int32 i = 0;
		Int32 quantum = 1;
		Int32 vezes = 0;
		String saida = "";
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			P1 = System.Convert.ToInt32(textBox1.Text);
			P2 = System.Convert.ToInt32(textBox2.Text);
			P3 = System.Convert.ToInt32(textBox3.Text);
			P4 = System.Convert.ToInt32(textBox4.Text);
			quantum = System.Convert.ToInt32(textBox5.Text);
			vezes = (P1+P2+P3+P4)/quantum;
			
			saida = "";
			textBox6.Text = "";			
						
			for(i = vezes; i >= quantum; i --){
				if(P1 < quantum){
					//
				}else{
					//
					saida = saida + "P1 ";
					P1 = P1 - quantum;
				}
				if(P2 < quantum){
					//
				}else{
					//
					saida = saida + "P2 ";
					P2 = P2 - quantum;
				}
				if(P3 < quantum){
					//
				}else{
					//
					saida = saida + "P3 ";
					P3 = P3 - quantum;
				}
				if(P4 < quantum){
					//
				}else{
					//
					saida = saida + "P4 ";
					P4 = P4 - quantum;
				}
				textBox6.Text = saida;
			}
		}
	}
}
