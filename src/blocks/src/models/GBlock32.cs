//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct GBlock32<T> : IDataBlock<GBlock32<T>>
        where T : unmanaged
    {
        GBlock16<T> A;

        GBlock16<T> B;
    }
}