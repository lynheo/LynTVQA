using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Property
{
    public enum EnglishHelloType
    {
        Hello,
        Hi
    }

    public class SerializeTest
    {
        public string Name { get; set; }

        [JsonProperty(PropertyName ="HelloType")]
        public string HelloTypeString
        {
            get
            {
                return HelloType.ToString();
            }
            set
            {
                HelloType = (EnglishHelloType)Enum.Parse(typeof(EnglishHelloType), value);
            }
        }
        [JsonIgnore]
        public EnglishHelloType HelloType { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var testObj = new SerializeTest()
            {
                Name = "Lyn",
                HelloType = EnglishHelloType.Hello
            };

            var jsonText = JsonConvert.SerializeObject(testObj);
            Console.WriteLine(jsonText);
            var newObj = JsonConvert.DeserializeObject<SerializeTest>(jsonText);            
        }
    }
}
