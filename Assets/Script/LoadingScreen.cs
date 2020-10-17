using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour {

	[SerializeField]
	private Slider slider;

	void Start () {
		StartCoroutine(LoadAsyncScene());
	}
	
	IEnumerator LoadAsyncScene() {
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(ThroughScenesParameters.getSceneToLoad());
		asyncLoad.allowSceneActivation = false;

		while (!asyncLoad.isDone) {
			slider.value = asyncLoad.progress;
			if (asyncLoad.progress == 0.9f) {
				slider.value = 1f;
				asyncLoad.allowSceneActivation = true;
			}
			yield return null;
		}
	}
}
