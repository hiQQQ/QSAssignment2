using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public GameObject Player;

    private Rigidbody rb;

    public float speed;
    public float size;
    private int count;

    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        count = 0;

	speed = GameManager.PlayingSpeed;
	float fsize = GameManager.PlayingSize;
        int nsize = (int)fsize; 

	Player.transform.localScale = new Vector3(nsize, nsize, nsize);

        SetCountText();

        winTextObject.SetActive(false);

        if (GameManager.colorValue == 0){
	    Player.GetComponent<Renderer>().material.color = Color.red;
	}
	else if (GameManager.colorValue == 1){
	    Player.GetComponent<Renderer>().material.color = Color.yellow;
	}
	else if (GameManager.colorValue == 2){
	    Player.GetComponent<Renderer>().material.color = Color.blue;   
	}
	else{
	    Player.GetComponent<Renderer>().material.color = Color.blue;
	}
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Collectible")){
            other.gameObject.SetActive(false);

            count = count + 1;

            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count >= 8)
        {
            winTextObject.SetActive(true);
        }
    }

    void FixedUpdate() 
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }
}
