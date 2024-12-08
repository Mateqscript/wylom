
using Exiled.API.Features;
using CommandSystem;
using System;

namespace CassieBreachPlugin
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "CassieBreachPlugin";
        public override string Author => "TwojeImie";
        public override Version Version => new Version(1, 0, 0);

        public override void OnEnabled()
        {
            base.OnEnabled();
            Log.Info("CassieBreachPlugin włączony!");
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            Log.Info("CassieBreachPlugin wyłączony!");
        }
    }

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class BreachCommand : ICommand
    {
        public string Command => "breach";
        public string[] Aliases => new string[] { };
        public string Description => "Odtwarza komunikat CASSIE o naruszeniu SCP.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Cassie.Message("pitch_0.8 Attention . . . scp containment breach detected repeat scp containment breach detected . . pitch_0.4 .g3 .g3 .g3 pitch_0.8 allremaining . . please go to shelter or safe room and wait for MTFUnit .g3 .g3 .g3", isHeld: false, isNoisy: false);
            response = "Komunikat CASSIE odtworzony.";
            return true;
        }
    }
}
