using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace BurgZergArcade.ItemSystem
{
	public class ItemSystemQualityDatabase : ScriptableObject
	{
		//[SerializeField]
		public List<ItemSystemQuality> database = new List<ItemSystemQuality>();
	}
}