using Unity.VisualScripting;
using UnityEngine;


public class Camera : MonoBehaviour
{
    [SerializeField] private Camera cam;
    public GameObject player;
    private Vector3 offset;
    public int movement;

    
    void Start()
    {

        cam = GetComponent<Camera>();
        offset = transform.position - player.transform.position;
    }
    void movementinput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            offset += (transform.forward * movement);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            offset += (transform.forward * -movement);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            offset += (transform.right * -movement);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            offset += (transform.right * movement);
        }
        transform.position = Vector3.Lerp(transform.position, offset, Time.deltaTime * movement);
    }

    void LateUpdate()
    {
        if(player != null)
        {
           transform.position = player.transform.position + offset;
        }
    }
    void Update()
    {
        movementinput();

    }
    
}
