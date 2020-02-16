using UnityEngine;
using UnityEngine.Events;
using Weapons;

namespace Enemies
{
    public class KillableTarget : MonoBehaviour
    {
        public int armor;
        public int life;

        public UnityEvent targetDied;

        public void DamageTarget(Shot shot)
        {
            var damage = shot.damage;
            var damageAfterArmor = damage - armor;
            if (damageAfterArmor < 1) damageAfterArmor = 1;
            life -= damageAfterArmor;

            if (life <= 0)
            {
                targetDied.Invoke();
                Destroy(gameObject);
            }
        }
    }
}