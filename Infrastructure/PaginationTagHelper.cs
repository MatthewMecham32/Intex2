
using justTesting.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace justTesting.Infrastructure
{
    //creates necessary tag helper for pagination
    [HtmlTargetElement("div", Attributes = "page-info")]
    public class PaginationTagHelper : TagHelper
    {
        private IUrlHelperFactory urlInfo;
        public PaginationTagHelper(IUrlHelperFactory uhf)
        {
            urlInfo = uhf;
        }
        //creates the necessary instances and variables 
        public PageNumberingInfo PageInfo { get; set; }
        public bool PageClassesEnabled { get; set; }
        public virtual string ToolTip { get; set; }
        public string PageClassNormal { get; set; }
        public string PageClassSelected { get; set; }
        public string PageClass { get; set; }
        //sets the dictionary and its attribute to be called in other files 
        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> KeyValuePairs { get; set; } = new Dictionary<string, object>();
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelp = urlInfo.GetUrlHelper(ViewContext);
            TagBuilder finishedTag = new TagBuilder("div");

            //sets the page numbering at the bottom and whether or not it has been selected
            for (int i = 1; i <= PageInfo.NumPages; i++)
            {
                TagBuilder individualTag = new TagBuilder("a");

                KeyValuePairs["pageNum"] = i;
                individualTag.Attributes["href"] = urlHelp.Action("BurialList", KeyValuePairs);

                    individualTag.AddCssClass(PageClass);
                    individualTag.AddCssClass(i == PageInfo.CurrentPage ? PageClassSelected : PageClassNormal);
                    individualTag.AddCssClass(ToolTip);
               
                //adds necessary info to the a tag
                individualTag.InnerHtml.Append(i.ToString());

                //adds the new a tag to the div
                finishedTag.InnerHtml.AppendHtml(individualTag);
            }



            output.Content.AppendHtml(finishedTag.InnerHtml);
        }
    }
}
