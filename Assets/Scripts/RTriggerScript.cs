using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTriggerScript : MonoBehaviour
{
    public Transform PacMan;
    public Transform LspawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Transform t = Instantiate(PacMan, LspawnPoint.position, Quaternion.identity);
        Rigidbody rb = t.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}