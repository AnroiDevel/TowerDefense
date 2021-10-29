namespace TowerDefese
{
    [System.Serializable]
    public class EnemyModel : BaseModel
    {
        public float Health { get; set; }
        public float MaxHealth { get; set; }
        public string Name { get; set; }
        public float Speed { get; set; }
        public Armor Armor { get; set; }
        public int Price { get; set; }
    }

}