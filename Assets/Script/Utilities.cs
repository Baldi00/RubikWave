using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilities : MonoBehaviour {
	public static GameObject GetGameObjectChildByName(GameObject obj, string name){
		return obj.transform.Find (name).gameObject;
	}
}
