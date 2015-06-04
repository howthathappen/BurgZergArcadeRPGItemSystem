using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
	public interface IItemSystemWeapon
	{
		int minDamage {get; set;}
		int Attack();
	}
}