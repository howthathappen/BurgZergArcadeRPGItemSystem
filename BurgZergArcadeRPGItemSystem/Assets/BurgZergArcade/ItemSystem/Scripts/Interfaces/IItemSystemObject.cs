using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
	public interface IItemSystemObject {
	
		//name
		//value - gold value
		//icon
		//burden
		//qualityLevel
		string Name {get; set;}
		int Value {get; set;}
		Sprite Icon {get; set;}
		int Burden {get; set;}
		ItemSystemQuality Quality {get; set;}
		
		//these go to other item interfaces
		//equip
		//questItem flag
		//durability
		//takeDamage
		//prefab
	}
}