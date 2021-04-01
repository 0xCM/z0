//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class XCmd
    {
        public static CmdResult<C,P> Success<C,P>(this C cmd, P payload)
            where C : struct, ICmd<C>
                => new CmdResult<C,P>(cmd,true,payload);
    }
}