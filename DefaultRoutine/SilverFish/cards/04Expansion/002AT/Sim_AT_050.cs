using HREngine.Bots;
using SilverFish.Enums;

namespace SilverFish.cards._04Expansion._002AT
{
    class Sim_AT_050 : SimTemplate //* Charged Hammer
    {
        //Deathrattle: Your Hero Power becomes 'Deal 2 damage.'

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardIdEnum.AT_050);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.setNewHeroPower(CardIdEnum.AT_050t, m.own); // Lightning Jolt
        }
    }
}