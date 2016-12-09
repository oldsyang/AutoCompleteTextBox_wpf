using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyWPFUI.Controls;

namespace AutoCompleteTextBox.Models
{
    public class StudentModel : MyPropertyChanged
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Code { get; set; }
    }
}
