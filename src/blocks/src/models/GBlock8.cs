//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct GBlock8<T> : IDataBlock<GBlock8<T>>
        where T : unmanaged
    {
        GBlock4<T> A;

        GBlock4<T> B;
    }
}