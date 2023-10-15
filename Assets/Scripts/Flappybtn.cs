using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flappybtn : MonoBehaviour
{
    public string nextSceneNext;

    private void OnMouseDown()
    {
        transform.position += Vector3.down * 0.1f;
    }

    private void OnMouseUp()
    {
        transform.position += Vector3.up * 0.1f;
        if (nextSceneNext!= "")
        {
            SceneManager.LoadScene(nextSceneNext);
        };
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
