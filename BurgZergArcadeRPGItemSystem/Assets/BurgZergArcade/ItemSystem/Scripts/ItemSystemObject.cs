﻿using UnityEngine;
using System.Collections;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace BurgZergArcade.ItemSystem
{
	[System.Serializable]
	public class ItemSystemObject : IItemSystemObject {
	
		[SerializeField]private string _name;
		[SerializeField]private Sprite _icon;
		[SerializeField]private int _value;
		[SerializeField]private int _burden;
		[SerializeField]private ItemSystemQuality _quality;
		
		public ItemSystemObject () {}
		
		public ItemSystemObject (ItemSystemObject item)
		{
			Clone(item);
		}
		
		public void Clone (ItemSystemObject item)
		{
			_name = item.Name;
			_icon = item.Icon;
			_value = item.Value;
			_burden = item.Burden;
			_quality = item.Quality;
		}
	
		public string Name 
		{
			get 
			{
				return _name;
			}
			set 
			{
				_name = value;
			}
		}
	
		public int Value 
		{
			get 
			{
				return _value;
			}
			set 
			{
				_value = value; //if the names were the same like value = value, you can get around any problems by using this.value = value
			}
		}
	
		public Sprite Icon 
		{
			get 
			{
				return _icon;
			}
			set 
			{
				_icon = value;
			}
		}
	
		public int Burden 
		{
			get 
			{
				return _burden;
			}
			set 
			{
				_burden = value;
			}
		}
	
		public ItemSystemQuality Quality 
		{
			get 
			{
				return _quality;
			}
			set 
			{
				_quality = value;
			}
		}
	
#if UNITY_EDITOR	
		//this code will be placed in a new class later on.
		private ItemSystemQualityDatabase qdb;
		private int qualitySelectedIndex = 0;
		private string[] options;// = new string[] {"com", "unc", "rar"};
		private bool qualityDatabaseLoaded = false;
		
		public virtual void OnGUI ()
		{
			GUILayout.BeginVertical();
			_name = EditorGUILayout.TextField("Name", _name);
			
			_value = EditorGUILayout.IntField("Value", _value);
			_burden = EditorGUILayout.IntField("Burden", _burden);
			//_value = System.Convert.ToInt32(EditorGUILayout.TextField("Value", _value.ToString()));
			//_burden = System.Convert.ToInt32(EditorGUILayout.TextField("Burden", _burden.ToString()));
			DisplayIcon();
			DisplayQuality();
			GUILayout.EndVertical();
		}
		
		public void DisplayIcon ()
		{
			_icon = EditorGUILayout.ObjectField("Icon", _icon, typeof(Sprite), false) as Sprite;
		}
		
		public int SelectedQualityID
		{
			get {return qualitySelectedIndex;}
		}
		
		public void LoadQualityDatabase ()
		{
			string DATABASE_NAME = @"bzaQualityDatabase.asset";
			string DATABASE_PATH = @"Database";
			qdb = ItemSystemQualityDatabase.GetDatabase<ItemSystemQualityDatabase>(DATABASE_PATH, DATABASE_NAME);
		
			options = new string[qdb.Count];
			for(int cnt = 0; cnt < qdb.Count; cnt++)
			{
				options[cnt] = qdb.Get(cnt).Name;
			}
			
			qualityDatabaseLoaded = true;
		}
		
		public void DisplayQuality ()
		{
			//GUILayout.Label("Quality");
			//if(_quality == null)
				//return;
				
			//Debug.Log("Quality Index: " + qdb.GetIndex(_quality.Name));
			if(!qualityDatabaseLoaded)
			{
				LoadQualityDatabase();
				return; //reduces chance of errors if the database dooes not load fast enough. Basically does the code below one frame after this code is executed.
			}
			
			int itemIndex = 0;
			
			//Debug.Log(qdb.GetIndex(_quality.Name).ToString());
			if(_quality != null)
			{
				itemIndex = qdb.GetIndex(_quality.Name);
			}
			
			if(itemIndex == -1) //-1 means it doesn't already have a quality assigned.
			{
				itemIndex = 0;
			}
			
			qualitySelectedIndex = EditorGUILayout.Popup("Quality", itemIndex, options);
			_quality = qdb.Get(SelectedQualityID);
		}
#endif
	}
}