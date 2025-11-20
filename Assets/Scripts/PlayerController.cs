using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public GameObject winTextObject;
    public float speed = 0;
    public TextMeshProUGUI countText;
    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;
    public GameObject restart;
    public Transform cameraTransform;
    void Start()
    {
        count = 0;
        rb = GetComponent<Rigidbody>();
        SetCountText();
        winTextObject.SetActive(false);
        restart.SetActive(false);
    }
    public void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 26)
        {
            winTextObject.SetActive(true);         
            Destroy(GameObject.FindGameObjectWithTag("Attacker"));
            restart.gameObject.SetActive(true);   
        }

    }
    void FixedUpdate()
    {
        if (!Restart.isPaused)
        {
            float horizontal = 0f;
            float vertical = 0f;
            if (Input.GetKey(KeyCode.W)) vertical = 1f;
            if (Input.GetKey(KeyCode.S)) vertical = -1f;
            if (Input.GetKey(KeyCode.A)) horizontal = -1f;
            if (Input.GetKey(KeyCode.D)) horizontal = 1f;
            Vector3 camForward = cameraTransform.forward;
            Vector3 camRight = cameraTransform.right;          
            camForward.y = 0f;
            camForward.Normalize();
            camRight.y = 0f;
            camRight.Normalize();                       
            Vector3 moveDirection = (camForward * vertical + camRight * horizontal).normalized;
            rb.AddForce(moveDirection * speed);
        }
    }
    void OnTriggerEnter(Collider other)
    {     
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Attacker"))
        {
            Destroy(gameObject);
            winTextObject.gameObject.SetActive(true);
            winTextObject.GetComponent<TextMeshProUGUI>().text = "You Lost!";
            restart.gameObject.SetActive(true);          
        }            
    }
    void Update()
    {

    }


}
