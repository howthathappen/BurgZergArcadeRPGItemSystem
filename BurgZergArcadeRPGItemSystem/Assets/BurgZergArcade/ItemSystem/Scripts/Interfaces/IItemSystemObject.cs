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
		string ISName {get; set;}
		int ISValue {get; set;}
		Sprite ISIcon {get; set;}
		int ISBurden {get; set;}
		ItemSystemQuality ItemSystemQuality {get; set;}
		
		//these go to other item interfaces
		//equip
		//questItem flag
		//durability
		//takeDamage
		//prefab
	}
}