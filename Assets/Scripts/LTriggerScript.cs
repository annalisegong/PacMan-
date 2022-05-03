using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LTriggerScript : MonoBehaviour
{
    public Transform PacMan;
    public Transform RspawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Transform t = Instantiate(PacMan, RspawnPoint.position, Quaternion.identity);
        Rigidbody rb = t.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
