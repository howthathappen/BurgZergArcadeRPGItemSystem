using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem.Editor
{
	public partial class ItemSystemObjectEditor
	{
		private void TopTabBar ()
		{
			GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
			WeaponTab();
			ArmorTab();
			GUILayout.Button("Potions");
			AboutTab();
			GUILayout.EndHorizontal();
		}
		
		private void WeaponTab ()
		{
			GUILayout.Button("Weapons");
		}
		
		private void ArmorTab ()
		{
			GUILayout.Button("Armor");
		}
		
		private void AboutTab ()
		{
			GUILayout.Button("About");
		}
	}
}