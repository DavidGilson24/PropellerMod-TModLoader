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
			Item.rare = ItemRarityID.Expert;
			Item.vanity = true;
		}

		public override void AddRecipes()
        {
			Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Feather, 5);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddIngredient(ItemID.DD2PetGato, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
