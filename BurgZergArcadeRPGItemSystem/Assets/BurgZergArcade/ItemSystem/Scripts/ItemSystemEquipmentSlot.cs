using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
	public class ItemSystemEquipmentSlot : IItemSystemEquipmentSlot 
	{
		[SerializeField] private string _name;
		[SerializeField] private Sprite _icon;
		
		public ItemSystemEquipmentSlot ()
		{
			_name = "Name Me";
			_icon = new Sprite();
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
	}
}