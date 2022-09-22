using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace thebackrooms {
    public class thebackroomsPlayer : ModPlayer {
        public int sanity = 100;
        public int wretchedCycle = 0;

        public override void Hurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit) {
            if (pvp == true) sanity -= 2;
            if (pvp ~= true) sanity -= 5;
	    }

        public override void OnRespawn(Player player) {
            sanity = 100;
            wretchedCycle = 0;
        }

        public override void UpdateDead() {
            sanity = 0;
        }
    }
}