using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplatform : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform pos1, pos2;
    public int Speed;
    Vector2 targetpos;
    void Start()
    {
        targetpos = pos2.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, pos1.position) < .1f) targetpos = pos2.position;
        if (Vector2.Distance(transform.position, pos2.position) < .1f) targetpos = pos1.position;
        transform.position = Vector2.MoveTowards(transform.position, targetpos, Speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(this.transform);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
