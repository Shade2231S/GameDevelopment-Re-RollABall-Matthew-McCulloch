using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Animator Gates1 = null;
    public bool opentrigger1 = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (opentrigger1)
            {
                Gates1.Play("GateAnim", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}
