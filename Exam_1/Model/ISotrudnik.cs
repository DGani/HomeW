using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1
{
   public interface ISotrudnik
    {
         string FIO { get; set; }
         int ID { get; set; }
         string Position { get; set; }
         int Age { get; set; }
         string Department { get; set; }
    }
}
