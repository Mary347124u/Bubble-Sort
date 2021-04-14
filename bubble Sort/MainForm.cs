/*
 * Created by SharpDevelop.
 * User: DELL
 * Date: 14/04/2021
 * Time: 11:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace bubble_Sort
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			//nomes = {“julio”, “amelia”, “henrique”, “silvia”, “camila”, “rui”, “cesar”, “benedito”, “alonso”, “claudia”, “maria”, “lucas”, “renato”, “heloisa”, “vilma”, “wanessa”, “ricardo”, “daniela”, “mauro”, “antonio”}
			
			string[] nomes = {"julio","amelia", "henrique", "silva", "camila", "rui", "cesar", "benedito", "alonso", "claudia", "maria", "lucas", "renato", "heloisa", "vilma", "wanessa", "ricardo", "daniela", "mauro", "antonio"};
		for (int j=0; j<19; j++) 
			for (int i=0; i<19; i++){
			string aux =""; 
	  		if ( nomes[i].CompareTo(nomes[i+1]) >= 0 )
	  		{
	  			aux = nomes[i];
	  			nomes[i] = nomes[i+1];
	  			nomes[i+1] = aux;
	  		}
		}
			
		listBox1.Items.Clear(); 
 		for (int i=0; i<20; i++)
		 listBox1.Items.Add(nomes[i]);
		}
	}
}
