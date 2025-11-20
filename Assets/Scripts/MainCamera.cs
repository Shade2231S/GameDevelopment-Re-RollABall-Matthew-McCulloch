using Unity.VisualScripting;
using UnityEngine;


public class Camera : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;
    public float rotationspeed = 85f;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    void LateUpdate()
    {
        if (player == null) return;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            offset = Quaternion.AngleAxis(rotationspeed * Time.deltaTime, Vector3.up) * offset;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            offset = Quaternion.AngleAxis(-rotationspeed * Time.deltaTime, Vector3.up) * offset;
        }
        transform.position = player.position + offset;
        transform.LookAt(player);
    }
    void Update()
    {

    }
}