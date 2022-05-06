using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.AI;

public class PacManScript : MonoBehaviour
{
    Rigidbody rb;
    //NavMeshAgent ghostAgent;
    TextMesh theScoreTextMesh;

    public GameObject scoreText;
    public GameObject ghost;
    public float speed = 20f;
    private int count = 0;

    void Awake()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        //ghostAgent = this.ghost.GetComponent<NavMeshAgent>();
        //ghostAgent.speed = 2.0f;
        this.theScoreTextMesh = this.scoreText.GetComponent<TextMesh>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //this.ghostAgent.SetDestination(this.gameObject.transform.position);

        if (Input.GetKeyDown("up"))
        {
            this.transform.rotation = Quaternion.LookRotation(Camera.main.transform.up);
            rb.velocity = Vector3.forward * speed;
        }
        else if (Input.GetKeyDown("down"))
        {
            this.transform.rotation = Quaternion.LookRotation(-Camera.main.transform.up);
            rb.velocity = Vector3.back * speed;
        }
        else if (Input.GetKeyDown("left"))
        {
            this.transform.rotation = Quaternion.LookRotation(-Camera.main.transform.right);
            rb.velocity = Vector3.left * speed;
        }
        else if (Input.GetKeyDown("right"))
        {
            this.transform.rotation = Quaternion.LookRotation(Camera.main.transform.right);
            rb.velocity = Vector3.right * speed;
        }
    }
}
