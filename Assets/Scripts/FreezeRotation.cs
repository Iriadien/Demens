using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeRotation : MonoBehaviour
{
    public bool freezeX;
    public bool freezeY;
    public bool freezeZ;

    private float x, y, z;

    private void Start()
    {
        if (freezeX) x = 0; else x = transform.rotation.x;
        if (freezeY) y = 0; else y = transform.rotation.y;
        if (freezeZ) z = 0; else z = transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = new Quaternion(x, y, z, 0);
    }
}
