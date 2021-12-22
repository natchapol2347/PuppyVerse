using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

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

    public void onTriggerEnter()
    {
        player.transform.position = originalPos;
    }

    public void EnterSquid(string GlassBridge)
    {
         SceneManager.LoadScene(GlassBridge);
    }
    public void ExitSquid(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }
}
