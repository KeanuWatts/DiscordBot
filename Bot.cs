using System;
using System.Collections.Generic;
using System.Text;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;

namespace DiscordBot
{

    class Bot
    {

        public DiscordClient Client {get;private set;}
        public CommandsNextConfiguration Commands{get; private set;}
        public async Task RunAsync()
        {
            Client = new DiscordClient(config);

            Client.Ready += OnClientReady;

            CommandsNextConfiguration cmdconfig = new CommandsNextConfiguration{

            };

            Commands = Client.UseCommandsNext(cmdconfig);

            await Client.ConnectAsync();

            await Task.Delay(1);
        }

        private Task OnClientReady(ReadyEventArgs e) 
        {
            return null;
        }
    }
}