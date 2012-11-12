using System.Collections.Generic;
using AlgorithmWordSearch.Models;

namespace AlgorithmWordSearch
{
	partial class DocumentWordSearch
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.ItemTemplate = new Microsoft.VisualBasic.PowerPacks.DataRepeaterItem();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dataRepeater1 = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.dataRepeater2 = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.button4 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dataRepeater1.ItemTemplate.SuspendLayout();
			this.dataRepeater1.SuspendLayout();
			this.dataRepeater2.ItemTemplate.SuspendLayout();
			this.dataRepeater2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(96, 359);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Start Search";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(84, 318);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(100, 23);
			this.progressBar1.TabIndex = 1;
			// 
			// ItemTemplate
			// 
			this.ItemTemplate.Size = new System.Drawing.Size(232, 18);
			// 
			// comboBox1
			// 
			this.comboBox1.DisplayMember = "SearchType";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(144, 0);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(73, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.ValueMember = "SearchType";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			// 
			// dataRepeater1
			// 
			this.dataRepeater1.AllowDrop = true;
			// 
			// dataRepeater1.ItemTemplate
			// 
			this.dataRepeater1.ItemTemplate.Controls.Add(this.textBox1);
			this.dataRepeater1.ItemTemplate.Controls.Add(this.comboBox1);
			this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(232, 22);
			this.dataRepeater1.Location = new System.Drawing.Point(21, 26);
			this.dataRepeater1.Name = "dataRepeater1";
			this.dataRepeater1.Size = new System.Drawing.Size(240, 113);
			this.dataRepeater1.TabIndex = 2;
			this.dataRepeater1.Text = "dataRepeater1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Search Perimeter";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(186, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Search Option";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(175, 145);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(84, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Add New Row";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(21, 146);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(90, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "Delete this Row";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// dataRepeater2
			// 
			// 
			// dataRepeater2.ItemTemplate
			// 
			this.dataRepeater2.ItemTemplate.Controls.Add(this.label3);
			this.dataRepeater2.ItemTemplate.Size = new System.Drawing.Size(570, 21);
			this.dataRepeater2.Location = new System.Drawing.Point(25, 191);
			this.dataRepeater2.Name = "dataRepeater2";
			this.dataRepeater2.Size = new System.Drawing.Size(578, 90);
			this.dataRepeater2.TabIndex = 6;
			this.dataRepeater2.Text = "dataRepeater2";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(96, 287);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 7;
			this.button4.Text = "Upload";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Upload);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "label3";
			// 
			// DocumentWordSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 403);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.dataRepeater2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataRepeater1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.button1);
			this.Name = "DocumentWordSearch";
			this.Text = "Form1";
			this.dataRepeater1.ItemTemplate.ResumeLayout(false);
			this.dataRepeater1.ItemTemplate.PerformLayout();
			this.dataRepeater1.ResumeLayout(false);
			this.dataRepeater2.ItemTemplate.ResumeLayout(false);
			this.dataRepeater2.ItemTemplate.PerformLayout();
			this.dataRepeater2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private Microsoft.VisualBasic.PowerPacks.DataRepeaterItem ItemTemplate;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater1;

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label3;
	}
}