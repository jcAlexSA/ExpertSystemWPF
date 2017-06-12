using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpertSystem.Model
{
    public class TriangleFunction
    {
        private string _nameFunction = "Triangle";
        private float _low;
        private float _mid;
        private float _high;

        public string Name
        {
            get { return _nameFunction; }
        }

        public float Low
        {
            get { return _low; }
            set { _low = value; }
        }

        public float Mid
        {
            get { return _mid; }
            set { _mid = value; }
        }

        public float High
        {
            get { return _high; }
            set { _high = value; }
        }

        public TriangleFunction() { }

        public TriangleFunction(float low, float mid, float high)
        {
            _low = low;
            _mid = mid;
            _high = high;
        }

        public override string ToString()
        {
            return string.Format("Type: {0}; a0: {1}; a1: {2}; a2: {3};", _nameFunction, _low, _mid, _high);
        }
    }
}
