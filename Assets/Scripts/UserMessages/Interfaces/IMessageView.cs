using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MessageSystem
{   
    public interface IMessageView 
    {
        void SetData( IMessage message );
    }
}
