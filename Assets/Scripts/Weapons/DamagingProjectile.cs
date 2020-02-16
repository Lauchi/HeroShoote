using Enemies;
using UnityEngine;

namespace Weapons
{
    public class DamagingProjectile : MonoBehaviour
    {
        public Shot shot;
        public GameObject hitEffect;

        private void OnCollisionEnter2D(Collision2D other)
        {
            var target = other.gameObject.GetComponent<KillableTarget>();
            if (target != null)
            {
                target.DamageTarget(shot);
            }

            var randomRotation = Quaternion.Euler(0, 0 , Random.Range(0.0f, 360.0f));
            var explosion = Instantiate(hitEffect, transform.position, randomRotation);
            Destroy(explosion, 1f);
            Destroy(gameObject);
        }
    }
}
