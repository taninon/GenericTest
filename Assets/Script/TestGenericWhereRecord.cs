using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TestGenericWhereRecordList<T> where T : IRecordKey, IRecordName
{
	private List<T> recordParams;

	public TestGenericWhereRecordList()
	{
		recordParams = new List<T>();
	}

	public void Add(T record)
	{
		recordParams.Add(record);
	}

	public T GetRecord(int key)
	{
		return recordParams.Where(r => r.Key == key).FirstOrDefault();
	}

	public T GetRecord(string name)
	{
		return recordParams.Where(r => r.Name == name).FirstOrDefault();
	}
}
