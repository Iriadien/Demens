using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarPalanca : MonoBehaviour
{
    public Animator animator;
    public float duration;

    private bool cooldown;
    private float time;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && !cooldown)
        {
            //Debug.Log("uses");
            animator.SetBool("Use", true);
            cooldown = true;
            
            //StartCoroutine(Wait(duration));
        }

        if (cooldown)
        {
            time += Time.deltaTime;Debug.Log(time);
            if (time >= duration)
            {
                cooldown = false;
                animator.SetBool("Use", false);
                time = 0;
            }
        }
    }

    IEnumerator Wait (float seconds)
    {
        yield return new WaitForSeconds(seconds);
        animator.SetBool("Use", false);
        cooldown = false;
    }
}
