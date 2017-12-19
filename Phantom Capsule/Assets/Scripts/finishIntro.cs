using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishIntro : MonoBehaviour {

    void Start () {

    }
	
	void Update () {
        SkipIntro();

        GameObject introScreen = GameObject.Find("IntroScreen");
        GameObject isIntroFinished = GameObject.Find("isIntroFinished");
        PlayIntroVideo playIntroVideo = introScreen.GetComponent<PlayIntroVideo>();
        ChangeScenes changeScenes = isIntroFinished.GetComponent<ChangeScenes>();
        if (playIntroVideo.videoFinished == true){
            changeScenes.SceneToChangeTo = 1;
            changeScenes.SceneToChange();
        }
	}

    void SkipIntro(){
        GameObject introScreen = GameObject.Find("IntroScreen");
        PlayIntroVideo playIntroVideo = introScreen.GetComponent<PlayIntroVideo>();
        if (Input.anyKeyDown){
            playIntroVideo.videoFinished = true;
        }
    }
}
