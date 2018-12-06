using System;

namespace Converter.Models
{
    public class ConverterViewModel
    {
        public decimal ValueToConvert {get; set; }
        public string ConversionType {get; set; }
        public decimal ConvertedValue {get; set; }
    }
}