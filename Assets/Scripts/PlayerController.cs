using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public Text winText;
	public Text timeText;
	float theTime;
    float speed = 1;
    private Rigidbody rb;
	public static int valide;
	public static int win;
	public bool move;
	public string minutes;
	public string seconds;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        winText.text = "";
		timeText.text = "";
		valide = 0;
		win=0;
		move = true;
    }

	void Update () {
		theTime+= Time.deltaTime*speed;
		minutes = Mathf.Floor((theTime % 3600) / 60).ToString("00");
		seconds = (theTime % 60).ToString("00");
	}

    void OnTriggerEnter(Collider other) 
    { 
	if (move == true) {
        if (other.gameObject.CompareTag ( "Pick Up"))
        {
			winText.text = "You Win! Press 'space' to continue";
			valide= 1;
			move = false;
        }
		if (other.gameObject.CompareTag ( "Pick Up2"))
        {
			winText.text = "You Win! Press 'space' to continue";
			valide= 2;
			move = false;
        }
		if (other.gameObject.CompareTag ( "Pick Up3"))
        {
			win++;
			if (win == 2) {
			winText.text = "You Win! Press 'space' to continue";
			valide= 3;
			move = false;
			}
        }
		if (other.gameObject.CompareTag ( "Death"))
        {
			winText.text = "You Lost! Press 'space' to continue";
			valide= 3;
			move = false;
        }
		if (other.gameObject.CompareTag ( "Death2"))
        {
			winText.text = "You Lost! Press 'space' to continue";
			valide= 1;
			move = false;
        }
		if (other.gameObject.CompareTag ( "Death3"))
        {
			winText.text = "You Lost! Press 'space' to continue";
			valide= 2;
			move = false;
        }
		
		if (other.gameObject.CompareTag ( "Key"))
        {
			valide= 4;
        }
		
		if (other.gameObject.CompareTag ( "Key2"))
		{
			valide= 5;
		}
		
		if (valide < 4)
		{
				timeText.text = "Your time: " + minutes + ":" + seconds;
		}
	}
    }
}
