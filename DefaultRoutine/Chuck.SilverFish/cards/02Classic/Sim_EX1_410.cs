using Chuck.SilverFish;

namespace SilverFish.cards._02Classic
{
	class Sim_EX1_410 : SimTemplate //shieldslam
	{

//    fügt einem diener für jeden eurer rüstungspunkte 1 schaden zu.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{


            int dmg = (ownplay) ? p.getSpellDamageDamage(p.ownHero.armor) : p.getEnemySpellDamageDamage(p.enemyHero.armor);
            p.minionGetDamageOrHeal(target, dmg);
		}

	}
}