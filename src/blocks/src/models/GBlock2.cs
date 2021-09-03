//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct GBlock2<T> : IDataBlock<GBlock2<T>>
        where T : unmanaged
    {
        GBlock1<T> A;

        GBlock1<T> B;
    }
}