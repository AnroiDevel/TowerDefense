using System;

namespace TowerDefese
{
    public class PlayerData
    {
        private int _score;
        public Action<int> ChangeScore;
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                _score += value;
                ChangeScore?.Invoke(_score);
            }
        }

        private string _name;
    }

}