using System;
using System.Collections.Generic;
public interface IHtmlElement
{
	 String TagName { get; set; }
	 String Content { get; set; }
	 String AsText();
	 List<IHtmlElement> children { get; set; }
}
