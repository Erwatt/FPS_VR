using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "ZombieStat", menuName = "ZombieStat", order = 0)]
    public class ZombieStat : ScriptableObject
    {
        [SerializeField] private float zombieLife;
        [SerializeField] private float zombieDamage;

        public float zLife
        {
            get => zombieLife;
            set => zombieLife = value;
        }

        public float zDamage
        {
            get => zombieDamage;
            set => zombieDamage = value;
        }
    }
}