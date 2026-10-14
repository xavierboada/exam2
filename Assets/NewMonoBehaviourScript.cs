
using UnityEngine;


public class NewMonoBehaviourScript : MonoBehaviour
{
    private Animator f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        f = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            f.SetTrigger("SadTrigger");
        }

        
        if (Input.GetKeyDown(KeyCode.H))
        {
           f.SetTrigger("HappyTrigger");
        }
    }
}


