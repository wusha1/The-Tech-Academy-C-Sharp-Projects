using System.Collections.Generic;

namespace ParametersAssignment
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }
    }
}