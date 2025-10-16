using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;

public class Camera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    public float Distance = 11.0f;
    public float rotationspeed = 10.0f;
    private float currentangle = 0f;
    public bool pressed = false;

    [SerializeField] private Camera cam;
    void Start()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        currentangle += horizontalInput * rotationspeed * Time.deltaTime;
        cam = GetComponent<Camera>();
        offset = transform.position - player.transform.position;
    }


    void LateUpdate()
    {
        
        transform.position = player.transform.position + offset;



    }
    void Update()
    {

        float x = player.transform.position.x + Distance * Mathf.Sin(currentangle * Mathf.Deg2Rad);
        float z = player.transform.position.z + Distance * Mathf.Cos(currentangle * Mathf.Deg2Rad);
        float y = transform.position.y;
        

        transform.position = new Vector3(x, y, z);
        
        if (Input.GetMouseButton(1))
        {
            
            

        }
        if (Input.GetMouseButtonUp(1))
        {
            
        }
    }
}
