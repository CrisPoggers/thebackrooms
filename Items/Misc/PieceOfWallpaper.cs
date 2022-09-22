using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace thebackrooms.Items.Misc
{
	public class PieceOfWallpaper : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Piece of Wallpaper");
			Tooltip.SetDefault("The Madness of the Mono-Yellow.");
		}

		public override void SetDefaults()
		{
			Item.width = 15;
			Item.height = 15;
			Item.useTime = 10;
			Item.useAnimation = 10;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.value = 1;
			Item.rare = ItemRarityID.White;
			Item.autoReuse = true;
			Item.maxStack = 64;
			Item.sellPrice(0,0,1,8);
		}
	}
}