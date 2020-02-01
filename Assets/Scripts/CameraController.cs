using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    //public float velocity;
    //public float YOffset;

    float posY;

    void Start()
    {
        posY = transform.position.y;
    }

    void Update()
    {
        //transform.position = Vector3.Lerp(player.transform.position.x, posY-YOffset,-10);
        transform.position = Vector3.Lerp(transform.position, new Vector3(player.transform.position.x,player.transform.position.y,-10), 10f);
        //if (posY < player.transform.position.y)
        //{
        //    Debug.Log("menos");
        //    posY += 1* velocity;
        //}
        //else if (posY > player.transform.position.y)
        //{
        //    Debug.Log("mas");
        //    posY -= 1*velocity;
        //}
    }
}
