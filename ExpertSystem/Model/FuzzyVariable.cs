using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.Model
{
    public enum VariableType : byte{
        Input = 0,
        Output,
        Intermadiate
    };

    public class FuzzyVariable
    {
        private string _name;
        private VariableType _type;
        private List<Term> _termsList;
        private string _comment;
        private float _min;
        private float _max;

        public string Name { get; set; }
        public VariableType Type { get; set; }
        public List<Term> TermsList { get; set; }
        public string Comment { get; set; }
        public float Min { get; set; }
        public float Max { get; set; }

        public FuzzyVariable() { }

    }
}
