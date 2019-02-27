using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    [SerializeField] public float speed = 1;
    private Rigidbody2D m_rigidbody;
    [SerializeField] public float jumpForce = 7.5f;
    [SerializeField] public float health = 100.00f;
    private bool isGrounded = false;
    private bool alive = true;
    private Collider2D m_collider;
    [SerializeField] public bool isThrown = false;
    public Animator animator; 


    public GameObject snowball;
    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = this.GetComponent<Rigidbody2D>();
        m_collider = this.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        life();
        if(!alive)
        {
            restart_game();
        }
        
        /*if(this.transform.position.y <= -17.0f)
        {
            restart_game();
        }*/

        move();

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }

        //Debug.Log(health);

        if (Input.GetKeyDown(KeyCode.F))
        {
            print("I pressed F");
            StartCoroutine(Throw_Snowball_Animation());
            //throw_snowball();
            //animator.SetBool("Is_thrown", false);
        }

    }

    IEnumerator Throw_Snowball_Animation()
    {
        animator.SetBool("Is_thrown", true);
        yield return StartCoroutine(Thrown(0.5f));
        throw_snowball();
        animator.SetBool("Is_thrown", false);
    }

    IEnumerator Thrown(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
    }

    void move()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void Jump()
    {
        m_rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;

            Vector2 feetPosition = new Vector2(this.transform.position.x, m_collider.bounds.min.y);
            RaycastHit2D jumpInfo = Physics2D.Raycast(feetPosition, Vector2.down, 0.1f);
            Debug.DrawRay(feetPosition, Vector2.down * 0.1f, Color.green);
            if (jumpInfo && jumpInfo.collider.CompareTag("Ground"))
            {
                isGrounded = true;
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.CompareTag("Lava"))
        {
            animator.SetFloat("health", 0.0f);
            restart_game();
        }

        else if(collider.CompareTag("Gem"))
        {
            restart_game();
        }
        else if(collider.CompareTag("Cactus"))
        {
            Debug.Log("5 s");
            health -= 5;
        }
        else if (collider.CompareTag("Fire"))
        {
            Debug.Log("20 s");
            health -= 20;
            Destroy(collider.gameObject);
        }
        else if (collider.CompareTag("Flamethrower"))
        {
            Debug.Log("30 s");
            health -= 30;
            Destroy(collider.gameObject);
        }
        else if (collider.CompareTag("Grill"))
        {
            Debug.Log("10 s");
            health -= 10;
            Destroy(collider.gameObject);
        }
        else if (collider.CompareTag("IceCube"))
        {
            Debug.Log("5 s");
            health += 5;
            Destroy(collider.gameObject);
        }
        else if (collider.CompareTag("AC"))
        {
            Debug.Log("20 s");
            health += 20;
            Destroy(collider.gameObject);
        }
        else if (collider.CompareTag("Popsicle"))
        {
            Debug.Log("10 s");
            health += 10;
            Destroy(collider.gameObject);
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private void life()
    {
        health -= GetDeltaTime();

        if (health < 0)
        {
            alive = false;
            animator.SetFloat("health", 0.0f);
        }
    }

    private static float GetDeltaTime()
    {
        return Time.deltaTime*2;
    }

    void restart_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void throw_snowball()
    {
        Vector3 oneUnitRightOfMe = this.transform.position + Vector3.right;
        //animator.SetBool("Is_thrown", true);
        GameObject Snowball = Instantiate(snowball, oneUnitRightOfMe, Quaternion.identity);
        Snowball.GetComponent<Rigidbody2D>().AddForce(new Vector2(12f, 4f), ForceMode2D.Impulse);
    }
}
