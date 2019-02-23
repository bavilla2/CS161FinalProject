using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            if (tag == "Popsicle")
            {
                Debug.Log("10 s");
                GameObject.Find("Player").GetComponent<Player>().health += 10.0f;
                Destroy(this.gameObject);
            }
            else if (tag == "AC")
            {
                Debug.Log("30 s");
                GameObject.Find("Player").GetComponent<Player>().health += 30.0f;
                Destroy(this.gameObject);
            }
            else if (tag == "IceCube")
            {
                Debug.Log("5 s");
                GameObject.Find("Player").GetComponent<Player>().health += 5.0f;
                Destroy(this.gameObject);
            }
        }
    }
}
