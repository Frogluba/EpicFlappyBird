using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EpicBirb : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpSpeed;
    public float rotatateScale;
    public int score;
    public TMP_Text scoretText;
    public float speed;
    public GameObject endScreen;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Pipe.speed = speed;
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
        Pipe.speed = 0;
        Invoke("ShowMenu", 1f);
        jumpSpeed = 0;
        //var curremtScene = SceneManager.GetActiveScene().name;
        //SceneManager.LoadScene(curremtScene);
    }
    void ShowMenu()
    {
        endScreen.SetActive(true);
        scoretText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        scoretText.text = score.ToString();
    }

}
