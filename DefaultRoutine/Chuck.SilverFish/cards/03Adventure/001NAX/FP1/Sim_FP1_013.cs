using Chuck.SilverFish;

namespace SilverFish.cards._03Adventure._001NAX.FP1
{
    class Sim_FP1_013 : SimTemplate //* Kel'Thuzad
	{
        // At the end of each turn, summon all friendly minions that died this turn.

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            foreach (GraveYardItem gyi in p.diedMinions.ToArray()) // toArray() because a knifejuggler could kill a minion due to the summon :D
            {
                if (gyi.own == triggerEffectMinion.own)
                {
                    CardDB.Card card = CardDB.Instance.getCardDataFromID(gyi.cardid);
                    int pos = triggerEffectMinion.own ? p.ownMinions.Count : p.enemyMinions.Count;
                    p.CallKid(card, p.ownMinions.Count, gyi.own);
                }
            }
        }
	}
}