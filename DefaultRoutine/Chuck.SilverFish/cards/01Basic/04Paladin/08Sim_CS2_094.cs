using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._01Basic._04Paladin
{
	class Sim_CS2_094 : SimTemplate //hammerofwrath
	{

//    verursacht $3 schaden. zieht eine karte.
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.minionGetDamageOrHeal(target, dmg);
            p.drawACard(CardName.unknown, ownplay);
		}

	}
}