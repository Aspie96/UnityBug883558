Hi everybody.

A while ago, I found out Unity has this bug:
https://fogbugz.unity3d.com/default.asp?883558_o8n9c8l8evpfeln7

# Unity version
I found this bug in unity version 5.5.1f1, but it is still there in 5.5.2f1.

# The bug
According to the documentation, in the [`OnControllerColliderHit`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnControllerColliderHit.html) method, in the [`ControllerColliderHit`](https://docs.unity3d.com/ScriptReference/ControllerColliderHit.html) object passed as a parameter, the value of [`moveLength`](https://docs.unity3d.com/ScriptReference/ControllerColliderHit-moveLength.html) should be the distance travelled by the object before the collision.

But that is simply not what happens.

Instead, I get the exact value I passed as a parameter to the [`Move`](https://docs.unity3d.com/ScriptReference/CharacterController.Move.html) function, or the value passed to [`SimpleMove`](https://docs.unity3d.com/ScriptReference/CharacterController.SimpleMove.html) divided by [`Time.deltaTime`](https://docs.unity3d.com/ScriptReference/Time-deltaTime.html).
