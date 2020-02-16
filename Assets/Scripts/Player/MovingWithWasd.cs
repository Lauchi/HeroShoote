using UnityEngine;

namespace Player
{
    public class MovingWithWasd : MonoBehaviour
    {
        public float speed = 4;
        void FixedUpdate()
        {
            var movement = new Vector3 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            transform.position += movement * (speed * Time.deltaTime);
        }
    }
}
