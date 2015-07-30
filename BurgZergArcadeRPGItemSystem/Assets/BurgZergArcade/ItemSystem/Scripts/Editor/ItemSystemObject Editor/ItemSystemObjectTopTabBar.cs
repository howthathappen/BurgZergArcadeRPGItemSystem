using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem.Editor
{
	public partial class ItemSystemObjectEditor
	{
		private enum TabState {
			WEAPON,
			ARMOR,
			POTION,
			ABOUT
		}
		
		private TabState tabState;
		
		private void TopTabBar ()
		{
			GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
			WeaponTab();
			ArmorTab();
			PotionTab();
			AboutTab();
			GUILayout.EndHorizontal();
		}
		
		private void WeaponTab ()
		{
			if(GUILayout.Button("Weapons"))
			{
				tabState = TabState.WEAPON;
			}
		}
		
		private void ArmorTab ()
		{
			if(GUILayout.Button("Armor"))
			{
				tabState = TabState.ARMOR;
			}
		}
		
		private void PotionTab ()
		{
			if(GUILayout.Button("Potions"))
			{
				tabState = TabState.POTION;
			}
		}
		
		private void AboutTab ()
		{
			if(GUILayout.Button("About"))
			{
				tabState = TabState.ABOUT;
			}
		}
	}
}