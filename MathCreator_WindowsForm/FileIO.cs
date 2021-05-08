/* FileIO.cs
 * 
 * To process everything relating to File Input/Output,
 *  it's an encapsulated class
 * 
 * Author: Huy Pham
 * 
 * Created on May 7th 2021
 * Finished on May 8th 2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using Microsoft.Office.Interop.Word;

namespace MathCreator_WindowsForm
{
	class FileIO
	{
		private static string path = "math.txt";
		private static string wordDocumentPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\math.docx";

		static StreamReader reader;
		static StreamWriter writer;

		/// <summary>
		/// Make sure the file is there, create the file if not exists
		/// </summary>
		public static void CheckFile()
		{
			try
			{
				if (!File.Exists(path))
				{
					File.Create(path).Dispose();
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Problems creating text file: " + ex.Message);
			}
		}
		/// <summary>
		/// Accepts a string and write it to the file
		/// </summary>
		/// <param name="input">The string to be written to the file</param>
		public static void WriteToTextFile(string input)
		{
			try
			{
				using (writer = new StreamWriter(path, append: true))
				{
					writer.WriteLine(input);
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error writing record to text file: " + ex.Message);
			}
			finally
			{
				writer.Dispose();
			}
		}
		/// <summary>
		/// Accepts a string list and write to file, each item on one line
		/// </summary>
		/// <param name="listOfString">List of strings to be written to file</param>
		public static void WriteToTextFile(List<String> listOfString)
		{
			try
			{
				using (writer = new StreamWriter(path, append: false))
				{
					foreach (string item in listOfString)
					{
						writer.WriteLine(item);
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error writing record to text file: " + ex.Message);
			}
			finally
			{
				writer.Dispose();
			}
		}
		/// <summary>
		/// Accepts a string list and write to Word document
		/// </summary>
		/// <param name="inputList">String list to be written to Word Document File</param>
		public static void WriteToWordDocument(List<string> inputList)
		{
			try
			{

				// Create application
				Application objWord = new Application();
				objWord.Visible = true;
				objWord.WindowState = WdWindowState.wdWindowStateNormal;

				// Create the document
				Document objDoc = objWord.Documents.Add();


				// Add
				object missing = System.Reflection.Missing.Value;
				Microsoft.Office.Interop.Word.Paragraph objPara;
				objPara = objDoc.Paragraphs.Add();
				float margin = float.Parse("36");
				objDoc.PageSetup.TopMargin = margin;
				objDoc.PageSetup.RightMargin = margin;
				objDoc.PageSetup.BottomMargin = margin;
				objDoc.PageSetup.LeftMargin = margin;
				Table firstTable = objDoc.Tables.Add(objPara.Range, inputList.Count / 2 + 1, 2, ref missing, ref missing);
				
				int i = 0;
				foreach (Row row in firstTable.Rows)
				{
					foreach (Cell cell in row.Cells)
					{
						if (i < inputList.Count)
						{
							cell.Height = 35;
							cell.Range.Font.Size = 16;
							cell.Range.Font.Name = "Arial";
							cell.Range.Text = inputList[i];
							i++;
						}
					}
				}
				objDoc.SaveAs2(wordDocumentPath);
				// Close
				objDoc.Close();
				objWord.Quit();

			}
			catch (Exception ex)
			{
				throw new Exception(("Error in writing to Word Document: ") + ex.Message);

			}
		}
		/// <summary>
		/// Open the text file
		/// </summary>
		public static void OpenTextFile()
		{
			Process.Start(path);
		}
		/// <summary>
		/// Open Word Document File
		/// </summary>
		public static void OpenWordDocument()
		{
			Process.Start(wordDocumentPath);
		}
	}
}
