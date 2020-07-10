using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electrap : MonoBehaviour
{

    public Transform spawnpoint;
    Collider2D electric;
    void Start()
    {
        electric = this.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCol()
    {
        electric.enabled = true;

    }

    public void OffCall()
    {
        electric.enabled = false;
    }

  /*  private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {

            //Respawn();
            
        }


    }
    public void Respawn()
    {
        this.transform.position = spawnpoint.position;
    }*/
}
