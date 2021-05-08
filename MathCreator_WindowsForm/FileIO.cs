using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MathCreator_WindowsForm
{
	class FileIO
	{
		private static string path = "math.txt";
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
                throw new Exception("Problems creating file: " + ex.Message);
            }
        }
        /// <summary>
        /// Accepts a string and write it to the file
        /// </summary>
        /// <param name="input">The string to be written to the file</param>
        public static void WriteToFile(string input)
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
                throw new Exception("Error writing record to file: " + ex.Message);
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
        public static void WriteToFile(List<String> listOfString)
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
                throw new Exception("Error writing record to file: " + ex.Message);
            }
            finally
            {
                writer.Dispose();
            }
        }
    }
}
