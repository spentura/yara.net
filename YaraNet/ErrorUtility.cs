using YaraNet.Interop;
using YaraNet.Exceptions;

namespace YaraNet
{
    public abstract class ErrorUtility
    {
        public static void ThrowOnError(YARA_ERROR error)
        {
            switch (error)
            {
                case YARA_ERROR.SUCCESS:
                    break;
                default:
                    throw new YaraException(error);
            }
        }
    }
}
