//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;

    using static Root;
    using static core;

    partial class XTend
    {
        public static CmdResult<C,P> Success<C,P>(this C cmd, P payload)
            where C : struct, ICmd<C>
                => new CmdResult<C,P>(cmd,true,payload);

        public static  CmdResult<C,P> ToResult<C,P>(this C spec, Outcome<P> outcome)
            where C : struct, ICmd<C>
                => Cmd.result(spec, outcome.Ok, outcome.Data, outcome.Message);

        public static Task Continue<T>(this Task<T> src, Action<T> @continue)
            where T : struct, ICmd
                => src.ContinueWith(t => @continue(t.Result));
    }
}