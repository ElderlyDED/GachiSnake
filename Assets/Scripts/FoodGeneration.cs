using UnityEngine;
using System.Collections;

public class FoodGeneration : MonoBehaviour {

	public GameObject foodPrefab;
	public Vector3 curPos;
	public GameObject curFood;
	void AddNewFood()
	{
	RandomPos();
	curFood = GameObject.Instantiate(foodPrefab,curPos,Quaternion.identity) as GameObject;
	}
	void RandomPos()
	{
    curPos = new Vector3(Random.Range(18,-40),7f,Random.Range(27,-35));
	}

	void Update()
	{
		if(!curFood)
		{
			AddNewFood();
		}
		else
		{
			return;
		}
	}
}
