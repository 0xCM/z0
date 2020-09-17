//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly partial struct MemoryPage<N,W,T>
        where T : unmanaged
        where W : unmanaged, ITypeWidth
        where N : unmanaged, ITypeNat
    {
        readonly TableSpan<T> Data;

        [MethodImpl(Inline)]
        internal MemoryPage(TableSpan<T> data)
        {
            Data = data;
        }
    }
}