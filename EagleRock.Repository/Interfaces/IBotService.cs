using EagleRock.Repository.Models;


namespace EagleRock.Repository.Interfaces
{
    public interface IBotStatusService
    {
        IEnumerable<BotStatus> GetBotStatuses();
    }
}
