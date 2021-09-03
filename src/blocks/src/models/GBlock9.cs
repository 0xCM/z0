//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct GBlock9<T> : IDataBlock<GBlock9<T>>
        where T : unmanaged
    {
        GBlock8<T> A;

        GBlock1<T> B;
    }
}