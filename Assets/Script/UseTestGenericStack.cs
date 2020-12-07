using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseTestGenericStack : MonoBehaviour
{
	// Start is called before the first frame update
	private void Start()
	{
		var stackFloat = new TestGenericStack<float>();
		stackFloat.Push(4.2f);
		stackFloat.Push(3.5f);
		stackFloat.Push(2.1f);

		Debug.Log(stackFloat.Pop());
		Debug.Log(stackFloat.Pop());
		Debug.Log(stackFloat.Pop());

		var stackString = new TestGenericStack<string>();
		stackString.Push("文字列も");
		stackString.Push("いけるよ！");
		stackString.Push("便利");

		Debug.Log(stackString.Pop());
		Debug.Log(stackString.Pop());
		Debug.Log(stackString.Pop());

	}

}
