namespace youtube_tool_back.ServiceContracts
{
    public interface IShortService
    {
        Task<List<ShortDto>> GetRecentShortAsync(string channelId, DateTime fromDate);
    
    }
}
