using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Security.Cryptography;

public class FileManager : MonoBehaviour {

	private static string FOLDER = Application.persistentDataPath + "/RubikWaveSaves/";
	private static string m_GiocoFilename = "saveFile";
	private static string m_OpzioniFileName = "options";

	private static GameObject m_GameManagerObject;
	private static GameManager m_GameManagerComponent;
	private static StatoCubo m_StatoCubo;

	private static bool m_Saving = false;

	private static void inizializza(){

		if (!Directory.Exists(FOLDER))
		{
			Directory.CreateDirectory(FOLDER);
		}

		m_GameManagerObject = GameObject.Find ("GameManager");
		m_GameManagerComponent = m_GameManagerObject.GetComponent<GameManager> ();
		m_StatoCubo = m_GameManagerObject.GetComponent<StatoCubo> ();
	}

	public static void salvaSuFile(){
		inizializza ();

		//PREPARO COLORI
		string stato = "";

		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getCentFrontColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getCentBackColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getCentRightColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getCentLeftColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getCentUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getCentDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigFrontUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigFrontLeftColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigFrontRightColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigFrontDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigBackUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigBackLeftColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigBackRightColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigBackDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigRightUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigRightLeftColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigRightRightColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigRightDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigLeftUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigLeftLeftColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigLeftRightColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigLeftDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigUpUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigUpLeftColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigUpRightColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigUpDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigDownUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigDownLeftColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigDownRightColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getSpigDownDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertFrontRightUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertFrontRightDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertFrontLeftUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertFrontLeftDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertBackRightUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertBackRightDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertBackLeftUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertBackLeftDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertLeftRightUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertLeftRightDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertLeftLeftUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertLeftLeftDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertRightRightUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertRightRightDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertRightLeftUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertRightLeftDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertUpRightUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertUpRightDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertUpLeftUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertUpLeftDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertDownRightUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertDownRightDownColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertDownLeftUpColor()) + ",";
		stato += "#" + ColorUtility.ToHtmlStringRGBA(m_StatoCubo.getVertDownLeftDownColor()) + "\n";

		//PREPARO MOSSE
		string mosseEseguite = "" + m_GameManagerComponent.GetNumMosseEseguite() + "\n";

		//PREPARO TEMPO
		string tempo = "";
		tempo += m_GameManagerComponent.GetTimerOre() + ",";
		tempo += m_GameManagerComponent.GetTimerMinuti() + ",";
		tempo += m_GameManagerComponent.GetTimerSecondi();

		StreamWriter writer = null;
		bool saved = false;
		m_Saving = true;
		while (!saved) {
			try {
				writer = new StreamWriter (FOLDER + m_GiocoFilename, false);
				writer.Write (stato);
				writer.Write (mosseEseguite);
				writer.Write (tempo);
				writer.Close ();
				saved = true;
				m_Saving = false;
			} catch (Exception e) {
				if (writer != null) {
					writer.Close ();
				}
			}
		}

		SalvaMD5 (m_GiocoFilename);
		salvaOpzioni ();
	}

	public static bool caricaDaFile() {
		StreamReader reader = null;
		StreamReader readerMD5 = null;

		try {
			if (isGameSavePresent ()) {

				inizializza ();

				//CONTROLLO MD5

				readerMD5 = new StreamReader(FOLDER + m_GiocoFilename + "MD5");
				string MD5Salvato = readerMD5.ReadLine ();
				string MD5Attuale = CalculateMD5 (FOLDER + m_GiocoFilename);
				readerMD5.Close ();

				if (!MD5Attuale.Equals (MD5Salvato)) {
					return false;
				}


				reader = new StreamReader(FOLDER + m_GiocoFilename);

				//LEGGO COLORI

				string stato = reader.ReadLine();
				string[] coloriSplit = stato.Split(',');

				Color coloreLetto;
				int coloreAttuale = 0;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setCentFrontColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setCentBackColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setCentRightColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setCentLeftColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setCentUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setCentDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigFrontUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigFrontLeftColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigFrontRightColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigFrontDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigBackUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigBackLeftColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigBackRightColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigBackDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigRightUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigRightLeftColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigRightRightColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigRightDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigLeftUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigLeftLeftColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigLeftRightColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigLeftDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigUpUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigUpLeftColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigUpRightColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigUpDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigDownUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigDownLeftColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigDownRightColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setSpigDownDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertFrontRightUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertFrontRightDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertFrontLeftUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertFrontLeftDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertBackRightUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertBackRightDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertBackLeftUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertBackLeftDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertLeftRightUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertLeftRightDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertLeftLeftUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertLeftLeftDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertRightRightUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertRightRightDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertRightLeftUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertRightLeftDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertUpRightUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertUpRightDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertUpLeftUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertUpLeftDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertDownRightUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertDownRightDownColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertDownLeftUpColor(coloreLetto);
				coloreAttuale++;

				ColorUtility.TryParseHtmlString(coloriSplit[coloreAttuale], out coloreLetto);
				m_StatoCubo.setVertDownLeftDownColor(coloreLetto);

				//LEGGO MOSSE
				m_GameManagerComponent.SetNumMosseEseguite(int.Parse(reader.ReadLine ()));

				//LEGGO TEMPO
				string tempo = reader.ReadLine ();
				string[] tempoSplit = tempo.Split (',');

				m_GameManagerComponent.SetTimerOre(int.Parse(tempoSplit[0]));
				m_GameManagerComponent.SetTimerMinuti(int.Parse(tempoSplit[1]));
				m_GameManagerComponent.SetTimerSecondi(float.Parse(tempoSplit[2]));

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
				string grafica = "" + m_GameManagerObject.GetComponent<SettingsManager>().GetGrafica() + "\n";

				//PREPARO GRAFICA_VSYNC
				string vsync = "" + m_GameManagerObject.GetComponent<SettingsManager>().GetGraficaVsync() + "\n";

				//PREPARO SUONI
				string suoni = "" + m_GameManagerObject.GetComponent<SettingsManager>().GetSuoni();

				m_Saving = true;
				writer = new StreamWriter (FOLDER + m_OpzioniFileName, false);
				writer.Write (grafica);
				writer.Write (vsync);
				writer.Write (suoni);
				writer.Close ();
				saved = true;
				m_Saving = false;
			} catch (Exception e) {
				if (writer != null) {
					writer.Close ();
				}
			}
		}

		SalvaMD5 (m_OpzioniFileName);
	}

	public static bool caricaOpzioni() {
		StreamReader reader = null;
		StreamReader readerMD5 = null;

		try {
			if (isOptionSavePresent ()) {

				inizializza ();

				//CONTROLLO MD5

				readerMD5 = new StreamReader(FOLDER + m_OpzioniFileName + "MD5");
				string MD5Salvato = readerMD5.ReadLine ();
				string MD5Attuale = CalculateMD5 (FOLDER + m_OpzioniFileName);
				readerMD5.Close ();

				if (!MD5Attuale.Equals (MD5Salvato)) {
					return false;
				}


				reader = new StreamReader(FOLDER + m_OpzioniFileName);

				//LEGGO GRAFICA
				m_GameManagerObject.GetComponent<SettingsManager>().SetGrafica(int.Parse(reader.ReadLine ()));

				//LEGGO GRAFICA_VSYNC
				m_GameManagerObject.GetComponent<SettingsManager>().SetGraficaVsync(int.Parse(reader.ReadLine ()));

				//LEGGO SUONI
				m_GameManagerObject.GetComponent<SettingsManager>().SetSuoni(int.Parse(reader.ReadLine ()));

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
		return File.Exists (FOLDER + m_GiocoFilename);
	}

	public static bool isOptionSavePresent() {
		return File.Exists (FOLDER + m_OpzioniFileName);
	}

	public static bool isSaving(){
		return m_Saving;
	}

	public static void setFilename(string filename) {
		m_GiocoFilename = filename;
	}

	private static void SalvaMD5 (string filename){
		StreamWriter writer = null;
		bool saved = false;
		m_Saving = true;
		while (!saved) {
			try {
				writer = new StreamWriter (FOLDER + filename + "MD5", false);
				writer.Write (CalculateMD5 (FOLDER + filename));
				writer.Close ();
				saved = true;
				m_Saving = false;
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
