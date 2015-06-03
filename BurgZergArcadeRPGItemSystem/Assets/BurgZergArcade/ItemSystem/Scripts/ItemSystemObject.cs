using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
	[System.Serializable]
	public class ItemSystemObject : IItemSystemObject {
	
		[SerializeField]private Sprite _icon;
		[SerializeField]private string _name;
		[SerializeField]private int _value;
		[SerializeField]private int _burden;
		[SerializeField]private ItemSystemQuality _quality;
	
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
	}
}