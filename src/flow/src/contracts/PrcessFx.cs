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

    public readonly struct ProcessFx
    {
        public delegate ref T Process<S,T>(in S src, ref T dst);

        public delegate Y ProcessTable<T,Y>(in T src)
            where T : struct, ITable;
    }
}