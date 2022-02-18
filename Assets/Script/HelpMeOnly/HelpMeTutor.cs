using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpMeTutor : MonoBehaviour {

	[SerializeField]
	private CalcolaProssimaPrecedenteController mCalProPreController;

	[SerializeField]
	private Animatore mAnimatore;

	[SerializeField]
	private int mVelocitaEsecuzione;

	[SerializeField]
	private GameObject mCalcError;

	[SerializeField]
	private InformazioniInGame mInformazioniInGame;

	private List<int> mMosse;
	private int mIndex = 0;

	void Start() {
		mMosse = new List<int> ();
	}

	public void AggiungiMosse(int[] mosse) {
		for (int i = 0; i < mosse.Length; i++) {
			mMosse.Add (mosse [i]);
		}
	}

	public void FineCalcolo(bool riuscito){
		if (riuscito) {
			OttimizzaMosse ();
			mInformazioniInGame.SetMosseEseguite (mMosse.Count);
			mCalProPreController.CambiaModalita ();
			gameObject.GetComponent<GameManager_HelpMe>().FaseSceltaColoriCompletata ();
			gameObject.GetComponent<GameManager_HelpMe>().ControllaSeHoVinto ();
		} else {
			mMosse.Clear ();
			setCalcErrorVisibility (true);
		}
	}

	public void ProssimaMossa(){
		if (mAnimatore.isFermo() && mIndex < mMosse.Count) {
			mAnimatore.EseguiPiuMosse (new int[]{ (int)mMosse[mIndex] }, mVelocitaEsecuzione);
			mIndex++;
			mInformazioniInGame.AddMossaEseguitaDalGiocatore ();
		}

		if (mIndex == mMosse.Count) {
			gameObject.GetComponent<GameManager_HelpMe>().ControllaSeHoVinto ();
		}
	}

	public void MossaPrecedente(){

		if (mAnimatore.isFermo() && mIndex > 0) {
			mIndex--;
			if (mMosse [mIndex] % 2 == 0) {
				mAnimatore.EseguiPiuMosse (new int[]{ mMosse [mIndex] - 1 }, mVelocitaEsecuzione);
			} else {
				mAnimatore.EseguiPiuMosse (new int[]{ mMosse [mIndex] + 1 }, mVelocitaEsecuzione);
			}
			mInformazioniInGame.SubMossaEseguitaDalGiocatore ();

		}

		if (mIndex == mMosse.Count-1) {
			gameObject.GetComponent<GameManager_HelpMe>().ControllaSeHoVinto ();
		}
	}

	public void setCalcErrorVisibility(bool visibility){
		mCalcError.SetActive (visibility);
	}

	public void OttimizzaMosse(){
		
		for(int j = 0; j < 3; j++){
			
			//Rimuove 4 mosse in una direzione
			for (int i = 0; i < mMosse.Count-3; i++) {
				int mossa = mMosse [i];
				if (mMosse [i] == mMosse [i + 1] && mMosse [i + 1] == mMosse [i + 2] && mMosse [i + 2] == mMosse [i + 3]) {
					mMosse.RemoveRange (i, 4);
				}
			}

			//Rimuove 3 mosse in una direzione, una nella direzione opposta
			for (int i = 0; i < mMosse.Count-2; i++) {
				int mossa = mMosse [i];
				if (mMosse [i] == mMosse [i + 1] && mMosse [i + 1] == mMosse [i + 2]) {
					mMosse.RemoveRange (i, 3);
					if (mossa % 2 == 0) {
						mMosse.Insert (i, mossa - 1);
					} else {
						mMosse.Insert (i, mossa + 1);
					}
				}
			}

			//Rimuove mossa e poi subito la sua opposta
			for (int i = 0; i < mMosse.Count-1; i++) {
				if ((mMosse [i] % 2 == 0 && mMosse [i] == mMosse [i + 1] + 1) || (mMosse [i] % 2 != 0 && mMosse [i] == mMosse [i + 1] - 1)) {
					mMosse.RemoveRange (i, 2);
				}
			}

		}
	}
}