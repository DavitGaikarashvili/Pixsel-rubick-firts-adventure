using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_life : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trap"))
        {
            Die();
            Destroy(gameObject);
            LevelManeger.instance.Respawn();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void Die()
    {
        //anim.SetTrigger("death");
        
    }
}
