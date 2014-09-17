using UnityEngine;
using System.Collections;

public class Hammer : MonoBehaviour {
	// Use this for initialization
	void Start () {
        iTween.RotateTo(gameObject, iTween.Hash("z", 30, "time", 1, "loopType", iTween.LoopType.pingPong, "easeType", iTween.EaseType.linear));
	}
}
