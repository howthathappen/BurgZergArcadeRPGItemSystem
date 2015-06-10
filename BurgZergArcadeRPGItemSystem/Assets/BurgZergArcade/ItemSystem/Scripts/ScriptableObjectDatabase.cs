using UnityEditor;
using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace BurgZergArcade
{
	public class ScriptableObjectDatabase<T> : ScriptableObject where T: class //pass in a class as a variable, T.
	{
		[SerializeField] List<T> database = new List<T>();
		
		public void Add (T item)
		{
			database.Add(item);
			EditorUtility.SetDirty(this); //saves our database so it will show up again after we close unity
		}
		
		public void Insert (int index, T item)
		{
			database.Insert(index, item);
			EditorUtility.SetDirty(this);
		}
		
		public void Remove (T item)
		{
			database.Remove(item);
			EditorUtility.SetDirty(this);
		}
		
		public void Remove (int index) //overloadede method in case we want to remove something from a specific spot instead
		{
			database.RemoveAt(index);
			EditorUtility.SetDirty(this);
		}
		
		public int Count
		{
			get {return database.Count;}
		}
		
		public T Get(int index)
		{
			return database.ElementAt(index);
		}
		
		public void Replace (int index, T item)
		{
			database[index] = item;
			EditorUtility.SetDirty(this);
		}
		
		public static U GetDatabase<U>(string dbPath, string dbName) where U: ScriptableObject //can only pass in a ScriptableObject
		{
			string dbFullPath = @"Assets/" + dbPath + "/" + dbName;
			
			//Recursive Serialization is not supported.
			//The error was related to loading assets in a constructor/static constructor. 
			//That was never allowed but somehow was working until now. Unfortunately I don't know the 
			//details of implementation of the serialiser. The fix was ws simply about moving loading the 
			//assets to Awake
			U db = AssetDatabase.LoadAssetAtPath(dbFullPath, typeof(U)) as U; //load the database
			
			if(db == null) //check to see if we actually loaded the database
			{
				//check to see if the folder exists
				if(!AssetDatabase.IsValidFolder("Assets/" + dbPath)) //if the folder isn't created
				{
					AssetDatabase.CreateFolder("Assets", dbPath); //create the folder
				}
				
				//create the database and refresh the AssetDatabase
				db = ScriptableObject.CreateInstance<U>() as U;
				AssetDatabase.CreateAsset(db, dbFullPath); //AssetDatabase will not work at runtime.
				AssetDatabase.SaveAssets();
				AssetDatabase.Refresh();
			}
			
			return db;
		}
	}
}