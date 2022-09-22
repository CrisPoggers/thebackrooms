using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace thebackrooms.Items.Consumables
{
	public class BottleOfCarpetLiquid : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bottle of Carpet Liquid");
			Tooltip.SetDefault("Yucky!");
		}

		public override void SetDefaults()
		{
			Item.width = 10;
			Item.height = 10;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = ItemUseStyleID.DrinkLong;
			Item.value = 5;
			Item.rare = ItemRarityID.White;
			Item.UseSound = SoundID.Item3;
			Item.autoReuse = true;
			Item.maxStack = 10;
			Item.sellPrice(0,0,0,2);
			Item.consumable = true;
			Item.healLife = 2;
			Item.buffType = BuffID.Venom;
			Item.buffTime = (60*120);
		}
	}
}