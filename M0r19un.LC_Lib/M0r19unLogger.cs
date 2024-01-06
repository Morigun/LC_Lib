using BepInEx.Logging;
using System;

namespace M0r19un.LC_Lib{
    public class M0r19unLogger{
        internal static ManualLogSource logSource;

        public static void Initialize(string modGUID) => M0r19unLogger.logSource = Logger.CreateLogSource(modGUID);

        public static void Log(object message) => M0r19unLogger.logSource.LogInfo($"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] - {message}");

        public static void LogError(object message) => M0r19unLogger.logSource.LogError($"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] - {message}");

        public static void LogWarning(object message) => M0r19unLogger.logSource.LogWarning($"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] - {message}");
    }
}