using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndlessScroll : MonoBehaviour
{
    public float scrollFactor = -1;
    public Vector3 gameVelocity;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = gameVelocity * scrollFactor;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider gameArea)
    {
        transform.position += Vector3.right * (gameArea.bounds.size.x + GetComponent<BoxCollider>().size.x);
    }

    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("GameOver");
    }
}
