using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Species.Species;
using Species.Types;


namespace Species.Monsters
{
    public class Monster
    {

        private Guid MonsterID;
        private int Size;
        private Specie Species;
        private Types.Type Type;
        private int DefaultAtt;
        private int DefaultDef;
        private int DefaultSpd;
        private int DefaultMagAtt;
        private int DefaultMagDef;
        private int Rarity;

        public Monster(int _size, Specie _specie, Types.Type _type, int _defaultAtt, int _defaultDef, int _defaultSpd, int _defaultMagAtt, int _defaultMagDef, int _rarity)
        {
            MonsterID = new Guid();
            Size = _size;
            Species = _specie;
            Type = _type;
            DefaultAtt = _defaultAtt;
            DefaultDef = _defaultDef;
            DefaultMagAtt = _defaultMagAtt;
            DefaultMagDef = _defaultMagDef;
            DefaultSpd = _defaultSpd;
            Rarity = _rarity;
        }
    }
}
