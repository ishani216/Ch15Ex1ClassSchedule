using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ClassSchedule.TagHelpers
{
    [HtmlTargetElement(Attributes = "[type=submit]")]
    public class SubmitButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext ctx, TagHelperOutput output)
        {
            output.Attributes.AppendCssClass("btn btn-dark");
        }
    }
}
