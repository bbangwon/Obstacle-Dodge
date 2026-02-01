using UnityEngine;

public class Dropper : MonoBehaviour
{
    
    void Update()
    {
        var time = Time.time;
        Debug.Log("이 게임이 시작된 후 경과한 시간: " + time);
    }
}
