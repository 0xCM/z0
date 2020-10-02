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

    public readonly struct WfCmdSpec<K,T> : IWfCmdSpec<WfCmdSpec<K,T>,K,T>
        where K : unmanaged
    {
        public WfCmdSpec(WfCmdId id, params WfCmdOption<K,T>[] options)
        {
            Id = id;
            Options = options;
        }

        public WfCmdId Id {get;}

        public WfCmdOption<K,T>[] Options {get;}
    }
}