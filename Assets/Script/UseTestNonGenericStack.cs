using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseTestNonGenericStack : MonoBehaviour
{
	private void Start()
	{
		var stack = new TestNonGenericStack();
		stack.Push(5);
		stack.Push(2);
		stack.Push(3);

		Debug.Log(stack.Pop());
		Debug.Log(stack.Pop());
		Debug.Log(stack.Pop());
	}
}
