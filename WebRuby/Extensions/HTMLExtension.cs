using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebRuby.Extension
{
    public static class HTMLExtension
    {                   
        public static MvcHtmlString Button(this HtmlHelper htmlHelper, string innerHtml, IDictionary<string, string> htmlAttributes)
        {
            var button = new TagBuilder("button");
            button.InnerHtml = innerHtml;
            button.MergeAttributes(htmlAttributes);
            return MvcHtmlString.Create(button.ToString());
        }
        public static MvcHtmlString Input(this HtmlHelper htmlHelper, IDictionary<string, string> htmlAttributes)
        {
            var input = new TagBuilder("input");
            input.MergeAttributes(htmlAttributes);
            return MvcHtmlString.Create(input.ToString());
        }
    }
}