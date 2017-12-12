using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PlayIntroVideo : MonoBehaviour {

    public bool videoFinished;

    public RawImage image;
    public VideoClip videoToPlay;
    private VideoPlayer videoPlayer;
    private VideoSource videoSource;
    private AudioSource audioSource;

	void Start () {
        Application.runInBackground = true;
        StartCoroutine(playVideo());
    }

    IEnumerator playVideo()
    {
        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        audioSource = gameObject.AddComponent<AudioSource>();
        videoPlayer.playOnAwake = false;
        audioSource.playOnAwake = false;
        audioSource.Pause();
        videoPlayer.source = VideoSource.VideoClip;
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.EnableAudioTrack(0, true);
        videoPlayer.SetTargetAudioSource(0, audioSource);
        videoPlayer.clip = videoToPlay;
        videoPlayer.Prepare();

        WaitForSeconds waitTime = new WaitForSeconds(1);
        while(!videoPlayer.isPrepared)
        {
            Debug.Log("preparing video");
            yield return waitTime;
            break;
        }
        Debug.Log("Done preparing video");
        image.texture = videoPlayer.texture;
        videoPlayer.Play();
        audioSource.Play();
        Debug.Log("Playing Video");
        while (videoPlayer.isPlaying)
        {
            Debug.LogWarning(" Vidoe time: " + Mathf.FloorToInt((float)videoPlayer.time));
            yield return null;
        }
        Debug.Log("Done playing video");
        videoFinished = true;
    }
	
	void Update () {
		
	}
}
