
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb; 
    public float forcemultiplair;
    public bool CanRun;
    public float Runforce;
    public bool CanJump;
    public float jumpForce;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        CanRun = true;
        CanJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalforce = Input.GetAxis("Horizontal") * forcemultiplair;
        //float Verticalforce = Input.GetAxis("Vertical") * forcemultiplair;

        horizontalforce *= Time.deltaTime;
        //Verticalforce *= Time.deltaTime;
        transform.Translate(horizontalforce, 0, 0);

        //if (Input.GetKeyDown(KeyCode.W) && CanRun)
        {
            rb.AddForce(0f, Runforce, 0f, ForceMode.Impulse);
            CanRun = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && CanJump)
        {
            rb.AddForce(0f, jumpForce, 0f, ForceMode.Impulse);
            CanJump = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            CanJump = true;
        }
    }
}
