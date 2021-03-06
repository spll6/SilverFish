using Chuck.SilverFish;

namespace SilverFish.cards._02Classic
{
	class Sim_EX1_582 : SimTemplate //dalaranmage
	{

//    zauberschaden +1/
        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.spellpower++;
            }
            else
            {
                p.enemyspellpower++;
            }
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.spellpower--;
            }
            else
            {
                p.enemyspellpower--;
            }
        }

	}
}