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
		
		private void ListView ()
		{
			_scrollPosition = GUILayout.BeginScrollView(_scrollPosition, "Box", GUILayout.ExpandHeight(true), GUILayout.Width(_listViewWidth)); //width in pixels
			//GUILayout.Label("List View");
			
			for(int cnt = 0; cnt < database.Count; cnt++)
			{
				GUILayout.Button(database.Get(cnt).Name, "box", GUILayout.Width(_listViewButtonWidth), GUILayout.Height(_listViewButtonHeight));
				//EditorGUILayout.LabelField(database.Get(cnt).Name);
			}
			
			GUILayout.EndScrollView();
		}
	}
}
