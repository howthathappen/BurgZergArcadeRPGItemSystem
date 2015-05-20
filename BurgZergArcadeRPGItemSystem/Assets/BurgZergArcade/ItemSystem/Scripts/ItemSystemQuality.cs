using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
	[System.Serializable]
	public class ItemSystemQuality : IItemSystemQuality {
	
		[SerializeField]private string _name; //he uses _ to denote a private variable
		[SerializeField]private Sprite _icon;
		
		ItemSystemQuality ()
		{
			_name = "Common";
			_icon = new Sprite();
		}
		
		public string Name 
		{
			get 
			{
				return _name;
				//throw new System.NotImplementedException ();
			}
			
			set 
			{
				_name = value;
				//throw new System.NotImplementedException ();
			}
		}
	
		public Sprite Icon 
		{
			get 
			{
				return _icon;
				//throw new System.NotImplementedException ();
			}
			set 
			{
				_icon = value;
				//throw new System.NotImplementedException ();
			}
		}	
	}
}
