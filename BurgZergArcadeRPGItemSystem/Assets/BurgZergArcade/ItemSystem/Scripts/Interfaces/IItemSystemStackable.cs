using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
	public interface IItemSystemStackable
	{
		int MaxStack {get; }
		int Stack(int amount); //default value of 0.
	}
}