//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct GBlock5<T> : IDataBlock<GBlock5<T>>
        where T : unmanaged
    {
        GBlock4<T> A;

        GBlock1<T> B;
    }
}