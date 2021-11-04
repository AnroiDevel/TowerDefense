using System;

namespace TowerDefese
{
    public class PlayerData
    {
        private int _score;
        public Action<int> ChangeGold;
        public int Gold
        {
            get
            {
                return _score;
            }
            set
            {
                _score += value;
                ChangeGold?.Invoke(_score);
            }
        }

        private string _name;
    }

}