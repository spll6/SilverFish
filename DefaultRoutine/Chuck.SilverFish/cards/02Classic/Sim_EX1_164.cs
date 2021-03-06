using System;
using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._02Classic
{
    class Sim_EX1_164 : SimTemplate //* nourish
    {

        //    Choose One - Gain 2 Mana Crystals or Draw 3 cards.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
            {
				if (ownplay)
				{
					p.mana = Math.Min(10, p.mana+2);
					p.ownMaxMana = Math.Min(10, p.ownMaxMana+2);
				}
				else
				{
					p.mana = Math.Min(10, p.mana+2);
					p.enemyMaxMana = Math.Min(10, p.enemyMaxMana+2);
				}
            }
            if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                //this.owncarddraw+=3;
                p.drawACard(CardName.unknown, ownplay);
                p.drawACard(CardName.unknown, ownplay);
                p.drawACard(CardName.unknown, ownplay);
            }
        }

    }


}