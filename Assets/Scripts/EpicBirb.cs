using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EpicBirb : MonoBehaviour
{
    Rigidbody2D rb;
    public  float jumpSpeed;
    public float rotatateScale;
    public int score;
    public TMP_Text scoretText;
    public float speed;
    public GameObject endScreen;
    public GameObject yellowbird;
    public GameObject redbird;
    public GameObject bluebird;
    public GameObject flash;
    public AudioClip jumpSound;
    public AudioClip diedsound;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Pipe.speed = speed;

        var rnd = Random.Range(0, 1);
        if(rnd <0.33f)
        {
            yellowbird.SetActive(true);
        }
        else if (rnd < 0.66f)
        {
            redbird.SetActive(true); 
        }
        else
        {
            bluebird.SetActive(true);
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = Vector2.up * jumpSpeed;
            var source = GetComponent<AudioSource>();
            source.clip = jumpSound;
            source.Play();
        }

        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y * rotatateScale);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Die();
        var source = GetComponent<AudioSource>();
        source.clip = diedsound;
        source.Play();
    }

    void Die()
    {
        Pipe.speed = 0;
        Invoke("ShowMenu", 0.1f);
        jumpSpeed = 0;
        PlayerPrefs.SetInt("score", score);
        flash.SetActive(true);

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
