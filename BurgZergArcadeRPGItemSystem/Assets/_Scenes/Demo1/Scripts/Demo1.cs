//connect to database
//spawn item from database

using UnityEngine;
using System.Collections;
using BurgZergArcade.ItemSystem;

[DisallowMultipleComponent]
public class Demo1 : MonoBehaviour {

	public ItemSystemWeaponDatabase database;
	
	private void OnGUI ()
	{
		for(int cnt = 0; cnt < database.Count; cnt++)
		{
			if(GUILayout.Button("Spawn: " + database.Get(cnt).Name))
			{
				Spawn(cnt);
			}
		}
	}
	
	private void Spawn (int index)
	{
		ItemSystemWeapon isw = database.Get(index);
		
		GameObject weapon = Instantiate(isw.Prefab);
		weapon.name = isw.Name;
	}
}
