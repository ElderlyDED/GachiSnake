using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TailMovment : MonoBehaviour {

	public float Speed;
	public Vector3 tailTarget;
	public int indx;
	public GameObject tailTargetObj;
	public SnakeMovment mainSnake;
	
	
	
	

	void Start()
	{
		
		mainSnake = GameObject.FindGameObjectWithTag("Nigger").GetComponent<SnakeMovment>();
		Speed = mainSnake.Speed;
		tailTargetObj = mainSnake.tailObjects[mainSnake.tailObjects.Count-2];
		indx = mainSnake.tailObjects.IndexOf(gameObject);
	}
	void Update () 
	{
		tailTarget = tailTargetObj.transform.position;
		transform.LookAt(tailTarget);
		transform.position = Vector3.Lerp(transform.position,tailTarget,Time.deltaTime*Speed);
		Speed = mainSnake.Speed - 2;
		


	}

	void OnTriggerEnter(Collider other)
	{
		
		if(other.CompareTag("Nigger"))
		{
			if(indx > 3)
			{
				SceneManager.LoadScene(2);
			}
		}

	}
	
}
