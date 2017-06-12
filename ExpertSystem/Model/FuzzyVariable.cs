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

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public VariableType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public List<Term> TermsList
        {
            get { return _termsList; }
            set { _termsList = value; }
        }
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        public float Min
        {
            get { return _min; }
            set { _min = value; }
        }
        public float Max
        {
            get { return _max; }
            set { _max = value; }
        }

        public FuzzyVariable() { }

    }
}
