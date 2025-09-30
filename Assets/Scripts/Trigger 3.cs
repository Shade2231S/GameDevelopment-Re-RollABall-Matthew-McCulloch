using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Animator Gates3 = null;
    public bool opentrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (opentrigger)
            {
                Gates3.Play("GateLower", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}
