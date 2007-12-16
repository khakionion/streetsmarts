using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace StreetSmarts
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class StreetSmartsMainForm : System.Windows.Forms.Form
	{
		private string CurrentVersion = "1.0";
		private StreetSmartsRuleProcessor myProcessor;
		private System.Windows.Forms.GroupBox FolderGroup;
		private System.Windows.Forms.Label CurrentFolder;
		private System.Windows.Forms.Button SelectFolder;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.FolderBrowserDialog SelectFolderDialog;
		private System.Windows.Forms.MainMenu MainMenu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox RuleSetInput;
		private System.Windows.Forms.TextBox FileFilter;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public StreetSmartsMainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			this.myProcessor = new StreetSmartsRuleProcessor();
			InitializeComponent();

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.FolderGroup = new System.Windows.Forms.GroupBox();
			this.SelectFolder = new System.Windows.Forms.Button();
			this.CurrentFolder = new System.Windows.Forms.Label();
			this.SelectFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.MainMenu = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.RuleSetInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.FileFilter = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.FolderGroup.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// FolderGroup
			// 
			this.FolderGroup.Controls.Add(this.SelectFolder);
			this.FolderGroup.Controls.Add(this.CurrentFolder);
			this.FolderGroup.Location = new System.Drawing.Point(8, 8);
			this.FolderGroup.Name = "FolderGroup";
			this.FolderGroup.Size = new System.Drawing.Size(648, 48);
			this.FolderGroup.TabIndex = 0;
			this.FolderGroup.TabStop = false;
			this.FolderGroup.Text = "Current Folder";
			// 
			// SelectFolder
			// 
			this.SelectFolder.Location = new System.Drawing.Point(544, 16);
			this.SelectFolder.Name = "SelectFolder";
			this.SelectFolder.Size = new System.Drawing.Size(96, 24);
			this.SelectFolder.TabIndex = 2;
			this.SelectFolder.Text = "Select Folder...";
			this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
			// 
			// CurrentFolder
			// 
			this.CurrentFolder.Location = new System.Drawing.Point(8, 24);
			this.CurrentFolder.Name = "CurrentFolder";
			this.CurrentFolder.Size = new System.Drawing.Size(528, 16);
			this.CurrentFolder.TabIndex = 1;
			this.CurrentFolder.Text = this.myProcessor.startPath;
			// 
			// SelectFolderDialog
			// 
			this.SelectFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
			this.SelectFolderDialog.SelectedPath = this.myProcessor.startPath;
			// 
			// MainMenu
			// 
			this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItem1,
																					 this.menuItem2,
																					 this.menuItem3});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "E&xit";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "&About...";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem8,
																					  this.menuItem4,
																					  this.menuItem5,
																					  this.menuItem6,
																					  this.menuItem7,
																					  this.menuItem9});
			this.menuItem3.Text = "&S^3 Reference";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 0;
			this.menuItem8.Text = "&General Info...";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Text = "&Delete...";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 2;
			this.menuItem5.Text = "&Spacify...";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 3;
			this.menuItem6.Text = "&Underscores...";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 4;
			this.menuItem7.Text = "&Capitalize...";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 5;
			this.menuItem9.Text = "&Append/Prepend...";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// RuleSetInput
			// 
			this.RuleSetInput.AcceptsReturn = true;
			this.RuleSetInput.AutoSize = false;
			this.RuleSetInput.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RuleSetInput.Location = new System.Drawing.Point(16, 80);
			this.RuleSetInput.Multiline = true;
			this.RuleSetInput.Name = "RuleSetInput";
			this.RuleSetInput.Size = new System.Drawing.Size(752, 120);
			this.RuleSetInput.TabIndex = 1;
			this.RuleSetInput.Text = "append (rock_remix)\r\nunderscores off\r\ncapitalize normally";
			this.RuleSetInput.WordWrap = false;
			this.RuleSetInput.TextChanged += new System.EventHandler(this.RuleSetInput_TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 64);
			this.label1.Name = "label1";
			this.label1.TabIndex = 2;
			this.label1.Text = "S^3 Command Set";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(16, 208);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(592, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Do It!";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(624, 208);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(144, 24);
			this.button2.TabIndex = 4;
			this.button2.Text = "Did you just say \"doit?\"";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// FileFilter
			// 
			this.FileFilter.Location = new System.Drawing.Point(8, 16);
			this.FileFilter.Name = "FileFilter";
			this.FileFilter.Size = new System.Drawing.Size(96, 20);
			this.FileFilter.TabIndex = 3;
			this.FileFilter.Text = "*";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.FileFilter);
			this.groupBox1.Location = new System.Drawing.Point(672, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(112, 48);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "File Filter";
			// 
			// StreetSmartsMainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(792, 238);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.RuleSetInput);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.FolderGroup);
			this.Menu = this.MainMenu;
			this.Name = "StreetSmartsMainForm";
			this.Text = "StreetSmarts";
			this.FolderGroup.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new StreetSmartsMainForm());
		}

		private void SelectFolder_Click(object sender, System.EventArgs e)
		{
			SelectFolderDialog.ShowDialog();
			CurrentFolder.Text = SelectFolderDialog.SelectedPath;
			myProcessor.SetRootFolder(SelectFolderDialog.SelectedPath,FileFilter.Text);
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("StreetSmarts v" + CurrentVersion + "\n\n http://code.google.com/p/streetsmarts/");
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Because, you know, they're spelled the same.");
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			myProcessor.SetRootFolder(SelectFolderDialog.SelectedPath,FileFilter.Text);
			foreach(string NextString in RuleSetInput.Lines)
			{
				myProcessor.AddAction(NextString);
			}
			myProcessor.ProcessRuleset();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Delete\n\nTakes two arguments: (first | last) and <integer>\n\nPretty straightforward, deletes either\nthe first or last n characters of a filename.");
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Capitalization\n\nTakes one argument: (normally.)\n\nIn the future, special capitalization\nmethods will be added.");
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Underscores\n\nTakes one argument: (off|on)\n\nOff will replace underscores with spaces.\nOn will do the opposite.");
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Spacify\n\nTakes one argument: <any SINGLE character>\n\nSpacify finds all instances of the specified \ncharacter, and surrounds them with a space.");
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("S^3 Notes\n\nAll commands are performed sequentially.\n\neverything must be in lowercase.\n\nWhitespace         is        ignored.\n\nYou can use the File Filter to only operate on \ncertain files. It's DOS-style, so *.mp3 means \"all MP3 files.\"");
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Append and Prepend\n\nTakes one argument: <text with no spaces>\n\nPlaces text at either the end or beginning\nof the filename.\n\nIf you want spaces, simply use underscores,\nand use the \"underscores off\" command\nafterwards to turn them to spaces.");
		}

		private void RuleSetInput_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
