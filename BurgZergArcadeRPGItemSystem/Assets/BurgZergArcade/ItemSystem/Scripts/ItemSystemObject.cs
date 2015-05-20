using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
	public class ItemSystemObject : IItemSystemObject {
	
		[SerializeField]private Sprite _icon;
		[SerializeField]private string _name;
		[SerializeField]private int _value;
		[SerializeField]private int _burden;
		[SerializeField]private ItemSystemQuality _quality;
	
		public string ISName 
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
	
		public int ISValue 
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
	
		public Sprite ISIcon 
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
	
		public int ISBurden 
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
	
		public ItemSystemQuality ItemSystemQuality 
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