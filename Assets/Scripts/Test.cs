using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
    private Sprite[] numSprites;
    public string name = "PreSprites";

	// Use this for initialization

    void Awake()
    {
        numSprites = Resources.LoadAll<Sprite>(name);
    }

	void Start () {
        transform.GetComponent<SpriteRenderer>().sprite = numSprites[5];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
