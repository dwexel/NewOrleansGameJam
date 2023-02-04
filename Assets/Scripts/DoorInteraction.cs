using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public Animator Anim;
    public bool isLocked = false;
    private bool isOpened = false;
    private KeyInteraction keyInteraction;

    // Start is called before the first frame update
    void Start()
    {
        keyInteraction = GetComponent<KeyInteraction>();
        Anim = GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider other)
    {
        StartCoroutine("DoorDelay");
    }
    IEnumerator DoorDelay()
    {
        if(isLocked == false)
        {
            if(isOpened == false)
                if (Input.GetKey(KeyCode.E))
                {
                    Anim.SetInteger("State", 2);
                    yield return new WaitForSeconds(0.3f);
                    isOpened = true;
                }
        }
        if(isOpened == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Anim.SetInteger("State", 1);
                yield return new WaitForSeconds(0.3f);
                isOpened = false;
                Anim.SetInteger("State", 0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
