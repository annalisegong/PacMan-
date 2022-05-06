using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostScript : MonoBehaviour
{
    Rigidbody rb;
    NavMeshAgent ghostAgent;
    public GameObject Player;
    public float speed = 3.0f;

    // ghost destroyed when playerCanKill is true; pacman destroyed when false
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            if(PelletKillScript.playerCanKill == true)
            {
                Destroy(this.gameObject);
                print("ghost destroyed");
            }
            else if(PelletKillScript.playerCanKill == false)
            {
                Destroy(other.gameObject);
                print("Player destroyed! ... Game Over");
            }
        }
    }

    void Awake()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        ghostAgent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.ghostAgent.SetDestination(Player.gameObject.transform.position);
    }
}