using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletKillScript : MonoBehaviour
{
    public GameObject Player;
    public static bool playerCanKill = false;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(playerCanKill == true)
        {
            print("player can kill");
            StartCoroutine(setBool());
        }
    }

    private IEnumerator setBool()
    {
        yield return new WaitForSeconds(5f);
        playerCanKill = false;
        print("ghost can kill");
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            CORE.score++;
            playerCanKill = true;
            Destroy(this.gameObject);
        }
    }
}