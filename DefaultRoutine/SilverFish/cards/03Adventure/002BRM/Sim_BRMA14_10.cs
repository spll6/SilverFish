using HREngine.Bots;
using SilverFish.Enums;

namespace SilverFish.cards._03Adventure._002BRM
{
	class Sim_BRMA14_10 : SimTemplate //* Activate!
	{
		// Hero Power: Activate a random Tron.

		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardIdEnum.BRMA14_5);//3/3toxitron
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.CallKid(kid, place, ownplay, false);
        }
	}
}