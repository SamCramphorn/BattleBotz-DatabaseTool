using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Species.Types;

namespace Species.Moves
{
    public class Move
    {

        private Guid MoveID;
        private int Cost;
        private int Power;
        private Types.Type Type;

        public Move(int _cost, int _power, Types.Type _type)
        {
            MoveID = new Guid();
            Cost = _cost;
            Power = _power;
            Type = _type;
        }

        public override string ToString()
        {
            return $"INSERT INTO Moves {MoveID.ToString()}, {Cost.ToString()},{Power.ToString()},{Type.ToString()}";
        }

    }

}
