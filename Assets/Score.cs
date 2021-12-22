using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject effectObject;
    public GameObject Ball;

    void Start(){
        effectObject.SetActive(false);
    }
    // Update is called once per frame
    void onTriggerEnter (Collider otherCollider){
        if (otherCollider.GetComponent<Ball>() != null){
            effectObject.SetActive(true);
        }
    }
}
 