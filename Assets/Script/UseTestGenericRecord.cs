using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseTestGenericRecord : MonoBehaviour
{
	// Start is called before the first frame update
	private void Start()
	{
		var monsterRecords = new TestGenericWhereRecordList<MonsterRecord>();
		monsterRecords.Add(new MonsterRecord(0, "Slime"));
		monsterRecords.Add(new MonsterRecord(1, "Dragon"));
		monsterRecords.Add(new MonsterRecord(2, "skeleton"));

		var monster = monsterRecords.GetRecord(0);

		Debug.Log(monster.Name);
		monster.Shout();

		var characterRecords = new TestGenericWhereRecordList<CharacterRecord>();
		characterRecords.Add(new CharacterRecord(0, "村人", "こんにちは"));
		characterRecords.Add(new CharacterRecord(1, "店の人", "いらっしゃい"));

		var character = characterRecords.GetRecord(1);
		Debug.Log(character.Name);
		character.Talk();
	}

}
