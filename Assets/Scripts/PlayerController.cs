using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.VisualScripting;
public class PlayerController : MonoBehaviour
{
    public GameObject winTextObject;
    public float speed = 0;
    public TextMeshProUGUI countText;
    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;
    public GameObject Restart;
    
    void Start()
    {
        count = 0;
        rb = GetComponent<Rigidbody>();
        SetCountText();
        winTextObject.SetActive(false);
        Restart.SetActive(false);
    }
    public void RestartFunction()
    {   
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }  
    void OnMove(InputValue MovementValue)
    {
        Vector2 movementVector = MovementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    public void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 26)
        {
            winTextObject.SetActive(true);         
            Destroy(GameObject.FindGameObjectWithTag("Attacker"));

            Restart.gameObject.SetActive(true);   
        }

    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
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
            Restart.gameObject.SetActive(true);
            
        }            
    }
    void Update()
    {
        
    }


}
