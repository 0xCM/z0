//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct GBlock6<T> : IDataBlock<GBlock6<T>>
        where T : unmanaged
    {
        GBlock3<T> A;

        GBlock3<T> B;
    }
}