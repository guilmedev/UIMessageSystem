using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MessageSystem
{    
    public class Message : MonoBehaviour , IMessage
    {
        public string title;
        
        public Message( string title )
        {
            this.title = title;
        }
    }

}
