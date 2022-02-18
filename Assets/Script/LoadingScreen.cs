using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour {

	protected Slider mSlider;

	void Start () {
		mSlider = GameObject.Find ("Slider").GetComponent<Slider> ();
		StartCoroutine(LoadAsyncScene());
	}
	
	IEnumerator LoadAsyncScene() {
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(ThroughScenesParameters.getSceneToLoad());
		asyncLoad.allowSceneActivation = false;

		while (!asyncLoad.isDone) {
			mSlider.value = asyncLoad.progress;
			if (asyncLoad.progress == 0.9f) {
				mSlider.value = 1f;
				asyncLoad.allowSceneActivation = true;
			}
			yield return null;
		}
	}
}
