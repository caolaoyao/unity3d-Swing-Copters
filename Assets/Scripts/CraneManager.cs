using UnityEngine;
using System.Collections;

public class CraneManager : MonoBehaviour {

    private static float lastX = 0;
    void StartMove()
    {
        iTween.MoveTo(gameObject, iTween.Hash("y", -6.5f, "speed", 1, "easeType", iTween.EaseType.linear, "onComplete", "Setoff"));
    }

    void Setoff()
    {
        gameObject.SetActive(false);
    }

    void SetInit()
    {
        Vector3 tempVector3 = new Vector3();
        do
        {
            tempVector3.x = Random.Range(-.1f, 1.2f);
        } while (Mathf.Abs(lastX - tempVector3.x) < .2f);
        tempVector3.y = 1.6f;
        transform.position = tempVector3;
    }
}
