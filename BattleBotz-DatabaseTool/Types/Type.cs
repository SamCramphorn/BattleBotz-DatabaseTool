using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Species.Types
{
    public class Type
    {

        private Guid TypeID;
        private Types Types;
        private Types WeakAgainst;
        private Types StrongAgainst;

        public Type(Types _types, Types _weakAgainst, Types _strongAgainst)
        {
            TypeID = new Guid();
            Types = _types;
            WeakAgainst = _weakAgainst;
            StrongAgainst = _strongAgainst;
        }

        public override string ToString()
        {
            return $"INSERT INTO TYPES {TypeID.ToString()}, {Types.ToString()},{WeakAgainst.ToString()},{StrongAgainst.ToString()}";
        }

    }

    public enum Types
    {
        Normal,
        Fighting,
        Fire,
        Water,
        Hack,
        Plant,
        Laser,
        Space
    }

}
