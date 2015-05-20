using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace BurgZergArcade.ItemSystem
{
	public class ItemSystemQualityDatabase : ScriptableObject
	{
		//[SerializeField]
		List<ItemSystemQuality> db = new List<ItemSystemQuality>();
	}
}