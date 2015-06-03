using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem.Editor
{
	public partial class ItemSystemObjectEditor
	{
		private void BottomStatusBar()
		{
			GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
			GUILayout.Label("Status Bar");
			GUILayout.EndHorizontal();
		}
	}
}