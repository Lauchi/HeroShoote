using UnityEngine;
using Weapons;

namespace Player
{
    public class ShootOnClick : MonoBehaviour
    {
        public GameObject equippedWeapon;
        public AudioSource audioSource;

        public Transform firePoint;

        private EquipableWeapon _equipableWeapon;

        private void Start()
        {
            _equipableWeapon = equippedWeapon.GetComponent<EquipableWeapon>();
        }

        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                _equipableWeapon.Fire(firePoint);
                audioSource.PlayOneShot(_equipableWeapon.fireSound);
            }
        }
    }
}