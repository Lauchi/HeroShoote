using UnityEngine;

namespace Player
{
    public class MovingWithWasd : MonoBehaviour
    {
        public float speed = 4;
        public void FixedUpdate()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
            var movement = new Vector3 (horizontal, vertical, 0);
            transform.position += movement * (speed * Time.deltaTime);
        }
    }
}
