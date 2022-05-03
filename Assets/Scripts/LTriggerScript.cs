using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LTriggerScript : MonoBehaviour
{
    public GameObject thePacMan;
    public Transform PacManPrefab;
    public Transform RspawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Transform t = Instantiate(PacManPrefab, RspawnPoint.position, Quaternion.identity);
        Rigidbody rb = t.GetComponent<Rigidbody>();
        Destroy(thePacMan);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
