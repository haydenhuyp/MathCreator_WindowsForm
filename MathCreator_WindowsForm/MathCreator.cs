using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathCreator_WindowsForm
{
	public partial class MathCreator : Form
	{
		public MathCreator()
		{
			InitializeComponent();
		}
		private void btnRun_Click(object sender, EventArgs e)
		{
			// Validations
			rtxtDisplay.Text = "";
			Regex numberPattern = new Regex(@"^\d+$");
			if (!numberPattern.IsMatch(txtNumberOfEquations.Text))
			{
				txtNumberOfEquations.Focus();
				if (rbtnEnglish.Checked)
				{
					rtxtDisplay.Text = "Number of Equations must be numeric (E.g. 1, 2, etc.)";
				}
				else
				{
					rtxtDisplay.Text = "Số lượng phép toán phải bằng số (VD: 1, 2 ,3)";
				}
			}
			else
			{
				Regex ratioPattern = new Regex(@"^(\d[:]){3}\d$");
				if (!ratioPattern.IsMatch(txtRatio.Text))
				{
					txtRatio.Focus();
					if (rbtnEnglish.Checked)
					{
						rtxtDisplay.Text = "Ratio is not in proper format (e.g. 1:1:1:1)";
					}
					else
					{
						rtxtDisplay.Text = "Tỉ lệ không đúng (VD 1:1:1:1)";
					}
				}
			}

			// Main code
			if (rtxtDisplay.Text == "")
			{
				// Deactivate input fields 
				grbLanguages.Enabled = false;
				grbPreferences.Enabled = false;
				btnRun.Enabled = false;
				btnClose.Enabled = false;
				progressBar.Visible = true;

				int numberOfEquations = int.Parse(txtNumberOfEquations.Text);
				int ratioOfAddition, ratioOfSubtraction, ratioOfMultiplication, ratioOfDivision;
				string[] ratio = txtRatio.Text.Split(':');
				ratioOfAddition = int.Parse(ratio[0]);
				ratioOfSubtraction = int.Parse(ratio[1]);
				ratioOfMultiplication = int.Parse(ratio[2]);
				ratioOfDivision = int.Parse(ratio[3]);
				int totalRatio = ratioOfAddition + ratioOfSubtraction + ratioOfMultiplication + ratioOfDivision;

				double numberOfAdditions, numberOfSubtractions, numberOfMultiplications, numberOfDivisions;
				numberOfAdditions = numberOfEquations / totalRatio * ratioOfAddition;
				numberOfAdditions = Math.Round(numberOfAdditions);
				numberOfSubtractions = numberOfEquations / totalRatio * ratioOfSubtraction;
				numberOfSubtractions = Math.Round(numberOfSubtractions);
				numberOfMultiplications = numberOfEquations / totalRatio * ratioOfMultiplication;
				numberOfMultiplications = Math.Round(numberOfMultiplications);
				numberOfDivisions = numberOfEquations / totalRatio * ratioOfDivision;
				numberOfDivisions = Math.Round(numberOfDivisions);

				// Generate equations
				int operations = 0;
				int i = 0;
				int a = 0; // first number
				int b = 0; // second number
				int minValue, maxValue;
				List<string> equationList = new List<string>();
				if (chkIncludeZero.Checked)
				{
					minValue = 0;
				}
				else
				{
					minValue = 1;
				}
				while (i <= numberOfEquations)
				{
					var rand = new Random();
					operations = rand.Next(0, 5);
					i++;
					Thread.Sleep(100);
					switch (operations)
					{
						case 1: // Add
							{
								maxValue = 9;
								equationList.Add(rand.Next(minValue, maxValue).ToString() + " + " + rand.Next(minValue, maxValue).ToString() + " =");
								break;
							}
						case 2: // Subtract
							{
								do
								{
									maxValue = 10;
									a = rand.Next(minValue, maxValue);
									b = rand.Next(minValue, maxValue);
								} while (a <= b);
								equationList.Add(a.ToString() + " - " + b.ToString() + " =");
								break;
							}
						case 3: // Multiplication
							{
								maxValue = 9;
								equationList.Add(rand.Next(minValue, maxValue).ToString() + " x " + rand.Next(minValue, maxValue).ToString() + " =");
								break;
							}
						case 4: // Division
							{
								minValue = 1;
								maxValue = 9;
								a = rand.Next(minValue, maxValue);
								b = rand.Next(minValue, maxValue);
								int product = a * b;
								if (DateTime.Now.Second % 2 == 0)
								{ 
									equationList.Add(product.ToString() + " : " + a.ToString() + " ="); 
								}
								else
								{
									equationList.Add(product.ToString() + " : " + b.ToString() + " =");
								}
								break;
							}
						default:
							i--;
							break;
					}
				}
				try 
				{
					FileIO.WriteToFile(equationList);
				}
				catch (Exception ex)
				{
					rtxtDisplay.Text = "Error in writing to file: "+ex.Message;
				}
				if (rtxtDisplay.Text == "")
				{
					rtxtDisplay.Text = "Finished.";
					grbLanguages.Enabled = true;
					grbPreferences.Enabled = true;
					btnRun.Enabled = true;
					btnClose.Enabled = true;
					progressBar.Visible = false;
				}
			}
		}
		private void rbtnVietnamese_CheckedChanged(object sender, EventArgs e)
		{
			if (rbtnVietnamese.Checked)
			{
				grbPreferences.Text = "Lựa chọn";
				chkIncludeZero.Text = "Chứa số 0?";
				lblNumberOfEquations.Text = "Số lượng phép toán:";
				lblRatio.Text = "Tỉ lệ 4 phép toán:";
				lblAuthor.Text = "Được tạo bởi Huy Pham";
				btnRun.Text = "Chạy";
				btnCancel.Text = "Hủy";
				btnClose.Text = "Thoát";
			}
			else
			{
				grbPreferences.Text = "Preferences";
				chkIncludeZero.Text = "Include Number 0?";
				lblNumberOfEquations.Text = "Number Of Equations:";
				lblRatio.Text = "Ratio of Four Math Operations::";
				lblAuthor.Text = "Created by Huy Pham (2021).";
				btnRun.Text = "Run";
				btnCancel.Text = "Cancel";
				btnClose.Text = "Exit";
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void MathCreator_Load(object sender, EventArgs e)
		{
			rtxtDisplay.Text = "This program will create math equations (addition, subtraction, multiplication, division)";
			rtxtDisplay.Text += "\nPhần mềm này sẽ tạo ra các câu hỏi phép toán (cộng, trừ, nhân, chia)";

			rtxtDisplay.Text += "\n\nAll equations will be in a Microsoft Word Document File";
			rtxtDisplay.Text += "\nCác phép toán sẽ được lưu trong file Word";
			try
			{
				FileIO.CheckFile();
			}
			catch
			{
				rtxtDisplay.Text = "Problems creating file\nXảy ra lỗi khi tạo file";
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (!btnRun.Enabled)
			{
				// Activate input fields 
				grbLanguages.Enabled = true;
				grbPreferences.Enabled = true;
				btnRun.Enabled = true;
				btnClose.Enabled = true;
				progressBar.Value = 0;
			}

		}
	}
}
