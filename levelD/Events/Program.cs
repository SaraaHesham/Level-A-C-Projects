namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class youtubeChannel
    {
        public string ChannelName { get; set; }
        public event EventHandler VideoUploaded;
        public void UploadVideo()
        {
            Console.WriteLine("Video Uploaded");
            OnVideoUploaded();
        }
        protected virtual void OnVideoUploaded()
        {
            if (VideoUploaded != null)
            {
                VideoUploaded(this, EventArgs.Empty);
            }
        }
    }
    public class Subscriber
    {
        public string Name { get; set; }
        public void OnVideoUploaded(object source, EventArgs e)
        {
            Console.WriteLine("Notification sent to " + Name);
        }
    }
}
