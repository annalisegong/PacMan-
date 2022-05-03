using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPelletScript : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject powerPellet;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("PacMan"))
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
