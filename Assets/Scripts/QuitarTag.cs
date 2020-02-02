using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarTag : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.tag = "Untagged";
        //StartCoroutine(Wait(0.5f, collision));
    }

    IEnumerator Wait(float seconds, Collider2D collision)
    {
        yield return new WaitForSeconds(seconds);
        collision.gameObject.tag = "Untagged";
    }
}
