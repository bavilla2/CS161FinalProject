using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour
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

        if (collider.CompareTag("Lava"))
        {
            Destroy(this.gameObject);
        }

        else if (collider.CompareTag("Gem"))
        {
            Destroy(this.gameObject);
        }
        else if (collider.CompareTag("Cactus"))
        {
            Destroy(this.gameObject);
        }
        else if (collider.CompareTag("Fire"))
        {
            Destroy(this.gameObject);
            Destroy(collider.gameObject);
        }
        else if (collider.CompareTag("Flamethrower"))
        {
            Destroy(this.gameObject);
            Destroy(collider.gameObject);
        }
        else if (collider.CompareTag("Grill"))
        {
            Destroy(this.gameObject);
            Destroy(collider.gameObject);
        }
        else if (collider.CompareTag("IceCube"))
        {
            Destroy(this.gameObject);
        }
        else if (collider.CompareTag("AC"))
        {
            Destroy(this.gameObject);
        }
        else if (collider.CompareTag("Popsicle"))
        {
            Destroy(this.gameObject);
        }
        else if (collider.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }


    }
}
