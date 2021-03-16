using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Discord.Net; 


using DiscordBot.Core; 

namespace DiscordBot
{
    class Program
    {
        static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult(); 

        public async Task MainAsync()
        {
            // entry point
        }
    }
}
