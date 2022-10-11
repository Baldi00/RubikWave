using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

	private int mFrames = 15;
	private int mSteps;
	private bool mOrario = true;
	private int mDaRoutare = 0;

	private GameObject mFrontAnim, mBackAnim, mLeftAnim, mRightAnim, mUpAnim, mDownAnim;
	private Vector3 mFrontAnimDefaultPosition = new Vector3 (-3.75f, 3.75f, 0f);
	private Vector3 mFrontAnimDefaultRotation = new Vector3 (0f, 0f, 0f);
	private Vector3 mBackAnimDefaultPosition = new Vector3 (-3.75f, 3.75f, 2.5f);
	private Vector3 mBackAnimDefaultRotation = new Vector3 (0f, 180f, 0f);
	private Vector3 mLeftAnimDefaultPosition = new Vector3 (-5f, 3.75f, 1.25f);
	private Vector3 mLeftAnimDefaultRotation = new Vector3 (0f, 90f, 0f);
	private Vector3 mRightAnimDefaultPosition = new Vector3 (-2.5f, 3.75f, 1.25f);
	private Vector3 mRightAnimDefaultRotation = new Vector3 (0f, -90f, 0f);
	private Vector3 mUpAnimDefaultPosition = new Vector3 (-3.75f, 2.5f, 1.25f);
	private Vector3 mUpAnimDefaultRotation = new Vector3 (-90f, 0f, 0f);
	private Vector3 mDownAnimDefaultPosition = new Vector3 (-3.75f, 5f, 1.25f);
	private Vector3 mDownAnimDefaultRotation = new Vector3 (90f, 0f, 0f);

	private CubeManager mStatoCubo;

	private GameObject VertFrontLeftUpFrontAnim,VertFrontRightUpFrontAnim,VertFrontLeftDownFrontAnim,VertFrontRightDownFrontAnim,VertLeftRightUpFrontAnim,VertLeftRightDownFrontAnim,VertRightLeftUpFrontAnim,VertRightLeftDownFrontAnim,VertUpLeftDownFrontAnim,VertUpRightDownFrontAnim,VertDownLeftUpFrontAnim,VertDownRightUpFrontAnim;
	private GameObject VertFrontLeftUpBackAnim,VertFrontRightUpBackAnim,VertFrontLeftDownBackAnim,VertFrontRightDownBackAnim,VertLeftRightUpBackAnim,VertLeftRightDownBackAnim,VertRightLeftUpBackAnim,VertRightLeftDownBackAnim,VertUpLeftDownBackAnim,VertUpRightDownBackAnim,VertDownLeftUpBackAnim,VertDownRightUpBackAnim;
	private GameObject VertFrontLeftUpLeftAnim,VertFrontRightUpLeftAnim,VertFrontLeftDownLeftAnim,VertFrontRightDownLeftAnim,VertLeftRightUpLeftAnim,VertLeftRightDownLeftAnim,VertRightLeftUpLeftAnim,VertRightLeftDownLeftAnim,VertUpLeftDownLeftAnim,VertUpRightDownLeftAnim,VertDownLeftUpLeftAnim,VertDownRightUpLeftAnim;
	private GameObject VertFrontLeftUpRightAnim,VertFrontRightUpRightAnim,VertFrontLeftDownRightAnim,VertFrontRightDownRightAnim,VertLeftRightUpRightAnim,VertLeftRightDownRightAnim,VertRightLeftUpRightAnim,VertRightLeftDownRightAnim,VertUpLeftDownRightAnim,VertUpRightDownRightAnim,VertDownLeftUpRightAnim,VertDownRightUpRightAnim;
	private GameObject VertFrontLeftUpUpAnim,VertFrontRightUpUpAnim,VertFrontLeftDownUpAnim,VertFrontRightDownUpAnim,VertLeftRightUpUpAnim,VertLeftRightDownUpAnim,VertRightLeftUpUpAnim,VertRightLeftDownUpAnim,VertUpLeftDownUpAnim,VertUpRightDownUpAnim,VertDownLeftUpUpAnim,VertDownRightUpUpAnim;
	private GameObject VertFrontLeftUpDownAnim,VertFrontRightUpDownAnim,VertFrontLeftDownDownAnim,VertFrontRightDownDownAnim,VertLeftRightUpDownAnim,VertLeftRightDownDownAnim,VertRightLeftUpDownAnim,VertRightLeftDownDownAnim,VertUpLeftDownDownAnim,VertUpRightDownDownAnim,VertDownLeftUpDownAnim,VertDownRightUpDownAnim;

	private GameObject SpigFrontUpFrontAnim,SpigFrontDownFrontAnim,SpigFrontLeftFrontAnim,SpigFrontRightFrontAnim,SpigLeftRightFrontAnim,SpigRightLeftFrontAnim,SpigUpDownFrontAnim,SpigDownUpFrontAnim;
	private GameObject SpigFrontUpBackAnim,SpigFrontDownBackAnim,SpigFrontLeftBackAnim,SpigFrontRightBackAnim,SpigLeftRightBackAnim,SpigRightLeftBackAnim,SpigUpDownBackAnim,SpigDownUpBackAnim;
	private GameObject SpigFrontUpLeftAnim,SpigFrontDownLeftAnim,SpigFrontLeftLeftAnim,SpigFrontRightLeftAnim,SpigLeftRightLeftAnim,SpigRightLeftLeftAnim,SpigUpDownLeftAnim,SpigDownUpLeftAnim;
	private GameObject SpigFrontUpRightAnim,SpigFrontDownRightAnim,SpigFrontLeftRightAnim,SpigFrontRightRightAnim,SpigLeftRightRightAnim,SpigRightLeftRightAnim,SpigUpDownRightAnim,SpigDownUpRightAnim;
	private GameObject SpigFrontUpUpAnim,SpigFrontDownUpAnim,SpigFrontLeftUpAnim,SpigFrontRightUpAnim,SpigLeftRightUpAnim,SpigRightLeftUpAnim,SpigUpDownUpAnim,SpigDownUpUpAnim;
	private GameObject SpigFrontUpDownAnim,SpigFrontDownDownAnim,SpigFrontLeftDownAnim,SpigFrontRightDownAnim,SpigLeftRightDownAnim,SpigRightLeftDownAnim,SpigUpDownDownAnim,SpigDownUpDownAnim;

	private AudioSource mSuonoRotazione;

	//Mescola
	private int mIndex;
	private int [] mMosse;
	private int mNumMosse;
	private bool mContinua = false;
	private bool mStoMescolando = false;
	private bool mStoRisolvendo = false;

	void Start () {
		mSteps = 0;

		VertFrontLeftUpFrontAnim 	= GameObject.Find("VertFrontLeftUpFrontAnim");
		VertFrontRightUpFrontAnim 	= GameObject.Find("VertFrontRightUpFrontAnim");
		VertFrontLeftDownFrontAnim 	= GameObject.Find("VertFrontLeftDownFrontAnim");
		VertFrontRightDownFrontAnim = GameObject.Find("VertFrontRightDownFrontAnim");
		VertLeftRightUpFrontAnim 	= GameObject.Find("VertLeftRightUpFrontAnim");
		VertLeftRightDownFrontAnim 	= GameObject.Find("VertLeftRightDownFrontAnim");
		VertRightLeftUpFrontAnim 	= GameObject.Find("VertRightLeftUpFrontAnim");
		VertRightLeftDownFrontAnim 	= GameObject.Find("VertRightLeftDownFrontAnim");
		VertUpLeftDownFrontAnim 	= GameObject.Find("VertUpLeftDownFrontAnim");
		VertUpRightDownFrontAnim 	= GameObject.Find("VertUpRightDownFrontAnim");
		VertDownLeftUpFrontAnim 	= GameObject.Find("VertDownLeftUpFrontAnim");
		VertDownRightUpFrontAnim 	= GameObject.Find("VertDownRightUpFrontAnim");
		VertFrontLeftUpBackAnim 	= GameObject.Find("VertFrontLeftUpBackAnim");
		VertFrontRightUpBackAnim 	= GameObject.Find("VertFrontRightUpBackAnim");
		VertFrontLeftDownBackAnim 	= GameObject.Find("VertFrontLeftDownBackAnim");
		VertFrontRightDownBackAnim 	= GameObject.Find("VertFrontRightDownBackAnim");
		VertLeftRightUpBackAnim 	= GameObject.Find("VertLeftRightUpBackAnim");
		VertLeftRightDownBackAnim 	= GameObject.Find("VertLeftRightDownBackAnim");
		VertRightLeftUpBackAnim 	= GameObject.Find("VertRightLeftUpBackAnim");
		VertRightLeftDownBackAnim 	= GameObject.Find("VertRightLeftDownBackAnim");
		VertUpLeftDownBackAnim 		= GameObject.Find("VertUpLeftDownBackAnim");
		VertUpRightDownBackAnim 	= GameObject.Find("VertUpRightDownBackAnim");
		VertDownLeftUpBackAnim 		= GameObject.Find("VertDownLeftUpBackAnim");
		VertDownRightUpBackAnim 	= GameObject.Find("VertDownRightUpBackAnim");
		VertFrontLeftUpLeftAnim 	= GameObject.Find("VertFrontLeftUpLeftAnim");
		VertFrontRightUpLeftAnim 	= GameObject.Find("VertFrontRightUpLeftAnim");
		VertFrontLeftDownLeftAnim 	= GameObject.Find("VertFrontLeftDownLeftAnim");
		VertFrontRightDownLeftAnim 	= GameObject.Find("VertFrontRightDownLeftAnim");
		VertLeftRightUpLeftAnim 	= GameObject.Find("VertLeftRightUpLeftAnim");
		VertLeftRightDownLeftAnim 	= GameObject.Find("VertLeftRightDownLeftAnim");
		VertRightLeftUpLeftAnim 	= GameObject.Find("VertRightLeftUpLeftAnim");
		VertRightLeftDownLeftAnim 	= GameObject.Find("VertRightLeftDownLeftAnim");
		VertUpLeftDownLeftAnim 		= GameObject.Find("VertUpLeftDownLeftAnim");
		VertUpRightDownLeftAnim 	= GameObject.Find("VertUpRightDownLeftAnim");
		VertDownLeftUpLeftAnim 		= GameObject.Find("VertDownLeftUpLeftAnim");
		VertDownRightUpLeftAnim 	= GameObject.Find("VertDownRightUpLeftAnim");
		VertFrontLeftUpRightAnim 	= GameObject.Find("VertFrontLeftUpRightAnim");
		VertFrontRightUpRightAnim 	= GameObject.Find("VertFrontRightUpRightAnim");
		VertFrontLeftDownRightAnim 	= GameObject.Find("VertFrontLeftDownRightAnim");
		VertFrontRightDownRightAnim = GameObject.Find("VertFrontRightDownRightAnim");
		VertLeftRightUpRightAnim 	= GameObject.Find("VertLeftRightUpRightAnim");
		VertLeftRightDownRightAnim 	= GameObject.Find("VertLeftRightDownRightAnim");
		VertRightLeftUpRightAnim 	= GameObject.Find("VertRightLeftUpRightAnim");
		VertRightLeftDownRightAnim 	= GameObject.Find("VertRightLeftDownRightAnim");
		VertUpLeftDownRightAnim 	= GameObject.Find("VertUpLeftDownRightAnim");
		VertUpRightDownRightAnim 	= GameObject.Find("VertUpRightDownRightAnim");
		VertDownLeftUpRightAnim 	= GameObject.Find("VertDownLeftUpRightAnim");
		VertDownRightUpRightAnim 	= GameObject.Find("VertDownRightUpRightAnim");
		VertFrontLeftUpUpAnim 		= GameObject.Find("VertFrontLeftUpUpAnim");
		VertFrontRightUpUpAnim 		= GameObject.Find("VertFrontRightUpUpAnim");
		VertFrontLeftDownUpAnim 	= GameObject.Find("VertFrontLeftDownUpAnim");
		VertFrontRightDownUpAnim 	= GameObject.Find("VertFrontRightDownUpAnim");
		VertLeftRightUpUpAnim 		= GameObject.Find("VertLeftRightUpUpAnim");
		VertLeftRightDownUpAnim 	= GameObject.Find("VertLeftRightDownUpAnim");
		VertRightLeftUpUpAnim 		= GameObject.Find("VertRightLeftUpUpAnim");
		VertRightLeftDownUpAnim 	= GameObject.Find("VertRightLeftDownUpAnim");
		VertUpLeftDownUpAnim 		= GameObject.Find("VertUpLeftDownUpAnim");
		VertUpRightDownUpAnim 		= GameObject.Find("VertUpRightDownUpAnim");
		VertDownLeftUpUpAnim 		= GameObject.Find("VertDownLeftUpUpAnim");
		VertDownRightUpUpAnim 		= GameObject.Find("VertDownRightUpUpAnim");
		VertFrontLeftUpDownAnim 	= GameObject.Find("VertFrontLeftUpDownAnim");
		VertFrontRightUpDownAnim 	= GameObject.Find("VertFrontRightUpDownAnim");
		VertFrontLeftDownDownAnim 	= GameObject.Find("VertFrontLeftDownDownAnim");
		VertFrontRightDownDownAnim 	= GameObject.Find("VertFrontRightDownDownAnim");
		VertLeftRightUpDownAnim 	= GameObject.Find("VertLeftRightUpDownAnim");
		VertLeftRightDownDownAnim 	= GameObject.Find("VertLeftRightDownDownAnim");
		VertRightLeftUpDownAnim 	= GameObject.Find("VertRightLeftUpDownAnim");
		VertRightLeftDownDownAnim 	= GameObject.Find("VertRightLeftDownDownAnim");
		VertUpLeftDownDownAnim 		= GameObject.Find("VertUpLeftDownDownAnim");
		VertUpRightDownDownAnim 	= GameObject.Find("VertUpRightDownDownAnim");
		VertDownLeftUpDownAnim 		= GameObject.Find("VertDownLeftUpDownAnim");
		VertDownRightUpDownAnim 	= GameObject.Find("VertDownRightUpDownAnim");

		SpigFrontUpFrontAnim 		= GameObject.Find("SpigFrontUpFrontAnim");
		SpigFrontDownFrontAnim 		= GameObject.Find("SpigFrontDownFrontAnim");
		SpigFrontLeftFrontAnim 		= GameObject.Find("SpigFrontLeftFrontAnim");
		SpigFrontRightFrontAnim 	= GameObject.Find("SpigFrontRightFrontAnim");
		SpigLeftRightFrontAnim 		= GameObject.Find("SpigLeftRightFrontAnim");
		SpigRightLeftFrontAnim 		= GameObject.Find("SpigRightLeftFrontAnim");
		SpigUpDownFrontAnim 		= GameObject.Find("SpigUpDownFrontAnim");
		SpigDownUpFrontAnim 		= GameObject.Find("SpigDownUpFrontAnim");
		SpigFrontUpBackAnim 		= GameObject.Find("SpigFrontUpBackAnim");
		SpigFrontDownBackAnim 		= GameObject.Find("SpigFrontDownBackAnim");
		SpigFrontLeftBackAnim 		= GameObject.Find("SpigFrontLeftBackAnim");
		SpigFrontRightBackAnim 		= GameObject.Find("SpigFrontRightBackAnim");
		SpigLeftRightBackAnim 		= GameObject.Find("SpigLeftRightBackAnim");
		SpigRightLeftBackAnim 		= GameObject.Find("SpigRightLeftBackAnim");
		SpigUpDownBackAnim 			= GameObject.Find("SpigUpDownBackAnim");
		SpigDownUpBackAnim 			= GameObject.Find("SpigDownUpBackAnim");
		SpigFrontUpLeftAnim 		= GameObject.Find("SpigFrontUpLeftAnim");
		SpigFrontDownLeftAnim 		= GameObject.Find("SpigFrontDownLeftAnim");
		SpigFrontLeftLeftAnim 		= GameObject.Find("SpigFrontLeftLeftAnim");
		SpigFrontRightLeftAnim 		= GameObject.Find("SpigFrontRightLeftAnim");
		SpigLeftRightLeftAnim 		= GameObject.Find("SpigLeftRightLeftAnim");
		SpigRightLeftLeftAnim 		= GameObject.Find("SpigRightLeftLeftAnim");
		SpigUpDownLeftAnim 			= GameObject.Find("SpigUpDownLeftAnim");
		SpigDownUpLeftAnim 			= GameObject.Find("SpigDownUpLeftAnim");
		SpigFrontUpRightAnim 		= GameObject.Find("SpigFrontUpRightAnim");
		SpigFrontDownRightAnim 		= GameObject.Find("SpigFrontDownRightAnim");
		SpigFrontLeftRightAnim 		= GameObject.Find("SpigFrontLeftRightAnim");
		SpigFrontRightRightAnim 	= GameObject.Find("SpigFrontRightRightAnim");
		SpigLeftRightRightAnim 		= GameObject.Find("SpigLeftRightRightAnim");
		SpigRightLeftRightAnim 		= GameObject.Find("SpigRightLeftRightAnim");
		SpigUpDownRightAnim 		= GameObject.Find("SpigUpDownRightAnim");
		SpigDownUpRightAnim 		= GameObject.Find("SpigDownUpRightAnim");
		SpigFrontUpUpAnim 			= GameObject.Find("SpigFrontUpUpAnim");
		SpigFrontDownUpAnim 		= GameObject.Find("SpigFrontDownUpAnim");
		SpigFrontLeftUpAnim 		= GameObject.Find("SpigFrontLeftUpAnim");
		SpigFrontRightUpAnim 		= GameObject.Find("SpigFrontRightUpAnim");
		SpigLeftRightUpAnim 		= GameObject.Find("SpigLeftRightUpAnim");
		SpigRightLeftUpAnim 		= GameObject.Find("SpigRightLeftUpAnim");
		SpigUpDownUpAnim 			= GameObject.Find("SpigUpDownUpAnim");
		SpigDownUpUpAnim 			= GameObject.Find("SpigDownUpUpAnim");
		SpigFrontUpDownAnim 		= GameObject.Find("SpigFrontUpDownAnim");
		SpigFrontDownDownAnim 		= GameObject.Find("SpigFrontDownDownAnim");
		SpigFrontLeftDownAnim 		= GameObject.Find("SpigFrontLeftDownAnim");
		SpigFrontRightDownAnim 		= GameObject.Find("SpigFrontRightDownAnim");
		SpigLeftRightDownAnim 		= GameObject.Find("SpigLeftRightDownAnim");
		SpigRightLeftDownAnim 		= GameObject.Find("SpigRightLeftDownAnim");
		SpigUpDownDownAnim 			= GameObject.Find("SpigUpDownDownAnim");
		SpigDownUpDownAnim 			= GameObject.Find("SpigDownUpDownAnim");

		mFrontAnim 	= GameObject.Find("FrontAnim");
		mBackAnim 	= GameObject.Find("BackAnim");
		mLeftAnim 	= GameObject.Find("LeftAnim");
		mRightAnim 	= GameObject.Find("RightAnim");
		mUpAnim 	= GameObject.Find("UpAnim");
		mDownAnim 	= GameObject.Find("DownAnim");

		mFrontAnim.transform.position = mFrontAnimDefaultPosition;
		mFrontAnim.transform.rotation = Quaternion.Euler(mFrontAnimDefaultRotation);
		mBackAnim.transform.position = mBackAnimDefaultPosition;
		mBackAnim.transform.rotation = Quaternion.Euler(mBackAnimDefaultRotation);
		mLeftAnim.transform.position = mLeftAnimDefaultPosition;
		mLeftAnim.transform.rotation = Quaternion.Euler(mLeftAnimDefaultRotation);
		mRightAnim.transform.position = mRightAnimDefaultPosition;
		mRightAnim.transform.rotation = Quaternion.Euler(mRightAnimDefaultRotation);
		mUpAnim.transform.position = mUpAnimDefaultPosition;
		mUpAnim.transform.rotation = Quaternion.Euler(mUpAnimDefaultRotation);
		mDownAnim.transform.position = mDownAnimDefaultPosition;
		mDownAnim.transform.rotation = Quaternion.Euler(mDownAnimDefaultRotation);

		mFrontAnim.SetActive (false);
		mBackAnim.SetActive (false);
		mLeftAnim.SetActive (false);
		mRightAnim.SetActive (false);
		mUpAnim.SetActive (false);
		mDownAnim.SetActive (false);

		mStatoCubo = GameObject.Find ("GameManager").GetComponent<CubeManager> ();
		mSuonoRotazione = GameObject.Find ("Cubo").GetComponent<AudioSource> ();
	}

	void FixedUpdate () {
		if (mSteps > 0) {

			Quaternion rotation = Quaternion.identity;
			float gradi;

			if (mOrario)
				gradi = 90f;
			else
				gradi = -90f;

			switch(mDaRoutare){
			case 1:
				rotation.eulerAngles = new Vector3 (mFrontAnim.transform.rotation.eulerAngles.x, mFrontAnim.transform.rotation.eulerAngles.y, mFrontAnim.transform.rotation.eulerAngles.z+gradi/mFrames);
				mFrontAnim.transform.rotation = rotation;
				break;

			case 2:
				rotation.eulerAngles = new Vector3 (mBackAnim.transform.rotation.eulerAngles.x, mBackAnim.transform.rotation.eulerAngles.y, mBackAnim.transform.rotation.eulerAngles.z+gradi/mFrames);
				mBackAnim.transform.rotation = rotation;
				break;

			case 3:
				rotation.eulerAngles = new Vector3 (mLeftAnim.transform.rotation.eulerAngles.x, mLeftAnim.transform.rotation.eulerAngles.y, mLeftAnim.transform.rotation.eulerAngles.z+gradi/mFrames);
				mLeftAnim.transform.rotation = rotation;
				break;

			case 4:
				rotation.eulerAngles = new Vector3 (mRightAnim.transform.rotation.eulerAngles.x, mRightAnim.transform.rotation.eulerAngles.y, mRightAnim.transform.rotation.eulerAngles.z+gradi/mFrames);
				mRightAnim.transform.rotation = rotation;
				break;

			case 5:
				rotation.eulerAngles = new Vector3 (mUpAnim.transform.rotation.eulerAngles.x, mUpAnim.transform.rotation.eulerAngles.y, mUpAnim.transform.rotation.eulerAngles.z+gradi/mFrames);
				mUpAnim.transform.rotation = rotation;
				break;

			case 6:
				rotation.eulerAngles = new Vector3 (mDownAnim.transform.rotation.eulerAngles.x, mDownAnim.transform.rotation.eulerAngles.y, mDownAnim.transform.rotation.eulerAngles.z+gradi/mFrames);
				mDownAnim.transform.rotation = rotation;
				break;
			}

			mSteps -= 1;
				

			if (mSteps == 0) {
				mFrontAnim.SetActive (false);
				mBackAnim.SetActive (false);
				mLeftAnim.SetActive (false);
				mRightAnim.SetActive (false);
				mUpAnim.SetActive (false);
				mDownAnim.SetActive (false);

				mStatoCubo.AccendiTuttiCubetti ();

				switch(mDaRoutare){
				case 1:
					rotation.eulerAngles = new Vector3 (mFrontAnim.transform.rotation.eulerAngles.x, mFrontAnim.transform.rotation.eulerAngles.y, mFrontAnim.transform.rotation.eulerAngles.z-gradi);
					mFrontAnim.transform.rotation = rotation;
					break;

				case 2:
					rotation.eulerAngles = new Vector3 (mBackAnim.transform.rotation.eulerAngles.x, mBackAnim.transform.rotation.eulerAngles.y, mBackAnim.transform.rotation.eulerAngles.z-gradi);
					mBackAnim.transform.rotation = rotation;
					break;

				case 3:
					rotation.eulerAngles = new Vector3 (mLeftAnim.transform.rotation.eulerAngles.x, mLeftAnim.transform.rotation.eulerAngles.y, mLeftAnim.transform.rotation.eulerAngles.z-gradi);
					mLeftAnim.transform.rotation = rotation;
					break;

				case 4:
					rotation.eulerAngles = new Vector3 (mRightAnim.transform.rotation.eulerAngles.x, mRightAnim.transform.rotation.eulerAngles.y, mRightAnim.transform.rotation.eulerAngles.z-gradi);
					mRightAnim.transform.rotation = rotation;
					break;

				case 5:
					rotation.eulerAngles = new Vector3 (mUpAnim.transform.rotation.eulerAngles.x, mUpAnim.transform.rotation.eulerAngles.y, mUpAnim.transform.rotation.eulerAngles.z-gradi);
					mUpAnim.transform.rotation = rotation;
					break;

				case 6:
					rotation.eulerAngles = new Vector3 (mDownAnim.transform.rotation.eulerAngles.x, mDownAnim.transform.rotation.eulerAngles.y, mDownAnim.transform.rotation.eulerAngles.z-gradi);
					mDownAnim.transform.rotation = rotation;
					break;
				}

				if (mContinua) {
					mIndex++;
					if (mIndex == mNumMosse) {
						mContinua = false;
						if (mStoMescolando) {
							mStoMescolando = false;
						}
						mFrames = 15;
					}
					else {
						switch (mMosse[mIndex]) {
						case 1:
							mStatoCubo.FrontOrario ();
							break;
						case 2:
							mStatoCubo.FrontAntioriario ();
							break;
						case 3:
							mStatoCubo.BackOrario ();
							break;
						case 4:
							mStatoCubo.BackAntioriario ();
							break;
						case 5:
							mStatoCubo.LeftOrario ();
							break;
						case 6:
							mStatoCubo.LeftAntioriario ();
							break;
						case 7:
							mStatoCubo.RightOrario ();
							break;
						case 8:
							mStatoCubo.RightAntioriario ();
							break;
						case 9:
							mStatoCubo.UpOrario ();
							break;
						case 10:
							mStatoCubo.UpAntioriario ();
							break;
						case 11:
							mStatoCubo.DownOrario ();
							break;
						case 12:
							mStatoCubo.DownAntioriario ();
							break;
						}
						mSuonoRotazione.enabled = false;
						mSuonoRotazione.enabled = true;
					}
				}
			}
				
		}
	}

	public void Front(Color c1, Color c2, Color c3, Color c4, Color c5, Color c6, Color c7, Color c8, Color c9, Color c10, Color c11, Color c12, Color c13, Color c14, Color c15, Color c16, Color c17, Color c18, Color c19, Color c20, bool orario){
		mSteps = mFrames;
		mFrontAnim.SetActive (true);

		VertFrontLeftUpFrontAnim.GetComponent<Renderer>().material.color = c1;
		VertFrontRightUpFrontAnim.GetComponent<Renderer>().material.color = c2;
		VertFrontLeftDownFrontAnim.GetComponent<Renderer>().material.color = c3;
		VertFrontRightDownFrontAnim.GetComponent<Renderer>().material.color = c4;
		VertLeftRightUpFrontAnim.GetComponent<Renderer>().material.color = c5;
		VertLeftRightDownFrontAnim.GetComponent<Renderer>().material.color = c6;
		VertRightLeftUpFrontAnim.GetComponent<Renderer>().material.color = c7;
		VertRightLeftDownFrontAnim.GetComponent<Renderer>().material.color = c8;
		VertUpLeftDownFrontAnim.GetComponent<Renderer>().material.color = c9;
		VertUpRightDownFrontAnim.GetComponent<Renderer>().material.color = c10;
		VertDownLeftUpFrontAnim.GetComponent<Renderer>().material.color = c11;
		VertDownRightUpFrontAnim.GetComponent<Renderer>().material.color = c12;
		SpigFrontUpFrontAnim.GetComponent<Renderer>().material.color = c13;
		SpigFrontDownFrontAnim.GetComponent<Renderer>().material.color = c14;
		SpigFrontLeftFrontAnim.GetComponent<Renderer>().material.color = c15;
		SpigFrontRightFrontAnim.GetComponent<Renderer>().material.color = c16;
		SpigLeftRightFrontAnim.GetComponent<Renderer>().material.color = c17;
		SpigRightLeftFrontAnim.GetComponent<Renderer>().material.color = c18;
		SpigUpDownFrontAnim.GetComponent<Renderer>().material.color = c19;
		SpigDownUpFrontAnim.GetComponent<Renderer>().material.color = c20;

		mOrario = orario;

		mDaRoutare = 1;
	}

	public void Back(Color c1,Color c2,Color c3,Color c4,Color c5,Color c6,Color c7,Color c8,Color c9,Color c10,Color c11,Color c12,Color c13,Color c14,Color c15,Color c16,Color c17,Color c18,Color c19,Color c20,bool orario){
		mSteps = mFrames;
		mBackAnim.SetActive(true);

		VertFrontLeftUpBackAnim.GetComponent<Renderer>().material.color = c1;
		VertFrontRightUpBackAnim.GetComponent<Renderer>().material.color = c2;
		VertFrontLeftDownBackAnim.GetComponent<Renderer>().material.color = c3;
		VertFrontRightDownBackAnim.GetComponent<Renderer>().material.color = c4;
		VertLeftRightUpBackAnim.GetComponent<Renderer>().material.color = c5;
		VertLeftRightDownBackAnim.GetComponent<Renderer>().material.color = c6;
		VertRightLeftUpBackAnim.GetComponent<Renderer>().material.color = c7;
		VertRightLeftDownBackAnim.GetComponent<Renderer>().material.color = c8;
		VertUpLeftDownBackAnim.GetComponent<Renderer>().material.color = c9;
		VertUpRightDownBackAnim.GetComponent<Renderer>().material.color = c10;
		VertDownLeftUpBackAnim.GetComponent<Renderer>().material.color = c11;
		VertDownRightUpBackAnim.GetComponent<Renderer>().material.color = c12;
		SpigFrontUpBackAnim.GetComponent<Renderer>().material.color = c13;
		SpigFrontDownBackAnim.GetComponent<Renderer>().material.color = c14;
		SpigFrontLeftBackAnim.GetComponent<Renderer>().material.color = c15;
		SpigFrontRightBackAnim.GetComponent<Renderer>().material.color = c16;
		SpigLeftRightBackAnim.GetComponent<Renderer>().material.color = c17;
		SpigRightLeftBackAnim.GetComponent<Renderer>().material.color = c18;
		SpigUpDownBackAnim.GetComponent<Renderer>().material.color = c19;
		SpigDownUpBackAnim.GetComponent<Renderer>().material.color = c20;

		mOrario = orario;

		mDaRoutare = 2;
	}

	public void Left(Color c1,Color c2,Color c3,Color c4,Color c5,Color c6,Color c7,Color c8,Color c9,Color c10,Color c11,Color c12,Color c13,Color c14,Color c15,Color c16,Color c17,Color c18,Color c19,Color c20,bool orario){
		mSteps = mFrames;
		mLeftAnim.SetActive (true);

		VertFrontLeftUpLeftAnim.GetComponent<Renderer>().material.color = c1;
		VertFrontRightUpLeftAnim.GetComponent<Renderer>().material.color = c2;
		VertFrontLeftDownLeftAnim.GetComponent<Renderer>().material.color = c3;
		VertFrontRightDownLeftAnim.GetComponent<Renderer>().material.color = c4;
		VertLeftRightUpLeftAnim.GetComponent<Renderer>().material.color = c5;
		VertLeftRightDownLeftAnim.GetComponent<Renderer>().material.color = c6;
		VertRightLeftUpLeftAnim.GetComponent<Renderer>().material.color = c7;
		VertRightLeftDownLeftAnim.GetComponent<Renderer>().material.color = c8;
		VertUpLeftDownLeftAnim.GetComponent<Renderer>().material.color = c9;
		VertUpRightDownLeftAnim.GetComponent<Renderer>().material.color = c10;
		VertDownLeftUpLeftAnim.GetComponent<Renderer>().material.color = c11;
		VertDownRightUpLeftAnim.GetComponent<Renderer>().material.color = c12;
		SpigFrontUpLeftAnim.GetComponent<Renderer>().material.color = c13;
		SpigFrontDownLeftAnim.GetComponent<Renderer>().material.color = c14;
		SpigFrontLeftLeftAnim.GetComponent<Renderer>().material.color = c15;
		SpigFrontRightLeftAnim.GetComponent<Renderer>().material.color = c16;
		SpigLeftRightLeftAnim.GetComponent<Renderer>().material.color = c17;
		SpigRightLeftLeftAnim.GetComponent<Renderer>().material.color = c18;
		SpigUpDownLeftAnim.GetComponent<Renderer>().material.color = c19;
		SpigDownUpLeftAnim.GetComponent<Renderer>().material.color = c20;

		mOrario = orario;

		mDaRoutare = 3;
	}

	public void Right(Color c1,Color c2,Color c3,Color c4,Color c5,Color c6,Color c7,Color c8,Color c9,Color c10,Color c11,Color c12,Color c13,Color c14,Color c15,Color c16,Color c17,Color c18,Color c19,Color c20,bool orario){
		mSteps = mFrames;
		mRightAnim.SetActive (true);

		VertFrontLeftUpRightAnim.GetComponent<Renderer>().material.color = c1;
		VertFrontRightUpRightAnim.GetComponent<Renderer>().material.color = c2;
		VertFrontLeftDownRightAnim.GetComponent<Renderer>().material.color = c3;
		VertFrontRightDownRightAnim.GetComponent<Renderer>().material.color = c4;
		VertLeftRightUpRightAnim.GetComponent<Renderer>().material.color = c5;
		VertLeftRightDownRightAnim.GetComponent<Renderer>().material.color = c6;
		VertRightLeftUpRightAnim.GetComponent<Renderer>().material.color = c7;
		VertRightLeftDownRightAnim.GetComponent<Renderer>().material.color = c8;
		VertUpLeftDownRightAnim.GetComponent<Renderer>().material.color = c9;
		VertUpRightDownRightAnim.GetComponent<Renderer>().material.color = c10;
		VertDownLeftUpRightAnim.GetComponent<Renderer>().material.color = c11;
		VertDownRightUpRightAnim.GetComponent<Renderer>().material.color = c12;
		SpigFrontUpRightAnim.GetComponent<Renderer>().material.color = c13;
		SpigFrontDownRightAnim.GetComponent<Renderer>().material.color = c14;
		SpigFrontLeftRightAnim.GetComponent<Renderer>().material.color = c15;
		SpigFrontRightRightAnim.GetComponent<Renderer>().material.color = c16;
		SpigLeftRightRightAnim.GetComponent<Renderer>().material.color = c17;
		SpigRightLeftRightAnim.GetComponent<Renderer>().material.color = c18;
		SpigUpDownRightAnim.GetComponent<Renderer>().material.color = c19;
		SpigDownUpRightAnim.GetComponent<Renderer>().material.color = c20;

		mOrario = orario;

		mDaRoutare = 4;
	}

	public void Up(Color c1,Color c2,Color c3,Color c4,Color c5,Color c6,Color c7,Color c8,Color c9,Color c10,Color c11,Color c12,Color c13,Color c14,Color c15,Color c16,Color c17,Color c18,Color c19,Color c20,bool orario){
		mSteps = mFrames;
		mUpAnim.SetActive (true);

		VertFrontLeftUpUpAnim.GetComponent<Renderer>().material.color = c1;
		VertFrontRightUpUpAnim.GetComponent<Renderer>().material.color = c2;
		VertFrontLeftDownUpAnim.GetComponent<Renderer>().material.color = c3;
		VertFrontRightDownUpAnim.GetComponent<Renderer>().material.color = c4;
		VertLeftRightUpUpAnim.GetComponent<Renderer>().material.color = c5;
		VertLeftRightDownUpAnim.GetComponent<Renderer>().material.color = c6;
		VertRightLeftUpUpAnim.GetComponent<Renderer>().material.color = c7;
		VertRightLeftDownUpAnim.GetComponent<Renderer>().material.color = c8;
		VertUpLeftDownUpAnim.GetComponent<Renderer>().material.color = c9;
		VertUpRightDownUpAnim.GetComponent<Renderer>().material.color = c10;
		VertDownLeftUpUpAnim.GetComponent<Renderer>().material.color = c11;
		VertDownRightUpUpAnim.GetComponent<Renderer>().material.color = c12;
		SpigFrontUpUpAnim.GetComponent<Renderer>().material.color = c13;
		SpigFrontDownUpAnim.GetComponent<Renderer>().material.color = c14;
		SpigFrontLeftUpAnim.GetComponent<Renderer>().material.color = c15;
		SpigFrontRightUpAnim.GetComponent<Renderer>().material.color = c16;
		SpigLeftRightUpAnim.GetComponent<Renderer>().material.color = c17;
		SpigRightLeftUpAnim.GetComponent<Renderer>().material.color = c18;
		SpigUpDownUpAnim.GetComponent<Renderer>().material.color = c19;
		SpigDownUpUpAnim.GetComponent<Renderer>().material.color = c20;

		mOrario = orario;

		mDaRoutare = 5;
	}

	public void Down(Color c1,Color c2,Color c3,Color c4,Color c5,Color c6,Color c7,Color c8,Color c9,Color c10,Color c11,Color c12,Color c13,Color c14,Color c15,Color c16,Color c17,Color c18,Color c19,Color c20,bool orario){
		mSteps = mFrames;
		mDownAnim.SetActive (true);

		VertFrontLeftUpDownAnim.GetComponent<Renderer>().material.color = c1;
		VertFrontRightUpDownAnim.GetComponent<Renderer>().material.color = c2;
		VertFrontLeftDownDownAnim.GetComponent<Renderer>().material.color = c3;
		VertFrontRightDownDownAnim.GetComponent<Renderer>().material.color = c4;
		VertLeftRightUpDownAnim.GetComponent<Renderer>().material.color = c5;
		VertLeftRightDownDownAnim.GetComponent<Renderer>().material.color = c6;
		VertRightLeftUpDownAnim.GetComponent<Renderer>().material.color = c7;
		VertRightLeftDownDownAnim.GetComponent<Renderer>().material.color = c8;
		VertUpLeftDownDownAnim.GetComponent<Renderer>().material.color = c9;
		VertUpRightDownDownAnim.GetComponent<Renderer>().material.color = c10;
		VertDownLeftUpDownAnim.GetComponent<Renderer>().material.color = c11;
		VertDownRightUpDownAnim.GetComponent<Renderer>().material.color = c12;
		SpigFrontUpDownAnim.GetComponent<Renderer>().material.color = c13;
		SpigFrontDownDownAnim.GetComponent<Renderer>().material.color = c14;
		SpigFrontLeftDownAnim.GetComponent<Renderer>().material.color = c15;
		SpigFrontRightDownAnim.GetComponent<Renderer>().material.color = c16;
		SpigLeftRightDownAnim.GetComponent<Renderer>().material.color = c17;
		SpigRightLeftDownAnim.GetComponent<Renderer>().material.color = c18;
		SpigUpDownDownAnim.GetComponent<Renderer>().material.color = c19;
		SpigDownUpDownAnim.GetComponent<Renderer>().material.color = c20;

		mOrario = orario;

		mDaRoutare = 6;
	}

	public bool isFermo(){
		if (mSteps == 0) {
			return !mStoMescolando && !mStoRisolvendo;
		}

		return false;
	}

	public bool isFermoAnimatorePuoAndare(){
		return mSteps == 0 && !mStoMescolando && mStoRisolvendo;
	}

	public void SetFrames(int frames){
		mFrames = frames;
	}

	public void EseguiPiuMosse(int[] mosse, int velocita){
		mMosse = mosse;
		mIndex = 0;
		mNumMosse = mMosse.Length;
		mContinua = true;
		mFrames = velocita;
		switch (mMosse[mIndex]) {
		case 1:
			mStatoCubo.FrontOrario ();
			break;
		case 2:
			mStatoCubo.FrontAntioriario ();
			break;
		case 3:
			mStatoCubo.BackOrario ();
			break;
		case 4:
			mStatoCubo.BackAntioriario ();
			break;
		case 5:
			mStatoCubo.LeftOrario ();
			break;
		case 6:
			mStatoCubo.LeftAntioriario ();
			break;
		case 7:
			mStatoCubo.RightOrario ();
			break;
		case 8:
			mStatoCubo.RightAntioriario ();
			break;
		case 9:
			mStatoCubo.UpOrario ();
			break;
		case 10:
			mStatoCubo.UpAntioriario ();
			break;
		case 11:
			mStatoCubo.DownOrario ();
			break;
		case 12:
			mStatoCubo.DownAntioriario ();
			break;
		}
		mSuonoRotazione.enabled = false;
		mSuonoRotazione.enabled = true;
	}

	public bool StoMescolando(){
		return mStoMescolando;
	}

	public void SetStatoStoMescolando(bool stoMescolando){
		mStoMescolando = stoMescolando;
	}

	public bool StoRisolvendo(){
		return mStoRisolvendo;
	}

	public void SetStatoStoRisolvendo(bool stoRisolvendo){
		mStoRisolvendo = stoRisolvendo;
	}
}
