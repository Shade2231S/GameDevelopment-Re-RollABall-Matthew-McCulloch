using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Animator Gates = null;
    public bool opentrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (opentrigger) 
            {
                Gates.Play("GateAnim", 0,0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}
