using System;
using System.Collections.Generic;
using System.Text;

public class HtmlElement : IHtmlElement
{
	public HtmlElement()
	{
	}

    public string TagName { get ; set ; }
    public string Content { get; set; }
    public List<IHtmlElement> children { get ; set ; }


    public HtmlElement(string tagName, string content)
    {
        TagName = tagName;
        Content = content;
        this.children = children;
    }

    public string AsText()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<").Append(TagName).Append(">")
        .Append(Content)
        .Append("</").Append(TagName).Append(">");

        return sb.ToString();
    }
}
