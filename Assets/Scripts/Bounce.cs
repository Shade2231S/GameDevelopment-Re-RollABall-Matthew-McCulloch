using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float BounceHight = 300f;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Rigidbody Player = other.GetComponent<Rigidbody>();
            if (Player != null)
            {
                Player.linearVelocity = new Vector3(0, BounceHight, 0);
            }
        }
    }
}
