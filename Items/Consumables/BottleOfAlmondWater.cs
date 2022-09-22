using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace thebackrooms.Items.Consumables
{
	public class BottleOfAlmondWater : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bottle of Almond Water");
			Tooltip.SetDefault("A sweet Vanilla Taste.");
		}

		public override void SetDefaults()
		{
			Item.width = 10;
			Item.height = 10;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = ItemUseStyleID.DrinkLong;
			Item.value = 10;
			Item.rare = ItemRarityID.White;
			Item.UseSound = SoundID.Item3;
			Item.autoReuse = true;
			Item.maxStack = 25;
			Item.sellPrice(0,0,1,10);
			Item.consumable = true;
			Item.buffType = BuffID.Endurance;
			Item.buffTime = (60*120);
		}
	}
}