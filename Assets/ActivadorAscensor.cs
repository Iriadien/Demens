using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorAscensor : MonoBehaviour
{
    public Animator animator;
    public Transform teleportPosition;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Jump") && (collision.gameObject.tag == "Player"))
        {
            animator.SetBool("Activar", true);
            StartCoroutine(WaitForTeleport(1f, collision));
        }
    }

    IEnumerator WaitForTeleport(float seconds, Collider2D collision)
    {
        yield return new WaitForSeconds(seconds);
        collision.transform.position = teleportPosition.position;
        animator.SetBool("Activar", false);
    }
}
