//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct GBlock10<T> : IDataBlock<GBlock10<T>>
        where T : unmanaged
    {
        GBlock8<T> A;

        GBlock2<T> B;
    }
}