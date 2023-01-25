using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class SnakeMovment : MonoBehaviour {

	public float Speed;
	public float RotationSpeed;
	public List<GameObject> tailObjects = new List<GameObject>();
	public float z_offset = -10.5f;
	public TailMovment SnakeBodyS;
	public GameObject AddScoreAnim;
	public GameObject TailPrefab;
	public Text ScoreText;
	public int score = 0;
	public GameObject CumParticle;

	public AudioSource[] TakeCumSounds;

	AudioSource Sounds;
	
	

	void Start () {
		tailObjects.Add(gameObject);
		AddTail();
		score -= 1;

	}
	void Update () 
	{
	    ScoreText.text = "CUM: " + score.ToString();
		transform.Translate(Vector3.forward*Speed*Time.deltaTime);
		RecordWriter();
		HighScoreWriterEasy();
		HighScoreWriterMedium();
		HighScoreWriterHard();
		MovmentKeys();
	}

	public void MovmentKeys()
    {
		if (PlayerPrefs.GetInt("IndxKeyBinds") == 1)
        {
			if (Input.GetKey(KeyCode.D))
			{
				transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
			}
			if (Input.GetKey(KeyCode.A))
			{
				transform.Rotate(Vector3.up * -1 * RotationSpeed * Time.deltaTime);
			}
		}

		if (PlayerPrefs.GetInt("IndxKeyBinds") == 2)
		{
			if (Input.GetKey(KeyCode.RightArrow))
			{
				transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
			}
			if (Input.GetKey(KeyCode.LeftArrow))
			{
				transform.Rotate(Vector3.up * -1 * RotationSpeed * Time.deltaTime);
			}
		}


	}

	public void AddTail()
	{
		
		score++;
		Vector3 newTailPos = tailObjects[tailObjects.Count-1].transform.position;
		newTailPos.z -= 0.5f;
		Speed += PlayerPrefs.GetFloat("PlusS");
		AddScore();
		CumEatEffect();
		SoundsCum();

		
		
		

		//SnakeBodyS = GameObject.FindGameObjectWithTag("NiggerBody").GetComponent<TailMovment>();
		//SnakeBodyS.transform.position = new Vector3(0f,-1f,0f); 




		tailObjects.Add(GameObject.Instantiate(TailPrefab,newTailPos,Quaternion.identity) as GameObject);
	}

	public void SoundsCum()
	{
		TakeCumSounds = GetComponents<AudioSource>();
		Sounds = TakeCumSounds[Random.Range(0, TakeCumSounds.Length)];
		this.Sounds.Play();
	}

	public void RecordWriter()
	{
		PlayerPrefs.SetInt("ScoreRecord", score);

	}

	public void HighScoreWriterEasy()
    {

		if (PlayerPrefs.GetInt("IndxHS") == 1)
        {
			if (PlayerPrefs.GetInt("HighScoreRecorderEasy") < score)
			{
				PlayerPrefs.SetInt("HighScoreRecorderEasy", score);
			}
		}
			
		
    }

	public void HighScoreWriterMedium()
	{

		if (PlayerPrefs.GetInt("IndxHS") == 2)
		{
			if (PlayerPrefs.GetInt("HighScoreRecorderMedium") < score)
			{
				PlayerPrefs.SetInt("HighScoreRecorderMedium", score);
			}
		}


	}

	public void HighScoreWriterHard()
	{

		if (PlayerPrefs.GetInt("IndxHS") == 3)
		{
			if (PlayerPrefs.GetInt("HighScoreRecorderHard") < score)
			{
				PlayerPrefs.SetInt("HighScoreRecorderHard", score);
			}
		}


	}

	public void AddScore()
    {
		AddScoreAnim.GetComponent<Animation>().Play("ScoreAddAnim");
		
	}

	public void CumEatEffect()
    {
		Instantiate(CumParticle, transform.position, Quaternion.identity);
    }
}
