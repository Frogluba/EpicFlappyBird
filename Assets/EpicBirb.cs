using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EpicBirb : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpSpeed;
    public float rotatateScale;
    public int score;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = Vector2.up * jumpSpeed;
        }

        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y * rotatateScale);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Die();
    }

    void Die()
    {
        var curremtScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(curremtScene);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
    }

}
