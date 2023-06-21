using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playercontroler : MonoBehaviour
{
    public Text scoreText;
    public Text winText; 
    Rigidbody2D rbd2;
    private int count = 0;

    void Start()
    {
        rbd2 = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");
        Vector2 Movement = new Vector2(MoveHorizontal, MoveVertical);
        rbd2.AddForce(Movement * 5);

    }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("PickUp"))
        {
            count++;
            Destroy(collision.gameObject);
            UpdateScoreText();
        }
        }
    void UpdateScoreText()
    {
        scoreText.text = "Wynik: " + count;
        if (count == 3)
        {
            winText.gameObject.SetActive(true);
            scoreText.gameObject.SetActive(false);
            StartCoroutine(WaitForFunction());
            SceneManager.LoadScene("Level02");
        }
    }
    IEnumerator WaitForFunction()
    {
        yield return new WaitForSeconds(3);
    }

}
