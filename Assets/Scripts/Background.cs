using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject day;
    public GameObject night;

    // Start is called before the first frame update
    void Start()
    {
        var rnd = Random.Range(0, 1);
        if (rnd < 0.5f)
        {
            day.SetActive(true);
        }
        else 
        {
            night.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
