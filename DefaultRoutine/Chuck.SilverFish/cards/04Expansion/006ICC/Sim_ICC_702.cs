using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._04Expansion._006ICC
{
    class Sim_ICC_702: SimTemplate //* Shallow Gravedigger
    {
        // Deathrattle: Add a random Deathrattle minion to your hand.

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardName.unknown, m.own, true);
        }
    }
}