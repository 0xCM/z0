//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    static class CaptureMessages
    {
        public static void CountedInstructions(this IAppMsgSink dst, ApiHostUri host, ulong count)
            => dst.NotifyConsole(AppMsg.Colorize($"Members defined by {host} require {count} instructions", AppMsgColor.Cyan));

        public static void MatchedEmissions(this IAppMsgSink dst, ApiHostUri host, int count, FilePath path)
            => dst.NotifyConsole(AppMsg.Colorize($"Matched {count} {host} capured members in memory with emissions to {path}", AppMsgColor.Cyan));

        public static void DuplicateWarning(this IAppMsgSink dst,  ApiHostUri host, OpIdentity id)
            => dst.NotifyConsole(AppMsg.Warn($"The host {host} defines operations with a duplicated identifer: {id}"));  

        public static void Deposit(this IAppMsgSink dst, IAppEvent src)      
            => dst.NotifyConsole(src.Message);
    }
}