using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Arrow_Factories
{
    class Arrow

    {
        private (string, float) _arrowHead;
        private (string, float) _fletching;
        private float _shaftLength { get; set; }

        //_shaftLength setter
        public float ShaftLength
        {
            get => _shaftLength;
            set => _shaftLength = value;

        }

        private float _arrowCost;
        bool _arrowHeadInputVerify;
        bool _arrowFletchingInputVerify;

        public bool ArrowHeadInputVerify(string input)
        {
            if (input == "Steel" || input == "steel")
            {
                _arrowHeadInputVerify = true;
                _arrowHead.Item1 = input;
                _arrowHead.Item2 = 10f;
                _arrowCost += _arrowHead.Item2;
            }

            else if (input == "Obsidian" || input == "obsidian")
            {
                _arrowHeadInputVerify = true;
                _arrowHead.Item1 = input;
                _arrowHead.Item2 = 5f;
                _arrowCost += _arrowHead.Item2;
            }

            else if (input == "Wood" || input == "wood")
            {
                _arrowHeadInputVerify = true;
                _arrowHead.Item1 = input;
                _arrowHead.Item2 = 3f;
                _arrowCost += _arrowHead.Item2;
            }
            else
            {
                _arrowHeadInputVerify = false;
            }

            if (_arrowHeadInputVerify)
            {
                return true;
            }
            return false;

        }

        public bool ArrowFletchingInputVerify(string input)
        {
            if (input == "Plastic" || input == "plastic")
            {
                _arrowFletchingInputVerify = true;
                _fletching.Item1 = input;
                _fletching.Item2 = 10f;
                _arrowCost += _fletching.Item2;
            }

            else if (input == "Turkey Feathers" || input == "turkey feathers" || input == "Turkey feathers")
            {
                _arrowFletchingInputVerify = true;
                _fletching.Item1 = input;
                _fletching.Item2 = 5f;
                _arrowCost += _fletching.Item2;
            }

            else if (input == "Goose Feathers" || input == "goose feathers" || input == "Goose feathers")
            {
                _arrowFletchingInputVerify = true;
                _fletching.Item1 = input;
                _fletching.Item2 = 3f;
                _arrowCost += _fletching.Item2;
            }
            else
            {
                _arrowFletchingInputVerify = false;
            }

            if (_arrowFletchingInputVerify)
            {

                return true;
            }
            return false;
        }


        public void AddShaftToCost()
        {
            _arrowCost += _shaftLength * 0.05f;
        }

        public void SingleArrowOrderSummary()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Sir, you really do have great taste in arrows. You will have a {_shaftLength}cm arrow with a fletching" +
                $" of {_fletching.Item1} and a { _arrowHead.Item1} head.\nThis arrow only costs you {_arrowCost}");
        }

        public float AddArrowToTotal()
        {
            return _arrowCost;
        }

        public static Arrow EliteArrowFactory() => new Arrow(
        

            _arrowHead.Item1 = "Steel";
            _arrowHead.Item2 = 10f;
            _fletching.Item1 = "Plastic";
            _fletching.Item2 = 10f;
            _shaftLength = 95f;
            _arrowCost = _arrowHead.Item2 + _fletching.Item2 + (_shaftLength * 0.05f););

        

        public void MarksmanArrowFactory()
        {

            _arrowHead.Item1 = "Steel";
            _arrowHead.Item2 = 10f;
            _fletching.Item1 = "Goose feathers";
            _fletching.Item2 = 3f;
            _shaftLength = 65f;
            _arrowCost = _arrowHead.Item2 + _fletching.Item2 + (_shaftLength * 0.05f);

        }

        public void BeginnerArrowFactory()
        {

            _arrowHead.Item1 = "wood";
            _arrowHead.Item2 = 3f;
            _fletching.Item1 = "Goose feathers";
            _fletching.Item2 = 3f;
            _shaftLength = 75f;
            AddShaftToCost();

        }
    }

}