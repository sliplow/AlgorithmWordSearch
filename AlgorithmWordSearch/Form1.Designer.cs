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
			System.Windows.Forms.Label valueLabel;
			System.Windows.Forms.Label positionLabel;
			System.Windows.Forms.Label importanceLabel;
			this.button1 = new System.Windows.Forms.Button();
			this.ItemTemplate = new Microsoft.VisualBasic.PowerPacks.DataRepeaterItem();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dataRepeater1 = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.dataRepeater2 = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
			this.fileLocations = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.button4 = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.fileImportance = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.documentComboBox = new System.Windows.Forms.ComboBox();
			this.sentencesDataRepeater = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
			this.importanceTextBox = new System.Windows.Forms.Label();
			this.positionLabel1 = new System.Windows.Forms.Label();
			this.valueTextBox = new System.Windows.Forms.TextBox();
			valueLabel = new System.Windows.Forms.Label();
			positionLabel = new System.Windows.Forms.Label();
			importanceLabel = new System.Windows.Forms.Label();
			this.dataRepeater1.ItemTemplate.SuspendLayout();
			this.dataRepeater1.SuspendLayout();
			this.dataRepeater2.ItemTemplate.SuspendLayout();
			this.dataRepeater2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.sentencesDataRepeater.ItemTemplate.SuspendLayout();
			this.sentencesDataRepeater.SuspendLayout();
			this.SuspendLayout();
			// 
			// valueLabel
			// 
			valueLabel.AutoSize = true;
			valueLabel.Location = new System.Drawing.Point(3, 27);
			valueLabel.Name = "valueLabel";
			valueLabel.Size = new System.Drawing.Size(56, 13);
			valueLabel.TabIndex = 0;
			valueLabel.Text = "Sentence:";
			// 
			// positionLabel
			// 
			positionLabel.AutoSize = true;
			positionLabel.Location = new System.Drawing.Point(391, 0);
			positionLabel.Name = "positionLabel";
			positionLabel.Size = new System.Drawing.Size(47, 13);
			positionLabel.TabIndex = 2;
			positionLabel.Text = "Position:";
			// 
			// importanceLabel
			// 
			importanceLabel.AutoSize = true;
			importanceLabel.Location = new System.Drawing.Point(3, 0);
			importanceLabel.Name = "importanceLabel";
			importanceLabel.Size = new System.Drawing.Size(63, 13);
			importanceLabel.TabIndex = 4;
			importanceLabel.Text = "Importance:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(87, 324);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Start Search";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Search);
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
			this.dataRepeater1.Location = new System.Drawing.Point(6, 18);
			this.dataRepeater1.Name = "dataRepeater1";
			this.dataRepeater1.Size = new System.Drawing.Size(240, 113);
			this.dataRepeater1.TabIndex = 2;
			this.dataRepeater1.Text = "dataRepeater1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Search Perimeter";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(171, 1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Search Option";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(160, 137);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(84, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Add New Row";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.AddNewSearchOption);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(6, 138);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(90, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "Delete this Row";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.RemoveSearchOption);
			// 
			// dataRepeater2
			// 
			// 
			// dataRepeater2.ItemTemplate
			// 
			this.dataRepeater2.ItemTemplate.Controls.Add(this.fileLocations);
			this.dataRepeater2.ItemTemplate.Size = new System.Drawing.Size(570, 21);
			this.dataRepeater2.Location = new System.Drawing.Point(3, 166);
			this.dataRepeater2.Name = "dataRepeater2";
			this.dataRepeater2.Size = new System.Drawing.Size(578, 111);
			this.dataRepeater2.TabIndex = 6;
			this.dataRepeater2.Text = "dataRepeater2";
			// 
			// fileLocations
			// 
			this.fileLocations.AutoSize = true;
			this.fileLocations.Location = new System.Drawing.Point(3, 0);
			this.fileLocations.Name = "fileLocations";
			this.fileLocations.Size = new System.Drawing.Size(35, 13);
			this.fileLocations.TabIndex = 0;
			this.fileLocations.Text = "label3";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(87, 295);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 7;
			this.button4.Text = "Upload";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Upload);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(591, 379);
			this.tabControl1.TabIndex = 8;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataRepeater1);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.button4);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.dataRepeater2);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(583, 353);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Search";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.AutoScroll = true;
			this.tabPage2.Controls.Add(this.fileImportance);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.documentComboBox);
			this.tabPage2.Controls.Add(this.sentencesDataRepeater);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(583, 353);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Results";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// fileImportance
			// 
			this.fileImportance.AutoSize = true;
			this.fileImportance.Location = new System.Drawing.Point(495, 31);
			this.fileImportance.Name = "fileImportance";
			this.fileImportance.Size = new System.Drawing.Size(0, 13);
			this.fileImportance.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(406, 30);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "File Importance:";
			// 
			// documentComboBox
			// 
			this.documentComboBox.DisplayMember = "MatchingSentences";
			this.documentComboBox.FormattingEnabled = true;
			this.documentComboBox.Location = new System.Drawing.Point(3, 6);
			this.documentComboBox.Name = "documentComboBox";
			this.documentComboBox.Size = new System.Drawing.Size(533, 21);
			this.documentComboBox.TabIndex = 2;
			this.documentComboBox.ValueMember = "MatchingSentences";
			this.documentComboBox.SelectedValueChanged += new System.EventHandler(this.SelectedIndexChanged);
			// 
			// sentencesDataRepeater
			// 
			// 
			// sentencesDataRepeater.ItemTemplate
			// 
			this.sentencesDataRepeater.ItemTemplate.Controls.Add(importanceLabel);
			this.sentencesDataRepeater.ItemTemplate.Controls.Add(this.importanceTextBox);
			this.sentencesDataRepeater.ItemTemplate.Controls.Add(positionLabel);
			this.sentencesDataRepeater.ItemTemplate.Controls.Add(this.positionLabel1);
			this.sentencesDataRepeater.ItemTemplate.Controls.Add(valueLabel);
			this.sentencesDataRepeater.ItemTemplate.Controls.Add(this.valueTextBox);
			this.sentencesDataRepeater.ItemTemplate.Size = new System.Drawing.Size(579, 48);
			this.sentencesDataRepeater.Location = new System.Drawing.Point(-4, 46);
			this.sentencesDataRepeater.Name = "sentencesDataRepeater";
			this.sentencesDataRepeater.Size = new System.Drawing.Size(587, 284);
			this.sentencesDataRepeater.TabIndex = 2;
			this.sentencesDataRepeater.Text = "dataRepeater3";
			// 
			// importanceTextBox
			// 
			this.importanceTextBox.Location = new System.Drawing.Point(72, 1);
			this.importanceTextBox.Name = "importanceTextBox";
			this.importanceTextBox.Size = new System.Drawing.Size(100, 20);
			this.importanceTextBox.TabIndex = 5;
			// 
			// positionLabel1
			// 
			this.positionLabel1.Location = new System.Drawing.Point(444, 0);
			this.positionLabel1.Name = "positionLabel1";
			this.positionLabel1.Size = new System.Drawing.Size(100, 23);
			this.positionLabel1.TabIndex = 3;
			this.positionLabel1.Text = "label4";
			// 
			// valueTextBox
			// 
			this.valueTextBox.Location = new System.Drawing.Point(65, 24);
			this.valueTextBox.Name = "valueTextBox";
			this.valueTextBox.Size = new System.Drawing.Size(479, 20);
			this.valueTextBox.TabIndex = 1;
			// 
			// DocumentWordSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 416);
			this.Controls.Add(this.tabControl1);
			this.Name = "DocumentWordSearch";
			this.Text = "Form1";
			this.dataRepeater1.ItemTemplate.ResumeLayout(false);
			this.dataRepeater1.ItemTemplate.PerformLayout();
			this.dataRepeater1.ResumeLayout(false);
			this.dataRepeater2.ItemTemplate.ResumeLayout(false);
			this.dataRepeater2.ItemTemplate.PerformLayout();
			this.dataRepeater2.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.sentencesDataRepeater.ItemTemplate.ResumeLayout(false);
			this.sentencesDataRepeater.ItemTemplate.PerformLayout();
			this.sentencesDataRepeater.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
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
		private System.Windows.Forms.Label fileLocations;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private Microsoft.VisualBasic.PowerPacks.DataRepeaterItem ItemTemplate;
		private Microsoft.VisualBasic.PowerPacks.DataRepeater sentencesDataRepeater;
		private System.Windows.Forms.Label importanceTextBox;
		private System.Windows.Forms.Label positionLabel1;
		private System.Windows.Forms.TextBox valueTextBox;
		private System.Windows.Forms.ComboBox documentComboBox;
		private System.Windows.Forms.Label fileImportance;
		private System.Windows.Forms.Label label4;
	}
}