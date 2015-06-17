using UnityEngine;
using System.Collections;
using UnityEditor;

namespace BurgZergArcade.ItemSystem.Editor
{
	public partial class ItemSystemObjectEditor : EditorWindow 
	{
		private ItemSystemWeaponDatabase database;
		//private GUIContent titleContent;

		private const string DATABASE_NAME = @"bzaWeaponDatabase.asset";
		private const string DATABASE_PATH = @"Database";
		private const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_PATH + "/" + DATABASE_NAME; //originally @"Assets/Database/bzaQualityDatabase.asset";
		
		[MenuItem("BZA/Database/Item System Editor %#i")] //makes the hotkey ctrl+shift+i. Look up unity menuitem for more hotkey combinations.
		//this function is called when the key combination is pressed
		public static void Init () //must be static for whatever reason
		{
			ItemSystemObjectEditor window = EditorWindow.GetWindow<ItemSystemObjectEditor>();
			window.minSize = new Vector2(800f, 600f);
			//window.titleContent.text = "Item System";//window.title = "Item System";
			window.titleContent = new GUIContent("Item System"); //this line and the two examples above give the same results
			window.Show();
		}
		
		private void OnEnable ()
		{
			if(database == null)
			{
				database = ItemSystemWeaponDatabase.GetDatabase<ItemSystemWeaponDatabase>(DATABASE_PATH, DATABASE_NAME);
			}
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