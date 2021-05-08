
namespace MathCreator_WindowsForm
{
	partial class MathCreator
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
			this.label1 = new System.Windows.Forms.Label();
			this.grbPreferences = new System.Windows.Forms.GroupBox();
			this.txtRatio = new System.Windows.Forms.TextBox();
			this.txtNumberOfEquations = new System.Windows.Forms.TextBox();
			this.lblRatio = new System.Windows.Forms.Label();
			this.lblNumberOfEquations = new System.Windows.Forms.Label();
			this.chkIncludeZero = new System.Windows.Forms.CheckBox();
			this.btnRun = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.rtxtDisplay = new System.Windows.Forms.RichTextBox();
			this.grbLanguages = new System.Windows.Forms.GroupBox();
			this.rbtnVietnamese = new System.Windows.Forms.RadioButton();
			this.rbtnEnglish = new System.Windows.Forms.RadioButton();
			this.lblAuthor = new System.Windows.Forms.Label();
			this.llblGitHub = new System.Windows.Forms.LinkLabel();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.grbPreferences.SuspendLayout();
			this.grbLanguages.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(406, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "MATH CREATOR";
			// 
			// grbPreferences
			// 
			this.grbPreferences.Controls.Add(this.txtRatio);
			this.grbPreferences.Controls.Add(this.txtNumberOfEquations);
			this.grbPreferences.Controls.Add(this.lblRatio);
			this.grbPreferences.Controls.Add(this.lblNumberOfEquations);
			this.grbPreferences.Controls.Add(this.chkIncludeZero);
			this.grbPreferences.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbPreferences.Location = new System.Drawing.Point(27, 207);
			this.grbPreferences.Name = "grbPreferences";
			this.grbPreferences.Size = new System.Drawing.Size(434, 174);
			this.grbPreferences.TabIndex = 2;
			this.grbPreferences.TabStop = false;
			this.grbPreferences.Text = "Preferences";
			// 
			// txtRatio
			// 
			this.txtRatio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRatio.Location = new System.Drawing.Point(308, 123);
			this.txtRatio.Name = "txtRatio";
			this.txtRatio.Size = new System.Drawing.Size(103, 30);
			this.txtRatio.TabIndex = 5;
			this.txtRatio.Text = "1:1:1:1";
			// 
			// txtNumberOfEquations
			// 
			this.txtNumberOfEquations.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumberOfEquations.Location = new System.Drawing.Point(304, 75);
			this.txtNumberOfEquations.Name = "txtNumberOfEquations";
			this.txtNumberOfEquations.Size = new System.Drawing.Size(107, 30);
			this.txtNumberOfEquations.TabIndex = 4;
			this.txtNumberOfEquations.Text = "10";
			// 
			// lblRatio
			// 
			this.lblRatio.AutoSize = true;
			this.lblRatio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRatio.Location = new System.Drawing.Point(22, 126);
			this.lblRatio.Name = "lblRatio";
			this.lblRatio.Size = new System.Drawing.Size(284, 23);
			this.lblRatio.TabIndex = 1;
			this.lblRatio.Text = "Ratio of Four Math Operations:";
			// 
			// lblNumberOfEquations
			// 
			this.lblNumberOfEquations.AutoSize = true;
			this.lblNumberOfEquations.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumberOfEquations.Location = new System.Drawing.Point(22, 78);
			this.lblNumberOfEquations.Name = "lblNumberOfEquations";
			this.lblNumberOfEquations.Size = new System.Drawing.Size(199, 23);
			this.lblNumberOfEquations.TabIndex = 1;
			this.lblNumberOfEquations.Text = "Number of Equations:";
			// 
			// chkIncludeZero
			// 
			this.chkIncludeZero.AutoSize = true;
			this.chkIncludeZero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkIncludeZero.Location = new System.Drawing.Point(25, 33);
			this.chkIncludeZero.Name = "chkIncludeZero";
			this.chkIncludeZero.Size = new System.Drawing.Size(196, 27);
			this.chkIncludeZero.TabIndex = 3;
			this.chkIncludeZero.Text = "Include Number 0?";
			this.chkIncludeZero.UseVisualStyleBackColor = true;
			// 
			// btnRun
			// 
			this.btnRun.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRun.Location = new System.Drawing.Point(496, 127);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(116, 47);
			this.btnRun.TabIndex = 6;
			this.btnRun.Text = "Run";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(496, 206);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(116, 47);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(496, 285);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(116, 47);
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// rtxtDisplay
			// 
			this.rtxtDisplay.Enabled = false;
			this.rtxtDisplay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtxtDisplay.Location = new System.Drawing.Point(647, 95);
			this.rtxtDisplay.Name = "rtxtDisplay";
			this.rtxtDisplay.Size = new System.Drawing.Size(376, 286);
			this.rtxtDisplay.TabIndex = 4;
			this.rtxtDisplay.Text = "";
			// 
			// grbLanguages
			// 
			this.grbLanguages.Controls.Add(this.rbtnVietnamese);
			this.grbLanguages.Controls.Add(this.rbtnEnglish);
			this.grbLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbLanguages.Location = new System.Drawing.Point(27, 95);
			this.grbLanguages.Name = "grbLanguages";
			this.grbLanguages.Size = new System.Drawing.Size(434, 87);
			this.grbLanguages.TabIndex = 5;
			this.grbLanguages.TabStop = false;
			this.grbLanguages.Text = "Languages/Ngôn ngữ";
			// 
			// rbtnVietnamese
			// 
			this.rbtnVietnamese.AutoSize = true;
			this.rbtnVietnamese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtnVietnamese.Location = new System.Drawing.Point(178, 41);
			this.rbtnVietnamese.Name = "rbtnVietnamese";
			this.rbtnVietnamese.Size = new System.Drawing.Size(122, 29);
			this.rbtnVietnamese.TabIndex = 2;
			this.rbtnVietnamese.Text = "Tiếng Việt";
			this.rbtnVietnamese.UseVisualStyleBackColor = true;
			this.rbtnVietnamese.CheckedChanged += new System.EventHandler(this.rbtnVietnamese_CheckedChanged);
			// 
			// rbtnEnglish
			// 
			this.rbtnEnglish.AutoSize = true;
			this.rbtnEnglish.Checked = true;
			this.rbtnEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtnEnglish.Location = new System.Drawing.Point(16, 41);
			this.rbtnEnglish.Name = "rbtnEnglish";
			this.rbtnEnglish.Size = new System.Drawing.Size(97, 29);
			this.rbtnEnglish.TabIndex = 1;
			this.rbtnEnglish.TabStop = true;
			this.rbtnEnglish.Text = "English";
			this.rbtnEnglish.UseVisualStyleBackColor = true;
			// 
			// lblAuthor
			// 
			this.lblAuthor.AutoSize = true;
			this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAuthor.Location = new System.Drawing.Point(27, 388);
			this.lblAuthor.Name = "lblAuthor";
			this.lblAuthor.Size = new System.Drawing.Size(251, 24);
			this.lblAuthor.TabIndex = 6;
			this.lblAuthor.Text = "Created by Huy Pham(2021).";
			// 
			// llblGitHub
			// 
			this.llblGitHub.AutoSize = true;
			this.llblGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llblGitHub.Location = new System.Drawing.Point(282, 388);
			this.llblGitHub.Name = "llblGitHub";
			this.llblGitHub.Size = new System.Drawing.Size(68, 24);
			this.llblGitHub.TabIndex = 7;
			this.llblGitHub.TabStop = true;
			this.llblGitHub.Text = "GitHub";
			// 
			// progressBar
			// 
			this.progressBar.Enabled = false;
			this.progressBar.Location = new System.Drawing.Point(647, 389);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(376, 23);
			this.progressBar.TabIndex = 8;
			this.progressBar.Visible = false;
			// 
			// MathCreator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1071, 444);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.llblGitHub);
			this.Controls.Add(this.lblAuthor);
			this.Controls.Add(this.grbLanguages);
			this.Controls.Add(this.rtxtDisplay);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.grbPreferences);
			this.Controls.Add(this.label1);
			this.Name = "MathCreator";
			this.Text = "MathCreator";
			this.Load += new System.EventHandler(this.MathCreator_Load);
			this.grbPreferences.ResumeLayout(false);
			this.grbPreferences.PerformLayout();
			this.grbLanguages.ResumeLayout(false);
			this.grbLanguages.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox grbPreferences;
		private System.Windows.Forms.TextBox txtNumberOfEquations;
		private System.Windows.Forms.Label lblRatio;
		private System.Windows.Forms.Label lblNumberOfEquations;
		private System.Windows.Forms.CheckBox chkIncludeZero;
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.RichTextBox rtxtDisplay;
		private System.Windows.Forms.TextBox txtRatio;
		private System.Windows.Forms.GroupBox grbLanguages;
		private System.Windows.Forms.RadioButton rbtnVietnamese;
		private System.Windows.Forms.RadioButton rbtnEnglish;
		private System.Windows.Forms.Label lblAuthor;
		private System.Windows.Forms.LinkLabel llblGitHub;
		private System.Windows.Forms.ProgressBar progressBar;
	}
}

