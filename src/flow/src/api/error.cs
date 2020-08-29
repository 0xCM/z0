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

    partial struct Flow
    {
        [Op, Closures(UnsignedInts)]
        public static void error<T>(IWfContext wf, string worker, T body, CorrelationToken ct,
            [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
                => wf.Raise(new WfError<T>(worker, body, ct, AB.source(caller,file,line)));

        [Op, Closures(UnsignedInts)]
        public static void error<T>(IWfContext wf, in WfActor actor, T body, CorrelationToken ct,
            [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
                => wf.Raise(new WfError<T>(actor, body, ct, AB.source(caller,file,line)));
    }
}