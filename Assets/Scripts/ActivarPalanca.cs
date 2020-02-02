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
            animator.SetBool("Use", true);
            cooldown = true;
        }

        if (cooldown)
        {
            time += Time.deltaTime;
            if (time >= duration)
            {
                cooldown = false;
                animator.SetBool("Use", false);
                time = 0;
            }
        }
    }
}
