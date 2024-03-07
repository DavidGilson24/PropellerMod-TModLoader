using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PropellerMod.Items
{
    [AutoloadEquip(EquipType.Head)]
    public class PropellerHat : ModItem
    {
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;
			Item.rare = -12;
			Item.vanity = true;
		}

		public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Feather, 5);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddIngredient(3859, 1);
			recipe.AddTile(TileID.Anvils);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}
