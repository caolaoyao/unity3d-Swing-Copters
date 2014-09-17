using UnityEngine;
using System.Collections;

public class BtnManager : MonoBehaviour {
    private int layerInt;
    public GameObject body;
    public GameObject tutorial;
    public GameObject logo;
    public GameObject sky1, sky2;

    PlayerManager playerManager;
    BackGroundScroll backGroundScroll1, backGroundScroll2;
	// Use this for initialization
	void Start () {
        layerInt = LayerMask.NameToLayer("UI");
        playerManager = body.GetComponent<PlayerManager>();
        if (sky1)
        {
            backGroundScroll1 = sky1.GetComponent<BackGroundScroll>();
        }
        if (sky2)
        {
            backGroundScroll2 = sky2.GetComponent<BackGroundScroll>();
        } 
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {

            Vector3 mouseVector3 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit;
            hit = Physics2D.Raycast(Camera.main.transform.position, mouseVector3, 100, 1 << layerInt);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.name);
                switch (hit.collider.name)
                {
                    case "start_btn":
                        Debug.Log("开始游戏");
                        gameObject.SetActive(false);
                        logo.SetActive(false);
                        body.SetActive(true);
                        tutorial.SetActive(true);
                        break;

                    case "tutorial":
                        gameObject.SetActive(false);
                        playerManager.setRunngin();
                        backGroundScroll1.StartScroll();
                        backGroundScroll2.StartScroll();
                        break;
                }                    
            }
        }
	}
}
