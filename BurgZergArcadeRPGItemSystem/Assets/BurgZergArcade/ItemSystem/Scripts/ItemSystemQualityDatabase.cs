using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using System.Linq; //needed for ElementAt

namespace BurgZergArcade.ItemSystem
{
	public class ItemSystemQualityDatabase : ScriptableObjectDatabase<ItemSystemQuality>
	{
		public int GetIndex (string name)
		{
			return database.FindIndex(a => a.Name == name);
		}
		
//		[SerializeField][HideInInspector] //show our database list in the inspector or not. Also allows the database to be saved after closing unity it seems
//		List<ItemSystemQuality> database = new List<ItemSystemQuality>();
//	
//		public void Add (ItemSystemQuality item)
//		{
//			database.Add(item);
//			EditorUtility.SetDirty(this); //saves our database so it will show up again after we close unity
//		}
//		
//		public void Insert (int index, ItemSystemQuality item)
//		{
//			database.Insert(index, item);
//			EditorUtility.SetDirty(this);
//		}
//		
//		public void Remove (ItemSystemQuality item)
//		{
//			database.Remove(item);
//			EditorUtility.SetDirty(this);
//		}
//		
//		public void Remove (int index) //overloadede method in case we want to remove something from a specific spot instead
//		{
//			database.RemoveAt(index);
//			EditorUtility.SetDirty(this);
//		}
//		
//		public int Count
//		{
//			get {return database.Count;}
//		}
//		
//		public ItemSystemQuality Get(int index)
//		{
//			return database.ElementAt(index);
//		}
//		
//		public void Replace (int index, ItemSystemQuality item)
//		{
//			database[index] = item;
//			EditorUtility.SetDirty(this);
//		}
	}
}