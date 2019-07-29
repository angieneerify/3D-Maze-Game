using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GroundController1 : MonoBehaviour {

    private Rigidbody rb;
    private int count;
	public Vector3 currentRot;
	public int validee;
	public float maxangle = 30.0f;
	public float xP;
	public float zP;
	public float zero = 0;
		
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
		currentRot = GetComponent<Transform> ().eulerAngles;
		if ((Input.GetAxis("Horizontal") <0) && (currentRot.z <=16 || currentRot.z >=342)) {
			transform.Rotate (0,0,1);
		}
		if ((Input.GetAxis("Horizontal") >0) && (currentRot.z >=344 || currentRot.z <=18)) {
			transform.Rotate (0,0,-1);
		}
		if ((Input.GetAxis("Vertical") >0)&& (currentRot.x <=16 || currentRot.x >=342)) 
		{
			transform.Rotate (1,0,0);
		}
		if ((Input.GetAxis("Vertical") <0)&& (currentRot.x >=344 || currentRot.x <=18)) 
		{
			transform.Rotate (-1,0,0);
		}
		
		if (Input.GetKeyDown("space"))
			{
				validee= PlayerController.valide;
				if (validee == 1) {
					SceneManager.LoadScene("Tilt level 2", LoadSceneMode.Single);
				}
				if (validee == 2) {
					SceneManager.LoadScene("Tilt level 3", LoadSceneMode.Single);
				}
				if (validee == 3) {
					SceneManager.LoadScene("Tilt level 1", LoadSceneMode.Single);
				}
			}
	}

}