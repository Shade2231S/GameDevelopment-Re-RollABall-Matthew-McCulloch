using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    public Animator Gates2 = null;
    public bool opentrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (opentrigger)
            {
                Gates2.Play("GateMove", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}
