using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SpaceShipMove : MonoBehaviour
{
    float moveSpeed = 10f;

    TextMeshProUGUI scoreBoard;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreBoard = GameObject.Find("currScore").GetComponent<TextMeshProUGUI>();
        scoreBoard.text = "Current Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0, 1) * Time.deltaTime * moveSpeed;
        if (transform.position.z <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            score++;
            scoreBoard.text = "Current Score: " + score.ToString();
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Player")
        {
            //lose game
            scoreBoard.text = "You lost";
        }
    }
}
