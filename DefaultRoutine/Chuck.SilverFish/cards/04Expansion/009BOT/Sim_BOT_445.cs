using System;
using System.Collections.Generic;
using System.Text;
using SilverFish.Enums;

namespace Chuck.SilverFish
{
	class Sim_BOT_445 : SimTemplate //* 机械袋鼠
	{
		//亡语：召唤一个1/1的机械袋鼠宝宝。

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardIdEnum.BOT_445t);

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.CallKid(kid, m.zonepos-1, m.own);
        }
	}
}