using UnityEngine;

namespace Player
{
    public class FollowObject : MonoBehaviour
    {
        public Transform objectToFollow;

        public float smoothSpeed = 0.125f;

        void LateUpdate()
        {
            var positionOfFollowingObject = objectToFollow.position;
            var currentPosition = transform.position;
            var desiredPosition = new Vector3(
                positionOfFollowingObject.x,
                positionOfFollowingObject.y,
                currentPosition.z);
            var lerpedPosition = Vector3.Lerp(currentPosition, desiredPosition, smoothSpeed);
            transform.position = lerpedPosition;
        }
    }
}
