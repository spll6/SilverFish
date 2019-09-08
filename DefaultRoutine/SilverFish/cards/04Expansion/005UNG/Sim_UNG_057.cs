using HREngine.Bots;
using SilverFish.Enums;

namespace SilverFish.cards._04Expansion._005UNG
{
	class Sim_UNG_057 : SimTemplate //* Razorpetal Volley
	{
		//Add two Razorpetals to your hand that deal 1 damage.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardIdEnum.UNG_057t1,ownplay, true);
            p.drawACard(CardIdEnum.UNG_057t1, ownplay, true);
        }
    }
}