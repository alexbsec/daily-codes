using UnityEngine;

public class cameraFollowScript : MonoBehaviour
{
    public Transform target;
    public float smoothedFactor;

    private void FixedUpdate()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 targetPosition = target.position - new Vector3(0, 0, 10);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothedFactor * Time.deltaTime);

        transform.position = smoothedPosition;
    }
}
