//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static Konst;
    using static z;

    public struct CmdSpec<T> : ICmdSpec<T>
        where T : struct, ICmdSpec<T>
    {
        public CmdArgs Args {get;}

        [MethodImpl(Inline)]
        public CmdSpec(params CmdArg[] args)
            => Args = args;

        [MethodImpl(Inline)]
        public CmdSpec(CmdArgs args)
            => Args = args;
    }
}