using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ReponseMod_JoinLeave
{
    public class Class1 : RocketPlugin<Config>
    {
        protected override void Load()
        {
            base.Load();
            U.Events.OnPlayerConnected += Join;
            U.Events.OnPlayerDisconnected += Leave;
        }


        private void Leave(UnturnedPlayer player)
        {
            Message($"<color=red>{player.CharacterName}</color> <color=orange>[<color=white>+</color>]</color>");
        }

        private void Join(UnturnedPlayer player)
        {
            Message($"<color=green>{player.CharacterName}</color> <color=orange>[<color=white>+</color>]</color>");
        }

        public void Message(string Message)
        {
            ChatManager.serverSendMessage(Message, Color.white, null, null, EChatMode.SAY, Configuration.Instance.ServerLogo, true);
        }
    }
}
