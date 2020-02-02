using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingPalanca : MonoBehaviour
{

    public bool enLaPalanca;

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.tag=="Player")  enLaPalanca = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player") enLaPalanca = false;
    }
}
