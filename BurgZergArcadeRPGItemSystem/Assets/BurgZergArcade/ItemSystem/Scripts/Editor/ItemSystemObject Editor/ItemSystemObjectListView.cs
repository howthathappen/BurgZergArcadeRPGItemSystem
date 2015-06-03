using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem.Editor
{
	public partial class ItemSystemObjectEditor
	{
		private Vector2 _scrollPosition = Vector2.zero;
		private int _listViewWidth = 200;
		
		private void ListView ()
		{
			_scrollPosition = GUILayout.BeginScrollView(_scrollPosition, "Box", GUILayout.ExpandHeight(true), GUILayout.Width(_listViewWidth)); //width in pixels
			GUILayout.Label("List View");
			GUILayout.EndScrollView();
		}
	}
}
