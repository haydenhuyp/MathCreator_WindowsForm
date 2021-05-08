/* MathCreator.cs
 * 
 * To generate randomized math equations with four math operations (plus, minus, multiply and divide)
 * 
 * Author: Huy Pham
 * 
 * Created on May 7th 2021
 * Finished on May 8th 2021
 */
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
			rtxtDisplay.Clear();
			rtxtDisplay.ForeColor = System.Drawing.Color.Red;
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
				Regex ratioPattern = new Regex(@"^(\d+[:]){3}\d+$");
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
				else
				{
					string[] ratio = txtRatio.Text.Split(':');
					// Simplify the ratio
					uint gcd = GetGCD(GetGCD(uint.Parse(ratio[0]), uint.Parse(ratio[1])), GetGCD(uint.Parse(ratio[2]), uint.Parse(ratio[3])));
					for (int i = 0; i < 4; i++)
					{
						ratio[i] = (uint.Parse(ratio[i]) / gcd).ToString();
					}
					int sum = 0;
					txtRatio.Text = ratio[0] + ':' + ratio[1] + ':' + ratio[2] + ':' + ratio[3];
					foreach (string digit in ratio)
					{
						sum = sum + int.Parse(digit);
					}
					if (sum > int.Parse(txtNumberOfEquations.Text))
					{
						txtRatio.Focus();
						if (rbtnEnglish.Checked)
						{
							rtxtDisplay.Text = "Ratio is not in appropriate (Sum of ratio must be less than the number of equations)";
						}
						else
						{
							rtxtDisplay.Text = "Tỉ lệ không phù hợp (Tổng tỉ lệ phải nhỏ hơn số phép toán.)";
						}
					}
				}
			}

			// Main code
			if (rtxtDisplay.Text == "")
			{
				// Deactivate input fields
				rtxtDisplay.Clear();
				rtxtDisplay.ForeColor = SystemColors.ControlText;
				if (rbtnEnglish.Checked)
				{
					rtxtDisplay.Text = "Running...";
				}
				if (rbtnVietnamese.Checked)
				{
					rtxtDisplay.Text = "Đang xử lí...";
				}
				grbLanguages.Enabled = false;
				grbPreferences.Enabled = false;
				btnRun.Enabled = false;
				btnClose.Enabled = false;
				progressBar.Visible = true;

				progressBar.Value = 20;
				int numberOfEquations = int.Parse(txtNumberOfEquations.Text);
				int estimatedTime = numberOfEquations / 1000 + 10;
				if (rbtnEnglish.Checked)
				{
					rtxtDisplay.Text = "Running...\nPlease wait for a moment. \nEstimated time: " + estimatedTime + " seconds";
				}
				if (rbtnVietnamese.Checked)
				{
					rtxtDisplay.Text = "Đang xử lí...\nVui lòng đợi trong giây lát.\nDự kiến: " + estimatedTime + " giây.";
				}
				Thread.Sleep(1000);

				/* Dealing with ratio */
				int ratioOfAddition, ratioOfSubtraction, ratioOfMultiplication, ratioOfDivision;
				string[] ratio = txtRatio.Text.Split(':');
				ratioOfAddition = int.Parse(ratio[0]);
				ratioOfSubtraction = int.Parse(ratio[1]);
				ratioOfMultiplication = int.Parse(ratio[2]);
				ratioOfDivision = int.Parse(ratio[3]);
				int totalRatio = ratioOfAddition + ratioOfSubtraction + ratioOfMultiplication + ratioOfDivision;

				/* CALCULATE HOW MANY ADDS, SUBTRACTIONS, ETC. WE NEED */
				int numberOfAdditions, numberOfSubtractions, numberOfMultiplications, numberOfDivisions;
				int portion = numberOfEquations / totalRatio;
				numberOfAdditions = portion * ratioOfAddition;
				numberOfSubtractions = portion * ratioOfSubtraction;
				numberOfMultiplications = portion * ratioOfMultiplication;
				numberOfDivisions = portion * ratioOfDivision;
				int remainder = numberOfEquations % totalRatio;
				if (remainder > 0)
				{
					if (remainder % 2 == 0)
					{
						numberOfAdditions += remainder / 2;
						numberOfSubtractions += remainder / 2;
					}
					else
					{
						numberOfAdditions += remainder / 2 + 1;
						numberOfSubtractions += remainder / 2;
					}
				}

				progressBar.Value = 40;

				// Generate equations
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

				progressBar.Value = 50;

				for (int i = 0; i < numberOfAdditions; i++)
				{
					var rand = new Random();
					Thread.Sleep(1);
					maxValue = 9;
					equationList.Add(rand.Next(minValue, maxValue).ToString() + " + " + rand.Next(minValue, maxValue).ToString() + " =");
				}
				for (int i = 0; i < numberOfSubtractions; i++)
				{
					var rand = new Random();
					do
					{
						maxValue = 10;
						a = rand.Next(minValue, maxValue);
						Thread.Sleep(1);
						b = rand.Next(minValue, maxValue);
					} while (a <= b);
					equationList.Add(a.ToString() + " - " + b.ToString() + " =");
				}
				for (int i = 0; i < numberOfMultiplications; i++)
				{
					var rand = new Random();
					Thread.Sleep(1);
					maxValue = 9;
					equationList.Add(rand.Next(minValue, maxValue).ToString() + " x " + rand.Next(minValue, maxValue).ToString() + " =");
				}
				for (int i = 0; i < numberOfDivisions; i++)
				{
					var rand = new Random();
					minValue = 2;
					maxValue = 9;
					a = rand.Next(minValue, maxValue);
					Thread.Sleep(1);
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
				}

				progressBar.Value = 80;

				// shuffle the list
				equationList = equationList.OrderBy(x => Guid.NewGuid()).ToList();
				try
				{
					FileIO.WriteToTextFile(equationList);
					FileIO.WriteToWordDocument(equationList);
				}
				catch (Exception ex)
				{
					rtxtDisplay.Text = "Error in writing to file: " + ex.Message;
				}

				progressBar.Value = 100;

				if (!rtxtDisplay.Text.StartsWith("Error"))
				{
					if (rbtnEnglish.Checked)
					{
						rtxtDisplay.Text = "Finished.\n\n";
						rtxtDisplay.Text += "Total: " + numberOfEquations + "\n";
						rtxtDisplay.Text += "Quantity of additions: " + numberOfAdditions + "\n";
						rtxtDisplay.Text += "Quantity of subtractions: " + numberOfSubtractions + "\n";
						rtxtDisplay.Text += "Quantity of multiplications: " + numberOfMultiplications + "\n";
						rtxtDisplay.Text += "Quantity of divisions: " + numberOfDivisions + "\n";
					}
					if (rbtnVietnamese.Checked)
					{
						rtxtDisplay.Text = "Hoàn tất.\n\n";
						rtxtDisplay.Text += "Tổng cộng: " + numberOfEquations + "\n";
						rtxtDisplay.Text += "Phép cộng: " + numberOfAdditions + "\n";
						rtxtDisplay.Text += "Phép trừ: " + numberOfSubtractions + "\n";
						rtxtDisplay.Text += "Phép nhân: " + numberOfMultiplications + "\n";
						rtxtDisplay.Text += "Phép chia: " + numberOfDivisions + "\n";
					}

					try
					{
						FileIO.OpenWordDocument();
					}
					catch (Exception ex)
					{
						rtxtDisplay.Text = "Error in opening Word Document: " + ex.Message;
					}
				}
			}
			grbLanguages.Enabled = true;
			grbPreferences.Enabled = true;
			btnRun.Enabled = true;
			btnClose.Enabled = true;
			progressBar.Visible = false;
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

			rtxtDisplay.Text += "\n\nThe Word document is in your Desktop folder";
			rtxtDisplay.Text += "\nFile Word sẽ được lưu trên Desktop (màn hình chính)";
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

		/// <summary>
		/// Accepts two unsign integer (uint), return the greatest common divisor (GCD)
		/// </summary>
		/// <param name="a">First number</param>
		/// <param name="b">Second number</param>
		/// <returns></returns>
		private uint GetGCD(uint a, uint b)
		{
			uint temporary = 0;
			while (a != 0 && b != 0)
			{
				if (a < b)
				{
					temporary = a;
					a = b;
					b = temporary;
				}
				a = a % b;
			}
			if (a == 0)
			{
				return b;
			}
			else
			{
				return a;
			}
		}
	}
}
