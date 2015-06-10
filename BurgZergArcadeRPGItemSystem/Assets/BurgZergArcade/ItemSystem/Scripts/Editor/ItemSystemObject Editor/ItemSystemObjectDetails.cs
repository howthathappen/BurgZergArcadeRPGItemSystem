using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem.Editor
{
	public partial class ItemSystemObjectEditor
	{
		private ItemSystemWeapon tempWeapon = new ItemSystemWeapon();
		private bool showNewWeaponDetails = false;
		
		private void ItemDetails ()
		{
			GUILayout.BeginVertical("Box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
			GUILayout.BeginVertical(GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
			//GUILayout.Label("Detail View");
			
			if(showNewWeaponDetails)
			{
				DisplayNewWeapon();
			}
//			else
//			{
//				if(GUILayout.Button("Create Weapon"))
//				{
//					//Debug.Log("Create New Weapon");
//					tempWeapon = new ItemSystemWeapon();
//					showNewWeaponDetails = true;
//				}
//			}
			
			GUILayout.EndVertical();
			
			GUILayout.Space(50);
			GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));
			DisplayButtons();
			GUILayout.EndHorizontal();
			GUILayout.EndVertical();
		}
		
		private void DisplayNewWeapon ()
		{
			tempWeapon.OnGUI();
		}
		
		private void DisplayButtons ()
		{
			if(!showNewWeaponDetails)
			{
				if(GUILayout.Button("Create Weapon"))
				{
					//Debug.Log("Create New Weapon");
					tempWeapon = new ItemSystemWeapon();
					showNewWeaponDetails = true;
				}
			}
			else
			{
				if(GUILayout.Button("Save"))
				{
					showNewWeaponDetails = false;
					tempWeapon = null;
				}
				
				if(GUILayout.Button("Cancel"))
				{
					showNewWeaponDetails = false;
					tempWeapon = null;
				}
			}
		}
	}
}