using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {

	// Use this for initialization
	void Start () {
        iTween.MoveTo(gameObject, iTween.Hash("y", 1.8f, "time", 1, "loopType", iTween.LoopType.pingPong, "easeType", iTween.EaseType.linear));
	}
}
