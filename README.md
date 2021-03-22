# UIMessageSystem
Show a list of messages on UI Canvas from anywhere of your code

## How to use
The system provides a singleton class to show the message. You can simply , add a message anywhere of your code and ask to controller shows all messages stored by the time.

## Create a message using IMessage interface

```C#
IMessage message = new Message( "This is a message" );
```

## Add it to the controller

```C#
MessageController.Instance.AddMessage(message);
```
## Ask controller to show
```C#
MessageController.Instance.ShowMessages();
```

### You can edit the messageView Prefab at Resources/MessagesPrefabs Folder
