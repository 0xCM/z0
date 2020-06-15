//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Konst;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    static class Tracing
    {
        public static int CasePadding
            => Tabular.width(TestCaseField.Case);

        public static string TracePrefix(object title, Type host, string caller)
            => string.Concat(Part.ExecutingPart.Format(), Chars.FSlash, host.Name, Chars.FSlash, caller, Chars.LBrace, title, Chars.RBrace).PadRight(CasePadding);

        public static IAppMsg TraceMsg(object title, object msg, Type host, string caller, AppMsgColor color)
            => AppMsg.Colorize(string.Concat(TracePrefix(title, host, caller), Chars.Pipe, Chars.Space, msg), color);

        public static IAppMsg TraceMsg(object title, object msg, Type host, string caller, AppMsgKind kind)
            => AppMsg.NoCaller(string.Concat(TracePrefix(title, host, caller), Chars.Pipe, Chars.Space, msg), kind);

        public static IAppMsg TraceMsg(object msg, Type host, string caller, AppMsgColor color)
            => TraceMsg(string.Empty, msg, host, caller, color);

        public static void Trace(this IAppMsgQueue dst, IAppMsg msg)
            => dst.NotifyConsole(msg);

        public static void Trace(this IAppMsgQueue dst, object msg, Type host, [Caller] string caller = null)
            => dst.Trace(TraceMsg(msg, host, caller, AppMsgColor.Magenta));
        
        public static void Trace(this IAppMsgQueue dst, string title, object msg, AppMsgColor color, Type host, [Caller] string caller = null)
            => dst.Trace(TraceMsg(title, msg, host, caller, color));

        public static void Trace(this IAppMsgQueue dst, string title, string msg, Type host, [Caller] string caller = null)
            => dst.Trace(TraceMsg(title, msg, host, caller, AppMsgColor.Magenta));        

        public static void Error(this IAppMsgQueue dst, object msg, Type host, [Caller] string caller = null)
            => dst.Trace(TraceMsg("Danger!", msg, host, caller, AppMsgKind.Error));        
    }
}