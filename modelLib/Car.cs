using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelLib
{
    public class Car
    {
        private String _model;
        private String _color;
        private String _regNo;

        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public string Color
        {
            get => _color;
            set => _color = value;
        }

        public string RegNo
        {
            get => _regNo;
            set => _regNo = value;
        }

        public Car():this("DummyModel", "DummyColor", "DummyRegNumber")
        {
        }

        public Car(string model, string color, string regNo)
        {
            _model = model;
            _color = color;
            _regNo = regNo;
        }

        public override string ToString()
        {
            return $"{nameof(Model)}: {Model}, {nameof(Color)}: {Color}, {nameof(RegNo)}: {RegNo}";
        }
    }
}
