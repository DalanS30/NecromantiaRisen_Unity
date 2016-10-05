using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class BeginButton : MonoBehaviour {

	public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
