using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.Model
{
    public class RuleBlock
    {
        private string _name;
        private List<FuzzyVariable> _inputVariables;
        private List<FuzzyVariable> _outputVariables;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public List<FuzzyVariable> InputVariables
        {
            get { return _inputVariables; }
            set { _inputVariables = value; }
        }

        public List<FuzzyVariable> OutputVariables
        {
            get { return _outputVariables; }
            set { _outputVariables = value; }
        }

        public RuleBlock() { }

        public RuleBlock(string name, List<FuzzyVariable> input, List<FuzzyVariable> output)
        {
            _name = name;
            _inputVariables = input;
            _outputVariables = output;
        }
    }
}
