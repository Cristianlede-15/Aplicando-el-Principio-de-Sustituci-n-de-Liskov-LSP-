using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicando_el_Principio_de_Sustitución_de_Liskov__LSP_
{
    public class HybridCourse : Course
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine($"El estudiante {std.Name} se inscribio en el curso hibrido...");
        }
    }
}
