using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskAlif
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            { 
                StreamReader sr = new StreamReader(args[0]);
                StringBuilder posBuilder = new StringBuilder();
                StringBuilder negBuilder = new StringBuilder();
                line = sr.ReadLine();
                 
                while (line != null)
                {
                    String[] words = line.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                    int first = Int32.Parse(words[0]);
                    int second = Int32.Parse(words[1]);
                    int result = 0;
                    switch (args[1])
                    {
                        case "*":
                            result = first * second;
                            break;
                        case "/":
                            result = first * second;
                            break;
                        case "+":
                            result = first * second;
                            break;
                        case "-":
                            result = first * second;
                            break;
                    }
                    if(result >= 0)
                    {
                        posBuilder.Append(result).Append("\n");
                    }
                    else
                    {
                        negBuilder.Append(result).Append("\n");
                    }
                    line = sr.ReadLine();
                }
                sr.Close();

                StreamWriter posWriter = new StreamWriter("C:\\posOutput.txt");
                posWriter.Write(posBuilder.ToString().Trim());
                posWriter.Flush();
                posWriter.Close();

                StreamWriter negWriter = new StreamWriter("C:\\negOutput.txt");
                negWriter.Write(negBuilder.ToString().Trim());
                negWriter.Flush();
                negWriter.Close();
                
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
