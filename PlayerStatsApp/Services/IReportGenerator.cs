using System.Collections.Generic;
using PlayerStatsApp.Models;

namespace PlayerStatsApp.Services
{
    public interface IReportGenerator
    {
        void GeneratePlayerReport(List<Player> players);
    }
}