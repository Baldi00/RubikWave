using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Security.Cryptography;

public class FileManager : MonoBehaviour {

	private static string FOLDER = Application.persistentDataPath + "/RubikWaveSaves/";
	private static string mGiocoFilename = "saveFile";
	private static string mOpzioniFileName = "options";

	private static GameObject mGameManagerObject;
	private static GameManager mGameManagerComponent;
	private static StatoCubo mStatoCubo;

	private static bool mSaving = false;

	private static void inizializza(){

		if (!Directory.Exists(FOLDER))
		{
			Directory.CreateDirectory(FOLDER);
		}

		mGameManagerObject = GameObject.Find ("GameManager");
		mGameManagerComponent = mGameManagerObject.GetComponent<GameManager> ();
		mStatoCubo = mGameManagerObject.GetComponent<StatoCubo> ();
	}

	public static void salvaSuFile(){
		inizializza ();

		//PREPARO COLORI
		string stato = "";

		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getCentFrontColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getCentBackColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getCentRightColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getCentLeftColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getCentUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getCentDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigFrontUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigFrontLeftColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigFrontRightColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigFrontDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigBackUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigBackLeftColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigBackRightColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigBackDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigRightUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigRightLeftColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigRightRightColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigRightDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigLeftUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigLeftLeftColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigLeftRightColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigLeftDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigUpUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigUpLeftColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigUpRightColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigUpDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigDownUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigDownLeftColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigDownRightColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getSpigDownDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertFrontRightUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertFrontRightDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertFrontLeftUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertFrontLeftDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertBackRightUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertBackRightDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertBackLeftUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertBackLeftDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertLeftRightUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertLeftRightDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertLeftLeftUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertLeftLeftDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertRightRightUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertRightRightDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertRightLeftUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertRightLeftDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertUpRightUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertUpRightDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertUpLeftUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertUpLeftDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertDownRightUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertDownRightDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertDownLeftUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(mStatoCubo.getVertDownLeftDownColor()) + "\n";

		//PREPARO MOSSE
		string mosseEseguite = "" + mGameManagerComponent.GetNumMosseEseguite() + "\n";

		//PREPARO TEMPO
		string tempo = "";
		tempo += mGameManagerComponent.GetTimerOre() + ",";
		tempo += mGameManagerComponent.GetTimerMinuti() + ",";
		tempo += mGameManagerComponent.GetTimerSecondi();

		StreamWriter writer = null;
		bool saved = false;
		mSaving = true;
		while (!saved) {
			try {
				writer = new StreamWriter (FOLDER + mGiocoFilename, false);
				writer.Write (stato);
				writer.Write (mosseEseguite);
				writer.Write (tempo);
				writer.Close ();
				saved = true;
				mSaving = false;
			} catch (Exception e) {
				if (writer != null) {
					writer.Close ();
				}
			}
		}

		SalvaMD5 (mGiocoFilename);
		salvaOpzioni ();
	}

	public static bool caricaDaFile() {
		StreamReader reader = null;
		StreamReader readerMD5 = null;

		try {
			if (isGameSavePresent ()) {

				inizializza ();

				//CONTROLLO MD5

				readerMD5 = new StreamReader(FOLDER + mGiocoFilename + "MD5");
				string MD5Salvato = readerMD5.ReadLine ();
				string MD5Attuale = CalculateMD5 (FOLDER + mGiocoFilename);
				readerMD5.Close ();

				if (!MD5Attuale.Equals (MD5Salvato)) {
					return false;
				}


				reader = new StreamReader(FOLDER + mGiocoFilename);

				//LEGGO COLORI

				string stato = reader.ReadLine();
				string[] coloriSplit = stato.Split(',');

				Color coloreLetto;
				int coloreAttuale = 0;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setCentFrontColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setCentBackColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setCentRightColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setCentLeftColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setCentUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setCentDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigFrontUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigFrontLeftColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigFrontRightColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigFrontDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigBackUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigBackLeftColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigBackRightColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigBackDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigRightUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigRightLeftColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigRightRightColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigRightDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigLeftUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigLeftLeftColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigLeftRightColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigLeftDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigUpUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigUpLeftColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigUpRightColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigUpDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigDownUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigDownLeftColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigDownRightColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setSpigDownDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertFrontRightUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertFrontRightDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertFrontLeftUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertFrontLeftDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertBackRightUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertBackRightDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertBackLeftUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertBackLeftDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertLeftRightUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertLeftRightDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertLeftLeftUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertLeftLeftDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertRightRightUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertRightRightDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertRightLeftUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertRightLeftDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertUpRightUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertUpRightDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertUpLeftUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertUpLeftDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertDownRightUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertDownRightDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertDownLeftUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				mStatoCubo.setVertDownLeftDownColor(coloreLetto);

				//LEGGO MOSSE
				mGameManagerComponent.SetNumMosseEseguite(int.Parse(reader.ReadLine ()));

				//LEGGO TEMPO
				string tempo = reader.ReadLine ();
				string[] tempoSplit = tempo.Split (',');

				mGameManagerComponent.SetTimerOre(int.Parse(tempoSplit[0]));
				mGameManagerComponent.SetTimerMinuti(int.Parse(tempoSplit[1]));
				mGameManagerComponent.SetTimerSecondi(float.Parse(tempoSplit[2]));

				reader.Close ();

				caricaOpzioni();
			}
		} catch (Exception e) {
			if (reader != null) {
				reader.Close ();
			}

			if (readerMD5 != null) {
				readerMD5.Close ();
			}

			return false;
		}

		return true;
	}

	public static void salvaOpzioni(){

		inizializza ();

		bool saved = false;
		StreamWriter writer = null;


		while (!saved) {
			try {

				//PREPARO GRAFICA
				string grafica = "" + mGameManagerObject.GetComponent<SettingsManager>().GetGrafica() + "\n";

				//PREPARO GRAFICA_VSYNC
				string vsync = "" + mGameManagerObject.GetComponent<SettingsManager>().GetGraficaVsync() + "\n";

				//PREPARO SUONI
				string suoni = "" + mGameManagerObject.GetComponent<SettingsManager>().GetSuoni();

				mSaving = true;
				writer = new StreamWriter (FOLDER + mOpzioniFileName, false);
				writer.Write (grafica);
				writer.Write (vsync);
				writer.Write (suoni);
				writer.Close ();
				saved = true;
				mSaving = false;
			} catch (Exception e) {
				if (writer != null) {
					writer.Close ();
				}
			}
		}

		SalvaMD5 (mOpzioniFileName);
	}

	public static bool caricaOpzioni() {
		StreamReader reader = null;
		StreamReader readerMD5 = null;

		try {
			if (isOptionSavePresent ()) {

				inizializza ();

				//CONTROLLO MD5

				readerMD5 = new StreamReader(FOLDER + mOpzioniFileName + "MD5");
				string MD5Salvato = readerMD5.ReadLine ();
				string MD5Attuale = CalculateMD5 (FOLDER + mOpzioniFileName);
				readerMD5.Close ();

				if (!MD5Attuale.Equals (MD5Salvato)) {
					return false;
				}


				reader = new StreamReader(FOLDER + mOpzioniFileName);

				//LEGGO GRAFICA
				mGameManagerObject.GetComponent<SettingsManager>().SetGrafica(int.Parse(reader.ReadLine ()));

				//LEGGO GRAFICA_VSYNC
				mGameManagerObject.GetComponent<SettingsManager>().SetGraficaVsync(int.Parse(reader.ReadLine ()));

				//LEGGO SUONI
				mGameManagerObject.GetComponent<SettingsManager>().SetSuoni(int.Parse(reader.ReadLine ()));

				reader.Close ();
			}
		} catch (Exception e) {
			if (reader != null) {
				reader.Close ();
			}

			if (readerMD5 != null) {
				readerMD5.Close ();
			}

			return false;
		}

		return true;
	}

	public static bool isGameSavePresent() {
		return File.Exists (FOLDER + mGiocoFilename);
	}

	public static bool isOptionSavePresent() {
		return File.Exists (FOLDER + mOpzioniFileName);
	}

	public static bool isSaving(){
		return mSaving;
	}

	public static void setFilename(string filename) {
		mGiocoFilename = filename;
	}

	private static void SalvaMD5 (string filename){
		StreamWriter writer = null;
		bool saved = false;
		mSaving = true;
		while (!saved) {
			try {
				writer = new StreamWriter (FOLDER + filename + "MD5", false);
				writer.Write (CalculateMD5 (FOLDER + filename));
				writer.Close ();
				saved = true;
				mSaving = false;
			} catch (Exception e) {
				if (writer != null) {
					writer.Close ();
				}
			}
		}
	}

	private static string CalculateMD5(string filename) {
		MD5 md5 = MD5.Create ();
		FileStream stream = File.OpenRead (filename);
		byte[] hash = md5.ComputeHash (stream);
		return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
	}
}
