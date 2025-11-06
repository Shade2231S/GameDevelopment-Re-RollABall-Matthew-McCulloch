using Unity.VisualScripting;
using UnityEngine;


public class Camera : MonoBehaviour
{
    [SerializeField] private Camera cam;
    public Transform player;
    private Vector3 offset;
    public float rotation = 85f;


    void Start()
    {

        cam = GetComponent<Camera>();
        offset = transform.position - player.transform.position;
    }


    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.transform.position + offset;
        }
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.RotateAround(player.position, Vector3.up, rotation * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.RotateAround(player.position, Vector3.up, -rotation * Time.deltaTime);
        //}

        
        //transform.LookAt(player);
    }
    void Update()
    {

    }
}