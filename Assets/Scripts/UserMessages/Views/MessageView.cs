using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MessageSystem
{   
    //Your Prefab
    public class MessageView : MonoBehaviour , IMessageView
    {
        [SerializeField] Text messagValue;
        
        private void SetData ( Message data )
        {
            if(messagValue)
                messagValue.text = data.title;
        }

        public void SetData( IMessage message )
        {
            Message msg = (Message) message;

            SetData( msg );
            
        }
    }
}
