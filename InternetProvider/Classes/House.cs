using System.Runtime.CompilerServices;

namespace InternetProvider.Classes
{
    public class House
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public String Address { get; set; }

        public override string ToString()
        {
            return $"{Address} д.{Number}";
        }
    }
}
