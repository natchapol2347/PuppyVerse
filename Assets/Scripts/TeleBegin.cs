using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleBegin : MonoBehaviour
{
    vector3 originalPos;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        originalPos = new vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
    }

    // Update is called once per frame
    void trigg()
    {
        player.transform.position = originalPos;
    }
}
