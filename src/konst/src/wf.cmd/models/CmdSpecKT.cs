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

    public struct CmdSpec<K,T> : ICmdSpec<CmdSpec<K,T>,K,T>
        where K : unmanaged
        where T : struct, ICmdSpec<T>
    {
        public CmdId Id {get;}

        public CmdArgs<K,T> Args {get;}

        [MethodImpl(Inline)]
        public CmdSpec(CmdId id, params CmdArg<K,T>[] args)
        {
            Id = id;
            Args = args;
        }

        CmdArgs ICmdSpec.Args
            => Cmd.args(this);
    }
}