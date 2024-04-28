using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahlama.Models.ollama
{
    public class GenerateInput
    {
        public string model { get; set; }
        public string prompt { get; set; }
    }

}
