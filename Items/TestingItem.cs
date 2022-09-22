using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace thebackrooms.Items
{
	public class TestingItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Goon");
			Tooltip.SetDefault("Him.");
		}

		public override void SetDefaults()
		{
			Item.damage = 1000000;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 10;
			Item.useAnimation = 10;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = ItemRarityID.Master;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.sellPrice(69,0,0,0);
		}
	}
}