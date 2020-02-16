using UnityEngine;

namespace Weapons
{
    public class ProjectileWeapon : EquipableWeapon
    {
        public int bulletSpeed;
        public Rigidbody2D projectile;

        protected override void FireWeapon(Transform firePoint)
        {
            var p = Instantiate(projectile, firePoint.position, firePoint.rotation);
            var fireVector = firePoint.right * bulletSpeed;
            p.AddForce(fireVector, ForceMode2D.Impulse);
        }
    }
}
