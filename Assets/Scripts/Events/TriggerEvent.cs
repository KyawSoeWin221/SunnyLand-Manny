using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;


public class TriggerEvent : MonoBehaviour
{
    public UnityEvent onEnter , onStay, onExit;
    public string hitTag = "Player";
    public UnityEvent onInteract;

    public void Interact()
    {
        onInteract.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(hitTag))
        {
            //Invoke Enter Event!
            onEnter.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(hitTag))
        {



            //Invoke Exit Event!
            onExit.Invoke();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag(hitTag))
        {

            //Invoke Stay Event!
            onStay.Invoke();


        }

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
