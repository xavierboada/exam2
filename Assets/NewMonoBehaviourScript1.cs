using UnityEngine;

public class NewMonoBehaviourScript1 : MonoBehaviour
{

    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetBool("IsSitting", false);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetBool("IsSitting", true);
        }
    }
}
