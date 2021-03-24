# UIMessageSystem
Show a list of messages on UI Canvas from anywhere of your code

[![Video](https://user-images.githubusercontent.com/38132109/112315644-14110500-8c89-11eb-84d6-77035a8e88a3.mp4)](https://user-images.githubusercontent.com/38132109/112315644-14110500-8c89-11eb-84d6-77035a8e88a3.mp4)

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
