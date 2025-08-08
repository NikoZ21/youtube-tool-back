using System.Threading.Channels;

namespace youtube_tool_back.Entities
{
    public class Short
    {
        public Guid Id { get; set; }
        public Guid ChannelId { get; set; }
        public Channel Channel { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Transcript { get; set; } // full text
        public DateTime PublishedAt { get; set; }
        public float[] TitleEmbedding { get; set; } // store embedding vector as float[]
        public float[] DescEmbedding { get; set; }
        public float[] TranscriptEmbedding { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
