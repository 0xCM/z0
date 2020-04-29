//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Seed;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    static class Tracing
    {
        public static int CasePadding
            => Reports.width(TestCaseField.Case);

        public static string TracePrefix(object title, string caller)
            => string.Concat(ExecutingApp.Format(), Chars.FSlash, caller, Chars.LBrace, title, Chars.RBrace).PadRight(CasePadding);

        public static IAppMsg TraceMsg(object title, object msg, string caller, AppMsgColor color = AppMsgColor.Magenta)
            => AppMsg.Colorize(string.Concat(TracePrefix(title,caller), Chars.Pipe, Chars.Space, msg), color);

        public static IAppMsg TraceMsg(object msg, string caller, AppMsgColor color = AppMsgColor.Magenta)
            => TraceMsg(string.Empty, msg, caller, color);

        public static void Trace(this IAppMsgQueue dst, IAppMsg msg)
            => dst.NotifyConsole(msg);

        public static void Trace(this IAppMsgQueue dst, object msg, [Caller] string caller = null)
            => dst.Trace(TraceMsg(msg, caller));
        
        public static void Trace(this IAppMsgQueue dst, string title, object msg, AppMsgColor color, [Caller] string caller = null)
            => dst.Trace(TraceMsg(title, msg, caller, color));

        public static void Trace(this IAppMsgQueue dst, string title, string msg, [Caller] string caller = null)
            => dst.Trace(TraceMsg(title, msg, caller));        

        public static void Error(this IAppMsgQueue dst, object msg)
            => dst.Trace(AppMsg.Error(msg));
    }
}