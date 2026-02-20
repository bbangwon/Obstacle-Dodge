using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]
    float timeToWait = 2f;

    MeshRenderer meshRenderer;
    Rigidbody rigidBody;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigidBody.useGravity = false;
    }

    void Update()
    {
        if(Time.time > timeToWait)
        {
            Debug.Log("아래를 조심하세요!");
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
