using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterRecord : IRecordKey, IRecordName
{
	private int _key;
	public int Key => _key;
	private string _name;
	public string Name => _name;

	public MonsterRecord(int key, string name)
	{
		_key = key;
		name = _name;
	}

	public void Shout()
	{
		Debug.Log("Gao!");
	}
}
