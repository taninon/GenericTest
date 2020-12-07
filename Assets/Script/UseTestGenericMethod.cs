using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseTestGenericMethod : MonoBehaviour
{
	private void Start()
	{
		string[] testStringArr = new string[3] { "おはよう", "こんにちわ", "こんばんわ", };

		ReverseLog<string>(testStringArr);

		int[] testIntArr = new int[5] { 2, 4, 6, 8, 10 };

		ReverseLog<int>(testIntArr);
	}

	private void ReverseLog<T>(T[] array)
	{
		for (int i = array.Length - 1; i >= 0; i--)
		{
			Debug.Log(array[i]);
		}
	}
}
