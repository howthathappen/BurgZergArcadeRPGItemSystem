using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
	public interface IItemSystemDestructable
	{
		int Durability {get; }
		int MaxDurability {get; }
		void TakeDamage(int amount);
		void Repair();
		void Break();
	}
}