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
            
            writeStringToFile("test.html", createSimpleHtmlDocumentV1());


        }

        static string createSimpleHtmlDocument()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"<!DOCTYPE html>")
                .Append("<Html>")
                    .Append("<head>")
                        .Append("<style>")
                        .Append("table {border: 2px solid black;border-collapse: collapse;} ")
                        .Append("td {border: 1px solid black;border-collapse: collapse;}")
                        .Append("</style>")
                    .Append("</head>")
                    .Append("<body>")
                        .Append("<h1>")
                        .Append("This is a header")
                        .Append("</h1>")
                        .Append("<p>")
                        .Append("This is a paragraph!")
                        .Append("</p>")
                        .Append("<table>")
                        .Append("<tr>")
                            .Append("<th style=\"color: blue; border: 1px solid black; \">")
                            .Append("Column 1")
                            .Append("</th>")
                            .Append("<th style=\"border: 1px solid black; border-collapse: collapse;\">")
                            .Append("Column 2")
                            .Append("</th>")
                        .Append("</tr>")
                        .Append("<tr>")
                            .Append("<td>")
                            .Append("Value 1")
                            .Append("</td>")
                            .Append("<td>")
                            .Append("Value 2")
                            .Append("</td>")
                        .Append("</tr>")
                        .Append("</table>")

                    .Append("</body>")
                .Append("</Html>");
            return sb.ToString();
        }

        // Using HTML object Helpers
    static string createSimpleHtmlDocumentV1()
        {
            HtmlElement paragraph = new HtmlElement("p","This is a paragraph");
            HtmlElement header = new HtmlElement("h1", "This is a header");
            List<IHtmlElement> listOfElements = new List<IHtmlElement>();
            listOfElements.Add(header);
            listOfElements.Add(paragraph);
            StringBuilder sb = new StringBuilder();
            sb.Append(@"<!DOCTYPE html>")
                .Append("<Html>")
                    .Append("<head>")
                        .Append("<style>")
                        .Append("table {border: 2px solid black;border-collapse: collapse;} ")
                        .Append("td {border: 1px solid black;border-collapse: collapse;}")
                        .Append("</style>")
                    .Append("</head>")
                    .Append("<body>")
                        .Append(listOfElements[0].AsText())
                        .Append(listOfElements[1].AsText())
                        .Append("<table>")
                        .Append("<tr>")
                            .Append("<th style=\"color: blue; border: 1px solid black; \">")
                            .Append("Column 1")
                            .Append("</th>")
                            .Append("<th style=\"border: 1px solid black; border-collapse: collapse;\">")
                            .Append("Column 2")
                            .Append("</th>")
                        .Append("</tr>")
                        .Append("<tr>")
                            .Append("<td>")
                            .Append("Value 1")
                            .Append("</td>")
                            .Append("<td>")
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
