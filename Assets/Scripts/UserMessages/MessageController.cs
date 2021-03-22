using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

/*
    - list of Messages
    - Show msgs in loop
    - Clear all msgs
*/
namespace MessageSystem
{
    public class MessageController : MonoBehaviour
    {
        public static MessageController Instance;


        public GameObject messageBackGround;

        public GameObject messageContainer;

        public GameObject messageView;

        [Header("Variables")]
        public float timeBetwennMessages = 2f;
        public float initialDelay = 1f;
        public float endedDelay = 1f;
        
        
        private bool showingMessages;

        private List<IMessage> messages = new List<IMessage>();



        private void Awake()
        {
            Instance = this;
            messageBackGround?.SetActive(false);
        }

        public void AddMessage(IMessage message)
        {
            messages.Add(message);
        }

        private void ClearAllMessages()
        {
            messages.Clear();
        }

        public void ShowMessages()
        {
            StartCoroutine(IShowMessages());
            
        }

        IEnumerator IShowMessages()
        {
            showingMessages = true;
            messageBackGround.SetActive(true);

            yield return new WaitForSeconds(initialDelay);

            foreach (var item in messages)
            {
                messageContainer.SetActive(true);

                GameObject msg = Instantiate(messageView, messageContainer.transform);
                msg.GetComponent<IMessageView>().SetData(item);

                yield return new WaitForSeconds(timeBetwennMessages);
                Destroy(msg);

                yield return new WaitForSeconds(endedDelay);
                messageContainer.SetActive(false);
            }

            Debug.Log("End of messages");

            showingMessages = false;
            ClearAllMessages();
            messageBackGround.SetActive(false);

        }

        public bool isShowingMessages => showingMessages;


        public bool HasMessages()
        {
            return messages.Count > 0 ? true : false;
        }

    }    
}
