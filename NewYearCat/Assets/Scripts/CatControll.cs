using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CatControll : MonoBehaviour {

    // Use this for initialization
    //public GameObject respawn;
    Rigidbody2D rb;
    public AudioClip mjau_clip;
    public AudioSource mjau;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Collision")
        {          
            SceneManager.LoadScene(0);         
        }
    }


    void Start () {
        rb = GetComponent<Rigidbody2D>();
        mjau.clip = mjau_clip;
                  }
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(40f, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 9000);
            mjau.Play();
        }
        


    }
}
