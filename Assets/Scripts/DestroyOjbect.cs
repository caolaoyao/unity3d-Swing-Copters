using UnityEngine;
using System.Collections;

public class DestroyOjbect : MonoBehaviour {

    void OnBecameInvisible()
    {
        // 销毁当前游戏对象
        Debug.Log(this.gameObject.name);
        Destroy(this.gameObject);
    }
}
