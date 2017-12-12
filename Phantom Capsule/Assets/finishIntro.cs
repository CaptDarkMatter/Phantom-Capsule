using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishIntro : MonoBehaviour {

    void Start () {

    }
	
	void Update () {
        GameObject introScreen = GameObject.Find("IntroScreen");
        GameObject isIntroFinished = GameObject.Find("isIntroFinished");
        PlayIntroVideo playIntroVideo = introScreen.GetComponent<PlayIntroVideo>();
        ChangeScenes changeScenes = isIntroFinished.GetComponent<ChangeScenes>();
        if (playIntroVideo.videoFinished == true){
            changeScenes.SceneToChangeTo = 1;
            changeScenes.SceneToChange();
        }
	}
}
