using Piranha.AttributeBuilder;
using Piranha.Extend.Fields;
using Piranha.Extend;

namespace NorthwindCms.Models.Regions
{
    public class CategoryRegion
    {
        [Field(Title="Category ID")]
        public NumberField CategoryID {get;set;}
        [Field(Title="Category Name")]
        public TextField CategoryName{get;set;}
        [Field]
        public HtmlField Description{get;set;}
        [Field(Title="Category image")]
        public ImageField CategoryImage{get;set;}
    }
}