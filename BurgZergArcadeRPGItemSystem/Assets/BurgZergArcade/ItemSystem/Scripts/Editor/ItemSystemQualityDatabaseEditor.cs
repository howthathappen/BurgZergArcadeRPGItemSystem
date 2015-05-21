using UnityEditor;
using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem.Editor
{
	public class ItemSystemQualityDatabaseEditor : EditorWindow 
	{
		private ItemSystemQualityDatabase qualityDatabase;
		private ItemSystemQuality selectedItem;
		private Texture2D selectedTexture;
		
		private const int SPRITE_BUTTON_SIZE = 92;
		private const string DATABASE_FILE_NAME = @"bzaQualityDatabase.asset";
		private const string DATABASE_FOLDER_NAME = @"Database";
		private const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_FOLDER_NAME + "/" + DATABASE_FILE_NAME; //originally @"Assets/Database/bzaQualityDatabase.asset";
	
		[MenuItem("BZA/Database/Quality Editor %#i")] //makes the hotkey ctrl+shift+i. Look up unity menuitem for more hotkey combinations.
		//this function is called when the key combination is pressed
		public static void Init () //must be static for whatever reason
		{
			ItemSystemQualityDatabaseEditor window = EditorWindow.GetWindow<ItemSystemQualityDatabaseEditor>();
			window.minSize = new Vector2(400f, 300f);
			window.title = "Quality Database";
			window.Show();
		}
		
		private void OnEnable ()
		{
			qualityDatabase = AssetDatabase.LoadAssetAtPath(DATABASE_FULL_PATH, typeof(ItemSystemQualityDatabase)) as ItemSystemQualityDatabase; //load the database
			
			if(qualityDatabase == null) //check to see if we actually loaded the database
			{
				if(!AssetDatabase.IsValidFolder("Assets/" + DATABASE_FOLDER_NAME)) //if the folder isn't created
				{
					AssetDatabase.CreateFolder("Assets", DATABASE_FOLDER_NAME); //create the folder
				}
				
				qualityDatabase = ScriptableObject.CreateInstance<ItemSystemQualityDatabase>();
				AssetDatabase.CreateAsset(qualityDatabase, DATABASE_FULL_PATH); //AssetDatabase will not work at runtime.
				AssetDatabase.SaveAssets();
				AssetDatabase.Refresh();
			}
			
			selectedItem = new ItemSystemQuality();
		}
		
		private void OnGUI ()
		{
			//GUILayout.Label("label"); //just a test
			AddQualityToDatabase();
		}
		
		private void AddQualityToDatabase ()
		{
			//name
			//sprite
			selectedItem.Name = EditorGUILayout.TextField("Name:", selectedItem.Name);
			if(selectedItem.Icon)
			{
				selectedTexture = selectedItem.Icon.texture; //change it from a sprite to a texture so it's easier to display it
			}
			else
			{
				selectedTexture = null;
			}
			
			if (GUILayout.Button(selectedTexture, GUILayout.Width(SPRITE_BUTTON_SIZE), GUILayout.Height(SPRITE_BUTTON_SIZE)))
			{
				int controlerID = EditorGUIUtility.GetControlID(FocusType.Passive);
				EditorGUIUtility.ShowObjectPicker<Sprite>(null, true, null, controlerID);
			}
			
			string commandName = Event.current.commandName;
			if(commandName == "ObjectSelectorUpdated")
			{
				selectedItem.Icon = (Sprite)EditorGUIUtility.GetObjectPickerObject();
				Repaint();
			}
			
			if(GUILayout.Button("Save"))
			{
				if(selectedItem == null)
				{
					return;
				}
				
				qualityDatabase.database.Add(selectedItem);
				
				selectedItem = new ItemSystemQuality();
			}
		}
	}
}