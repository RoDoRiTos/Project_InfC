using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader: MonoBehaviour {

	public void ChangeScene(int sceneIndex) {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);
    }

}
