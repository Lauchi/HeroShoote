using UnityEngine;

namespace Weapons
{
    public class EquipableWeapon : MonoBehaviour
    {
        public AudioClip fireSound;

        public void Fire(Transform firePoint)
        {
            FireWeapon(firePoint);
        }

        protected virtual void FireWeapon(Transform firePoint)
        {
        }
    }
}