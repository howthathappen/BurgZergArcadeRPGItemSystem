﻿using UnityEngine;
using System.Collections;
using UnityEditor;

namespace BurgZergArcade.ItemSystem.Editor
{
	public partial class ItemSystemObjectEditor
	{
		private enum DisplayState{
			NONE,
			DETAILS
		};
	
		private ItemSystemWeapon tempWeapon = new ItemSystemWeapon();
		private bool showNewWeaponDetails = false;
		
		private DisplayState state = DisplayState.NONE;
		
		private void ItemDetails ()
		{
			GUILayout.BeginVertical("Box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
			GUILayout.BeginVertical(GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
			//GUILayout.Label("Detail View");
			
			EditorGUILayout.LabelField("State: " + state);
			switch(state)
			{
				case DisplayState.DETAILS:
					if(showNewWeaponDetails)
					{
						DisplayNewWeapon();
					}
					break;
				default:
					break;
			}
			
//			if(showNewWeaponDetails)
//			{
//				DisplayNewWeapon();
//			}
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
					state = DisplayState.DETAILS;
				}
			}
			else
			{
				if(GUILayout.Button("Save"))
				{
					if(_selectedIndex == -1)
					{
						database.Add(tempWeapon);
					}
					else
					{
						database.Replace(_selectedIndex, tempWeapon);
					}
					showNewWeaponDetails = false;
					
//					string DATABASE_NAME = @"bzaQualityDatabase.asset";
//					string DATABASE_PATH = @"Database";
//					ItemSystemQualityDatabase qdb;
//					qdb = ItemSystemQualityDatabase.GetDatabase<ItemSystemQualityDatabase>(DATABASE_PATH, DATABASE_NAME);
//					
//					tempWeapon.Quality = qdb.Get(tempWeapon.SelectedQualityID);
					
					//database.Add(tempWeapon);
					tempWeapon = null;
					_selectedIndex = -1;
					state = DisplayState.NONE;
				}
				
				if(GUILayout.Button("Cancel"))
				{
					showNewWeaponDetails = false;
					tempWeapon = null;
					_selectedIndex = -1;
					state = DisplayState.NONE;
				}
			}
		}
	}
}