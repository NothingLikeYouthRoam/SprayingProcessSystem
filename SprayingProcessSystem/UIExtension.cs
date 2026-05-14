using Sunny.UI;
using LogLevel = Microsoft.Extensions.Logging.LogLevel;

namespace SprayingProcessSystem
{
    public static class UIExtension
    {
        public static Action<UIStyleManager> SetStyleManager;
    }

    public static class LogExtension
    {
        public static Action<string, LogLevel> ShowMessage;
    }
}
