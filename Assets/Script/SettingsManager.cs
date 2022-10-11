using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class SettingsManager : MonoBehaviour {

	private AudioClip mWhoosh, mTurn, mVictory;
	private PostProcessingProfile mAlto, mMedio, mBasso;

	private GameObject mCameraPrincipale;
	private GameObject mCubo;

	private MainMenuManager mMainMenuManager;
	private ScrittaMenuOpzioni mScrittaAlto, mScrittaMedio, mScrittaBasso, mScrittaVsyncOn, mScrittaVsyncOff, mScrittaSuoniOn, mScrittaSuoniOff;

	public void Initialize(){
		mWhoosh = Resources.Load<AudioClip>("Sounds/Whoosh");
		mTurn = Resources.Load<AudioClip>("Sounds/Turn");
		mVictory = Resources.Load<AudioClip>("Sounds/Victory - Tada");

		mAlto = Resources.Load<PostProcessingProfile>("PostProPresetTAA");
		mMedio = Resources.Load<PostProcessingProfile>("PostProPresetNoMotionBlur");
		mBasso = Resources.Load<PostProcessingProfile>("PostProPresetLow");

		mCameraPrincipale = GameObject.Find("CameraFree");
		mCubo = GameObject.Find("Cubo");

		mMainMenuManager = GameObject.Find ("GameManager").GetComponent<MainMenuManager> ();
		mScrittaAlto = mMainMenuManager.GetAlto().GetComponent<ScrittaMenuOpzioni> ();
		mScrittaMedio = mMainMenuManager.GetMedio().GetComponent<ScrittaMenuOpzioni> ();
		mScrittaBasso = mMainMenuManager.GetBasso().GetComponent<ScrittaMenuOpzioni> ();
		mScrittaVsyncOn = mMainMenuManager.GetVsOn().GetComponent<ScrittaMenuOpzioni> ();
		mScrittaVsyncOff = mMainMenuManager.GetVsOff().GetComponent<ScrittaMenuOpzioni> ();
		mScrittaSuoniOn = mMainMenuManager.GetSuoniOn().GetComponent<ScrittaMenuOpzioni> ();
		mScrittaSuoniOff = mMainMenuManager.GetSuoniOff().GetComponent<ScrittaMenuOpzioni> ();
	}

	public void SetAlto(){
		mCameraPrincipale.GetComponent<PostProcessingBehaviour> ().profile = mAlto;
		mScrittaAlto.SetAcceso (true);
	}

	public void SetMedio(){
		mCameraPrincipale.GetComponent<PostProcessingBehaviour> ().profile = mMedio;
		mScrittaMedio.SetAcceso (true);
	}

	public void SetBasso(){
		mCameraPrincipale.GetComponent<PostProcessingBehaviour> ().profile = mBasso;
		mScrittaBasso.SetAcceso (true);
	}

	public void SetVsyncOn(){
		QualitySettings.vSyncCount = 1;
		mScrittaVsyncOn.SetAcceso (true);
	}

	public void SetVsyncOff(){
		QualitySettings.vSyncCount = 0;
		//Application.targetFrameRate = 60;
		mScrittaVsyncOff.SetAcceso (true);
	}

	public void SetSuoniOn(){
		mCubo.GetComponent<AudioSource> ().clip = mTurn;
		mCameraPrincipale.GetComponent<AudioSource> ().clip = mWhoosh;
		GetComponent<AudioSource> ().clip = mVictory;
		mScrittaSuoniOn.SetAcceso (true);
	}

	public void SetSuoniOff(){
		mCubo.GetComponent<AudioSource> ().clip = null;
		mCameraPrincipale.GetComponent<AudioSource> ().clip = null;
		GetComponent<AudioSource> ().clip = null;
		mScrittaSuoniOff.SetAcceso (true);
	}

	public int GetGrafica(){
		if (mCameraPrincipale.GetComponent<PostProcessingBehaviour> ().profile == mAlto) {
			return 2;
		} else if (mCameraPrincipale.GetComponent<PostProcessingBehaviour> ().profile == mMedio) {
			return 1;
		} else {
			return 0;
		}
	}

	public int GetGraficaVsync(){
		return QualitySettings.vSyncCount;
	}

	public int GetSuoni(){
		if (GetComponent<AudioSource> ().clip == null) {
			return 0;
		} else {
			return 1;
		}
	}

	public void SetGrafica(int grafica){
		switch (grafica) {
		case 0: SetBasso (); break;
		case 1: SetMedio (); break;
		case 2: SetAlto (); break;
		}
	}

	public void SetGraficaVsync(int graficaVsync){
		switch (graficaVsync) {
		case 0: SetVsyncOff (); break;
		case 1: SetVsyncOn (); break;
		}
	}

	public void SetSuoni(int suoni){
		if (suoni == 1) {
			SetSuoniOn ();
		} else {
			SetSuoniOff ();
		}
	}
}
