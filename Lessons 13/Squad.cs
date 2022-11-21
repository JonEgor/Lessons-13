using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_13
{
    [Serializable] // Условия 
    internal class Squad
    {
        public string squadName { get; set; }
        public string homeTown { get; set; }
        public int formed { get; set; }
        public string secretBase { get; set; }
        public bool active { get; set; }
        public List<Members> members { get; set; }
    
    }

    [Serializable] // Пользовательская сериализация 
    public class Members
    {
        public string name { get; set; }
        public int age { get; set; }
        public string secretIdentity { get; set; }
        public List<string> powers { get; set; }

    }




}
