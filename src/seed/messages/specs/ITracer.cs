//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Seed;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    using static TraceMessages;
    static class TraceMessages
    {
        static int Padding => 50;

        public static IAppMsg TraceMsg(object title, object msg, int casepad, string caller, AppMsgColor color = AppMsgColor.Magenta)
            => AppMsg.Colorize(string.Concat(string.Concat(caller, Chars.Space, title, Chars.Colon).PadRight(Padding), "| ", msg), color);

        public static IAppMsg TraceMsg(object msg, int casepad,  string caller, AppMsgColor color = AppMsgColor.Magenta)
            => AppMsg.Colorize(string.Concat(string.Concat(caller).PadRight(Padding), "| ", msg), color);
    }

    public readonly struct Tracer : ITracer
    {
    
        public int CasePadding {get;}
        
        public Tracer(IConsoleNotifier notifier, int? casepad = null)
        {
            this.ConsoleNotifier = notifier;
            this.CasePadding = casepad ?? 50;
        }   

        public IConsoleNotifier ConsoleNotifier {get;}

        public void NotifyConsole(IAppMsg msg)
            => ConsoleNotifier.NotifyConsole(msg);

        public void NotifyConsole(object content, AppMsgColor color = AppMsgColor.Green)
            => ConsoleNotifier.NotifyConsole(content,color);
    }

    public interface ITracer : IConsoleNotifier
    {
        static ITracer Create(IConsoleNotifier notifier, int? casepad = null)
            => new Tracer(notifier,casepad);
        
        int CasePadding => 50;

        void trace(IAppMsg msg)
            => NotifyConsole(msg);

        void error(object msg)
            => trace(AppMsg.Error(msg));

        void trace(object msg,  [Caller] string caller = null)
            => trace(TraceMsg(msg, CasePadding, caller));
        
        void trace(string title, object msg, AppMsgColor color, [Caller] string caller = null)
            => trace(TraceMsg(title, msg, CasePadding, caller, color));

        void trace(string title, string msg, int? tpad = null, AppMsgKind? severity = null, [Caller] string caller = null)
            => trace(TraceMsg(title, msg, CasePadding, caller));        
    }
}