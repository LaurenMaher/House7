using UnityEngine;

public class BackDoor : MonoBehaviour
{

    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("SlidingDoor", true);

    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("SlidingDoor", false);

    }
}
