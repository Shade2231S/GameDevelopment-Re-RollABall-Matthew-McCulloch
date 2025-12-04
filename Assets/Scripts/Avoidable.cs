using TMPro;
using UnityEngine;

public class Avoidable : MonoBehaviour
{
    public GameObject player;
    public GameObject winTextObject;
    public GameObject Restart;
    public GameObject quit;
    private void OnCollisionEnter(Collision collision)
    {
        player = GameObject.Find("Player");
        PlayerController playerController = player.GetComponent<PlayerController>();
        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(collision.gameObject);
            winTextObject.gameObject.SetActive(true);
            winTextObject.GetComponent<TextMeshProUGUI>().text = "You Lost!";
            Restart.gameObject.SetActive(true);
            quit.gameObject.SetActive(true);
        }
    }
}
