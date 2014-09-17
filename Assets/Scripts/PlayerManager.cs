using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
    public GameObject player;

    float speedUp = 0.02f;
    float speedLR = 0.02f;
    bool lookAtRight = true;
    public int score = 0;
    public GameObject sky;
    public GameObject bg;
    public int num = 1;
    public GameObject crane_ground;

    public enum GAME_STATUE
    {
        START,
        READY,
        RUNNING,
        END
    };

    public GAME_STATUE gameStatus;

    void Start()
    {
        gameStatus = GAME_STATUE.START;
    }
	
	// Update is called once per frame
	void Update () {
        if (gameStatus == GAME_STATUE.RUNNING)
        {
            if (lookAtRight)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x + speedLR, gameObject.transform.position.y, gameObject.transform.position.z);
            }
            else
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x - speedLR, gameObject.transform.position.y, gameObject.transform.position.z);
            }

            if (Input.GetMouseButtonDown(0))
            {
                if (lookAtRight)
                {
                    player.transform.Rotate(0, 180, 0);
                }
                else
                {
                    player.transform.Rotate(0, 0, 0);
                }

                lookAtRight = !lookAtRight;
            }
        }

        if (gameObject.transform.position.x > 3.5 || gameObject.transform.position.x < -3.5)
        {
            gameStatus = GAME_STATUE.END;
        }

        if (gameStatus == GAME_STATUE.END)
        {

        }
        
	}

    public void setRunngin()
    {
        gameStatus = GAME_STATUE.RUNNING;
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        Debug.Log("碰撞到的物体的名字是：" + otherCollider.gameObject.name);

        if (otherCollider.gameObject.name == "pass_point")
        {
            score += 1;
            Debug.Log("分数"+score);
        }

        else
        {
            gameStatus = GAME_STATUE.END;
        }     
    }
}
