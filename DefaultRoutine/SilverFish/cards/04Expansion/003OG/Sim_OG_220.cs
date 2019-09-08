using HREngine.Bots;
using SilverFish.Enums;

namespace SilverFish.cards._04Expansion._003OG
{
	class Sim_OG_220 : SimTemplate //* Malkorok
	{
		//Battlecry: Equip a random weapon.
		
        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardIdEnum.CS2_080);

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.equipWeapon(w, own.own);
        }
    }
}