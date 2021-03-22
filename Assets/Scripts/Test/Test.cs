using MessageSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    internal void AddMessage(string messageString)
    {
        //Create and Add message
        IMessage message = new Message( messageString );
        MessageController.Instance.AddMessage(message);
    }

    internal void ShowAllMessages()
    {
       MessageController.Instance.ShowMessages();
    }
}
