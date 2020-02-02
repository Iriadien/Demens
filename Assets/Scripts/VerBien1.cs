using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class VerBien1 : MonoBehaviour
{

    public Camera cam;
    public PostProcessVolume ppvol;
    DepthOfField dof;

    public bool use;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (use)
        {
            ppvol.profile.TryGetSettings(out dof);
            dof.focalLength.value = 95f;
            //use = false;
        }
    }
}
