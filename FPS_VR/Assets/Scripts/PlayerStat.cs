using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "PlayerStat", menuName = "PlayerStat", order = 0)]
    public class PlayerStat : ScriptableObject
    {
        [SerializeField] private float playerLife;
        [SerializeField] private int gunDamage;
        [SerializeField] private int swordDamage;
        private int killCounter;

        public float Life
        {
            get => playerLife;
            set => playerLife = value;
        }

        public int gunDMG
        {
            get => gunDamage;
            set => gunDamage = value;
        }

        public int swordDMG
        {
            get => swordDamage;
            set => swordDamage = value;
        }

        public int killCount
        {
            get => killCounter;
            set => killCounter = value;
        }
    }
}