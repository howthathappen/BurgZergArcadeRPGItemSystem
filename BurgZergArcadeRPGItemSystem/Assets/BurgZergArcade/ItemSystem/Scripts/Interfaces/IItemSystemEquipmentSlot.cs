using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
	public interface IItemSystemEquipmentSlot 
	{
		string Name {get; set;}
		Sprite Icon {get; set;}
	}
}