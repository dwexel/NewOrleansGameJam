using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInteraction : MonoBehaviour
{
    public GameObject keyObject;
    public DoorInteraction doorInteraction;

    // Start is called before the first frame update
    void Start()
    {
        keyObject.SetActive(true);
        DoorInteraction doorInteraction = GetComponent<DoorInteraction>();
        
    }

    void OnTriggerStay()
    {
        if(Input.GetKey(KeyCode.E))
        {
            keyObject.SetActive(false);
            doorInteraction.isLocked = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
