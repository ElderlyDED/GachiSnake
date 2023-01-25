using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BCmusScript : MonoBehaviour
{
    [Header("Tags")]
    [SerializeField] private string createdTag;

    public AudioSource MusicList;
    public AudioClip[] MusicClips;
    AudioClip ClipPlay;
    AudioSource NowPlayMusic;

    // Start is called before the first frame update
    void Awake()
    {
        //DontDestroyOnLoad(this.gameObject);

        GameObject obj = GameObject.FindWithTag(this.createdTag);
        
        if(obj != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            this.gameObject.tag = this.createdTag;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Start()
    {
        MusicPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        if (!MusicList.isPlaying)
        {
            MusicPlayer();
        }
    }

    public void MusicPlayer()
    {
        //MusicList = GetComponent<AudioSource>();
        //NowPlayMusic = MusicList[Random.Range(0, MusicList.Length)];
        //this.NowPlayMusic.Play();

        ClipPlay = MusicClips[Random.Range(0, MusicClips.Length)];
        MusicList.PlayOneShot(ClipPlay);
    }

}



