using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repos : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 originalPos;
    public GameObject player;
 
    void Start()
    {
        originalPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
    }

    public void ButtonClick()
    {
        player.transform.position = originalPos;
    }
}
