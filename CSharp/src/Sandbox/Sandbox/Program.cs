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
                        .Append("<h1>")
                        .Append("This is a header")
                        .Append("</h1>")
                        .Append("<p>")
                        .Append("This is a paragraph!")
                        .Append("</p>")
                        .Append("<table style=\"border: 2px solid black;border-collapse: collapse;\">")
                        .Append("<tr>")
                            .Append("<th style=\"color: blue; border: 1px solid black; \">")
                            .Append("Column 1")
                            .Append("</th>")
                            .Append("<th style=\"border: 1px solid black; border-collapse: collapse;\">")
                            .Append("Column 2")
                            .Append("</th>")
                        .Append("</tr>")
                        .Append("<tr>")
                            .Append("<td style=\"border: 1px solid black;border-collapse: collapse;\">")
                            .Append("Value 1")
                            .Append("</td>")
                            .Append("<td style=\"border: 1px solid black;border-collapse: collapse;\">")
                            .Append("Value 2")
                            .Append("</td>")
                        .Append("</tr>")
                        .Append("</table>")

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
