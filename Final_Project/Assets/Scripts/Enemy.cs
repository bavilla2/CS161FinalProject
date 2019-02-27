using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (tag == "Grill")
            {
                Debug.Log("10 s");
                player.GetComponent<Player>().health -= 10;
            }
            else if (tag == "Flamethrower")
            {
                Debug.Log("30 s");
                player.GetComponent<Player>().health -= 30;
            }
            else if (tag == "Fire")
            {
                Debug.Log("5 s");
                player.GetComponent<Player>().health -= 5;
            }
            else if (tag == "Cactus")
            {
                Debug.Log("2 s");
                player.GetComponent<Player>().health -= 2;
            }
        }
    }
}
