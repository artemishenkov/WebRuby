using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRuby.Models.Tags
{
    public class Input
    {
        public IDictionary<string, string> HtmlAttributes { get; }
        public Input(IDictionary<string, string> htmlAttributes)
        {
            HtmlAttributes = htmlAttributes;
        }
    }
}