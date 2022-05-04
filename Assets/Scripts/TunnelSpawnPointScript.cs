using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelSpawnPointScript : MonoBehaviour
{
    public GameObject theOtherSpawnPoint;
    //public GameObject LSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(CORE.currentTrigger == null)
        {
            CORE.currentTrigger = other.gameObject;
            other.gameObject.transform.position = this.theOtherSpawnPoint.transform.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CORE.currentTrigger = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
