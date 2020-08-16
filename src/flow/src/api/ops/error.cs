//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial struct OldFlow    
    {
        [Op]
        public static void error(IWfContext wf, Exception e, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
        {
            const string CallerPattern = "An error was trapped by {0} on line {1} in {2}";
            const string Pattern = "{0}" + Eol + "{1}";
            var where = text.format(CallerPattern, caller, line, file);
            var what = e.ToString();
            var msg = text.format(Pattern, where, what);
            wf.Raise(Flow.error(caller, msg, ct));
        }             

        [Op, Closures(UnsignedInts)]
        public static void error<T>(IWfContext wf, string worker, T body, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => wf.Raise(new WfError<T>(worker, body, ct, AppMsgSource.create(caller,file,line)));

        [Op, Closures(UnsignedInts)]
        public static void error<T>(IWfContext wf, in WfActor actor, T body, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => wf.Raise(new WfError<T>(actor, body, ct, AppMsgSource.create(caller,file,line)));
    }
}