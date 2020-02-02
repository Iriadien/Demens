using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeY : MonoBehaviour
{
    public bool y;

    private float posy;

    private void Start()
    {
        posy = gameObject.transform.position.y;
    }

    private void Update()
    {
        if (y)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x,posy, gameObject.transform.position.z);
        }
    }
}
