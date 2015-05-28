using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
	public interface IItemSystemEquipable
	{
		ItemSystemEquipmentSlot EquipmentSlot {get; }
		bool Equip();
	}
}