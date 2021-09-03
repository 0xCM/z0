//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct GBlock4<T> : IDataBlock<GBlock4<T>>
        where T : unmanaged
    {
        GBlock2<T> A;

        GBlock2<T> B;
    }
}