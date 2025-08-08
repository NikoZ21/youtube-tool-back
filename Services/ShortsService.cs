using youtube_tool_back.ServiceContracts;

namespace youtube_tool_back.Services
{
    public class ShortsService : IShortService
    {
        private readonly IYouTubeService _youtube;

        public ShortsService(IYouTubeService youtube)
        {
            _youtube = youtube;
        }

        public async Task<List<ShortDto>> GetRecentShortAsync(string channelId, DateTime fromDate)
        {
            List<ShortDto> videos = await _youtube.GetVideosAsync(channelId, fromDate);
            return videos;
        }
    }
}
