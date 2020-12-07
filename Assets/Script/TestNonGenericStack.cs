using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestNonGenericStack
{
	private int stackIndex = 0;
	private int[] stackArray;
	private readonly int maxStack = 10;

	public TestNonGenericStack()
	{
		stackArray = new int[maxStack];
	}

	public void Push(int value)
	{
		if (stackIndex <= maxStack)
		{
			stackArray[stackIndex] = value;
			stackIndex++;
			return;
		}

		Debug.Log("StackMax");
	}

	public int Pop()
	{
		if (stackIndex == 0)
		{
			return stackArray[0];
		}

		stackIndex--;
		return stackArray[stackIndex];
	}
}

