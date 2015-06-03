using UnityEngine;
using System.Collections;
using UnityEditor;

namespace BurgZergArcade.ItemSystem.Editor
{
	public partial class ItemSystemObjectEditor : EditorWindow 
	{
	
		[MenuItem("BZA/Database/Item System Editor %#i")] //makes the hotkey ctrl+shift+i. Look up unity menuitem for more hotkey combinations.
		//this function is called when the key combination is pressed
		public static void Init () //must be static for whatever reason
		{
			ItemSystemObjectEditor window = EditorWindow.GetWindow<ItemSystemObjectEditor>();
			window.minSize = new Vector2(800f, 600f);
			window.title = "Item System";
			window.Show();
		}
		
		private void OnEnable ()
		{
			
		}
		
		private void OnGUI ()
		{
			TopTabBar();
			
			GUILayout.BeginHorizontal();
			ListView();
			ItemDetails();
			GUILayout.EndHorizontal();
			
			BottomStatusBar();
		}
	}
}