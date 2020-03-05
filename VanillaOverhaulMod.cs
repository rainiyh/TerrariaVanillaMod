using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System.Linq;
using System.Collections.Generic;

// TODO: Frostspark boot + Lava Wader upgrade
namespace VanillaOverhaulMod
{
	public class VanillaOverhaulMod : Mod
	{
		public VanillaOverhaulMod()
		{
		}

        public override void AddRecipes()
        {
            // Create equivalencies
            List<int> anyCopperBar = new List<int> { ItemID.CopperBar, ItemID.TinBar };
            List<int> anyIronBar = new List<int> { ItemID.IronBar, ItemID.LeadBar };
            List<int> anySilverBar = new List<int> { ItemID.SilverBar, ItemID.TungstenBar };
            List<int> anyGoldBar = new List<int> { ItemID.GoldBar, ItemID.PlatinumBar };

            // Magic carpet gold
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Silk, 30);
            recipe.AddIngredient(ItemID.GoldBar, 8);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.FlyingCarpet);
            recipe.AddRecipe();

            // Magic carpet plat
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Silk, 30);
            recipe.AddIngredient(ItemID.PlatinumBar, 8);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.FlyingCarpet);
            recipe.AddRecipe();

            // Hermes boots
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddIngredient(ItemID.SwiftnessPotion, 3);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.HermesBoots);
            recipe.AddRecipe();

            // Fisherman's Pocket Guide
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Silk, 20);
            recipe.AddIngredient(ItemID.Chain);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(ItemID.FishermansGuide);
            recipe.AddRecipe();

            // Weather Radio iron
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(ItemID.NeptunesShell);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(ItemID.WeatherRadio);
            recipe.AddRecipe();

            // Weather Radio lead
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LeadBar, 10);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(ItemID.NeptunesShell);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(ItemID.WeatherRadio);
            recipe.AddRecipe();

            // Sextant gold
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.GoldBar, 15);
            recipe.AddIngredient(ItemID.Glass, 15);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(ItemID.Sextant);
            recipe.AddRecipe();

            // Sextant plat
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.PlatinumBar, 15);
            recipe.AddIngredient(ItemID.Glass, 15);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(ItemID.Sextant);
            recipe.AddRecipe();

            // Cobalt Shield cobalt
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CobaltBar, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.CobaltShield);
            recipe.AddRecipe();

            // Cobalt Shield palladium
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.PalladiumBar, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.CobaltShield);
            recipe.AddRecipe();

            // Cloud in a Bottle
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Bottle);
            recipe.AddIngredient(ItemID.Cloud);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.CloudinaBottle);
            recipe.AddRecipe();

            // Slime Staff
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(ItemID.Gel, 20);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.SlimeStaff);
            recipe.AddRecipe();

            // Ankh Charm
            RecipeFinder finder = new RecipeFinder();
            finder.SetResult(ItemID.AnkhCharm);
            foreach (Recipe ankhRecipe in finder.SearchRecipes())
            {
                RecipeEditor editor = new RecipeEditor(ankhRecipe);
                editor.AddIngredient(ItemID.PocketMirror);
            }

            // Pocket Mirror magic
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.MagicMirror);
            recipe.AddIngredient(ItemID.SoulofLight, 10);
            recipe.AddIngredient(ItemID.Obsidian, 15);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PocketMirror);
            recipe.AddRecipe();

            // Magic Mirror iron
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient(ItemID.Glass, 10);
            recipe.AddIngredient(ItemID.FallenStar, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.MagicMirror);
            recipe.AddRecipe();

            // Magic Mirror lead
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LeadBar, 10);
            recipe.AddIngredient(ItemID.Glass, 10);
            recipe.AddIngredient(ItemID.FallenStar, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.MagicMirror);
            recipe.AddRecipe();

            // Rod of Discord
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofLight, 20);
            recipe.AddIngredient(ItemID.FallenStar, 50);
            recipe.AddIngredient(ItemID.SoulofFright, 10);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(ItemID.RodofDiscord);
            recipe.AddRecipe();

            // Wooden Boomerang
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.WoodenBoomerang);
            recipe.AddRecipe();

            // Enchanted Boomerang
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.WoodenBoomerang);
            recipe.AddIngredient(ItemID.FallenStar, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.EnchantedBoomerang);
            recipe.AddRecipe();

            // Aglet copper
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CopperBar, 5);
            recipe.SetResult(ItemID.Aglet);
            recipe.AddTile(TileID.Anvils);
            recipe.AddRecipe();

            // Aglet tin
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TinBar, 5);
            recipe.SetResult(ItemID.Aglet);
            recipe.AddTile(TileID.Anvils);
            recipe.AddRecipe();

            // Anklet of the Wind
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.JungleSpores, 15);
            recipe.AddIngredient(ItemID.Cloud, 10);
            recipe.AddIngredient(ItemID.PinkGel, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.AnkletoftheWind);
            recipe.AddRecipe();

            // Titan Glove cobalt
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CobaltBar, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.TitanGlove);
            recipe.AddRecipe();

            // Titan Glove palladium
        }
    }
}