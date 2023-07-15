using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Killplayer : MonoBehaviour
{
    // Start is called before the first frame update
    public int respawn_loadscene;
    [SerializeField] Transform spawnpoint;
    [SerializeField] Transform spawnpoint2;
    void Start()
    {
        
    }
    //public void OnTriggerEnter2D(Collider2D other)
    //{
        //if (other.CompareTag("Player"))
        //{
            //SceneManager.LoadScene(respawn_loadscene);
            //other.transform.position = spawnpoint.position;
            //Destroy(gameObject);

        //}
    //}
    // Update is called once per frame
    void Update()
    {
        
    }
}
