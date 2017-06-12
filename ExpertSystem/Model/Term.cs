using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.Model
{
    public class Term
    {
        private string _name;
        private TriangleFunction _function;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public TriangleFunction Function
        {
            get { return _function; }
            set { _function = value; }
        }

        public Term(string name, TriangleFunction function)
        {
            _name = name;
            _function = function;
        }

        public override string ToString()
        {
            return string.Format("Name term: {0}; {1}", _name, _function);
        }
    }
}
