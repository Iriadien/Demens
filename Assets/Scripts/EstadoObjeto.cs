using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoObjeto : MonoBehaviour
{
    public Activador activador;
    public ActivadorAscensor activadorAscensor;
    public bool Activado;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colli");
        if (activador != null && activador.gameObject == collision.gameObject)
        {
            Debug.Log("activar");
            Activado = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (activador != null && activador.gameObject == collision.gameObject)
        {
            Activado = false;
        }
    }
}
