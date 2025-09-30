using UnityEngine;

public class Trigger3 : MonoBehaviour
{
    public Animator Gates3 = null;
    public bool opentrigger3 = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (opentrigger3)
            {
                Gates3.Play("GateLower", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}
