using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activador : MonoBehaviour
{
    public GameObject objetoActivador;

    public List<GameObject> objetosParaActivar;

    private EstadoObjeto eo;

    // Start is called before the first frame update
    void Start()
    {
        eo = objetoActivador.GetComponent<EstadoObjeto>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!eo.Activado) return;
        Debug.Log("cosas");

    }
}
