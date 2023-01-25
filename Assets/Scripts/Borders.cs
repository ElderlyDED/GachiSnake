using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Borders : MonoBehaviour {

	public AudioSource[] DieSounds;

	AudioSource PlayDie;

	public GameObject mainSnake;


	void OnTriggerEnter(Collider other)
	{
		
		if(other.CompareTag("Nigger"))
		{
			Invoke("SceneLoader", 1f);
			PlayDieSounds();
			KillSnake();

		}

	}

	void SceneLoader()
    {
		SceneManager.LoadScene(2);

	}

	void KillSnake()
    {
		mainSnake = GameObject.FindGameObjectWithTag("Nigger");
		Destroy(mainSnake);

	}

	void PlayDieSounds()
    {
		DieSounds = GetComponents<AudioSource>();
		PlayDie = DieSounds[Random.Range(0, DieSounds.Length)];
		this.PlayDie.Play();
    }
}
