using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    public Vector2 maxPosition;
    public Vector2 minPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // this keeps the camera moving with the player
    // but does not go beyond the room 
    // meaning you can not see outside the room you are in
    // the max x, max y, min x, min y are all set in unity
    void LateUpdate()
    {
     if(transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(target.position.x,
                                                 target.position.y,
                                                 transform.position.z);

            targetPosition.x = Mathf.Clamp(targetPosition.x,
                                            minPosition.x,
                                            maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y,
                                            minPosition.y,
                                            maxPosition.y);
            transform.position = Vector3.Lerp(transform.position,
                                                targetPosition, smoothing);

        }
    }
}
