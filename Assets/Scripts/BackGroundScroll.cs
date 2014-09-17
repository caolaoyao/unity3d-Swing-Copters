using UnityEngine;
using System.Collections;

public class BackGroundScroll : MonoBehaviour {
    float speed = 0.8f;
    public bool startScroll = false;
	// Update is called once per frame
	void Update () {
        if (startScroll)
        {
            transform.position -= Vector3.up * speed * Time.deltaTime;
        }

        if (transform.position.y < -10)
        {
            transform.position = new Vector3(0, 10, 2);
            if (transform.FindChild("tree"))
            {
                transform.FindChild("tree").transform.gameObject.SetActive(false);
            }
            if (transform.FindChild("land"))
            {
                transform.FindChild("land").transform.gameObject.SetActive(false);
            }
        }
	}

    public void StartScroll()
    {
        startScroll = true;
    }
}
