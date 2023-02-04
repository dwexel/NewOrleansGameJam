using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePickup : MonoBehaviour
{
    // reference to main camera
    // hides inherited member?
    public GameObject camera;
    public float AnimationLength = 2f;

    

    private float tt = 0f;
    private Vector3 currentP;
    private Vector3 targetP;
    private Quaternion currentO;
    private Quaternion targetO;

    public void Pickup()
    {
        Vector3 camP = camera.transform.position;
        Vector3 noteP = transform.position;

        currentO = transform.rotation;
        targetO = Quaternion.LookRotation((noteP - camP), Vector3.up);

        // move relative to camera
        Camera cameraComponent = camera.GetComponent<Camera>();
        currentP = transform.position;
        targetP = cameraComponent.cameraToWorldMatrix.MultiplyPoint(new Vector3(0, 0, -10));




        tt = AnimationLength;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.Pickup();
    }

    // very linear - could add easing
    // flagged as "inefficient"
    void Update()
    {
        if (tt > 0)
        {
            print(tt);

            float dt = Time.deltaTime;
            tt -= dt;
            transform.position =     Vector3.Lerp(currentP, targetP, (AnimationLength - tt) / AnimationLength);
            transform.rotation = Quaternion.Slerp(currentO, targetO, (AnimationLength - tt) / AnimationLength);
        }
        else
        {
            tt = 0f;
        }
    }
}
