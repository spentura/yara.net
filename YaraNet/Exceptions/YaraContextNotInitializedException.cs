namespace YaraNet.Exceptions
{
    public class YaraContextNotInitializedException : InvalidOperationException
    {
        public YaraContextNotInitializedException()
            : base("YaraContext has been cleaned up.")
        {
        }
    }
}
