using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repos : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 originalPos;
 
    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    public void ButtonClick()
    {
        gameObject.transform.position = originalPos;
    }
}
