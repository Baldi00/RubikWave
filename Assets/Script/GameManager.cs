using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.PostProcessing;

public class GameManager : MonoBehaviour {

	protected CubeManager mStatoCubo;

	protected int mNumMosseMescola = 50;
	protected int mVelocitaMescola = 5;
	protected int mNumMosseEseguite = 0;
	protected AnimationManager mAnimatore;

	protected bool mGameRunning;

	protected MainMenuManager mMainMenuManager;
	protected GameObject mMenuPrincipalePrincipaleContinua;
	protected GameObject mCongratulazioni;

	protected AudioSource mVictoryAudioSource;
	protected bool mhoGiaVintoUnaVolta = false;

	protected StatisticheInGame mStatisticheInGame;

	protected bool mCheckVittoria = false;

	protected Camera mCameraFree;

	protected int mCameraPosition;
	protected bool mCameraRotated;
	protected bool mCameraHasJustRotated;
	protected int mActionPosition;

	protected InputManager mInputManager;
	protected AI mAI;


    private void Awake() {
		GetComponent<SettingsManager>().Initialize();
		mStatoCubo = GetComponent<CubeManager>();
		mStatoCubo.Initialize();
	}

    void Start () {
		mAnimatore = GameObject.Find ("GameManager").GetComponent<AnimationManager>();
		mInputManager = gameObject.GetComponent<InputManager>();
		mAI = GameObject.Find ("AI").GetComponent<AI>();
		mMainMenuManager = gameObject.GetComponent<MainMenuManager>();
		mMenuPrincipalePrincipaleContinua = mMainMenuManager.GetContinua();
		mCongratulazioni = GameObject.Find ("Congratulazioni");
		mCongratulazioni.SetActive (false);
		mStatisticheInGame = GameObject.Find ("CanvasInGameUI").GetComponent<StatisticheInGame>();
		mCameraFree = GameObject.Find ("CameraFree").GetComponent<Camera>();
		mVictoryAudioSource = GetComponent<AudioSource> ();

		mGameRunning = false;
		SetCameraFreeEnabled(false);

		SetCameraPosition (1);
		SetCameraRotation (false);
		SetActionPosition (0);

		if (FileManager.isGameSavePresent () && FileManager.caricaDaFile ()) {
			Color attivato = new Color ();
			ColorUtility.TryParseHtmlString ("#00CAFFFF", out attivato);
			mMenuPrincipalePrincipaleContinua.GetComponent<Text> ().color = attivato;
			mMenuPrincipalePrincipaleContinua.GetComponent<BoxCollider> ().enabled = true;
		} else {
			Color disattivato = new Color ();
			ColorUtility.TryParseHtmlString ("#00CAFF64", out disattivato);
			mMenuPrincipalePrincipaleContinua.GetComponent<Text>().color = disattivato;
			mMenuPrincipalePrincipaleContinua.GetComponent<BoxCollider> ().enabled = false;

			GetComponent<SettingsManager> ().SetAlto ();
			GetComponent<SettingsManager> ().SetVsyncOn ();
			GetComponent<SettingsManager> ().SetSuoniOn ();
		}

		if (ThroughScenesParameters.getSceneToLoad() == 0) {
			Color attivato = new Color ();
			ColorUtility.TryParseHtmlString ("#00CAFFFF", out attivato);
			mMenuPrincipalePrincipaleContinua.GetComponent<Text> ().color = attivato;
			mMenuPrincipalePrincipaleContinua.GetComponent<BoxCollider> ().enabled = true;

			ResetCubo ();
			ResetMosseEseguite ();
			ResetTimer ();

			mMainMenuManager.SetFirtsStart(false);
			mMainMenuManager.SetMainMenuVisibility (false);
			mGameRunning = true;
		}
	}


	void Update () {

		if (mCheckVittoria && mAnimatore.isFermo () && mGameRunning) {
			if (HoVinto ()) {
				if (!mhoGiaVintoUnaVolta) {
					mCongratulazioni.SetActive (true);
					mVictoryAudioSource.enabled = false;
					mVictoryAudioSource.enabled = true;
					mhoGiaVintoUnaVolta = true;
				}
			} else {
				mCongratulazioni.SetActive (false);
				mhoGiaVintoUnaVolta = false;
			}

			mCheckVittoria = false;
		}
	}

	public void ToggleGameRunning(){
		mGameRunning = !mGameRunning;
	}

	public bool IsGameRunning(){
		return mGameRunning;
	}

	public void HoFattoUnaMossa(){
		mNumMosseEseguite++;
	}

	public void HoFattoPiuMosse(int numMosseEseguite){
		mNumMosseEseguite+=numMosseEseguite;
	}

	public int GetNumMosseEseguite(){
		return mNumMosseEseguite;
	}

	public void SetNumMosseEseguite(int newMosseEseguite){
		mNumMosseEseguite = newMosseEseguite;
	}

	public int GetTimerOre(){
		return mStatisticheInGame.GetOre();
	}

	public int GetTimerMinuti(){
		return mStatisticheInGame.GetMinuti();
	}

	public float GetTimerSecondi(){
		return mStatisticheInGame.GetSecondi();
	}

	public void SetTimerOre(int newOre){
		mStatisticheInGame.SetOre(newOre);
	}

	public void SetTimerMinuti(int newMinuti){
		mStatisticheInGame.SetMinuti(newMinuti);
	}

	public void SetTimerSecondi(float newSecondi){
		mStatisticheInGame.SetSecondi(newSecondi);
	}

	public void ResetMosseEseguite(){
		mNumMosseEseguite = 0;
	}

	public void ResetTimer(){
		mStatisticheInGame.TimeReset ();
	}

	public void ResetCubo(){
		mStatoCubo.ResetCubo ();
	}

	public bool HoVinto(){
		if (mNumMosseEseguite <= 0)
			return false;
		return mStatoCubo.IsStatoIniziale();
	}

	public void ControllaSeHoVinto(){
		mCheckVittoria = true;
	}

	public int GetNumMosseMescola(){
		return mNumMosseMescola;
	}

	public int GetVelocitaMescola(){
		return mVelocitaMescola;
	}

	public void SetCameraFreeEnabled(bool enabled){
		mCameraFree.enabled = enabled;
	}

	public bool ColorCompare(Color c1, Color c2){
		bool r = (int)(c1.r * 1000) == (int)(c2.r * 1000);
		bool g = (int)(c1.g * 1000) == (int)(c2.g * 1000);
		bool b = (int)(c1.b * 1000) == (int)(c2.b * 1000);
		bool a = (int)(c1.a * 1000) == (int)(c2.a * 1000);

		return r & b & g & a;
	}

	public void SetCameraPosition(int position){
		mCameraPosition = position;
	}

	public int GetCameraPosition(){
		return mCameraPosition;
	}

	public void SetCameraRotation(bool rotation){
		mCameraRotated = rotation;
	}

	public bool IsCameraRotated(){
		return mCameraRotated;
	}

	public void SetCameraHasJustRotated(bool rotation){
		mCameraHasJustRotated = rotation;
	}

	public bool CameraHasJustRotated(){
		return mCameraHasJustRotated;
	}

	public void SetActionPosition(int position){
		mActionPosition = position;
	}

	public int GetActionPosition(){
		return mActionPosition;
	}

	public GameObject GetCongratulazioni() {
		return mCongratulazioni;
	}

	public void AISolve() {
		mAI.Risolvi ();
	}

	public void AIReset() {
		mAI.Reset ();
	}
}
