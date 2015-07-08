using UnityEngine;
using System.Collections;
using UnityEditor;

namespace BurgZergArcade.ItemSystem.Editor
{
	public partial class ItemSystemObjectEditor
	{
		private Vector2 _scrollPosition = Vector2.zero;
		private int _listViewWidth = 200;
		private int _listViewButtonWidth = 190;
		private int _listViewButtonHeight = 25;
		
		private int _selectedIndex = -1; //if the selected index is -1, we know the item is a new item that we are adding. 0 or greater is a current item that is being edited.
		
		private void ListView ()
		{
			if(state != DisplayState.NONE) //makes our selection full screen essentially		
			{
				return;
			}
			
			_scrollPosition = GUILayout.BeginScrollView(_scrollPosition, "Box", GUILayout.ExpandHeight(true), GUILayout.Width(_listViewWidth)); //width in pixels
			//GUILayout.Label("List View");
			
			for(int cnt = 0; cnt < database.Count; cnt++)
			{
				if(GUILayout.Button(database.Get(cnt).Name, "box", GUILayout.Width(_listViewButtonWidth), GUILayout.Height(_listViewButtonHeight)))
				{
					//Debug.Log(database.Get(cnt).Name + " : " + cnt);
					_selectedIndex = cnt;
					tempWeapon = new ItemSystemWeapon(database.Get(cnt));
					//tempWeapon = new ItemSystemWeapon(); //these two lines would do essentially the same thing as the one above.
					//tempWeapon.Clone(database.Get(cnt)); //for a more "robust" method, search for deep copy vs shallow copy for c#
					//Debug.Log(tempWeapon.minDamage);
					showNewWeaponDetails = true;
					state = DisplayState.DETAILS;
				}
			}
			
			GUILayout.EndScrollView();
		}
	}
}
