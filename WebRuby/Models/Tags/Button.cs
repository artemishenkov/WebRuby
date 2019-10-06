using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRuby.Models.Tags
{
    public class Button
    {
        public string InnerHtml { get; } 
        public IDictionary<string, string> HtmlAttributes { get; }
        public Button(string innerHtml, IDictionary<string, string> htmlAttributes)
        {
            InnerHtml = innerHtml;
            HtmlAttributes = htmlAttributes;
        }
    }
}