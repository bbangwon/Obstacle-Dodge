using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]
    float timeToWait = 2f;    
    
    void Update()
    {
        if(Time.time > timeToWait)
        {
            Debug.Log("아래를 조심하세요!");
        }
    }
}
