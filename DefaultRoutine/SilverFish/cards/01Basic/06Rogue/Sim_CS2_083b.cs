using HREngine.Bots;
using SilverFish.Enums;

namespace SilverFish.cards._01Basic._06Rogue
{
	class Sim_CS2_083b : SimTemplate //daggermastery
	{

//    heldenfähigkeit/\nlegt einen dolch (1/2) an.
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardIdEnum.CS2_082);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

	}
}