using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncenderLuz : MonoBehaviour
{
    public EstadoObjeto eo;

    // Update is called once per frame
    void Update()
    {
        if (eo.Activado)
        {
            GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
