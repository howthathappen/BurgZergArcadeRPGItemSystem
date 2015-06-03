using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem.Editor
{
	public partial class ItemSystemObjectEditor
	{
		private void ItemDetails ()
		{
			GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
			GUILayout.Label("Detail View");
			GUILayout.EndHorizontal();
		}
	}
}