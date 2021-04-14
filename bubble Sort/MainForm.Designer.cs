/*
 * Created by SharpDevelop.
 * User: DELL
 * Date: 14/04/2021
 * Time: 11:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace bubble_Sort
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
		
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.AliceBlue;
			this.label1.Location = new System.Drawing.Point(59, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bubble Sort";
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(59, 37);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(146, 212);
			this.listBox1.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MidnightBlue;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "bubble Sort";
			this.ResumeLayout(false);

		}
	}
}
