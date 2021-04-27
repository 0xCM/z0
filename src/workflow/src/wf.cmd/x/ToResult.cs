//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XCmd
    {
        public static  CmdResult<C,P> ToResult<C,P>(this C spec, Outcome<P> outcome)
            where C : struct, ICmd<C>
                => Cmd.result(spec, outcome.Ok, outcome.Data, outcome.Message);
    }
}