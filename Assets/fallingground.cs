using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingground : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    private Vector3 respawnpoint;
    public float wami = 1f;
    public Rigidbody2D platforma1;
    public Transform gachenisadgili;
    void Start()
    {
         respawnpoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine("chavardna");
        }     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "trap")
        {
            rb.isKinematic = true;
            Instantiate(gameObject, respawnpoint, Quaternion.identity );
             Destroy(gameObject);
           
        }
    }
    IEnumerator chavardna()
    {
        yield return new WaitForSeconds(wami);
        rb.isKinematic = false;
    }

}
