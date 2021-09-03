//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct GBlock7<T> : IDataBlock<GBlock6<T>>
        where T : unmanaged
    {
        GBlock6<T> A;

        GBlock1<T> B;
    }
}