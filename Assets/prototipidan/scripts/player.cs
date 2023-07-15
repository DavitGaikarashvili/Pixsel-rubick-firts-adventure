using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;//siswrafe
    public float jumpforce;//axtomis zdala
    float inputX;//gilakebis migeba

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }

    void Update()
    {
        inputX = Input.GetAxis("Horizontal");//miigebs informacias minus ertidan ertamde (inputX)
        if (Input.GetKeyDown(KeyCode.W))//tu am gilaks daawvebi
        {
            //(0,1)
            rb.velocity = Vector2.up * jumpforce;//velocity gaxdes vector 2 gamravlebuli axtoma
        }
        rb.velocity = new Vector2(inputX * speed * Time.deltaTime, rb.velocity.y);
    }




}//velosyti - nishnavs sichqare (veqtoruli sidide)