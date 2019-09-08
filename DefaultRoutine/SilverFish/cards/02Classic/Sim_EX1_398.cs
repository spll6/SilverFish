﻿using HREngine.Bots;
using SilverFish.Enums;

namespace SilverFish.cards._02Classic
{
    class Sim_EX1_398 : SimTemplate//Arathi Weaponsmith
    {
        CardDB.Card wcard = CardDB.Instance.getCardDataFromID(CardIdEnum.EX1_398t);//battleaxe

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.equipWeapon(wcard,own.own);

        }

    }
}
