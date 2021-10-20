namespace TowerDefese
{
    [System.Serializable]
    public  class EnemyModel : BaseModel
    {
        public string Name { get; set; }
        public float Speed { get; set; }
        public Armor Armor { get; set; }
    }

}