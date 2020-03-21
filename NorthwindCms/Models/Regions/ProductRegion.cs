using Piranha.AttributeBuilder;
using Piranha.Extend.Fields;
using Piranha.Extend;
using Piranha.Models;

namespace NorthwindCms.Models.Regions
{
    public class ProductRegion
    {
        [Field(Title="Product ID")]
        public NumberField ProductID {get;set;}
        [Field(Title="Product Name")]
        public TextField ProductName{get;set;}
        [Field(Title="Unit price", Options=FieldOption.HalfWidth)]
        public StringField UnitPrice{get;set;}
        [Field(Title="Units in stock", Options=FieldOption.HalfWidth)]
        public NumberField UnitsInStock{get;set;}
    }
}