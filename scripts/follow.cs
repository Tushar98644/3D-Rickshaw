
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform mainpalyer;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position=mainpalyer.position + offset;
    }
}
