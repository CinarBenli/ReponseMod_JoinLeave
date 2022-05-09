using Rocket.API;

namespace ReponseMod_JoinLeave
{
    public class Config : IRocketPluginConfiguration
    {
        public string ServerLogo;
        public void LoadDefaults()
        {
            ServerLogo = "https://media.discordapp.net/attachments/959142220366237796/962008357990977626/122.png";
        }
    }
}