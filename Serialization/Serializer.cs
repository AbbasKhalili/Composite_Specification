using System;
using System.Linq;
using System.Text;

namespace Serialization.Tests
{
    public class Serializer
    {
        public static string Serialize(object input)
        {
            var properties = input.GetType().GetProperties().ToList();

            var nameOfClass = input.GetType().Name;
            var outputXmlBuilder = new StringBuilder();
            outputXmlBuilder.Append($"<{nameOfClass}>");
            
            foreach (var propertyInfo in properties)
            {
                var nameOfProperty = propertyInfo.Name;
                var value = propertyInfo.GetValue(input);
                outputXmlBuilder.Append($"<{nameOfProperty}>{value}</{nameOfProperty}>");
            }
            outputXmlBuilder.Append($"</{nameOfClass}>");
            return outputXmlBuilder.ToString();
        }
    }
}
