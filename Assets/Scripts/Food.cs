using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Food : MonoBehaviour {

	

	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Nigger"))
		{
			other.GetComponent<SnakeMovment>().AddTail();
			Destroy(gameObject);
		}
	}

	

}
