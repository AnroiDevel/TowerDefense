namespace TowerDefese
{
    [System.Serializable]
    public class SkeletonModel : EnemyModel
    {
        private readonly string _name = "Скелет";
        private readonly float _skeletonSpeed = 1.0f;
        private readonly Armor _armor = Armor.Medium;


        public SkeletonModel()
        {
            Speed = _skeletonSpeed;
            Armor = _armor;
            Name = _name;
        }

    }
}