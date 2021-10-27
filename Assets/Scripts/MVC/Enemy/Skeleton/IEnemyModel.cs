namespace TowerDefese
{
    public interface IEnemyModel
    {
        public float Health { get; set; }
        public string Name { get; set; }
        public float Speed { get; set; }
        public Armor Armor { get; set; }
    }
}