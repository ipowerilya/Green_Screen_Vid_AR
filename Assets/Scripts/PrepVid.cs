using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PrepVid : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }
    // Update is called once per frame
    void Update()
    {
        if (!videoPlayer.isPrepared)
        {
            videoPlayer.Prepare();
        }
    }
}
