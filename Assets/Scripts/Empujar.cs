using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empujar : MonoBehaviour
{

    public Animator animator;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pusheable") animator.SetBool("Push", true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pusheable") animator.SetBool("Push", false);
    }
}
