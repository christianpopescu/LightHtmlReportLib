using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            writeStringToFile("test.html", createSimpleHtmlDocument());
        }

        static string createSimpleHtmlDocument()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"<!DOCTYPE html>")
                .Append("<Html>")
                    .Append("<body>")
                        .Append("<p>")
                        .Append("This is a paragraph!")
                        .Append("</p>")
                    .Append("</body>")
                .Append("</Html>");
            return sb.ToString();
        }

        static void writeStringToFile(string pFileName, string pContent)
        {

            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(pFileName))
            {
                sw.Write(pContent);
            }

        }

    }
}
