using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class koinebisshemgrovebeli : MonoBehaviour
{
    public int koini = 0;
    public GameObject WinnerScreen;
    [SerializeField] private TextMeshProUGUI koinebi;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("formula"))
        {
            Destroy(collision.gameObject);
            koini++;
            koinebi.text = koini + "formula";
            //if (koini == 4)
            //{
            //WinnerScreen.SetActive(true);
            //Destroy(gameObject);
            //}
        }
    }
}
