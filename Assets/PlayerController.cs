using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Camera TrackedCamera;
    private Rigidbody rb;
    private float moveHorizontal;
    private float moveVertical;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        Vector3[] corners = new Vector3[4];

        float distanceFromPlayer = Vector3.Distance(transform.position, TrackedCamera.transform.position);

        Debug.DrawRay(
            TrackedCamera.transform.position,
            TrackedCamera.transform.forward * distanceFromPlayer,
            Color.red
        );

        TrackedCamera.CalculateFrustumCorners(
            new Rect(0, 0, 1, 1),
            distanceFromPlayer,
            Camera.MonoOrStereoscopicEye.Mono,
            corners
        );
        for (int i = 0; i < 4; i++)
        {
            var worldSpaceCorner = TrackedCamera.transform.TransformPoint(corners[i]);
            Debug.DrawRay(
                TrackedCamera.transform.position,
                worldSpaceCorner,
                Color.green
            );
        }
    }


    void FixedUpdate()
    {
        if (moveHorizontal != 0 || moveVertical != 0)
        {
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            // rb.AddForce(movement * speed);
            rb.velocity = movement * speed;
        }
    }
}
