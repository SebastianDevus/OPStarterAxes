using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EarlyClasses.Global
{
	public class GlobalItemList : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.CopperAxe || item.type == ItemID.IronAxe)
			{
				item.useTime = 1;
				item.useAnimation = 15;

				item.axe = 100;
			}
		}
	}
}