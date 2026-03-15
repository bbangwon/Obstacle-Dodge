using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private async void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            await Task.Yield();
            GetComponent<MeshRenderer>().material.color = Color.black;
            gameObject.tag = "Hit";
        }
    }
}
