﻿using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._02Classic
{
    class Sim_EX1_007 : SimTemplate//* Acolyte of Pain
    {
        // Whenever this minion takes damage, draw a card.

        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.anzGotDmg > 0)
            {
                int tmp = m.anzGotDmg;
                m.anzGotDmg = 0;
                for (int i = 0; i < tmp; i++)
                {
                    p.drawACard(CardName.unknown, m.own);
                }
            }
        }
    }
}
