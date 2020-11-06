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
        where T : struct
    {
        public CmdId Id;

        public CmdArgs<K,T> Options;

        [MethodImpl(Inline)]
        public CmdSpec(CmdId id, params CmdArg<K,T>[] options)
        {
            Id = id;
            Options = options;
        }

        CmdId ICmdSpec.CmdId
            => Id;
    }
}