using EagleRock.Repository.Models;


namespace EagleRock.Repository.Interfaces
{
    public interface IBotStatusService
    {
        /// <summary>
        /// Gets current status of Bots
        /// </summary>
        /// <returns>List of Bot status records</returns>
        IEnumerable<BotStatus> GetBotStatus();
    }
}
