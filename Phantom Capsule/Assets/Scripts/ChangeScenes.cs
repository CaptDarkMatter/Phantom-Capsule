using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour {

    public int SceneToChangeTo;

    public void SceneToChange(){
        SceneManager.LoadScene(SceneToChangeTo);
    }
}
