using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Species.Items
{
    public class Item
    {
        private Guid ItemID;
        private string Name;

        //0 = Unlimited
        private int Use;
        private string Description;
        
        private PlayerBattleBot PlayerBattleBot;

        private int BuyPrice;
        private int SellPrice;

        public Item(string _name, int _use, string _description, PlayerBattleBot _playerBattleBot, int _buy, int _sell)
        {
            Name = _name;
            Use = _use;
            Description = _description;
            PlayerBattleBot = _playerBattleBot;
            BuyPrice = _buy;
            SellPrice = _sell;
        }

        public override string ToString()
        {
            return $"INSERT INTO ITEM {ItemID.ToString()},{Name},{Use},{Description},{PlayerBattleBot.ToString()},{BuyPrice},{SellPrice}";
        }

    }

    public enum PlayerBattleBot
    {
        Player = 0,
        BattleBot = 1
    }

}
