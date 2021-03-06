using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Prt_f01
{
    public class Ditrahel : Npc
    {
        public override void OnInit()
        {
            MapName = "Prt_f01";
            Type = 1159;
            Name = "Ditrahel";
            StartX = 9984F;
            StartY = 79999F;
            StartZ = 5056;
            Startyaw = 58768;
            SetScript(3);
            AddButton(Functions.EverydayConversation, new func(OnButton));
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
        }

    }
}