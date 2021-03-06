using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._04Expansion._005UNG
{
	class Sim_UNG_029 : SimTemplate //* Shadow Visions
	{
		//Discover a copy of a spell in your deck.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardName.shadowworddeath, ownplay, true);
            p.drawACard(CardName.holynova, ownplay, true);
			p.owncarddraw--;
		}
	}
}