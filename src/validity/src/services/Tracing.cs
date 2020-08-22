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
            => Tabular.Width(TestCaseField.Case);

        public static string TracePrefix(object title, Type host, string caller)
            => string.Concat(Part.ExecutingPart.Format(), Chars.FSlash, host.Name, Chars.FSlash, caller, Chars.LBrace, title, Chars.RBrace).PadRight(CasePadding);

        public static IAppMsg TraceMsg(object title, object msg, Type host, string caller, MessageFlair color)
            => AppMsg.colorize(string.Concat(TracePrefix(title, host, caller), Chars.Pipe, Chars.Space, msg), color);

        public static IAppMsg TraceMsg(object msg, Type host, string caller, MessageFlair color)
            => TraceMsg(string.Empty, msg, host, caller, color);

        public static void Trace(this IAppMsgQueue dst, IAppMsg msg)
            => dst.NotifyConsole(msg);

        public static void Trace(this IAppMsgQueue dst, object msg, Type host, [Caller] string caller = null)
            => dst.Trace(TraceMsg(msg, host, caller, MessageFlair.Magenta));

        public static void Trace(this IAppMsgQueue dst, string title, object msg, MessageFlair color, Type host, [Caller] string caller = null)
            => dst.Trace(TraceMsg(title, msg, host, caller, color));

        public static void Trace(this IAppMsgQueue dst, string title, string msg, Type host, [Caller] string caller = null)
            => dst.Trace(TraceMsg(title, msg, host, caller, MessageFlair.Magenta));
    }
}