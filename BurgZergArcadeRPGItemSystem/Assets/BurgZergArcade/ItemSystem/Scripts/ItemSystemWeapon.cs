using UnityEngine;
using System.Collections;
using UnityEditor;

namespace BurgZergArcade.ItemSystem
{
	[System.Serializable]
	public class ItemSystemWeapon : ItemSystemObject, IItemSystemWeapon, IItemSystemDestructable, IItemSystemEquipable, IItemSystemGameObject //inherits the class ItemSystemObject and many other interfaces
	{
		[SerializeField] private int _minDamage;
		[SerializeField] private int _durability;
		[SerializeField] private int _maxDurability;
		[SerializeField] private ItemSystemEquipmentSlot _equipmentSlot;
		[SerializeField] private GameObject _prefab;
		
		public ItemSystemWeapon () //constructor
		{
			_equipmentSlot = new ItemSystemEquipmentSlot();
			//_prefab = new GameObject();
		}
		
		public ItemSystemWeapon (int durability, int maxDurability, ItemSystemEquipmentSlot equipmentSlot, GameObject prefab)
		{
			_durability = durability;
			_maxDurability = maxDurability;
			_equipmentSlot = equipmentSlot;
			_prefab = prefab;
		}
		
		//IItemSystemWeapon Implementation
		public int minDamage 
		{
			get 
			{
				return _minDamage;
			}
			set 
			{
				_minDamage = value;
			}
		}
		
		public int Attack ()
		{
			throw new System.NotImplementedException ();
		}

		//IItemSystemDestructable
		public void TakeDamage (int amount) //this is when the item takes damage
		{
			_durability -= amount;
			
			if(_durability < 0)
			{
				_durability = 0;
			}
		}

		public void Repair ()
		{
			_maxDurability--;
			
			if(_maxDurability > 0)
			{
				_durability = _maxDurability;
			}
		}

		//set the durability to zero.
		public void Break ()
		{
			_durability = 0;
		}

		public int Durability 
		{
			get 
			{
				return _durability;
			}
		}

		public int MaxDurability 
		{
			get 
			{
				return _maxDurability;
			}
		}

		//IItemSystemEquipable
		public bool Equip () //we don't want our items equiping themselves, so instead, we will probably have another system handle the equiping of items.
		{
			throw new System.NotImplementedException ();
		}

		public ItemSystemEquipmentSlot EquipmentSlot 
		{
			get 
			{
				return _equipmentSlot;
			}
		}

		//IItemSystemGameObject
		public GameObject Prefab 
		{
			get 
			{
				return _prefab;
			}
		}
		
		//this code will go into a new script later
		
		public override void OnGUI ()//this OnGUI method overrides whatever OnGUI method we have in the base class
		{
			//Name = EditorGUILayout.TextField("Name: ", Name);
			base.OnGUI();
			
			_minDamage = System.Convert.ToInt32(EditorGUILayout.TextField("Damage", _minDamage.ToString()));
			_durability = System.Convert.ToInt32(EditorGUILayout.TextField("Durability", _durability.ToString()));
			_maxDurability = System.Convert.ToInt32(EditorGUILayout.TextField("Max Durability", _maxDurability.ToString()));
			
			DisplayEquipmentSlot();
			DisplayPrefab();
		}
		
		public void DisplayEquipmentSlot ()
		{
			GUILayout.Label("Equipment Slot");
		}
		
		public void DisplayPrefab ()
		{
			GUILayout.Label("Prefab");
		}
	}
}