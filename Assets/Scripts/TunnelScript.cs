using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelScript : MonoBehaviour
{
    public Transform RSpawnPoint;
    public Transform LSpawnPoint;
    public GameObject Player;
    //public GameObject LSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(this.tag.Equals("RExitTrigger"))
        { 
            Player.transform.position = LSpawnPoint.position;
        }
        else if(this.tag.Equals("LExitTrigger"))
        {
            Player.transform.position = RSpawnPoint.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
