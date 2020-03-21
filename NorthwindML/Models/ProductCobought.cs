
using Microsoft.ML.Data; 
namespace NorthwindML.Models
{
    public class ProductCobought
    {
        [KeyType(77)]
        public uint ProductID{get;set;}
        [KeyType(77)]
        public uint CoboughtProductID{get;set;}
    }
}