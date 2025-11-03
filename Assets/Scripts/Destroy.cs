using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject winTextObject;
    public GameObject Restart;
    private void OnCollisionEnter(Collision collision)
    {
            player = GameObject.Find("Player");
            PlayerController playerController = player.GetComponent<PlayerController>();
        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(collision.gameObject);
            winTextObject.gameObject.SetActive(true);
            winTextObject.GetComponent<TextMeshProUGUI>().text = "You Went Out Of Bounds !Stop It!";
            Restart.gameObject.SetActive(true);

        }
    }
}
