using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarPalanca : MonoBehaviour
{
    public Animator animator;
    public float duration;

    public bool usingPalanca;

    private bool cooldown;
    private float time;

    public List<GameObject> palancas;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && !cooldown)
        {
            usingPalanca = true;
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
                usingPalanca = false;
                time = 0;
            }
        }

        foreach (GameObject go in palancas)
        {
            if (usingPalanca)
            {
                if (go.GetComponent<UsingPalanca>().enLaPalanca)
                {
                    go.GetComponent<EstadoObjeto>().Activado=true;
                }
            }
        }
    }
}
